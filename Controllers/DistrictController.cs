using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TEBARVALCOMPARE.Data;
using TEBARVALCOMPARE.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using TEBARVALCOMPARE.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace TEBARVALCOMPARE.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DistrictController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public DistrictController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: District
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

                var data = _context.District.Select(c => new { c.DistrictID, c.DistrictName, c.DistrictCode, CityName = c.City.CityName, UserName = c.User.UserName });

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

        [HttpGet]
        public JsonResult JsonSelectData(string? term, int? cityID, int? cityCode)
        {
            try
            {

                var DistrictData = _context.District
                                    .Select(x => new {
                                        id = x.DistrictID.ToString(),
                                        text = x.DistrictName,
                                        city = x.CityID,
                                        cityCode = x.City.CityCode
                                    });

                var check = "";
                if (!String.IsNullOrEmpty(term))
                {
                    DistrictData = DistrictData.Where(m => m.text.Contains(term));
                    check = "Term is included.";
                }

                if (!String.IsNullOrEmpty(cityID.ToString()))
                {
                    DistrictData = DistrictData.Where(m => m.city == cityID);
                    check += "CityID is included";
                }

                if (!String.IsNullOrEmpty(cityCode.ToString()))
                {
                    DistrictData = DistrictData.Where(m => m.cityCode == cityCode);
                    check += "cityCode is included";
                }

                //Count 
                var totalCount = DistrictData.Count();

                //Paging   
                var passData = DistrictData.Take(10).ToList();


                //Returning Json Data  
                return Json(new { check = check, results = passData, term = term, cityID = cityID, cityCode = cityCode, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: District/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractor = _context.District
                .Include(d => d.User)
                .Where(m => m.DistrictID == id).FirstOrDefault();
            if (contractor == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", contractor);
        }

        // GET: District/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: District/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DistrictID,DistrictCode,DistrictName,CityID,UserID,CreationDate,UpdateDate,DeletionDate")] District district)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    district.CreationDate = DateTime.Now;
                    district.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(district);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {district.DistrictID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(district);
        }

        // GET: District/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var district = await _context.District.Include(city => city.City).FirstOrDefaultAsync(i => i.DistrictID == id);
            if (district == null)
            {
                return NotFound();
            }
            return View(district);
        }

        // POST: District/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DistrictID,DistrictCode,DistrictName,CityID,UserID,CreationDate,UpdateDate,DeletionDate")] District district)
        {
            if (id != district.DistrictID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    district.UpdateDate = CurrentDate;

                    _context.Update(district);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{district.DistrictID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistrictExists(district.DistrictID))
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
            return View(district);
        }

        // GET: District/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var district = await _context.District
                .FirstOrDefaultAsync(m => m.DistrictID == id);
            if (district == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", district);
        }

        // POST: District/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var district = await _context.District.Include(city => city.City).FirstOrDefaultAsync(i => i.DistrictID == id);
            
            try
            {
                _context.District.Remove(district);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{district.DistrictID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool DistrictExists(int id)
        {
            return _context.District.Any(e => e.DistrictID == id);
        }
    }
}
