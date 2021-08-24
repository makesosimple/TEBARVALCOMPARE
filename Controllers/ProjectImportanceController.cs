using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using IBBPortal.Helpers;

namespace IBBPortal.Controllers
{
    public class ProjectImportanceController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectImportanceController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: City
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

                var data = _context.ProjectImportance.Select(c => new { c.ProjectImportanceID, c.ProjectImportanceTitle, UserName = c.User.UserName });
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

        [HttpGet]
        public JsonResult JsonSelectData(string term)
        {
            try
            {

                var ProjectImportanceData = _context.ProjectImportance
                                    .Select(x => new
                                    {
                                        id = x.ProjectImportanceID.ToString(),
                                        text = x.ProjectImportanceTitle
                                    }).Take(10);

                if (!String.IsNullOrEmpty(term))
                {
                    ProjectImportanceData = ProjectImportanceData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ProjectImportanceData.Count();

                //Paging   
                var passData = ProjectImportanceData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: ProjectImportance/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectImportance = await _context.ProjectImportance
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectImportanceID == id);
            if (projectImportance == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectImportance);
        }

        // GET: ProjectImportance/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectImportance/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectImportanceID,ProjectImportanceTitle,ProjectImportanceDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectImportance projectImportance)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    projectImportance.CreationDate = DateTime.Now;
                    projectImportance.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(projectImportance);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {projectImportance.ProjectImportanceID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(projectImportance);
        }

        // GET: ProjectImportance/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectImportance = await _context.ProjectImportance.FindAsync(id);
            if (projectImportance == null)
            {
                return NotFound();
            }
            return View(projectImportance);
        }

        // POST: ProjectImportance/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectImportanceID,ProjectImportanceTitle,ProjectImportanceDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectImportance projectImportance)
        {
            if (id != projectImportance.ProjectImportanceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    projectImportance.UpdateDate = CurrentDate;

                    _context.Update(projectImportance);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{projectImportance.ProjectImportanceID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectImportanceExists(projectImportance.ProjectImportanceID))
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
            return View(projectImportance);
        }

        // GET: ProjectImportance/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectImportance = await _context.ProjectImportance
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectImportanceID == id);
            if (projectImportance == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectImportance);
        }

        // POST: ProjectImportance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectImportance = await _context.ProjectImportance.FindAsync(id);
            
            try
            {
                _context.ProjectImportance.Remove(projectImportance);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectImportance.ProjectImportanceID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ProjectImportanceExists(int id)
        {
            return _context.ProjectImportance.Any(e => e.ProjectImportanceID == id);
        }
    }
}
