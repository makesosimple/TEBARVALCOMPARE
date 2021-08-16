using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using System.Globalization;
using IBBPortal.Helpers;

namespace IBBPortal.Controllers
{
    public class SubfunctionFeatureController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public SubfunctionFeatureController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

                var data = _context.SubfunctionFeature.Select(c => new { c.SubfunctionFeatureID, c.SubfunctionFeatureTitle,  c.SubfunctionMeasurementUnit, c.Subfunction.SubfunctionTitle, UserName = c.User.UserName });

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

                for (int i = 0; i < 4; i++)
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

        // GET: SubfunctionFeature/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subfunctionFeature = await _context.SubfunctionFeature
                .Include(s => s.Subfunction)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.SubfunctionFeatureID == id);
            if (subfunctionFeature == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", subfunctionFeature);
        }

        // GET: SubfunctionFeature/Create
        public IActionResult Create()
        {
            var culture = new CultureInfo("tr-TR");
            ViewBag.CurrentDate = DateTime.Now.ToString(culture);
            ViewBag.UserID = _userManager.GetUserId(HttpContext.User);
            return View();
        }

        // POST: SubfunctionFeature/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubfunctionFeatureID,SubfunctionFeatureTitle,SubfunctionFeatureDescription,SubfunctionMeasurementUnit,SubfunctionID,UserID,CreationDate,UpdateDate,DeletionDate")] SubfunctionFeature subfunctionFeature)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    subfunctionFeature.CreationDate = DateTime.Now;
                    subfunctionFeature.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(subfunctionFeature);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {subfunctionFeature.SubfunctionFeatureID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index), new { id = subfunctionFeature.SubfunctionFeatureID.ToString() });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(subfunctionFeature);
        }

        // GET: SubfunctionFeature/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subfunctionFeature = await _context.SubfunctionFeature.Include(subfunction => subfunction.Subfunction).FirstOrDefaultAsync(i => i.SubfunctionFeatureID == id);
            if (subfunctionFeature == null)
            {
                return NotFound();
            }
            return View(subfunctionFeature);
        }

        // POST: SubfunctionFeature/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubfunctionFeatureID,SubfunctionFeatureTitle,SubfunctionFeatureDescription,SubfunctionMeasurementUnit,SubfunctionID,UserID,CreationDate,UpdateDate,DeletionDate")] SubfunctionFeature subfunctionFeature)
        {
            if (id != subfunctionFeature.SubfunctionFeatureID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    subfunctionFeature.UpdateDate = CurrentDate;

                    _context.Update(subfunctionFeature);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{subfunctionFeature.SubfunctionFeatureID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubfunctionFeatureExists(subfunctionFeature.SubfunctionFeatureID))
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
            return View(subfunctionFeature);
        }

        // GET: SubfunctionFeature/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subfunctionFeature = await _context.SubfunctionFeature
                .Include(s => s.Subfunction)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.SubfunctionFeatureID == id);
            if (subfunctionFeature == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", subfunctionFeature);
        }

        // POST: SubfunctionFeature/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subfunctionFeature = await _context.SubfunctionFeature.FindAsync(id);
            
            try
            {
                _context.SubfunctionFeature.Remove(subfunctionFeature);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{subfunctionFeature.SubfunctionFeatureID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool SubfunctionFeatureExists(int id)
        {
            return _context.SubfunctionFeature.Any(e => e.SubfunctionFeatureID == id);
        }
    }
}
