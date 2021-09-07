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
    public class ZoningPlanStatusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ZoningPlanStatusController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

                var data = _context.ZoningPlanStatus.Select(c => new { c.ZoningPlanStatusID, c.ZoningPlanStatusTitle, UserName = c.User.UserName });

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

                var ZoningPlanStatusData = _context.ZoningPlanStatus
                                    .Select(x => new {
                                        id = x.ZoningPlanStatusID.ToString(),
                                        text = x.ZoningPlanStatusTitle
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    ZoningPlanStatusData = ZoningPlanStatusData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ZoningPlanStatusData.Count();

                //Paging   
                var passData = ZoningPlanStatusData.Take(10).ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: ZoningPlanStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zoningPlanStatus = await _context.ZoningPlanStatus
                .Include(z => z.User)
                .FirstOrDefaultAsync(m => m.ZoningPlanStatusID == id);
            if (zoningPlanStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", zoningPlanStatus);
        }

        // GET: ZoningPlanStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZoningPlanStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZoningPlanStatusID,ZoningPlanStatusTitle,ZoningPlanStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ZoningPlanStatus zoningPlanStatus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    zoningPlanStatus.CreationDate = DateTime.Now;
                    zoningPlanStatus.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(zoningPlanStatus);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {zoningPlanStatus.ZoningPlanStatusID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(zoningPlanStatus);
        }

        // GET: ZoningPlanStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zoningPlanStatus = await _context.ZoningPlanStatus.FindAsync(id);
            if (zoningPlanStatus == null)
            {
                return NotFound();
            }
            return View(zoningPlanStatus);
        }

        // POST: ZoningPlanStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZoningPlanStatusID,ZoningPlanStatusTitle,ZoningPlanStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ZoningPlanStatus zoningPlanStatus)
        {
            if (id != zoningPlanStatus.ZoningPlanStatusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    zoningPlanStatus.UpdateDate = CurrentDate;

                    _context.Update(zoningPlanStatus);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{zoningPlanStatus.ZoningPlanStatusID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZoningPlanStatusExists(zoningPlanStatus.ZoningPlanStatusID))
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
            return View(zoningPlanStatus);
        }

        // GET: ZoningPlanStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zoningPlanStatus = await _context.ZoningPlanStatus
                .Include(z => z.User)
                .FirstOrDefaultAsync(m => m.ZoningPlanStatusID == id);
            if (zoningPlanStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", zoningPlanStatus);
        }

        // POST: ZoningPlanStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zoningPlanStatus = await _context.ZoningPlanStatus.FindAsync(id);
            
            try
            {
                _context.ZoningPlanStatus.Remove(zoningPlanStatus);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{zoningPlanStatus.ZoningPlanStatusID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));

            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ZoningPlanStatusExists(int id)
        {
            return _context.ZoningPlanStatus.Any(e => e.ZoningPlanStatusID == id);
        }
    }
}
