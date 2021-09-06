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
    public class PropertyStatusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PropertyStatusController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Organization
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

                var data = _context.PropertyStatus.Select(c => new { c.PropertyStatusID, c.PropertyStatusTitle, UserName = c.User.UserName }).AsQueryable();

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

                var PropertyStatusData = _context.PropertyStatus
                                    .Select(x => new {
                                        id = x.PropertyStatusID.ToString(),
                                        text = x.PropertyStatusTitle
                                    }).Take(10);

                if (!String.IsNullOrEmpty(term))
                {
                    PropertyStatusData = PropertyStatusData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = PropertyStatusData.Count();

                //Paging   
                var passData = PropertyStatusData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: PropertyStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyStatus = await _context.PropertyStatus
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PropertyStatusID == id);
            if (propertyStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", propertyStatus);
        }

        // GET: PropertyStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PropertyStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyStatusID,PropertyStatusTitle,PropertyStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] PropertyStatus propertyStatus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    propertyStatus.CreationDate = DateTime.Now;
                    propertyStatus.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(propertyStatus);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {propertyStatus.PropertyStatusID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(propertyStatus);
        }

        // GET: PropertyStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyStatus = await _context.PropertyStatus.FindAsync(id);
            if (propertyStatus == null)
            {
                return NotFound();
            }
            return View(propertyStatus);
        }

        // POST: PropertyStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyStatusID,PropertyStatusTitle,PropertyStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] PropertyStatus propertyStatus)
        {
            if (id != propertyStatus.PropertyStatusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    propertyStatus.UpdateDate = CurrentDate;

                    _context.Update(propertyStatus);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{propertyStatus.PropertyStatusID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyStatusExists(propertyStatus.PropertyStatusID))
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
            return View(propertyStatus);
        }

        // GET: PropertyStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyStatus = await _context.PropertyStatus
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PropertyStatusID == id);
            if (propertyStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", propertyStatus);
        }

        // POST: PropertyStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propertyStatus = await _context.PropertyStatus.FindAsync(id);
            try
            {
                _context.PropertyStatus.Remove(propertyStatus);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{propertyStatus.PropertyStatusID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool PropertyStatusExists(int id)
        {
            return _context.PropertyStatus.Any(e => e.PropertyStatusID == id);
        }
    }
}
