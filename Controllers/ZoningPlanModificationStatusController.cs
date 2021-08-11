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
    public class ZoningPlanModificationStatusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ZoningPlanModificationStatusController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

                var data = _context.ZoningPlanModificationStatus.Select(c => new { c.ZoningPlanModificationStatusID, c.ZoningPlanModificationStatusTitle, UserName = c.User.UserName });

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

        // GET: ZoningPlanModificationStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zoningPlanModificationStatus = await _context.ZoningPlanModificationStatus
                .Include(z => z.User)
                .FirstOrDefaultAsync(m => m.ZoningPlanModificationStatusID == id);
            if (zoningPlanModificationStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", zoningPlanModificationStatus);
        }

        // GET: ZoningPlanModificationStatus/Create
        public IActionResult Create()
        {
            var culture = new CultureInfo("tr-TR");
            ViewBag.CurrentDate = DateTime.Now.ToString(culture);
            ViewBag.UserID = _userManager.GetUserId(HttpContext.User);
            return View();
        }

        // POST: ZoningPlanModificationStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZoningPlanModificationStatusID,ZoningPlanModificationStatusTitle,ZoningPlanModificationStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ZoningPlanModificationStatus zoningPlanModificationStatus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(zoningPlanModificationStatus);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {zoningPlanModificationStatus.ZoningPlanModificationStatusID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Edit), new { id = zoningPlanModificationStatus.ZoningPlanModificationStatusID.ToString() });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Edit), new { id = zoningPlanModificationStatus.ZoningPlanModificationStatusID.ToString() });
                }

                //return RedirectToAction(nameof(Index));
            }
            return View(zoningPlanModificationStatus);
        }

        // GET: ZoningPlanModificationStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zoningPlanModificationStatus = await _context.ZoningPlanModificationStatus.FindAsync(id);
            if (zoningPlanModificationStatus == null)
            {
                return NotFound();
            }
            return View(zoningPlanModificationStatus);
        }

        // POST: ZoningPlanModificationStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZoningPlanModificationStatusID,ZoningPlanModificationStatusTitle,ZoningPlanModificationStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ZoningPlanModificationStatus zoningPlanModificationStatus)
        {
            if (id != zoningPlanModificationStatus.ZoningPlanModificationStatusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    zoningPlanModificationStatus.UpdateDate = CurrentDate;

                    _context.Update(zoningPlanModificationStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZoningPlanModificationStatusExists(zoningPlanModificationStatus.ZoningPlanModificationStatusID))
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
            return View(zoningPlanModificationStatus);
        }

        // GET: ZoningPlanModificationStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zoningPlanModificationStatus = await _context.ZoningPlanModificationStatus
                .Include(z => z.User)
                .FirstOrDefaultAsync(m => m.ZoningPlanModificationStatusID == id);
            if (zoningPlanModificationStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", zoningPlanModificationStatus);
        }

        // POST: ZoningPlanModificationStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zoningPlanModificationStatus = await _context.ZoningPlanModificationStatus.FindAsync(id);
            _context.ZoningPlanModificationStatus.Remove(zoningPlanModificationStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZoningPlanModificationStatusExists(int id)
        {
            return _context.ZoningPlanModificationStatus.Any(e => e.ZoningPlanModificationStatusID == id);
        }
    }
}
