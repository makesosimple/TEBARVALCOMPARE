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
using Microsoft.AspNetCore.Authorization;
using IBBPortal.Static;

namespace IBBPortal.Controllers
{
    [Authorize]
    public class ProjectPersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectPersonController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectPerson
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.ProjectTitle = _context.Project.Single(m => m.ProjectID == id).ProjectTitle;
            ViewBag.ProjectID = id;
            return View();
        }

        [HttpPost]
        public JsonResult JSONData(int projectID)
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

                var data = _context.ProjectPerson
                    .Select(c => new
                {
                    c.ProjectPersonID,
                    c.ProjectID,
                    ProjectPersonName = c.Person.PersonName.Trim() + " " + c.Person.PersonSurname.Trim(),
                    ProjectPersonJob = c.JobTitle.Title,
                    ProjectPersonJobField = c.JobField.JobFieldTitle,
                    ProjectPersonIsInternal = c.IsInternal,
                    ProjectPersonContractor = c.Contractor.Title
                })
                    .Where(c => c.ProjectID == projectID);

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

                for (int i = 0; i < 5; i++)
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

        // GET: ProjectPerson/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerson = await _context.ProjectPerson
                .Include(p => p.Contractor)
                .Include(p => p.JobField)
                .Include(p => p.JobTitle)
                .Include(p => p.Person)
                .Include(p => p.Project)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPersonID == id);
            if (projectPerson == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectPerson);
        }

        // GET: ProjectPerson/Create
        public IActionResult Create(int id)
        {
            ViewBag.ProjectID = id;
            return PartialView("_CreateModal");
        }

        // POST: ProjectPerson/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectPersonID,IsInternal,ProjectID,PersonID,JobTitleID,JobFieldID,ContractorID,ProjectPersonDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPerson projectPerson)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    projectPerson.CreationDate = DateTime.Now;
                    projectPerson.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(projectPerson);
                    await _context.SaveChangesAsync();

                    ProjectHelper.UpdatedProject(projectPerson.ProjectID.Value, _context);
                    TransactionLogger.logTransaction(_context, (int)projectPerson.ProjectID, "project-person-added", _userManager.GetUserId(HttpContext.User));

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index), new { id = projectPerson.ProjectID});
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index), new { id = projectPerson.ProjectID });
                }
            }
            return PartialView("_CreateModal");
        }

        // GET: ProjectPerson/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerson = await _context.ProjectPerson
                .Include(p => p.Contractor)
                .Include(p => p.JobField)
                .Include(p => p.JobTitle)
                .Include(p => p.Person)
                .Include(p => p.Project)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPersonID == id);

            if (projectPerson == null)
            {
                return NotFound();
            }
            return PartialView("_EditModal", projectPerson);
        }

        // POST: ProjectPerson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectPersonID,IsInternal,ProjectID,PersonID,JobTitleID,JobFieldID,ContractorID,ProjectPersonDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPerson projectPerson)
        {
            if (id != projectPerson.ProjectPersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    projectPerson.UpdateDate = CurrentDate;

                    _context.Update(projectPerson);
                    await _context.SaveChangesAsync();

                    ProjectHelper.UpdatedProject(projectPerson.ProjectID.Value, _context);
                    TransactionLogger.logTransaction(_context, (int)projectPerson.ProjectID, "project-person-changed", _userManager.GetUserId(HttpContext.User));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectPersonExists(projectPerson.ProjectPersonID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = projectPerson.ProjectID });
            }
            return PartialView("_EditModal", projectPerson);
        }

        // GET: ProjectPerson/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerson = await _context.ProjectPerson
                .Include(p => p.Contractor)
                .Include(p => p.JobField)
                .Include(p => p.JobTitle)
                .Include(p => p.Person)
                .Include(p => p.Project)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPersonID == id);
            if (projectPerson == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectPerson);
        }

        // POST: ProjectPerson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectPerson = await _context.ProjectPerson.FindAsync(id);

            try
            {
                _context.ProjectPerson.Remove(projectPerson);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectPerson.ProjectPersonID} numaralı kayıt başarıyla silindi.";

                ProjectHelper.UpdatedProject(projectPerson.ProjectID.Value, _context);
                return RedirectToAction(nameof(Index), new { id = projectPerson.ProjectID});
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index), new { id = projectPerson.ProjectID });
            }
        }

        private bool ProjectPersonExists(int id)
        {
            return _context.ProjectPerson.Any(e => e.ProjectPersonID == id);
        }
    }
}
