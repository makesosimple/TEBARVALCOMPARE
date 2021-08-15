using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using System.Globalization;
using IBBPortal.Helpers;

namespace IBBPortal.Controllers
{
    public class JobTitleController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public JobTitleController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: JobTitle
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

                var data = _context.JobTitle.Select(c => new { c.JobTitleID, c.Title, UserName = c.User.UserName }).AsQueryable();

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

                var JobTitleData = _context.JobTitle
                                    .Select(x => new {
                                        id = x.JobTitleID.ToString(),
                                        text = x.Title
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    JobTitleData = JobTitleData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = JobTitleData.Count();

                //Paging   
                var passData = JobTitleData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: JobTitle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitle
                .Include(j => j.User)
                .FirstOrDefaultAsync(m => m.JobTitleID == id);
            if (jobTitle == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", jobTitle);
        }

        // GET: JobTitle/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobTitle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobTitleID,Title,JobDescription,UserID,CreationDate,UpdateDate,DeletionDate")] JobTitle jobTitle)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    jobTitle.CreationDate = DateTime.Now;
                    jobTitle.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(jobTitle);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {jobTitle.JobTitleID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Edit), new { id = jobTitle.JobTitleID.ToString() });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(jobTitle);
        }

        // GET: JobTitle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitle.FindAsync(id);
            if (jobTitle == null)
            {
                return NotFound();
            }
            return View(jobTitle);
        }

        // POST: JobTitle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobTitleID,Title,JobDescription,UserID,CreationDate,UpdateDate,DeletionDate")] JobTitle jobTitle)
        {
            if (id != jobTitle.JobTitleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    jobTitle.UpdateDate = CurrentDate;

                    _context.Update(jobTitle);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{jobTitle.JobTitleID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobTitleExists(jobTitle.JobTitleID))
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
            return View(jobTitle);
        }

        // GET: JobTitle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitle
                .Include(j => j.User)
                .FirstOrDefaultAsync(m => m.JobTitleID == id);
            if (jobTitle == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", jobTitle);
        }

        // POST: JobTitle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobTitle = await _context.JobTitle.FindAsync(id);
            
            try
            {
                _context.JobTitle.Remove(jobTitle);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{jobTitle.JobTitleID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool JobTitleExists(int id)
        {
            return _context.JobTitle.Any(e => e.JobTitleID == id);
        }
    }
}
