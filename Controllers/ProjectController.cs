using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using IBBPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using IBBPortal.Helpers;
using NetTopologySuite.Geometries;
using System.Xml.Linq;
using System.Text.RegularExpressions;


namespace IBBPortal.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: District
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult JSONData()
        {
            try
            {

                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][data]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault().ToUpper();

                //Paging Size (10, 20, 50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var data = _context.Project.Select(c => new 
                { 
                    c.ProjectID, 
                    c.ProjectTitle,
                    RequestingDepartmentTitle = c.RequestingDepartment.DepartmentTitle, 
                    ResponsibleDepartmentTitle = c.ResponsibleDepartment.DepartmentTitle, 
                    OwnerFullName = c.ProjectOwnerPerson.PersonName.Trim() + " " + c.ProjectOwnerPerson.PersonSurname.Trim(),
                    ServiceAreaTitle = c.ProjectServiceArea.ServiceAreaTitle,
                    ProjectStatusTitle = c.ProjectStatus.ProjectStatusTitle,
                    ProjectImportanceTitle = c.ProjectImportance.ProjectImportanceTitle,
                    
                    //_context.Shortcuts.Where(s => s.UserID == _userManager.GetUserId(HttpContext.User), s => s.ShortcutsProjectID == c.ProjectID)
                });

                var shortcuts = _context.Shortcuts.Where(s => s.UserID == _userManager.GetUserId(HttpContext.User)).ToList();

                /*var data = _context.Project.Join(_context.Shortcuts.Where(s => s.UserID == _userManager.GetUserId(HttpContext.User)), 
                    p => p.ProjectID, 
                    s => s.ShortcutsProjectID, 
                    (p,s) => new
                    {
                        p.ProjectID,
                        p.ProjectTitle,
                        RequestingDepartmentTitle = p.RequestingDepartment.DepartmentTitle,
                        ResponsibleDepartmentTitle = p.ResponsibleDepartment.DepartmentTitle,
                        OwnerFullName = p.ProjectOwnerPerson.PersonName.Trim() + " " + p.ProjectOwnerPerson.PersonSurname.Trim(),
                        ServiceAreaTitle = p.ProjectServiceArea.ServiceAreaTitle,
                        ProjectStatusTitle = p.ProjectStatus.ProjectStatusTitle,
                        ProjectImportanceTitle = p.ProjectImportance.ProjectImportanceTitle,
                        p.HasRelatedProject,
                        s.ShortcutsProjectID
                 
                    }
                    );*/

                //Sorting
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    var sortProp = sortColumn + " " + sortColumnDirection;
                    data = data.OrderBy(sortProp);
                }

                //Search Functionality = Programmer will always know how many columns will be shown to the user.
                //So we will use that to check every column if they have a search value.
                //If control checks out, search. If not loop goes on until the end.
                string columnName, searchValue;

                for (int i = 0; i < 8; i++)
                {
                    columnName = Request.Form[$"columns[{i}][data]"].FirstOrDefault();
                    searchValue = Request.Form[$"columns[{i}][search][value]"].FirstOrDefault();

                    if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchValue))
                    {
                        data = data.WhereContains(columnName, searchValue);
                    }
                }

                //total number of rows count   
                recordsTotal = data.Count();
                //Paging   
                var passData = data.Skip(skip).Take(pageSize).ToList();

                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = passData, shortCuts = shortcuts });

            }

            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public JsonResult MapData()
        {
            //try
            //{
            string projectKeyword = HttpContext.Request.Query["projectKeyword"];
            var selectedDistrict = HttpContext.Request.Query["districtID"];
            var respDepartmentID = HttpContext.Request.Query["respDepartmentID"];
            var projectOwnerID = HttpContext.Request.Query["ProjectOwnerID"];
            var yearSelected = HttpContext.Request.Query["yearSelected"];

            var data = _context.ProjectField.Select(c => new
            {
                c.ProjectID,
                ProjectTitle = c.Project.ProjectTitle,
                DistrictName = c.District.DistrictName,
                Longitude = c.ProjectLongitude,
                Latitude = c.ProjectLatitude,
                Coordinates = c.coordinates,
                RequestingDepartmentTitle = c.Project.RequestingDepartment.DepartmentTitle,
                ResponsibleDepartmentTitle = c.Project.ResponsibleDepartment.DepartmentTitle,
                OwnerFullName = c.Project.ProjectOwnerPerson.PersonName.Trim() + " " + c.Project.ProjectOwnerPerson.PersonSurname.Trim(),
                ServiceAreaTitle = c.Project.ProjectServiceArea.ServiceAreaTitle,
                ProjectImportanceTitle = c.Project.ProjectImportance.ProjectImportanceTitle,
                RequestingDepartmentID = c.Project.RequestingDepartmentID == null ? 0 : c.Project.RequestingDepartmentID,
                ResponsibleDepartmentID = c.Project.ResponsibleDepartmentID == null ? 0 : c.Project.ResponsibleDepartmentID,
                DistrictID = c.DistrictID == null ? 0 : c.DistrictID,
                ProjectOwnerID = c.Project.ProjectOwnerPersonID == null ? 0 : c.Project.ProjectOwnerPersonID,
            });

            if (Int32.TryParse(selectedDistrict, out int selectedDistrictInt))
            {
                if (selectedDistrictInt != 0)
                {
                    data = data.Where(c => c.DistrictID == selectedDistrictInt);
                }
                
            } else
            {
                selectedDistrictInt = -1;
            }

            if (Int32.TryParse(respDepartmentID, out int respDepartmentIDInt))
            {
                data = data.Where(c => c.ResponsibleDepartmentID == respDepartmentIDInt);
            } else
            {
                respDepartmentIDInt = -1;
            }

            if (Int32.TryParse(projectOwnerID, out int projectOwnerIDint))
            {
                data = data.Where(c => c.ProjectOwnerID == projectOwnerIDint);
            } else
            {
                projectOwnerIDint = -1;
            }

            if (projectKeyword == null)
            {
                projectKeyword = "";
            }

            if(projectKeyword.Length > 1)
            {
                data = data.Where(c => c.ProjectTitle.Contains(projectKeyword));
            }


            //Sorting


            //total number of rows count   
            //var recordsTotal = data.Count();
                //Paging   
                var passData = data.ToList();

                //Returning Json Data  
                return Json(new { data = passData, districtID = selectedDistrictInt, ProjectKeyword = projectKeyword });

            //}

            //catch (Exception)
            //{
              //  throw;
            //}
        }

        [HttpGet]
        public JsonResult JsonSelectData(string term)
        {
            try
            {

                var ProjectData = _context.Project
                                    .Select(x => new {
                                        id = x.ProjectID.ToString(),
                                        text = x.ProjectTitle
                                    }).Take(10);

                if (!String.IsNullOrEmpty(term))
                {
                    ProjectData = ProjectData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ProjectData.Count();

                //Paging   
                var passData = ProjectData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        //Map Values for Project.
        //POST : PRoject/ProjectSpatialData/5
        [HttpPost]
        public JsonResult ProjectSpatialData(int? id)
        {
            try
            {

                var ProjectSpatialData = _context.ProjectField
                                    .Select(x => new {
                                        x.ProjectID,
                                        Longitude = x.ProjectPoint.Coordinate.Y.ToString(),
                                        Latitude = x.ProjectPoint.Coordinate.X.ToString(),
                                        ProjectKMLString = x.KML,
                                    });

                if (!String.IsNullOrEmpty(id.ToString()))
                {
                    ProjectSpatialData = ProjectSpatialData.Where(m => m.ProjectID == id);
                }

                //Count 
                var totalCount = ProjectSpatialData.Count();

                //Paging   
                var passData = ProjectSpatialData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                return Json(new { error = "No Data Found!" });
            }
        }

        // GET: Project/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .Include(p => p.ProjectImportance)
                .Include(p => p.ProjectOwnerPerson)
                .Include(p => p.ProjectServiceArea)
                .Include(p => p.ProjectStatus)
                .Include(p => p.RequestingDepartment)
                .Include(p => p.ResponsibleDepartment)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectID == id);
            if (project == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", project);
        }

        // GET: Project/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectID,ProjectTitle,ProjectIBBCode,RequestingDepartmentID,ResponsibleDepartmentID,ProjectOwnerPersonID,ProjectServiceAreaID,ProjectImportanceID,ProjectStatusID,ProjectStatusDescription,ProjectStatusDescriptionDate,UserID,CreationDate,UpdateDate,DeletionDate")] Project project)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    project.CreationDate = DateTime.Now;
                    project.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(project);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {project.ProjectID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index), new { id = project.ProjectID.ToString() });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(project);
        }

        // GET: Project/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .Include(p => p.ProjectImportance)
                .Include(p => p.ProjectOwnerPerson)
                .Include(p => p.ProjectServiceArea)
                .Include(p => p.ProjectStatus)
                .Include(p => p.RequestingDepartment)
                .Include(p => p.ResponsibleDepartment)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectID == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectID,ProjectTitle,ProjectIBBCode,RequestingDepartmentID,ResponsibleDepartmentID,ProjectOwnerPersonID,ProjectServiceAreaID,ProjectImportanceID,ProjectStatusID,ProjectStatusDescription,ProjectStatusDescriptionDate,UserID,CreationDate,UpdateDate,DeletionDate")] Project project)
        {
            if (id != project.ProjectID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    project.UpdateDate = CurrentDate;

                    _context.Update(project);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{project.ProjectID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ProjectID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Edit));
            }
            return View(project);
        }

        // GET: Project/EditProjectField/5
        public async Task<IActionResult> EditProjectField(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Define ViewModel for Project Field
            EditProjectFieldViewModel model = new EditProjectFieldViewModel();

            //Attach Desired Entities to ViewModel
            model.ProjectField = await _context.ProjectField
                .Include(p => p.District)
                .FirstOrDefaultAsync(m => m.ProjectID == id);

            model.ProjectBoardApproval = await _context.ProjectBoardApproval
                .Include(p => p.Board)
                .FirstOrDefaultAsync(m => m.Project.ProjectID == id );

            model.ProjectZoningPlan = await _context.ProjectZoningPlan
                .Include(p => p.ZoningPlanModificationStatus)
                .Include(p => p.ZoningPlanResponsiblePerson)
                .Include(p => p.ZoningPlanStatus1000)
                .Include(p => p.ZoningPlanStatus5000)
                .FirstOrDefaultAsync(m => m.Project.ProjectID == id);

            model.ProjectExpropriation= await _context.ProjectExpropriation
                .Include(c => c.PropertyStatus)
                .Include(c => c.ExpropriationStatus)
                .FirstOrDefaultAsync(m => m.Project.ProjectID == id);

            model.ProjectPermission = await _context.ProjectPermission
                .Include(m => m.Organization)
                .FirstOrDefaultAsync(m => m.Project.ProjectID == id);

            ViewBag.ProjectID = id;
            return View(model);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("EditProjectField")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProjectFieldMain(int? id, EditProjectFieldViewModel model)
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
                projectField.ProjectAddress = model.ProjectField.ProjectAddress;
                projectField.ProjectArea = model.ProjectField.ProjectArea;
                projectField.ProjectConstructionArea = model.ProjectField.ProjectConstructionArea;
                projectField.ProjectPaysageArea = model.ProjectField.ProjectPaysageArea;
                projectField.ProjectPaftaAdaParsel = model.ProjectField.ProjectPaftaAdaParsel;
                projectField.ProjectLongitude = model.ProjectField.ProjectLongitude;
                projectField.ProjectLatitude = model.ProjectField.ProjectLatitude;
                projectField.KML = model.ProjectField.KML;

                string coordinates = null;

                if (model.ProjectField.KML!=null)
                {
                    try
                    {
                        Regex regex = new Regex(@"\<coordinates\>(.*)\</coordinates\>");
                        var v = regex.Match(model.ProjectField.KML);
                        coordinates = v.Groups[1].Value;
                    } 
                    catch
                    {
                        coordinates = null;
                    }
                    
                }

                //projectField.ProjectPolygon = 
                // Read: https://csharp.hotexamples.com/examples/NetTopologySuite.Geometries/Polygon/-/php-polygon-class-examples.html
                // Read: https://www.csharpcodi.com/csharp-examples/NetTopologySuite.IO.WKTReader.Read(System.IO.TextReader)/
                /*var reader = new NetTopologySuite.IO.WKTReader();
                var geom = reader.Read("POLYGON((" + coordinates + "))");

                var polygon = (Polygon)geom;
                projectField.ProjectPolygon = polygon;*/
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

                if (model.ProjectField.KML != null)
                {
                    try
                    {
                        Regex regex = new Regex(@"\<coordinates\>(.*)\</coordinates\>");
                        var v = regex.Match(model.ProjectField.KML);
                        coordinates = v.Groups[1].Value;
                    }
                    catch
                    {
                        coordinates = null;
                    }

                }

                projectFieldToUpdate.coordinates = coordinates; // model.ProjectField.KML;
                projectFieldToUpdate.UpdateDate = CurrentDate;

                //var reader = new NetTopologySuite.IO.WKTReader();
                //var geom = reader.Read("POLYGON((" + coordinates + "))");

                //var polygon = (Polygon)geom;
                //projectFieldToUpdate.ProjectPolygon = polygon;
            }

            //Project Board Approval
            if (projectBoardApprovalToUpdate == null)
            {
                //For creation we need a Model that is connected to a Database.
                ProjectBoardApproval projectBoardApproval = new ProjectBoardApproval();

                projectBoardApproval.ProjectID = id;
                projectBoardApproval.IsBoardApprovalNeeded = model.ProjectBoardApproval.IsBoardApprovalNeeded;
                projectBoardApproval.BoardID = model.ProjectBoardApproval.BoardID;
                projectBoardApproval.ProjectBoardApprovalDate = model.ProjectBoardApproval.ProjectBoardApprovalDate;
                projectBoardApproval.ProjectBoardApprovalReason = model.ProjectBoardApproval.ProjectBoardApprovalReason;
                projectBoardApproval.UserID = CurrentUser;
                projectBoardApproval.CreationDate = CurrentDate;

                _context.Add(projectBoardApproval);
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
                //For creation we need a Model that is connected to a Database.
                ProjectZoningPlan projectZoningPlan = new ProjectZoningPlan();

                projectZoningPlan.ProjectID = id;
                projectZoningPlan.ZoningPlanStatusID1000 = model.ProjectZoningPlan.ZoningPlanStatusID1000;
                projectZoningPlan.ZoningPlanDate1000 = model.ProjectZoningPlan.ZoningPlanDate1000;
                projectZoningPlan.ZoningPlanStatusID5000 = model.ProjectZoningPlan.ZoningPlanStatusID5000;
                projectZoningPlan.ZoningPlanDate5000 = model.ProjectZoningPlan.ZoningPlanDate5000;
                projectZoningPlan.ZoningPlanModificationNeeded = model.ProjectZoningPlan.ZoningPlanModificationNeeded;
                projectZoningPlan.ZoningPlanModificationReason = model.ProjectZoningPlan.ZoningPlanModificationReason;
                projectZoningPlan.ModificationApprovalDate = model.ProjectZoningPlan.ModificationApprovalDate;
                projectZoningPlan.ModificationProposalDate = model.ProjectZoningPlan.ModificationProposalDate;
                projectZoningPlan.ZoningPlanModificationStatusID = model.ProjectZoningPlan.ZoningPlanModificationStatusID;
                projectZoningPlan.ZoningPlanResponsiblePersonID = model.ProjectZoningPlan.ZoningPlanResponsiblePersonID;
                projectZoningPlan.UserID = CurrentUser;
                projectZoningPlan.CreationDate = CurrentDate;

                _context.Add(projectZoningPlan);
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
                projectZoningPlanToUpdate.UpdateDate = CurrentDate;
            }

            //Project Expropriation
            if (projectExpropriationToUpdate == null)
            {
                //For creation we need a Model that is connected to a Database.
                ProjectExpropriation projectExpropriation = new ProjectExpropriation();

                projectExpropriation.ProjectID = id;
                projectExpropriation.PropertyStatusID = model.ProjectExpropriation.PropertyStatusID;
                projectExpropriation.PropertyStatusDescription = model.ProjectExpropriation.PropertyStatusDescription;
                projectExpropriation.ProjectExpropriationDescription = model.ProjectExpropriation.ProjectExpropriationDescription;
                projectExpropriation.ProjectNeedsExpropriation = model.ProjectExpropriation.ProjectNeedsExpropriation;
                projectExpropriation.ProjectExpropriationDate = model.ProjectExpropriation.ProjectExpropriationDate;
                projectExpropriation.ProjectExpropriationCost = model.ProjectExpropriation.ProjectExpropriationCost;
                projectExpropriation.ProjectExpropriationCost = model.ProjectExpropriation.ProjectExpropriationCost;
                projectExpropriation.ExpropriationStatusID = model.ProjectExpropriation.ExpropriationStatusID;
                projectExpropriation.ProjectExpropriationStatusDesc = model.ProjectExpropriation.ProjectExpropriationStatusDesc;
                projectExpropriation.UserID = CurrentUser;
                projectExpropriation.CreationDate = CurrentDate;

                _context.Add(projectExpropriation);
            }

            else
            {
                projectExpropriationToUpdate.ProjectID = id;
                projectExpropriationToUpdate.PropertyStatusID = model.ProjectExpropriation.PropertyStatusID;
                projectExpropriationToUpdate.PropertyStatusDescription = model.ProjectExpropriation.PropertyStatusDescription;
                projectExpropriationToUpdate.ProjectExpropriationDescription = model.ProjectExpropriation.ProjectExpropriationDescription;
                projectExpropriationToUpdate.ProjectNeedsExpropriation = model.ProjectExpropriation.ProjectNeedsExpropriation;
                projectExpropriationToUpdate.ProjectExpropriationDate = model.ProjectExpropriation.ProjectExpropriationDate;
                projectExpropriationToUpdate.ProjectExpropriationCost = model.ProjectExpropriation.ProjectExpropriationCost;
                projectExpropriationToUpdate.ProjectExpropriationCost = model.ProjectExpropriation.ProjectExpropriationCost;
                projectExpropriationToUpdate.ExpropriationStatusID = model.ProjectExpropriation.ExpropriationStatusID;
                projectExpropriationToUpdate.ProjectExpropriationStatusDesc = model.ProjectExpropriation.ProjectExpropriationStatusDesc;
                projectExpropriationToUpdate.UpdateDate = CurrentDate;
            }

            //Project Permission
            if (projectPermissionToUpdate == null)
            {
                //For creation we need a Model that is connected to a Database.
                ProjectPermission projectPermission = new ProjectPermission();

                projectPermission.ProjectID = id;
                projectPermission.OrganizationID = model.ProjectPermission.OrganizationID;
                projectPermission.IsPermissionNeeded = model.ProjectPermission.IsPermissionNeeded;
                projectPermission.ProjectPermissionDate = model.ProjectPermission.ProjectPermissionDate;
                projectPermission.ProjectPermissionReason = model.ProjectPermission.ProjectPermissionReason;
                projectPermission.UserID = CurrentUser;
                projectPermission.CreationDate = CurrentDate;

                _context.Add(projectPermission);
            }

            else
            {
                projectPermissionToUpdate.ProjectID = id;
                projectPermissionToUpdate.OrganizationID = model.ProjectPermission.OrganizationID;
                projectPermissionToUpdate.IsPermissionNeeded = model.ProjectPermission.IsPermissionNeeded;
                projectPermissionToUpdate.ProjectPermissionDate = model.ProjectPermission.ProjectPermissionDate;
                projectPermissionToUpdate.ProjectPermissionReason = model.ProjectPermission.ProjectPermissionReason;
                projectPermissionToUpdate.UpdateDate = CurrentDate;
            }

            try
            {
                await _context.SaveChangesAsync();

                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectFieldToUpdate.ProjectID} numaralı kayıt başarıyla düzenlendi.";
            }
            catch (Exception)
            {
                throw;
                //TempData["ErrorTitle"] = "HATA";
                //TempData["ErrorMessage"] = $"Kayıt düzenlenirken bir hata oluştu. Lütfen sistem yöneticinizle görüşün.";
                //return RedirectToAction(nameof(EditProjectField), new { id = projectFieldToUpdate.ProjectID.ToString() });
            }

            return RedirectToAction(nameof(EditProjectField), new { id = projectFieldToUpdate.ProjectID.ToString() });
        }

        // GET: Project/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .Include(p => p.ProjectImportance)
                .Include(p => p.ProjectOwnerPerson)
                .Include(p => p.ProjectServiceArea)
                .Include(p => p.ProjectStatus)
                .Include(p => p.RequestingDepartment)
                .Include(p => p.ResponsibleDepartment)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectID == id);
            if (project == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", project);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Project.FindAsync(id);
            
            try
            {
                _context.Project.Remove(project);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{project.ProjectID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.ProjectID == id);
        }
    }
}
