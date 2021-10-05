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
using Microsoft.AspNetCore.Authorization;

namespace IBBPortal.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProjectTypeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProjectTypeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectType
        public async Task<IActionResult> Index()
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

                var data = _context.ProjectType.Select(c => new { 
                    c.Id, 
                    c.Title }).AsQueryable();

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

                var ProjectStatusData = _context.ProjectType
                                    .Select(x => new {
                                        id = x.Id.ToString(),
                                        text = x.Title
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    ProjectStatusData = ProjectStatusData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ProjectStatusData.Count();

                //Paging   
                var passData = ProjectStatusData.Take(10).ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: ProjectType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectType = await _context.ProjectType
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectType == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectType);
        }

        // GET: ProjectType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create()
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", projectType.UserID);
            return View(projectType);
        }

        // GET: ProjectType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectType = await _context.ProjectType.FindAsync(id);
            if (projectType == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", projectType.UserID);
            return View(projectType);
        }

        // POST: ProjectType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectTypeID,Title,Description,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectType projectType)
        {
            if (id != projectType.ProjectTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectTypeExists(projectType.ProjectTypeID))
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
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", projectType.UserID);
            return View(projectType);
        }

        // GET: ProjectType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectType = await _context.ProjectType
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectTypeID == id);
            if (projectType == null)
            {
                return NotFound();
            }

            return View(projectType);
        }

        // POST: ProjectType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectType = await _context.ProjectType.FindAsync(id);
            _context.ProjectType.Remove(projectType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectTypeExists(int id)
        {
            return _context.ProjectType.Any(e => e.ProjectTypeID == id);
        }
    }
}
