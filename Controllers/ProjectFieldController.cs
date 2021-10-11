using IBBPortal.Data;
using IBBPortal.Helpers;
using IBBPortal.Models;
using IBBPortal.Static;
using IBBPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IBBPortal.Controllers
{
    public class ProjectFieldController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectFieldController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Project/EditProjectField/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Define ViewModel for Project Field
            EditProjectFieldViewModel model = new EditProjectFieldViewModel();

            //Attach Desired Entities to ViewModel
            model.ProjectTitle = _context.Project.Single(m => m.ProjectID == id).ProjectTitle;

            model.ProjectField = await _context.ProjectField
                .Include(p => p.District)
                .Include(p => p.City)
                .FirstOrDefaultAsync(m => m.ProjectID == id);

            model.ProjectBoardApproval = await _context.ProjectBoardApproval
                .Include(p => p.Board)
                .FirstOrDefaultAsync(m => m.Project.ProjectID == id);

            model.ProjectZoningPlan = await _context.ProjectZoningPlan
                .Include(p => p.ZoningPlanModificationStatus)
                .Include(p => p.ZoningPlanResponsiblePerson)
                .Include(p => p.ZoningPlanStatus1000)
                .Include(p => p.ZoningPlanStatus5000)
                .FirstOrDefaultAsync(m => m.Project.ProjectID == id);

            model.ProjectExpropriation = await _context.ProjectExpropriation
                .Include(c => c.ExpropriationStatus)
                .FirstOrDefaultAsync(m => m.Project.ProjectID == id);

            model.ChosenPropertyStatus = await _context.RelProjectPropertyStatus
                .Include(c => c.PropertyStatus)
                .Select( c => new ProjectPropertyStatusViewModel { 
                    ProjectID = c.ProjectID,
                    PropertyStatusID = c.PropertyStatus.PropertyStatusID,
                    PropertyStatusTitle = c.PropertyStatus.PropertyStatusTitle
                })
                .Where(c => c.ProjectID == id)
                .ToListAsync();

            model.ProjectPermission = await _context.ProjectPermission
                .Include(m => m.Organization)
                .FirstOrDefaultAsync(m => m.Project.ProjectID == id);

            ViewBag.ProjectID = id;
            return View(model);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProjectField(int? id, EditProjectFieldViewModel model)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Current Date
            var CurrentDate = DateTime.Now;

            //Log User for Activity LOG
            var CurrentUser = _userManager.GetUserId(HttpContext.User);

            var projectFieldToUpdate = await _context.ProjectField.FirstOrDefaultAsync(c => c.ProjectID == id);
            var projectBoardApprovalToUpdate = await _context.ProjectBoardApproval.FirstOrDefaultAsync(c => c.ProjectID == id);
            var projectZoningPlanToUpdate = await _context.ProjectZoningPlan.FirstOrDefaultAsync(c => c.ProjectID == id);
            var projectExpropriationToUpdate = await _context.ProjectExpropriation.FirstOrDefaultAsync(c => c.ProjectID == id);
            var projectPermissionToUpdate = await _context.ProjectPermission.FirstOrDefaultAsync(c => c.ProjectID == id);

            //ProjectField
            if (projectFieldToUpdate == null)
            {
                ProjectField projectField = new ProjectField();


                double projectLongitude = Convert.ToDouble(Request.Form["ProjectLongitude"].FirstOrDefault());
                double projectLatitude = Convert.ToDouble(Request.Form["ProjectLatitude"].FirstOrDefault());

                projectField.ProjectPoint = new Point(projectLatitude, projectLongitude) { SRID = 4326 };

                projectField.ProjectID = id;
                projectField.IsProjectInIstanbul = model.ProjectField.IsProjectInIstanbul;
                projectField.DistrictID = model.ProjectField.DistrictID;
                projectField.CityID = model.ProjectField.CityID;
                projectField.ProjectAddress = model.ProjectField.ProjectAddress;
                projectField.ProjectArea = model.ProjectField.ProjectArea;
                projectField.ProjectConstructionArea = model.ProjectField.ProjectConstructionArea;
                projectField.ProjectPaysageArea = model.ProjectField.ProjectPaysageArea;
                projectField.ProjectPaftaAdaParsel = model.ProjectField.ProjectPaftaAdaParsel;
                projectField.ProjectLongitude = model.ProjectField.ProjectLongitude;
                projectField.ProjectLatitude = model.ProjectField.ProjectLatitude;
                projectField.KML = model.ProjectField.KML;
                TransactionLogger.logTransaction(_context, (int)id, "created-project-field", _userManager.GetUserId(HttpContext.User));
                string coordinates = null;

                if (model.ProjectField.KML != null)
                {
                    try
                    {
                        var rx_coordinates = new Regex("<coordinates>(.|\n)*?</coordinates>");
                        coordinates = rx_coordinates.Match(model.ProjectField.KML).Groups[0].Value;
                        coordinates = coordinates.Replace("<coordinates>", "");
                        coordinates = coordinates.Replace("</coordinates>", "");
                        Debug.WriteLine("model.ProjectField.KML = " + model.ProjectField.KML);
                        //coordinates = v.Groups[1].Value;
                        coordinates = coordinates.Replace("\n", "").Replace("\r", "");
                        coordinates = coordinates.Replace(",0", " ");
                        coordinates = Regex.Replace(coordinates, @"\s+", " ");
                        coordinates = coordinates.Trim();
                        Debug.WriteLine("coordinates = " + coordinates);
                    }
                    catch
                    {
                        coordinates = null;
                    }

                }

                //projectField.ProjectPolygon = 
                // Read: https://csharp.hotexamples.com/examples/NetTopologySuite.Geometries/Polygon/-/php-polygon-class-examples.html
                // Read: https://www.csharpcodi.com/csharp-examples/NetTopologySuite.IO.WKTReader.Read(System.IO.TextReader)/
                if (coordinates != null)
                {
                    var formattedCoordinates = coordinates.Replace(",", ";").Replace(" ", ",").Replace(";", " ");
                    Console.WriteLine(formattedCoordinates);
                    var reader = new NetTopologySuite.IO.WKTReader();
                    //var geom = reader.Read(@"SRID=4326;POLYGON((" + formattedCoordinates + "))");
                    var geomls = reader.Read(@"SRID=4326;LINESTRING(" + formattedCoordinates + ")");
                    //var polygon = new Polygon(null) { SRID = 4326 };
                    //var polygon = (Polygon)geom;
                    var linestring = (LineString)geomls;
                    //projectField.ProjectPolygon = polygon;
                    projectField.ProjectLineString = linestring;
                }

                //projectField.ProjectPolygon = new Polygon(new LinearRing(new LineString()
                projectField.coordinates = coordinates; // model.ProjectField.KML;
                projectField.CreationDate = CurrentDate;
                projectField.UserID = CurrentUser;

                _context.Add(projectField);
                projectFieldToUpdate = projectField;

            }
            else
            {
                double projectLongitude = Convert.ToDouble(Request.Form["ProjectLongitude"].FirstOrDefault());
                double projectLatitude = Convert.ToDouble(Request.Form["ProjectLatitude"].FirstOrDefault());

                projectFieldToUpdate.ProjectPoint = new Point(projectLatitude, projectLongitude) { SRID = 4326 };

                projectFieldToUpdate.ProjectID = id;
                projectFieldToUpdate.IsProjectInIstanbul = model.ProjectField.IsProjectInIstanbul;
                projectFieldToUpdate.DistrictID = model.ProjectField.DistrictID;
                projectFieldToUpdate.CityID = model.ProjectField.CityID;
                projectFieldToUpdate.ProjectAddress = model.ProjectField.ProjectAddress;
                projectFieldToUpdate.ProjectArea = model.ProjectField.ProjectArea;
                projectFieldToUpdate.ProjectConstructionArea = model.ProjectField.ProjectConstructionArea;
                projectFieldToUpdate.ProjectPaysageArea = model.ProjectField.ProjectPaysageArea;
                projectFieldToUpdate.ProjectPaftaAdaParsel = model.ProjectField.ProjectPaftaAdaParsel;
                projectFieldToUpdate.ProjectLongitude = model.ProjectField.ProjectLongitude;
                projectFieldToUpdate.ProjectLatitude = model.ProjectField.ProjectLatitude;
                //XDocument doc = XDocument.Parse(model.ProjectField.KML);
                //string coordinates = null;
                projectFieldToUpdate.KML = model.ProjectField.KML;
                string coordinates = null;
                TransactionLogger.logTransaction(_context, (int)id, "updated-project-field", _userManager.GetUserId(HttpContext.User));

                if (model.ProjectField.KML != null)
                {
                    try
                    {
                        var rx_coordinates = new Regex("<coordinates>(.|\n)*?</coordinates>");
                        coordinates = rx_coordinates.Match(model.ProjectField.KML).Groups[0].Value;
                        coordinates = coordinates.Replace("<coordinates>", "");
                        coordinates = coordinates.Replace("</coordinates>", "");
                        Debug.WriteLine("model.ProjectField.KML = " + model.ProjectField.KML);
                        //coordinates = v.Groups[1].Value;
                        coordinates = coordinates.Replace("\n", "").Replace("\r", "");
                        coordinates = coordinates.Replace(",0", " ");
                        coordinates = Regex.Replace(coordinates, @"\s+", " ");
                        coordinates = coordinates.Trim();
                        Debug.WriteLine("coordinates = " + coordinates);
                    }
                    catch
                    {
                        coordinates = null;
                    }

                }

                projectFieldToUpdate.coordinates = coordinates; // model.ProjectField.KML;
                projectFieldToUpdate.UpdateDate = CurrentDate;

                if (coordinates != null)
                {
                    var formattedCoordinates = coordinates.Replace(",", ";").Replace(" ", ",").Replace(";", " ");
                    Debug.WriteLine("formattedCoordinates=" + formattedCoordinates);
                    var reader = new NetTopologySuite.IO.WKTReader();
                    //var geom = reader.Read(@"SRID=4326;POLYGON((" + formattedCoordinates + "))");
                    var geomls = reader.Read(@"SRID=4326;LINESTRING(" + formattedCoordinates + ")");
                    //var polygon = new Polygon(null) { SRID = 4326 };
                    //var polygon = (Polygon)geom;
                    var linestring = (LineString)geomls;
                    //projectFieldToUpdate.ProjectPolygon = polygon;
                    projectFieldToUpdate.ProjectLineString = linestring;
                }
            }

            //Project Board Approval
            if (projectBoardApprovalToUpdate == null)
            {
                projectBoardApprovalToUpdate.Create<ProjectBoardApproval>(_context, model.ProjectBoardApproval, (int)id, CurrentUser);
                TransactionLogger.logTransaction(_context, (int)id, "zoning-plan-created", _userManager.GetUserId(HttpContext.User));
            }

            else
            {
                projectBoardApprovalToUpdate.ProjectID = id;
                projectBoardApprovalToUpdate.IsBoardApprovalNeeded = model.ProjectBoardApproval.IsBoardApprovalNeeded;
                projectBoardApprovalToUpdate.BoardID = model.ProjectBoardApproval.BoardID;
                projectBoardApprovalToUpdate.ProjectBoardApprovalDate = model.ProjectBoardApproval.ProjectBoardApprovalDate;
                projectBoardApprovalToUpdate.ProjectBoardApprovalReason = model.ProjectBoardApproval.ProjectBoardApprovalReason;
                projectBoardApprovalToUpdate.UpdateDate = CurrentDate;
            }

            //Project Zoning Plan
            if (projectZoningPlanToUpdate == null)
            {
                projectZoningPlanToUpdate.Create<ProjectZoningPlan>(_context, model.ProjectZoningPlan, (int)id, CurrentUser);
                TransactionLogger.logTransaction(_context, (int)id, "zoning-plan-created", _userManager.GetUserId(HttpContext.User));
            }

            else
            {
                projectZoningPlanToUpdate.ProjectID = id;
                projectZoningPlanToUpdate.ZoningPlanStatusID1000 = model.ProjectZoningPlan.ZoningPlanStatusID1000;
                projectZoningPlanToUpdate.ZoningPlanDate1000 = model.ProjectZoningPlan.ZoningPlanDate1000;
                projectZoningPlanToUpdate.ZoningPlanStatusID5000 = model.ProjectZoningPlan.ZoningPlanStatusID5000;
                projectZoningPlanToUpdate.ZoningPlanDate5000 = model.ProjectZoningPlan.ZoningPlanDate5000;
                projectZoningPlanToUpdate.ZoningPlanModificationNeeded = model.ProjectZoningPlan.ZoningPlanModificationNeeded;
                projectZoningPlanToUpdate.ZoningPlanModificationReason = model.ProjectZoningPlan.ZoningPlanModificationReason;
                projectZoningPlanToUpdate.ModificationApprovalDate = model.ProjectZoningPlan.ModificationApprovalDate;
                projectZoningPlanToUpdate.ModificationProposalDate = model.ProjectZoningPlan.ModificationProposalDate;
                projectZoningPlanToUpdate.ZoningPlanModificationStatusID = model.ProjectZoningPlan.ZoningPlanModificationStatusID;
                projectZoningPlanToUpdate.ZoningPlanResponsiblePersonID = model.ProjectZoningPlan.ZoningPlanResponsiblePersonID;
                TransactionLogger.logTransaction(_context, (int)id, "zoning-plan-updated", _userManager.GetUserId(HttpContext.User));
                projectZoningPlanToUpdate.UpdateDate = CurrentDate;
            }

            //Project Expropriation
            if (projectExpropriationToUpdate == null)
            {
                projectExpropriationToUpdate.Create<ProjectExpropriation>(_context, model.ProjectExpropriation, (int)id, CurrentUser);
                TransactionLogger.logTransaction(_context, (int)id, "expropriation-created", _userManager.GetUserId(HttpContext.User));
            }

            else
            {
                projectExpropriationToUpdate.ProjectID = id;
                projectExpropriationToUpdate.PropertyStatusDescription = model.ProjectExpropriation.PropertyStatusDescription;
                projectExpropriationToUpdate.ProjectExpropriationDescription = model.ProjectExpropriation.ProjectExpropriationDescription;
                projectExpropriationToUpdate.ProjectNeedsExpropriation = model.ProjectExpropriation.ProjectNeedsExpropriation;
                projectExpropriationToUpdate.ProjectExpropriationDate = model.ProjectExpropriation.ProjectExpropriationDate;
                projectExpropriationToUpdate.ProjectExpropriationCost = model.ProjectExpropriation.ProjectExpropriationCost;
                projectExpropriationToUpdate.ProjectExpropriationCost = model.ProjectExpropriation.ProjectExpropriationCost;
                projectExpropriationToUpdate.ExpropriationStatusID = model.ProjectExpropriation.ExpropriationStatusID;
                projectExpropriationToUpdate.ProjectExpropriationStatusDesc = model.ProjectExpropriation.ProjectExpropriationStatusDesc;
                projectExpropriationToUpdate.UpdateDate = CurrentDate;
                TransactionLogger.logTransaction(_context, (int)id, "expropriation-updated", _userManager.GetUserId(HttpContext.User));
            }

            if (model.PropertyStatus.Length > 0)
            {
                //Until better option for multiple select, drop everything then update the field on every request.
                //hours_spent = 16. Increment the counter until a solution is found
                var relatedPropertyStatus = await _context.RelProjectPropertyStatus.Where(x => x.ProjectID == id).ToListAsync();
                _context.RelProjectPropertyStatus.RemoveRange(relatedPropertyStatus);

                foreach(var propertyID in model.PropertyStatus)
                {
                    RelProjectPropertyStatus relatedPropertyStatusToAdd = new RelProjectPropertyStatus()
                    {
                        ProjectExpropriationID = projectExpropriationToUpdate.ProjectExpropriationID,
                        ProjectID = id,
                        PropertyStatusID = propertyID
                    };

                    await _context.AddAsync(relatedPropertyStatusToAdd);
                }
            }

            //Project Permission
            if (projectPermissionToUpdate == null)
            {
                projectPermissionToUpdate.Create<ProjectPermission>(_context, model.ProjectPermission, (int)id, CurrentUser);
                TransactionLogger.logTransaction(_context, (int)id, "permission-created", _userManager.GetUserId(HttpContext.User));
            }

            else
            {
                projectPermissionToUpdate.ProjectID = id;
                projectPermissionToUpdate.OrganizationID = model.ProjectPermission.OrganizationID;
                projectPermissionToUpdate.IsPermissionNeeded = model.ProjectPermission.IsPermissionNeeded;
                projectPermissionToUpdate.ProjectPermissionDate = model.ProjectPermission.ProjectPermissionDate;
                projectPermissionToUpdate.ProjectPermissionReason = model.ProjectPermission.ProjectPermissionReason;
                projectPermissionToUpdate.UpdateDate = CurrentDate;
                TransactionLogger.logTransaction(_context, (int)id, "permission-updated", _userManager.GetUserId(HttpContext.User));
            }

            try
            {
                await _context.SaveChangesAsync();

                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectFieldToUpdate.ProjectID} numaralı kayıt başarıyla düzenlendi.";
            }
            catch (Exception)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Kayıt düzenlenirken bir hata oluştu. Lütfen sistem yöneticinizle görüşün.";
            }

            return RedirectToAction(nameof(Edit), new { id = projectFieldToUpdate.ProjectID.ToString() });
        }
    }
}
