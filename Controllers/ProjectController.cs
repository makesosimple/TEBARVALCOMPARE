using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using IBBPortal.Helpers;
using NetTopologySuite.Geometries;

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
                    c.HasRelatedProject
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
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = passData });

            }

            catch (Exception)
            {
                throw;
            }
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
                var passData = ProjectData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
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
        public async Task<IActionResult> Create([Bind("ProjectID,ProjectTitle,ProjectIBBCode,RequestingDepartmentID,ResponsibleDepartmentID,ProjectOwnerPersonID,ProjectServiceAreaID,ProjectImportanceID,ProjectStatusID,ProjectStatusDescription,ProjectStatusDescriptionDate,IsFeasibilityNeeded,HasRelatedProject,UserID,CreationDate,UpdateDate,DeletionDate")] Project project)
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
        public async Task<IActionResult> Edit(int id, [Bind("ProjectID,ProjectTitle,ProjectIBBCode,RequestingDepartmentID,ResponsibleDepartmentID,ProjectOwnerPersonID,ProjectServiceAreaID,ProjectImportanceID,ProjectStatusID,ProjectStatusDescription,ProjectStatusDescriptionDate,IsFeasibilityNeeded,HasRelatedProject,UserID,CreationDate,UpdateDate,DeletionDate")] Project project)
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
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Project/Edit/5
        public async Task<IActionResult> EditProjectField(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .Include(p => p.District)
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
        [HttpPost, ActionName("EditProjectField")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProjectFieldMain(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectToUpdate = await _context.Project.FirstOrDefaultAsync(c => c.ProjectID == id);

            //Set Update Date
            var CurrentDate = DateTime.Now;
            projectToUpdate.UpdateDate = CurrentDate;

            //Get Project Longitude and Latitude. This will throw an error if user tries to update with null Lang and Long!
            double projectLongitude = Convert.ToDouble(Request.Form["ProjectLongitude"].FirstOrDefault());
            double projectLatitude = Convert.ToDouble(Request.Form["ProjectLatitude"].FirstOrDefault());

            projectToUpdate.ProjectPoint = new Point(projectLatitude, projectLongitude) { SRID = 4326 };

            if (await TryUpdateModelAsync<Project>(projectToUpdate, "", 
                c =>  c.IsProjectInIstanbul, c => c.DistrictID, c => c.ProjectAddress, c => c.ProjectArea, 
                c => c.ProjectConstructionArea, c => c.ProjectPaysageArea, c => c.ProjectPaftaAdaParsel,
                c => c.ProjectLongitude, c => c.ProjectLatitude, c => c.KML, c => c.ProjectPoint))
            {
                try
                {
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{projectToUpdate.ProjectID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (Exception)
                {
                    if (!ProjectExists(projectToUpdate.ProjectID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        TempData["ErrorTitle"] = "HATA";
                        TempData["ErrorMessage"] = $"Kayıt düzenlenirken bir hata oluştu. Lütfen sistem yöneticinizle görüşün.";
                        return RedirectToAction(nameof(EditProjectField), new { id = projectToUpdate.ProjectID.ToString() });
                    }
                }
                return RedirectToAction(nameof(EditProjectField), new { id = projectToUpdate.ProjectID.ToString() });
            }
            return View(projectToUpdate);
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
