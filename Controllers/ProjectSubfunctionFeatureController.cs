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
    public class ProjectSubfunctionFeatureController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectSubfunctionFeatureController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectPerson
        public IActionResult Index(int id)
        {
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

                var data = _context.ProjectSubfunctionFeature
                    .Select(c => new
                    {
                        c.ProjectSubfunctionFeatureID,
                        c.ProjectID,
                        SubfunctionTitle = c.Subfunction.SubfunctionTitle,
                        SubfunctionFeatureTitle = c.SubfunctionFeature.SubfunctionFeatureTitle,
                        c.SubfunctionFeatureValue
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

                for (int i = 0; i < 3; i++)
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

        // GET: ProjectSubfunctionFeature/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectSubfunctionFeature = await _context.ProjectSubfunctionFeature
                .Include(p => p.Project)
                .Include(p => p.Subfunction)
                .Include(p => p.SubfunctionFeature)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectSubfunctionFeatureID == id);
            if (projectSubfunctionFeature == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectSubfunctionFeature);
        }

        // GET: ProjectSubfunctionFeature/Create
        public IActionResult Create(int id)
        {
            ViewBag.ProjectID = id;
            return PartialView("_CreateModal");
        }

        // POST: ProjectSubfunctionFeature/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectSubfunctionFeatureID,ProjectID,SubfunctionID,SubfunctionFeatureID,SubfunctionFeatureValue,SubfunctionFeatureValueDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectSubfunctionFeature projectSubfunctionFeature)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    projectSubfunctionFeature.CreationDate = DateTime.Now;
                    projectSubfunctionFeature.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(projectSubfunctionFeature);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index), new { id = projectSubfunctionFeature.ProjectID });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index), new { id = projectSubfunctionFeature.ProjectID });
                }
            }
            return PartialView("_CreateModal");
        }

        // GET: ProjectSubfunctionFeature/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectSubfunctionFeature = await _context.ProjectSubfunctionFeature.
                Include(p => p.Project)
                .Include(p => p.Subfunction)
                .Include(p => p.SubfunctionFeature)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectSubfunctionFeatureID == id); ;
            if (projectSubfunctionFeature == null)
            {
                return NotFound();
            }
            return PartialView("_EditModal", projectSubfunctionFeature);
        }

        // POST: ProjectSubfunctionFeature/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectSubfunctionFeatureID,ProjectID,SubfunctionID,SubfunctionFeatureID,SubfunctionFeatureValue,SubfunctionFeatureValueDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectSubfunctionFeature projectSubfunctionFeature)
        {
            if (id != projectSubfunctionFeature.ProjectSubfunctionFeatureID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    projectSubfunctionFeature.UpdateDate = CurrentDate;

                    _context.Update(projectSubfunctionFeature);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectSubfunctionFeatureExists(projectSubfunctionFeature.ProjectSubfunctionFeatureID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = projectSubfunctionFeature.ProjectID });
            }
            return PartialView("_EditModal", projectSubfunctionFeature);
        }

        // GET: ProjectSubfunctionFeature/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectSubfunctionFeature = await _context.ProjectSubfunctionFeature
                .Include(p => p.Project)
                .Include(p => p.Subfunction)
                .Include(p => p.SubfunctionFeature)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectSubfunctionFeatureID == id);
            if (projectSubfunctionFeature == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectSubfunctionFeature);
        }

        // POST: ProjectSubfunctionFeature/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectSubfunctionFeature = await _context.ProjectSubfunctionFeature.FindAsync(id);

            try
            {
                _context.ProjectSubfunctionFeature.Remove(projectSubfunctionFeature);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectSubfunctionFeature.ProjectSubfunctionFeatureID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index), new { id = projectSubfunctionFeature.ProjectID });
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index), new { id = projectSubfunctionFeature.ProjectID });
            }
        }

        private bool ProjectSubfunctionFeatureExists(int id)
        {
            return _context.ProjectSubfunctionFeature.Any(e => e.ProjectSubfunctionFeatureID == id);
        }
    }
}
