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

namespace IBBPortal.Controllers
{
    public class JobTitleController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public JobTitleController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: JobTitle
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

                var data = _context.JobTitle.Select(c => new { c.JobTitleID, c.Title, UserName = c.User.UserName });

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

                    if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchValue))
                    {
                        data = data.Where($"{columnName}.Contains(@0)", searchValue);
                    }
                }

                //total number of rows count   
                recordsTotal = data.Count();
                //Paging   
                var passData = data.ToList();

                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = passData });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: JobTitle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitle
                .Include(j => j.User)
                .FirstOrDefaultAsync(m => m.JobTitleID == id);
            if (jobTitle == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", jobTitle);
        }

        // GET: JobTitle/Create
        public IActionResult Create()
        {
            var culture = new CultureInfo("tr-TR");
            ViewBag.CurrentDate = DateTime.Now.ToString(culture);
            ViewBag.UserID = _userManager.GetUserId(HttpContext.User);
            return View();
        }

        // POST: JobTitle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobTitleID,Title,JobDescription,UserID,CreationDate,UpdateDate,DeletionDate")] JobTitle jobTitle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobTitle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobTitle);
        }

        // GET: JobTitle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitle.FindAsync(id);
            if (jobTitle == null)
            {
                return NotFound();
            }
            return View(jobTitle);
        }

        // POST: JobTitle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobTitleID,Title,JobDescription,UserID,CreationDate,UpdateDate,DeletionDate")] JobTitle jobTitle)
        {
            if (id != jobTitle.JobTitleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    jobTitle.UpdateDate = CurrentDate;

                    _context.Update(jobTitle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobTitleExists(jobTitle.JobTitleID))
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
            return View(jobTitle);
        }

        // GET: JobTitle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobTitle = await _context.JobTitle
                .Include(j => j.User)
                .FirstOrDefaultAsync(m => m.JobTitleID == id);
            if (jobTitle == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", jobTitle);
        }

        // POST: JobTitle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobTitle = await _context.JobTitle.FindAsync(id);
            _context.JobTitle.Remove(jobTitle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobTitleExists(int id)
        {
            return _context.JobTitle.Any(e => e.JobTitleID == id);
        }
    }
}
