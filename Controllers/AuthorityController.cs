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
    public class AuthorityController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public AuthorityController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

                var data = _context.Authority.Select(c => new { c.AuthorityID, c.AuthorityTitle, UserName = c.User.UserName });

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

                var AuthorityData = _context.Authority
                                    .Select(x => new {
                                        id = x.AuthorityID.ToString(),
                                        text = x.AuthorityTitle
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    AuthorityData = AuthorityData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = AuthorityData.Count();

                //Paging   
                var passData = AuthorityData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: Management/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authority = await _context.Authority
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.AuthorityID == id);
            if (authority == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", authority);
        }

        // GET: Management/Create
        public IActionResult Create()
        {
            var culture = new CultureInfo("tr-TR");
            ViewBag.CurrentDate = DateTime.Now.ToString(culture);
            ViewBag.UserID = _userManager.GetUserId(HttpContext.User);
            return View();
        }

        // POST: Management/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuthorityID,AuthorityTitle,AuthorityDescription,UserID,CreationDate,UpdateDate,DeletionDate")] Authority authority)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authority);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(authority);
        }

        // GET: Management/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authority = await _context.Authority.FindAsync(id);
            if (authority == null)
            {
                return NotFound();
            }
            return View(authority);
        }

        // POST: Management/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuthorityID,AuthorityTitle,AuthorityDescription,UserID,CreationDate,UpdateDate,DeletionDate")] Authority authority)
        {
            if (id != authority.AuthorityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    var CurrentDate = DateTime.Now;
                    authority.UpdateDate = CurrentDate;

                    _context.Update(authority);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManagementExists(authority.AuthorityID))
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
            return View(authority);
        }

        // GET: Management/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authority = await _context.Authority
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.AuthorityID == id);
            if (authority == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", authority);
        }

        // POST: Management/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authority = await _context.Authority.FindAsync(id);
            _context.Authority.Remove(authority);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManagementExists(int id)
        {
            return _context.Authority.Any(e => e.AuthorityID == id);
        }
    }
}
