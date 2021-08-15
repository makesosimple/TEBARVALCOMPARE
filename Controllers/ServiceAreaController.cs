using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using IBBPortal.Helpers;
using System.Globalization;

namespace IBBPortal.Controllers
{
    public class ServiceAreaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ServiceAreaController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

                var data = _context.ServiceArea.Select(c => new { c.ServiceAreaID, c.ServiceAreaTitle, ParentServiceAreaTitle = c.ParentServiceArea.ServiceAreaTitle, UserName = c.User.UserName });

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

                var ServiceAreaData = _context.ServiceArea
                                    .Select(x => new {
                                        id = x.ServiceAreaID.ToString(),
                                        text = x.ServiceAreaTitle
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    ServiceAreaData = ServiceAreaData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ServiceAreaData.Count();

                //Paging   
                var passData = ServiceAreaData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: ServiceArea/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceArea = await _context.ServiceArea
                .Include(s => s.ParentServiceArea)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.ServiceAreaID == id);
            if (serviceArea == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", serviceArea);
        }

        // GET: ServiceArea/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceArea/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceAreaID,ServiceAreaTitle,ServiceAreaDescription,ParentServiceAreaID,UserID,CreationDate,UpdateDate,DeletionDate")] ServiceArea serviceArea)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    serviceArea.CreationDate = DateTime.Now;
                    serviceArea.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(serviceArea);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {serviceArea.ServiceAreaID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Edit), new { id = serviceArea.ServiceAreaID.ToString() });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(serviceArea);
        }

        // GET: ServiceArea/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceArea = await _context.ServiceArea.FindAsync(id);
            if (serviceArea == null)
            {
                return NotFound();
            }
            return View(serviceArea);
        }

        // POST: ServiceArea/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ServiceAreaID,ServiceAreaTitle,ServiceAreaDescription,ParentServiceAreaID,UserID,CreationDate,UpdateDate,DeletionDate")] ServiceArea serviceArea)
        {
            if (id != serviceArea.ServiceAreaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    serviceArea.UpdateDate = CurrentDate;

                    _context.Update(serviceArea);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{serviceArea.ServiceAreaID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceAreaExists(serviceArea.ServiceAreaID))
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
            return View(serviceArea);
        }

        // GET: ServiceArea/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceArea = await _context.ServiceArea
                .Include(s => s.ParentServiceArea)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.ServiceAreaID == id);
            if (serviceArea == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", serviceArea);
        }

        // POST: ServiceArea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceArea = await _context.ServiceArea.FindAsync(id);

            try
            {
                _context.ServiceArea.Remove(serviceArea);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{serviceArea.ServiceAreaID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ServiceAreaExists(int id)
        {
            return _context.ServiceArea.Any(e => e.ServiceAreaID == id);
        }
    }
}
