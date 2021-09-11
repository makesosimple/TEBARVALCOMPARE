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

namespace IBBPortal.Controllers
{
    [Authorize]
    public class ProjectPhaseStatusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectPhaseStatusController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectPhaseStatus
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

                var data = _context.ProjectPhaseStatus.Select(c => new { c.ProjectPhaseStatusID, c.ProjectPhaseStatusTitle, UserName = c.User.UserName }).AsQueryable();

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

        [HttpGet]
        public JsonResult JsonSelectData(string term)
        {
            try
            {

                var ProjectPhaseStatusData = _context.ProjectPhaseStatus
                                    .Select(x => new {
                                        id = x.ProjectPhaseStatusID.ToString(),
                                        text = x.ProjectPhaseStatusTitle
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    ProjectPhaseStatusData = ProjectPhaseStatusData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ProjectPhaseStatusData.Count();

                //Paging   
                var passData = ProjectPhaseStatusData.Take(10).ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: ProjectPhaseStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhaseStatus = await _context.ProjectPhaseStatus
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPhaseStatusID == id);
            if (projectPhaseStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectPhaseStatus);
        }

        // GET: ProjectPhaseStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectPhaseStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectPhaseStatusID,ProjectPhaseStatusTitle,ProjectPhaseStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPhaseStatus projectPhaseStatus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    projectPhaseStatus.CreationDate = DateTime.Now;
                    projectPhaseStatus.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(projectPhaseStatus);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {projectPhaseStatus.ProjectPhaseStatusID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(projectPhaseStatus);
        }

        // GET: ProjectPhaseStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhaseStatus = await _context.ProjectPhaseStatus.FindAsync(id);
            if (projectPhaseStatus == null)
            {
                return NotFound();
            }
            return View(projectPhaseStatus);
        }

        // POST: ProjectPhaseStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectPhaseStatusID,ProjectPhaseStatusTitle,ProjectPhaseStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPhaseStatus projectPhaseStatus)
        {
            if (id != projectPhaseStatus.ProjectPhaseStatusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    projectPhaseStatus.UpdateDate = CurrentDate;

                    _context.Update(projectPhaseStatus);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{projectPhaseStatus.ProjectPhaseStatusID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectPhaseStatusExists(projectPhaseStatus.ProjectPhaseStatusID))
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
            return View(projectPhaseStatus);
        }

        // GET: ProjectPhaseStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhaseStatus = await _context.ProjectPhaseStatus
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPhaseStatusID == id);
            if (projectPhaseStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectPhaseStatus);
        }

        // POST: ProjectPhaseStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectPhaseStatus = await _context.ProjectPhaseStatus.FindAsync(id);
            
            try
            {
                _context.ProjectPhaseStatus.Remove(projectPhaseStatus);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectPhaseStatus.ProjectPhaseStatusID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ProjectPhaseStatusExists(int id)
        {
            return _context.ProjectPhaseStatus.Any(e => e.ProjectPhaseStatusID == id);
        }
    }
}
