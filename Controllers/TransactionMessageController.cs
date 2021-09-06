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
    public class TransactionMessageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TransactionMessageController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: TransactionMessage
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

                var data = _context.TransactionMessages.Select(c => new { c.TransactionMessageID, c.TransactionMessageContent, c.TransactionMessageDescription, c.TransactionMessageSlug, TransactionTypeName = c.TransactionType.TransactionTypeName, UserName = c.User.UserName });

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
        public JsonResult JsonSelectData(string? term, int? transactionTypeID)
        {
            try
            {

                var TransactionMessageData = _context.TransactionMessages
                                    .Select(x => new {
                                        id = x.TransactionMessageID.ToString(),
                                        text = x.TransactionMessageContent,
                                        transactionType = x.TransactionTypeID
                                    }).Take(10);

                if (!String.IsNullOrEmpty(term))
                {
                    TransactionMessageData = TransactionMessageData.Where(m => m.text.Contains(term));
                }

                if (!String.IsNullOrEmpty(transactionTypeID.ToString()))
                {
                    TransactionMessageData = TransactionMessageData.Where(m => m.transactionType == transactionTypeID);
                }

                //Count 
                var totalCount = TransactionMessageData.Count();

                //Paging   
                var passData = TransactionMessageData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: TransactionMessage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionMessages = await _context.TransactionMessages
                .Include(t => t.User)
                .Where(m => m.TransactionMessageID == id).FirstOrDefaultAsync();
            if (transactionMessages == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", transactionMessages);
        }

        // GET: TransactionMessage/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TransactionMessage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionMessageID,TransactionTypeID,TransactionMessageContent,TransactionMessageDescription,UserID,TransactionMessageSlug,CreationDate,UpdateDate,DeletionDate")] TransactionMessages transactionMessages)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    transactionMessages.CreationDate = DateTime.Now;
                    transactionMessages.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(transactionMessages);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {transactionMessages.TransactionMessageID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(transactionMessages);
        }

        // GET: TransactionMessage/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionMessages = await _context.TransactionMessages.Include(transactionType => transactionType.TransactionType).FirstOrDefaultAsync(i => i.TransactionMessageID == id);
            if (transactionMessages == null)
            {
                return NotFound();
            }
            return View(transactionMessages);
        }

        // POST: TransactionMessage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionMessageID,TransactionTypeID,TransactionMessageContent,TransactionMessageDescription,UserID,TransactionMessageSlug,CreationDate,UpdateDate,DeletionDate")] TransactionMessages transactionMessages)
        {
            if (id != transactionMessages.TransactionMessageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    transactionMessages.UpdateDate = CurrentDate;

                    _context.Update(transactionMessages);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{transactionMessages.TransactionMessageID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionMessagesExists(transactionMessages.TransactionMessageID))
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
            return View(transactionMessages);
        }

        // GET: TransactionMessage/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionMessages = await _context.TransactionMessages
                .FirstOrDefaultAsync(m => m.TransactionMessageID == id);
            if (transactionMessages == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", transactionMessages);
        }

        // POST: TransactionMessage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionMessages = await _context.TransactionMessages.Include(transactionType => transactionType.TransactionType).FirstOrDefaultAsync(i => i.TransactionMessageID == id);
            try
            {
                _context.TransactionMessages.Remove(transactionMessages);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{transactionMessages.TransactionMessageID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool TransactionMessagesExists(int id)
        {
            return _context.TransactionMessages.Any(e => e.TransactionMessageID == id);
        }
    }
}
