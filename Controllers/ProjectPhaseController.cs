﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using IBBPortal.Helpers;
using System.Globalization;

namespace IBBPortal.Controllers
{
    public class ProjectPhaseController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectPhaseController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectPerson
        public IActionResult Index(int id)
        {
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

                var cultureInfo = CultureInfo.CreateSpecificCulture("tr-TR");

                var data = _context.ProjectPhase
                    .Select(c => new
                    {
                        c.ProjectPhaseID,
                        c.ProjectID,
                        PhaseTitle = c.Phase.PhaseTitle,
                        PhaseStatusTitle = c.ProjectPhaseStatus.ProjectPhaseStatusTitle,
                        ProjectPhaseStartDate = c.ProjectPhaseStart.HasValue ? c.ProjectPhaseStart.Value.ToString("d MMMMM yyyy", cultureInfo) : "",
                        ProjectPhaseFinishDate = c.ProjectPhaseFinish.HasValue ? c.ProjectPhaseFinish.Value.ToString("d MMMMM yyyy", cultureInfo) : "",
                        ProjectPhaseRecordedStartDate = c.ProjectPhaseRecordedStart.HasValue ? c.ProjectPhaseRecordedStart.Value.ToString("d MMMMM yyyy", cultureInfo) : "",
                        ProjectPhaseRecordedFinishDate = c.ProjectPhaseRecordedFinish.HasValue ? c.ProjectPhaseRecordedFinish.Value.ToString("d MMMMM yyyy", cultureInfo) : "",
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

                for (int i = 0; i < 6; i++)
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

        [HttpGet]
        public JsonResult JsonSelectData(string term)
        {
            try
            {

                var ProjectPhaseData = _context.ProjectPhase
                                    .Select(x => new {
                                        id = x.ProjectPhaseID.ToString(),
                                        text = x.Phase.PhaseOrder + ". " + x.Phase.PhaseTitle,
                                    }).Take(10);

                if (!String.IsNullOrEmpty(term))
                {
                    ProjectPhaseData = ProjectPhaseData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = ProjectPhaseData.Count();

                //Paging   
                var passData = ProjectPhaseData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }
        public JsonResult JsonDataForGantt(int? id)
        {
            if (id == null)
            {
                return Json(new { error = "No ID was sent!", errorCode = "404 Bad Request"});
            }

            var data = _context.ProjectPhase.Select(x => new
            {
                x.ProjectID,
                id = x.ProjectPhaseID.ToString(),
                name = x.Phase.PhaseOrder + ". " + x.Phase.PhaseTitle,
                start = x.ProjectPhaseStart.Value.ToString("yyyy-MM-dd"),
                end = x.ProjectPhaseFinish.Value.ToString("yyyy-MM-dd"),
                progress = 100
            })
                .ToList()
                .Where(x => x.ProjectID == id)
                .OrderBy(x => x.start);

            return Json(new { tasks = data });
        }
        // GET: ProjectPhase/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhase = await _context.ProjectPhase
                .Include(p => p.Phase)
                .Include(p => p.Project)
                .Include(p => p.ProjectPhaseStatus)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPhaseID == id);
            if (projectPhase == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectPhase);
        }

        // GET: ProjectPhase/Create
        public IActionResult Create(int id)
        {
            ViewBag.ProjectID = id;
            return PartialView("_CreateModal");
        }

        // POST: ProjectPhase/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectPhaseID,ProjectID,PhaseID,ProjectPhaseStatusID,ProjectPhaseStatusDescription,ProjectPhaseStart,ProjectPhaseFinish,ProjectPhaseRecordedStart,ProjectPhaseRecordedFinish,ProjectPhaseTimeExtension,ProjectPhaseTimeExtentedFinish,ProjectPhaseExtensionReason,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPhase projectPhase)
        {
            if (!ProjectPhaseChecker(projectPhase))
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Sunum tipi olmayan fazlar sadece bir kere eklenebilir.";
                return RedirectToAction(nameof(Index), new { id = projectPhase.ProjectID });
            }

            if (ModelState.IsValid)
            {
                try
                {
                    projectPhase.CreationDate = DateTime.Now;
                    projectPhase.UserID = _userManager.GetUserId(HttpContext.User);

                    //Manage Extended Dates
                    if (!String.IsNullOrEmpty(projectPhase.ProjectPhaseTimeExtension.ToString()))
                    {
                        projectPhase.ProjectPhaseTimeExtentedFinish = projectPhase.ProjectPhaseFinish.HasValue ? projectPhase.ProjectPhaseFinish.Value.AddDays((double)projectPhase.ProjectPhaseTimeExtension) : null;
                    }

                    _context.Add(projectPhase);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index), new { id = projectPhase.ProjectID });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index), new { id = projectPhase.ProjectID });
                }
            }
            return View(projectPhase);
        }

        // GET: ProjectPhase/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhase = await _context.ProjectPhase
                .Include(p => p.Phase)
                .Include(p => p.Project)
                .Include(p => p.ProjectPhaseStatus)
                .FirstOrDefaultAsync(m => m.ProjectPhaseID == id);

            if (projectPhase == null)
            {
                return NotFound();
            }
            return PartialView("_EditModal", projectPhase);
        }

        // POST: ProjectPhase/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProjectPhase(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhaseToUpdate = _context.ProjectPhase.Find(id);

            projectPhaseToUpdate.UpdateDate = DateTime.Now;

            //Manage Extended Dates
            if (!String.IsNullOrEmpty(projectPhaseToUpdate.ProjectPhaseTimeExtension.ToString()))
            {
                projectPhaseToUpdate.ProjectPhaseTimeExtentedFinish = projectPhaseToUpdate.ProjectPhaseFinish.HasValue ? projectPhaseToUpdate.ProjectPhaseFinish.Value.AddDays((double)projectPhaseToUpdate.ProjectPhaseTimeExtension) : null;
            }

            if (await TryUpdateModelAsync<ProjectPhase>(projectPhaseToUpdate, "",
                x => x.PhaseID, x => x.ProjectPhaseStatusID, x => x.ProjectPhaseStatusDescription, x => x.ProjectPhaseStart, x => x.ProjectPhaseFinish, 
                x => x.ProjectPhaseRecordedStart, x => x.ProjectPhaseRecordedFinish, x => x.ProjectPhaseTimeExtension, 
                x => x.ProjectPhaseTimeExtentedFinish, x => x.ProjectPhaseExtensionReason, x => x.UpdateDate))
            {
                try
                {
                    bool IsProjectPhaseModified = _context.Entry(projectPhaseToUpdate).Property(e => e.PhaseID).IsModified;

                    if (IsProjectPhaseModified)
                    {
                        TempData["ErrorTitle"] = "HATA";
                        TempData["ErrorMessage"] = $"Sunum tipi olmayan fazlar sadece bir kere eklenebilir.";
                        return RedirectToAction(nameof(Index), new { id = projectPhaseToUpdate.ProjectID });
                    }

                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectPhaseExists(projectPhaseToUpdate.ProjectPhaseID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = projectPhaseToUpdate.ProjectID });
            }
            return View(projectPhaseToUpdate);
        }

        // GET: ProjectPhase/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhase = await _context.ProjectPhase
                .Include(p => p.Phase)
                .Include(p => p.Project)
                .Include(p => p.ProjectPhaseStatus)
                .FirstOrDefaultAsync(m => m.ProjectPhaseID == id);
            if (projectPhase == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectPhase);
        }

        // POST: ProjectPhase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectPhase = await _context.ProjectPhase.FindAsync(id);

            try
            {
                _context.ProjectPhase.Remove(projectPhase);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectPhase.ProjectPhaseID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index), new { id = projectPhase.ProjectID });
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index), new { id = projectPhase.ProjectID });
            }
        }

        private bool ProjectPhaseExists(int id)
        {
            return _context.ProjectPhase.Any(e => e.ProjectPhaseID == id);
        }

        //Use this function to check wheter user is entering the main phases twice. If it is a Presentation then no problem!
        private bool ProjectPhaseChecker(ProjectPhase projectPhase)
        {
            var ProjectPhaseResults = _context.ProjectPhase
                .Include(c => c.Phase)
                .Where(c => c.ProjectID == projectPhase.ProjectID)
                .ToList();

            var PhaseResults = _context.Phase.FirstOrDefault(c => c.PhaseID == projectPhase.PhaseID);

            //If there are no phases in the project then there is nothing to check.
            if (ProjectPhaseResults == null) return true;

            //If Phase that is being created is a Presentation, there is nothing to check.
            else if (PhaseResults.isPresentation) return true;

            //This is for edit function. Check if user is changing the Phase ID. If not, then edit should not be stuck to false.

            else
            {
                //Check if the user had created the main Phase before. If true then don't allow user to enter a main Phase twice!
                bool DoesPhaseExistInCurrentContext = ProjectPhaseResults.Exists(x => x.PhaseID == projectPhase.PhaseID);

                if (DoesPhaseExistInCurrentContext) return false;
                return true;
            }



        }
    }
}