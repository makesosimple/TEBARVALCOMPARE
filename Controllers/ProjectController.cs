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
                    ProjectIBBCode = c.ProjectIBBCode != null ? c.ProjectIBBCode.ToString() : "",
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

            return Json(new { data = data.Take(250).ToList(), districtID = selectedDistrictInt, ProjectKeyword = projectKeyword });
        }


        [HttpGet]
        public JsonResult MapDataExecutive()
        {
            string projectKeyword = HttpContext.Request.Query["projectTitle"];
            var selectedDistrict = HttpContext.Request.Query["selectDistrict"];
            var selectedFunction = HttpContext.Request.Query["selectFunction"];

            var selectedDepartment = HttpContext.Request.Query["selectedDepartment"];
            var selectedProjectStatus = HttpContext.Request.Query["selectProjectStatus"];
            var selectedProjectOwner = HttpContext.Request.Query["selectProjectOwner"];

            var yearSelected = HttpContext.Request.Query["yearSelected"];

            var data = _context.ProjectField.Select(c => new
            {
                c.ProjectID,
                ProjectStatus = c.Project.ProjectStatus.ProjectStatusTitle,
                ProjectStatusID = c.Project.ProjectStatusID,
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

            }
            else
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

            if (Int32.TryParse(selectedDepartment, out int respDepartmentIDInt))
            {
                data = data.Where(c => c.ResponsibleDepartmentID == respDepartmentIDInt);
            }
            else
            {
                respDepartmentIDInt = -1;
            }

            if (Int32.TryParse(selectedProjectStatus, out int selectedProjectStatusInt))
            {
                data = data.Where(c => c.ProjectStatusID == selectedProjectStatusInt);
            }
            else
            {
                selectedProjectStatusInt = -1;
            }

            if (Int32.TryParse(selectedProjectOwner, out int projectOwnerIDint))
            {
                data = data.Where(c => c.ProjectOwnerID == projectOwnerIDint);
            }
            else
            {
                projectOwnerIDint = -1;
            }

            if (projectKeyword == null)
            {
                projectKeyword = "";
            }

            if (projectKeyword.Length > 1)
            {
                data = data.Where(c => c.ProjectTitle.Contains(projectKeyword));
            }

            return Json(new { data = data.Take(100).ToList(), districtID = selectedDistrictInt, ProjectKeyword = projectKeyword });
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
        public async Task<IActionResult> Create([Bind("ProjectID,ProjectTitle,ProjectIBBCode,IsDoneByIBB,ProjectCost,ExternalOrganizationID,RequestingDepartmentID,ResponsibleDepartmentID,RequestingAuthorityID,ProjectOwnerPersonID,ProjectServiceAreaID,ProjectImportanceID,ProjectStatusID,ProjectStatusDescription,ProjectStatusDescriptionDate,ProjectYear,ProjectProductionRespDepartmentID,RequestingAuthorityDescription,RespDepartmentTransferDate,ProjectTypeID,ProjectProductionStatusDescription,ProjectProductionStatusID,ProjectAdditionalServiceAreaID,ProjectManagerID,ProjectProductionName,ProjectEndTime,ProjectProductionEndTime,UserID,CreationDate,UpdateDate,DeletionDate")] Project project)
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
                .Include(p => p.ProjectType)
                .Include(p => p.ProjectAdditionalServiceArea)
                .Include(p => p.ProjectProductionStatus)
                .Include(p => p.ExternalOrganization)
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
        public async Task<IActionResult> Edit(int id, [Bind("ProjectID,ProjectTitle,ProjectIBBCode,IsDoneByIBB,ExternalOrganizationID,ProjectCost,RequestingDepartmentID,ResponsibleDepartmentID,RequestingAuthorityID,ProjectOwnerPersonID,ProjectServiceAreaID,ProjectImportanceID,ProjectStatusID,ProjectStatusDescription,ProjectStatusDescriptionDate,ProjectYear,ProjectProductionRespDepartmentID,RequestingAuthorityDescription,RespDepartmentTransferDate,ProjectTypeID,ProjectProductionStatusDescription,ProjectProductionStatusID,ProjectAdditionalServiceAreaID,ProjectManagerID,ProjectProductionName,ProjectEndTime,ProjectProductionEndTime,UserID,CreationDate,UpdateDate,DeletionDate")] Project project)
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
