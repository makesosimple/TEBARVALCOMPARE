using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Authorization;
using IBBPortal.Static;
using IBBPortal.Helpers;

namespace IBBPortal.Controllers
{
    [Authorize]
    public class ProjectSettingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectSettingsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectSettings/Index/5 -> 5 is the Project ID!!
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectSetting = await _context.ProjectSettings
                .FirstOrDefaultAsync(m => m.ProjectID == id);


            if (projectSetting == null)
            {
                ViewBag.ProjectID = id;
                projectSetting = new ProjectSettings();
            }

            ViewBag.ProjectTitle = _context.Project.Single(m => m.ProjectID == id).ProjectTitle;
            return View(projectSetting);

        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrUpdateSetting(int id, [Bind("ProjectSettingsID,ProjectID,Priority,HideOrShow," +
            "ProjectObjectID,ProjectUID,ProjectGlobalID,ProjectFileNumber,ProjectPackageNumber," +
            "UserID,CreationDate,UpdateDate,DeletionDate")] ProjectSettings projectSetting)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (!ProjectSettingExists(projectSetting.ProjectID))
                    {
                        projectSetting.ProjectID = id;
                        projectSetting.CreationDate = DateTime.Now;
                        projectSetting.UserID = _userManager.GetUserId(HttpContext.User);
                        _context.Add(projectSetting);
                        TransactionLogger.logTransaction(_context, (int)projectSetting.ProjectID, "project-setting-added", _userManager.GetUserId(HttpContext.User));
                        TempData["SuccessTitle"] = "BAŞARILI";
                        TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
                    }

                    else
                    {
                        projectSetting.UpdateDate = DateTime.Now;
                        _context.Update(projectSetting);
                        TempData["SuccessTitle"] = "BAŞARILI";
                        TempData["SuccessMessage"] = $"Kayıt başarıyla düzenlendi.";
                        TransactionLogger.logTransaction(_context, (int)projectSetting.ProjectID, "project-setting-updated", _userManager.GetUserId(HttpContext.User));

                    }

                    await _context.SaveChangesAsync();

                    ProjectHelper.UpdatedProject(projectSetting.ProjectID.Value, _context);

                    return RedirectToAction(nameof(Index), new { id = projectSetting.ProjectID });
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
            return View(projectSetting);
        }

        private bool ProjectSettingExists(int? id)
        {
            if (id == null) return false;

            return _context.ProjectSettings.Any(e => e.ProjectID == id);
        }
    }
}
