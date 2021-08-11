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
    public class FileCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public FileCategoryController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

                var data = _context.FileCategory.Select(c => new { c.FileCategoryID, c.FileCategoryTitle, ParentFileCategoryTitle = c.ParentFileCategory.FileCategoryTitle, c.FileCategoryFolderName,  UserName = c.User.UserName });

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
        public JsonResult JsonSelectData(string term)
        {
            try
            {

                var FileCategoryData = _context.FileCategory
                                    .Select(x => new {
                                        id = x.FileCategoryID.ToString(),
                                        text = x.FileCategoryTitle
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    FileCategoryData = FileCategoryData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = FileCategoryData.Count();

                //Paging   
                var passData = FileCategoryData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: FileCategory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileCategory = await _context.FileCategory
                .Include(f => f.ParentFileCategory)
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.FileCategoryID == id);
            if (fileCategory == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", fileCategory);
        }

        // GET: FileCategory/Create
        public IActionResult Create()
        {
            var culture = new CultureInfo("tr-TR");
            ViewBag.CurrentDate = DateTime.Now.ToString(culture);
            ViewBag.UserID = _userManager.GetUserId(HttpContext.User);
            return View();
        }

        // POST: FileCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FileCategoryID,FileCategoryTitle,FileCategoryFolderName,FileCategoryDescription,ParentFileCategoryID,UserID,CreationDate,UpdateDate,DeletionDate")] FileCategory fileCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fileCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(fileCategory);
        }

        // GET: FileCategory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileCategory = await _context.FileCategory.FindAsync(id);
            if (fileCategory == null)
            {
                return NotFound();
            }

            return View(fileCategory);
        }

        // POST: FileCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FileCategoryID,FileCategoryTitle,FileCategoryFolderName,FileCategoryDescription,ParentFileCategoryID,UserID,CreationDate,UpdateDate,DeletionDate")] FileCategory fileCategory)
        {
            if (id != fileCategory.FileCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    fileCategory.UpdateDate = CurrentDate;

                    _context.Update(fileCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FileCategoryExists(fileCategory.FileCategoryID))
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

            return View(fileCategory);
        }

        // GET: FileCategory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileCategory = await _context.FileCategory
                .Include(f => f.ParentFileCategory)
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.FileCategoryID == id);
            if (fileCategory == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", fileCategory);
        }

        // POST: FileCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fileCategory = await _context.FileCategory
                .Include(f => f.ParentFileCategory)
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.FileCategoryID == id);

            try
            {
                _context.FileCategory.Remove(fileCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Silmeye çalıştığınız {fileCategory.FileCategoryID} kodlu {fileCategory.FileCategoryFolderName} kategorisi " +
                    $"başka Dosya Kategorileri tarafından kullanılmaktadır. Lütfen önce bağlı kayıtları siliniz!";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool FileCategoryExists(int id)
        {
            return _context.FileCategory.Any(e => e.FileCategoryID == id);
        }
    }
}
