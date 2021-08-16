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

namespace IBBPortal.Controllers
{
    public class ProjectTeamCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectTeamCategoryController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult JSONData()
        {
            try
            {

                var draw = HttpContext.Request.Query["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Query["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Query["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Query["columns[" + Request.Query["order[0][column]"].FirstOrDefault() + "][data]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Query["order[0][dir]"].FirstOrDefault().ToUpper();

                //Paging Size (10, 20, 50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var data = _context.ProjectTeamCategory.Select(c => new { c.ProjectTeamCategoryID, c.ProjectTeamCategoryTitle, UserName = c.User.UserName }).AsQueryable();

                //Sorting
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    var sortProp = sortColumn + " " + sortColumnDirection;
                    data = data.OrderBy(sortProp);
                }

                //Search Functionality = Programmer will always know how many columns will be shown to the user.
                //So we will use that to check every column if they have a search value.
                //If control checks out, search. If not, loop goes on until the end.
                string columnName, searchValue;

                for (int i = 0; i < 2; i++)
                {
                    columnName = Request.Query[$"columns[{i}][data]"].FirstOrDefault();
                    searchValue = Request.Query[$"columns[{i}][search][value]"].FirstOrDefault();

                    if (!(string.IsNullOrEmpty(columnName) && string.IsNullOrEmpty(searchValue)))
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

        // GET: ProjectTeamCategory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectTeamCategory = await _context.ProjectTeamCategory
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectTeamCategoryID == id);
            if (projectTeamCategory == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectTeamCategory); 
        }

        // GET: ProjectTeamCategory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectTeamCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectTeamCategoryID,ProjectTeamCategoryTitle,ProjectTeamCategoryDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectTeamCategory projectTeamCategory)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    projectTeamCategory.CreationDate = DateTime.Now;
                    projectTeamCategory.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(projectTeamCategory);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {projectTeamCategory.ProjectTeamCategoryID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index), new { id = projectTeamCategory.ProjectTeamCategoryID.ToString() });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(projectTeamCategory);
        }

        // GET: ProjectTeamCategory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectTeamCategory = await _context.ProjectTeamCategory.FindAsync(id);
            if (projectTeamCategory == null)
            {
                return NotFound();
            }
            return View(projectTeamCategory);
        }

        // POST: ProjectTeamCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectTeamCategoryID,ProjectTeamCategoryTitle,ProjectTeamCategoryDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectTeamCategory projectTeamCategory)
        {
            if (id != projectTeamCategory.ProjectTeamCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    projectTeamCategory.UpdateDate = CurrentDate;

                    _context.Update(projectTeamCategory);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{projectTeamCategory.ProjectTeamCategoryID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectTeamCategoryExists(projectTeamCategory.ProjectTeamCategoryID))
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
            return View(projectTeamCategory);
        }

        // GET: ProjectTeamCategory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectTeamCategory = await _context.ProjectTeamCategory
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectTeamCategoryID == id);
            if (projectTeamCategory == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectTeamCategory);
        }

        // POST: ProjectTeamCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectTeamCategory = await _context.ProjectTeamCategory.FindAsync(id);
            
            try
            {
                _context.ProjectTeamCategory.Remove(projectTeamCategory);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectTeamCategory.ProjectTeamCategoryID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ProjectTeamCategoryExists(int id)
        {
            return _context.ProjectTeamCategory.Any(e => e.ProjectTeamCategoryID == id);
        }
    }
}
