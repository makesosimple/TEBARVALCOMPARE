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
using System.Diagnostics;
using IBBPortal.Static;
using Microsoft.AspNetCore.Authorization;

namespace IBBPortal.Controllers
{
    [Authorize]
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

                var draw = Request.Form["draw"].FirstOrDefault();
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
                    c.ProjectIBBCode,
                    c.ProjectTitle,
                    EstimatedProjectCost = c.EstimatedProjectCost != null ? c.EstimatedProjectCost.ToString() + " TL" : "",
                    RequestingAuthorityID = c.RequestingAuthority != null ? c.RequestingAuthority.AuthorityID : 0,
                    RequestingAuthorityTitle = c.RequestingAuthority != null ? c.RequestingAuthority.AuthorityTitle : "",
                    ResponsibleDepartmentID = c.ResponsibleDepartment != null ? c.ResponsibleDepartment.DepartmentID : 0,
                    ResponsibleDepartmentTitle = c.ResponsibleDepartment != null ? c.ResponsibleDepartment.DepartmentTitle : "",
                    OwnerID = c.ProjectOwnerPerson != null ? c.ProjectOwnerPerson.PersonID : 0,
                    OwnerFullName = c.ProjectOwnerPerson != null ?  c.ProjectOwnerPerson.PersonName.Trim() + " " + c.ProjectOwnerPerson.PersonSurname.Trim() : "",
                    ServiceAreaID = c.ProjectServiceArea != null ? c.ProjectServiceArea.ServiceAreaID : 0,
                    ServiceAreaTitle = c.ProjectServiceArea != null ? c.ProjectServiceArea.ServiceAreaTitle : "",
                    ProjectStatusID = c.ProjectStatus != null ? c.ProjectStatus.ProjectStatusID : 0,
                    ProjectStatusTitle = c.ProjectStatus != null ? c.ProjectStatus.ProjectStatusTitle : "",
                    ProjectImportanceID = c.ProjectImportance != null ? c.ProjectImportance.ProjectImportanceID : 0,
                    ProjectImportanceTitle = c.ProjectImportance != null ? c.ProjectImportance.ProjectImportanceTitle : "",

                    ShortcutID = _context.Shortcuts.Where(s => (s.UserID == _userManager.GetUserId(HttpContext.User) && s.ShortcutsProjectID == c.ProjectID)).ToList()
                });

                //var shortcuts = _context.Shortcuts.Where(s => s.UserID == _userManager.GetUserId(HttpContext.User)).ToList();

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

                for (int i = 0; i < 10; i++)
                {
                    columnName = Request.Form[$"columns[{i}][data]"].FirstOrDefault();
                    searchValue = Request.Form[$"columns[{i}][search][value]"].FirstOrDefault();

                    if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchValue))
                    {
                        data = data.WhereContains(columnName, searchValue);
                    }
                }

                data = data.Where(d => d.ProjectTitle.Length > 0);

                //total number of rows count   
                recordsTotal = data.Count();
                //Paging   
                var passData = data.Skip(skip).Take(pageSize).ToList();

                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = passData});

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
                OwnerFullName = c.Project.ProjectOwnerPerson.PersonName.Trim(), // + " " + c.Project.ProjectOwnerPerson.PersonSurname.Trim(),
                ServiceAreaTitle = c.Project.ProjectServiceArea.ServiceAreaTitle,
                ProjectImportanceTitle = c.Project.ProjectImportance.ProjectImportanceTitle,
                RequestingDepartmentID = c.Project.RequestingDepartmentID == null ? 0 : c.Project.RequestingDepartmentID,
                ResponsibleDepartmentID = c.Project.ResponsibleDepartmentID == null ? 0 : c.Project.ResponsibleDepartmentID,
                DistrictID = c.DistrictID == null ? 0 : c.DistrictID,
                ProjectOwnerID = c.Project.ProjectOwnerPersonID == null ? 0 : c.Project.ProjectOwnerPersonID,
                ProjectYear = c.Project.ProjectYear,
                MapIcon = c.Project.ResponsibleDepartment.MapIcon,
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

            if (Int32.TryParse(yearSelected, out int yearSelectedInt))
            {
                if (selectedDistrictInt != 0)
                {
                    data = data.Where(c => c.ProjectYear == yearSelectedInt);
                }

            }
            else
            {
                yearSelectedInt = -1;
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
                //var passData = data.ToList();

                //Returning Json Data  
                return Json(new { data = data.ToList(), districtID = selectedDistrictInt, ProjectKeyword = projectKeyword });

            //}

            //catch (Exception)
            //{
              //  throw;
            //}
        }

        [HttpGet]
        public JsonResult MapDetail()
        {
            //try
            //{
            string projectKeyword = HttpContext.Request.Query["projectKeyword"];
            var showIntersectingProjects = HttpContext.Request.Query["showIntersectingProjects"];
            var closeProjectsKM = HttpContext.Request.Query["closeProjectsKM"];
            var projectID = HttpContext.Request.Query["projectID"];

            if (Int32.TryParse(closeProjectsKM, out int closeProjectsKMInt))
            {
                //do nothing;

            }
            else
            {
                closeProjectsKMInt = 0;

            }

            if (Int32.TryParse(projectID, out int projectIDparsed))
            {
                //do nothing;

            }
            else
            {
                projectIDparsed = -1;

            }

            var currentProject = _context.ProjectField.Select(c => new
            {
                c.ProjectLineString,
                c.ProjectPoint,
                c.ProjectPolygon,
                c.ProjectID,

            }).Where(c => c.ProjectID == projectIDparsed).First();

            if (currentProject == null)
            {
                return Json(new { data = false, ProjectKeyword = projectKeyword });
            }
            

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
                ProjectYear = c.Project.ProjectYear,
                ProjectLineString = c.ProjectLineString,
                ProjectPoint = c.ProjectPoint,
                Distance = c.ProjectPoint.Distance(currentProject.ProjectPoint),
            });

            data = data.Where(c => c.ProjectID != projectIDparsed);


            
           if (projectIDparsed != 0 && currentProject!=null && currentProject.ProjectLineString!=null && showIntersectingProjects=="true")
           {
              data = data.Where(c => c.ProjectLineString.Intersects(currentProject.ProjectLineString));
           }

            if (projectIDparsed != 0 && currentProject != null && currentProject.ProjectPoint != null)
            {
                data = data.Where(c => c.ProjectPoint.Distance(currentProject.ProjectPoint) < closeProjectsKMInt);

            }








            //Sorting


            //total number of rows count   
            //var recordsTotal = data.Count();
            //Paging   
            var passData = data.Select(
                c => new
                {
                    c.ProjectID,
                    c.ProjectTitle,
                    c.DistrictName,
                    c.Longitude,
                    c.Latitude,
                    c.Coordinates,
                    c.RequestingDepartmentTitle,
                    c.ResponsibleDepartmentTitle,
                    c.OwnerFullName,
                    c.ServiceAreaTitle,
                    c.ProjectImportanceTitle,
                    c.RequestingDepartmentID,
                    c.ResponsibleDepartmentID,
                    c.DistrictID,
                    c.ProjectOwnerID,
                    c.ProjectYear,
                    c.Distance,
                }
                ).Take(100).ToList();

            //Returning Json Data  
            return Json(new { data = passData, ProjectKeyword = projectKeyword, closeProjectsKMInt = closeProjectsKMInt, showIntersectingProjects = showIntersectingProjects });

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
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    ProjectData = ProjectData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ProjectData.Count();

                //Paging   
                var passData = ProjectData.Take(10).ToList();


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
                .Include(p => p.RequestingAuthority)
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
        public async Task<IActionResult> Create([Bind("ProjectID,ProjectTitle,ProjectIBBCode,RequestingDepartmentID,ResponsibleDepartmentID,RequestingAuthorityID,ProjectOwnerPersonID,ProjectServiceAreaID,ProjectImportanceID,ProjectStatusID,ProjectStatusDescription,ProjectStatusDescriptionDate,ProjectObjectID,ProjectUID,ProjectGlobalID,ProjectYear,ProjectProductionRespDepartmentID,ProjectFileNumber,ProjectPackageNumber,ProjectManagerID,ProjectProductionName,ProjectEndTime,ProjectProductionEndTime,UserID,CreationDate,UpdateDate,DeletionDate")] Project project)
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

                    TransactionLogger.logTransaction(_context, project.ProjectID, "created-new-project", _userManager.GetUserId(HttpContext.User));

                    return RedirectToAction(nameof(Index), new { id = project.ProjectID.ToString() });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";

                    TransactionLogger.logTransaction(_context, project.ProjectID, "error-created-new-project", _userManager.GetUserId(HttpContext.User));

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
                .Include(p => p.RequestingAuthority)
                .Include(p => p.ResponsibleDepartment)
                .Include(p => p.ProjectProductionRespDepartment)
                .Include(p => p.ProjectManager)
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
        public async Task<IActionResult> Edit(int id, [Bind("ProjectID,ProjectTitle,ProjectIBBCode,RequestingDepartmentID,ResponsibleDepartmentID,RequestingAuthorityID,ProjectOwnerPersonID,ProjectServiceAreaID,ProjectImportanceID,ProjectStatusID,ProjectStatusDescription,ProjectStatusDescriptionDate,ProjectObjectID,ProjectUID,ProjectGlobalID,ProjectYear,ProjectProductionRespDepartmentID,ProjectFileNumber,ProjectPackageNumber,ProjectManagerID,ProjectProductionName,ProjectEndTime,ProjectProductionEndTime,UserID,CreationDate,UpdateDate,DeletionDate")] Project project)
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

                    TransactionLogger.logTransaction(_context, project.ProjectID, "updated-project", _userManager.GetUserId(HttpContext.User));

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

                    var unused = TransactionLogger.logTransaction(_context, project.ProjectID, "error-updating-project", _userManager.GetUserId(HttpContext.User));
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
            model.ProjectTitle = _context.Project.Single(m => m.ProjectID == id).ProjectTitle;

            model.ProjectField = await _context.ProjectField
                .Include(p => p.District)
                .Include(p => p.City)
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

                if (model.ProjectField.KML!=null)
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
                if (coordinates!=null)
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
                    Debug.WriteLine("formattedCoordinates="+formattedCoordinates);
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
                TransactionLogger.logTransaction(_context, (int)id, "zoning-plan-created", _userManager.GetUserId(HttpContext.User));
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
                TransactionLogger.logTransaction(_context, (int)id, "zoning-plan-updated", _userManager.GetUserId(HttpContext.User));
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
                TransactionLogger.logTransaction(_context, (int)id, "expropriation-created", _userManager.GetUserId(HttpContext.User));
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
                TransactionLogger.logTransaction(_context, (int)id, "expropriation-updated", _userManager.GetUserId(HttpContext.User));
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
                TransactionLogger.logTransaction(_context, (int)id, "permission-created", _userManager.GetUserId(HttpContext.User));
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
                return RedirectToAction(nameof(EditProjectField), new { id = projectFieldToUpdate.ProjectID.ToString() });
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
                //_context.Project.Remove(project);
                project.DeletionDate = DateTime.Now;
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{project.ProjectID} numaralı kayıt başarıyla silindi.";
                TransactionLogger.logTransaction(_context, (int)id, "project-deleted", _userManager.GetUserId(HttpContext.User));
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                TransactionLogger.logTransaction(_context, (int)id, "project-deleted-attempt", _userManager.GetUserId(HttpContext.User));
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.ProjectID == id);
        }
    }
}
