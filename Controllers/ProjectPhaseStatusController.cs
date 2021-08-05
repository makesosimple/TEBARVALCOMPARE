﻿using System;
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
    public class ProjectPhaseStatusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectPhaseStatusController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ProjectPhaseStatus
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

                var data = _context.ProjectPhaseStatus.Select(c => new { c.ProjectPhaseStatusID, c.ProjectPhaseStatusTitle, UserName = c.User.UserName }).AsQueryable();

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

        // GET: ProjectPhaseStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhaseStatus = await _context.ProjectPhaseStatus
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPhaseStatusID == id);
            if (projectPhaseStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectPhaseStatus);
        }

        // GET: ProjectPhaseStatus/Create
        public IActionResult Create()
        {
            var culture = new CultureInfo("tr-TR");
            ViewBag.CurrentDate = DateTime.Now.ToString(culture);
            ViewBag.UserID = _userManager.GetUserId(HttpContext.User);
            return View();
        }

        // POST: ProjectPhaseStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectPhaseStatusID,ProjectPhaseStatusTitle,ProjectPhaseStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPhaseStatus projectPhaseStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectPhaseStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectPhaseStatus);
        }

        // GET: ProjectPhaseStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhaseStatus = await _context.ProjectPhaseStatus.FindAsync(id);
            if (projectPhaseStatus == null)
            {
                return NotFound();
            }
            return View(projectPhaseStatus);
        }

        // POST: ProjectPhaseStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectPhaseStatusID,ProjectPhaseStatusTitle,ProjectPhaseStatusDescription,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPhaseStatus projectPhaseStatus)
        {
            if (id != projectPhaseStatus.ProjectPhaseStatusID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    projectPhaseStatus.UpdateDate = CurrentDate;

                    _context.Update(projectPhaseStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectPhaseStatusExists(projectPhaseStatus.ProjectPhaseStatusID))
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
            return View(projectPhaseStatus);
        }

        // GET: ProjectPhaseStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPhaseStatus = await _context.ProjectPhaseStatus
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPhaseStatusID == id);
            if (projectPhaseStatus == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectPhaseStatus);
        }

        // POST: ProjectPhaseStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectPhaseStatus = await _context.ProjectPhaseStatus.FindAsync(id);
            _context.ProjectPhaseStatus.Remove(projectPhaseStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectPhaseStatusExists(int id)
        {
            return _context.ProjectPhaseStatus.Any(e => e.ProjectPhaseStatusID == id);
        }
    }
}
