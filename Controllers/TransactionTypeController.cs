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
    public class TransactionTypeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TransactionTypeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: TransactionType
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

                var data = _context.TransactionTypes.Select(c => new { c.TransactionTypeID, c.TransactionTypeName, UserName = c.User.UserName }).AsQueryable();

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

                for (int i = 0; i < 5; i++)
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

                var TransactionTypeData = _context.TransactionTypes
                                    .Select(x => new {
                                        id = x.TransactionTypeID.ToString(),
                                        text = x.TransactionTypeName
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    TransactionTypeData = TransactionTypeData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = TransactionTypeData.Count();

                //Paging   
                var passData = TransactionTypeData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: TransactionType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionTypes = _context.TransactionTypes
                .Include(t => t.User)
                .Where(m => m.TransactionTypeID == id).FirstOrDefault();
            if (transactionTypes == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", transactionTypes);
        }

        // GET: TransactionType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TransactionType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionTypeID,TransactionTypeName,TransactionTypeDescription,UserID,CreationDate,UpdateDate,DeletionDate")] TransactionTypes transactionTypes)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    transactionTypes.CreationDate = DateTime.Now;
                    transactionTypes.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(transactionTypes);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {transactionTypes.TransactionTypeID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(transactionTypes);
        }

        // GET: TransactionType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionTypes = await _context.TransactionTypes.FindAsync(id);
            if (transactionTypes == null)
            {
                return NotFound();
            }
            return View(transactionTypes);
        }

        // POST: TransactionType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionTypeID,TransactionTypeName,TransactionTypeDescription,UserID,CreationDate,UpdateDate,DeletionDate")] TransactionTypes transactionTypes)
        {
            if (id != transactionTypes.TransactionTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    transactionTypes.UpdateDate = CurrentDate;

                    _context.Update(transactionTypes);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{transactionTypes.TransactionTypeID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionTypesExists(transactionTypes.TransactionTypeID))
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
            return View(transactionTypes);
        }

        // GET: TransactionType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionTypes = await _context.TransactionTypes
                .FirstOrDefaultAsync(m => m.TransactionTypeID == id);
            if (transactionTypes == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", transactionTypes);
        }

        // POST: TransactionType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionTypes = await _context.TransactionTypes.FindAsync(id);
            try
            {
                _context.TransactionTypes.Remove(transactionTypes);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{transactionTypes.TransactionTypeID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool TransactionTypesExists(int id)
        {
            return _context.TransactionTypes.Any(e => e.TransactionTypeID == id);
        }
    }
}