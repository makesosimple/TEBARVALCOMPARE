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
using Microsoft.AspNetCore.Authorization;

namespace IBBPortal.Controllers
{
    [Authorize]
    public class ExpropriationStatusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ExpropriationStatusController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

                var data = _context.ExpropriationStatus.Select(c => new { c.ExpropriationStatusID, c.ExpropriationStatusTitle, UserName = c.User.UserName });

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

                var ExpropriationStatusData = _context.ExpropriationStatus
                                    .Select(x => new {
                                        id = x.ExpropriationStatusID.ToString(),
                                        text = x.ExpropriationStatusTitle
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    ExpropriationStatusData = ExpropriationStatusData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ExpropriationStatusData.Count();

                //Paging   
                var passData = ExpropriationStatusData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: ExpropriationStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expropriationStatus = await _context.ExpropriationStatus
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.ExpropriationStatusID == id);
            if (expropriationStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", expropriationStatus);
        }

        // GET: ExpropriationStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExpropriationStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExpropriationStatusID,ExpropriationStatusTitle,ExpropriationStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ExpropriationStatus expropriationStatus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    expropriationStatus.CreationDate = DateTime.Now;
                    expropriationStatus.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(expropriationStatus);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {expropriationStatus.ExpropriationStatusID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(expropriationStatus);
        }

        // GET: ExpropriationStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expropriationStatus = await _context.ExpropriationStatus.FindAsync(id);
            if (expropriationStatus == null)
            {
                return NotFound();
            }
            return View(expropriationStatus);
        }

        // POST: ExpropriationStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExpropriationStatusID,ExpropriationStatusTitle,ExpropriationStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ExpropriationStatus expropriationStatus)
        {
            if (id != expropriationStatus.ExpropriationStatusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    expropriationStatus.UpdateDate = CurrentDate;

                    _context.Update(expropriationStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpropriationStatusExists(expropriationStatus.ExpropriationStatusID))
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
            return View(expropriationStatus);
        }

        // GET: ExpropriationStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expropriationStatus = await _context.ExpropriationStatus
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.ExpropriationStatusID == id);
            if (expropriationStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", expropriationStatus);
        }

        // POST: ExpropriationStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expropriationStatus = await _context.ExpropriationStatus.FindAsync(id);
            
            try
            {
                _context.ExpropriationStatus.Remove(expropriationStatus);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{expropriationStatus.ExpropriationStatusID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));

            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ExpropriationStatusExists(int id)
        {
            return _context.ExpropriationStatus.Any(e => e.ExpropriationStatusID == id);
        }
    }
}
