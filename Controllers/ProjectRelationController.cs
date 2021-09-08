using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using System.Globalization;
using IBBPortal.Helpers;

namespace IBBPortal.Controllers
{
    public class ProjectRelationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectRelationController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectRelation
        public IActionResult Index(int id)
        {
            ViewBag.ProjectTitle = _context.Project.Single(m => m.ProjectID == id).ProjectTitle;
            ViewBag.ProjectID = id;
            return View();
        }

        [HttpPost]
        public JsonResult JSONData(int projectID)
        {
            try
            {

                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][data]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault().ToUpper();

                //Paging Size (10, 20, 50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var data = _context.ProjectRelation
                    .Select(c => new
                    {
                        c.ProjectRelationID,
                        c.ProjectID,
                        RelatedProjectTitle = c.RelatedProject.ProjectTitle,
                        RelatedProjectIBBCode = c.RelatedProject.ProjectIBBCode,
                        RelationType = c.RelationType.RelationTypeTitle
                    })
                    .Where(c => c.ProjectID == projectID);

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
                    columnName = Request.Form[$"columns[{i}][data]"].FirstOrDefault();
                    searchValue = Request.Form[$"columns[{i}][search][value]"].FirstOrDefault();

                    if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchValue))
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

        // GET: ProjectRelation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRelation = await _context.ProjectRelation
                .Include(p => p.Project)
                .Include(p => p.RelatedProject)
                .Include(p => p.RelationType)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectRelationID == id);
            if (projectRelation == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectRelation);
        }

        // GET: ProjectRelation/Create
        public IActionResult Create(int id)
        {
            ViewBag.ProjectID = id;
            return PartialView("_CreateModal");
        }

        // POST: ProjectRelation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectRelationID,ProjectID,RelatedProjectID,RelationTypeID,ProjectRelationDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectRelation projectRelation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    projectRelation.CreationDate = DateTime.Now;
                    projectRelation.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(projectRelation);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index), new { id = projectRelation.ProjectID });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index), new { id = projectRelation.ProjectID });
                }
            }
            return PartialView("_CreateModal");
        }

        // GET: ProjectRelation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRelation = await _context.ProjectRelation
                .Include(p => p.Project)
                .Include(p => p.RelatedProject)
                .Include(p => p.RelationType)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectRelationID == id);
            if (projectRelation == null)
            {
                return NotFound();
            }
            return PartialView("_EditModal", projectRelation);
        }

        // POST: ProjectRelation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectRelationID,ProjectID,RelatedProjectID,RelationTypeID,ProjectRelationDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectRelation projectRelation)
        {
            if (id != projectRelation.ProjectRelationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    projectRelation.UpdateDate = CurrentDate;

                    _context.Update(projectRelation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectRelationExists(projectRelation.ProjectRelationID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = projectRelation.ProjectID });
            }
            return PartialView("_EditModal", projectRelation);
        }

        // GET: ProjectRelation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectRelation = await _context.ProjectRelation
                .Include(p => p.Project)
                .Include(p => p.RelatedProject)
                .Include(p => p.RelationType)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectRelationID == id);
            if (projectRelation == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectRelation);
        }

        // POST: ProjectRelation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectRelation = await _context.ProjectRelation.FindAsync(id);
            
            try
            {
                _context.ProjectRelation.Remove(projectRelation);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectRelation.ProjectRelationID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index), new { id = projectRelation.ProjectID });
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index), new { id = projectRelation.ProjectID });
            }
        }

        private bool ProjectRelationExists(int id)
        {
            return _context.ProjectRelation.Any(e => e.ProjectRelationID == id);
        }
    }
}
