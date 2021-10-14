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
using IBBPortal.Static;

namespace IBBPortal.Controllers
{
    [Authorize]
    public class ProjectFeasibilityController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectFeasibilityController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectPerson/FeasibilityManagement/5 -> 5 is the Project ID!!
        public async Task<IActionResult> Form(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectFeasibility = await _context.ProjectFeasibility
                .Include(p => p.Contractor)
                .Include(p => p.Person)
                .Include(p => p.Project)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectID == id);

            if (projectFeasibility == null)
            {
                ViewBag.ProjectID = id;
                projectFeasibility = new ProjectFeasibility();
            }

            ViewBag.ProjectTitle = _context.Project.Single(m => m.ProjectID == id).ProjectTitle;
            return View(projectFeasibility);

        }

        // POST: ProjectFeasibility/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Form")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrUpdateFeasibility(int id, [Bind("ProjectFeasibilityID,IsFeasibilityNeeded,ProjectID,ContractorID,PersonID,ProjectFeasibilityOutsource,ProjectFeasibilityDate,ProjectFeasibilityCost,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectFeasibility projectFeasibility)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (!ProjectFeasibilityExists(projectFeasibility.ProjectID))
                    {
                        projectFeasibility.ProjectID = id;
                        projectFeasibility.CreationDate = DateTime.Now;
                        projectFeasibility.UserID = _userManager.GetUserId(HttpContext.User);
                        _context.Add(projectFeasibility);
                        TransactionLogger.logTransaction(_context, (int)projectFeasibility.ProjectID, "project-feasiblity-added", _userManager.GetUserId(HttpContext.User));
                        TempData["SuccessTitle"] = "BAŞARILI";
                        TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
                    }

                    else
                    {
                        projectFeasibility.UpdateDate = DateTime.Now;
                        _context.Update(projectFeasibility);
                        TempData["SuccessTitle"] = "BAŞARILI";
                        TempData["SuccessMessage"] = $"Kayıt başarıyla düzenlendi.";
                        TransactionLogger.logTransaction(_context, (int)projectFeasibility.ProjectID, "project-feasiblity-updated", _userManager.GetUserId(HttpContext.User));

                    }

                    await _context.SaveChangesAsync();

                    ProjectHelper.UpdatedProject(projectFeasibility.ProjectID.Value, _context);
                    return RedirectToAction(nameof(Form), new { id = projectFeasibility.ProjectID });
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
            return View(projectFeasibility);
        }


        // POST: ProjectFeasibility/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectFeasibilityID,IsFeasibilityNeeded,ProjectID,ContractorID,PersonID,ProjectFeasibilityOutsource,ProjectFeasibilityDate,ProjectFeasibilityCost,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectFeasibility projectFeasibility)
        {
            if (id != projectFeasibility.ProjectFeasibilityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectFeasibility);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectFeasibilityExists(projectFeasibility.ProjectFeasibilityID))
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
            return View(projectFeasibility);
        }

        private bool ProjectFeasibilityExists(int? id)
        {
            if (id == null) return false;

            return _context.ProjectFeasibility.Any(e => e.ProjectID == id);
        }
    }
}
