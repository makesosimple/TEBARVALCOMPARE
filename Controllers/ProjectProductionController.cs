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
using System.Globalization;

namespace IBBPortal.Controllers
{
    [Authorize]
    public class ProjectProductionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectProductionController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectProduction/Index/5 -> 5 is the Project ID!!
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectProduction = await _context.ProjectProduction
                .FirstOrDefaultAsync(m => m.ProjectID == id);


            if (projectProduction == null)
            {
                ViewBag.ProjectID = id;
                projectProduction = new ProjectProduction();
            }

            ViewBag.ProjectTitle = _context.Project.Single(m => m.ProjectID == id).ProjectTitle;
            return View(projectProduction);

        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrUpdateProduction(int id, [Bind("ProjectProductionID,ProjectID,FoundationDate,OpeningDate,Cost," +
            "EstimatedCost,ApproximateCost,ContractCost,ContractIncrementCost," +
            "ApproximateCostDate,ContractStartingDate,StartingDate," +
            "ContractEndingDate,EndingDate,PhysicalCompletionRatio,TotalProgressPaymentCost,MonetaryCompletionRatio," +
            "UserID,CreationDate,UpdateDate,DeletionDate")] ProjectProduction projectProduction)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (!ProjectProductionExists(projectProduction.ProjectID))
                    {
                        projectProduction.ProjectID = id;
                        projectProduction.CreationDate = DateTime.Now;
                        projectProduction.UserID = _userManager.GetUserId(HttpContext.User);
                        _context.Add(projectProduction);
                        TransactionLogger.logTransaction(_context, (int)projectProduction.ProjectID, "project-production-added", _userManager.GetUserId(HttpContext.User));
                        TempData["SuccessTitle"] = "BAŞARILI";
                        TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
                    }

                    else
                    {
                        projectProduction.UpdateDate = DateTime.Now;
                        _context.Update(projectProduction);
                        TempData["SuccessTitle"] = "BAŞARILI";
                        TempData["SuccessMessage"] = $"Kayıt başarıyla düzenlendi.";
                        TransactionLogger.logTransaction(_context, (int)projectProduction.ProjectID, "project-prodution-updated", _userManager.GetUserId(HttpContext.User));

                    }

                    ProjectHelper.UpdatedProject(projectProduction.ProjectID.Value, _context);

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index), new { id = projectProduction.ProjectID });
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
            return View(projectProduction);
        }

        private bool ProjectProductionExists(int? id)
        {
            if (id == null) return false;

            return _context.ProjectProduction.Any(e => e.ProjectID == id);
        }
    }
}
