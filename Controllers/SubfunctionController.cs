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
    public class SubfunctionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public SubfunctionController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

                var data = _context.Subfunction.Select(c => new { c.SubfunctionID, c.SubfunctionTitle, UserName = c.User.UserName });

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

                var SubfunctionData = _context.Subfunction
                                    .Select(x => new {
                                        id = x.SubfunctionID.ToString(),
                                        text = x.SubfunctionTitle
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    SubfunctionData = SubfunctionData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = SubfunctionData.Count();

                //Paging   
                var passData = SubfunctionData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: Subfunction/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subfunction = await _context.Subfunction
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.SubfunctionID == id);
            if (subfunction == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", subfunction);
        }

        // GET: Subfunction/Create
        public IActionResult Create()
        {
            var culture = new CultureInfo("tr-TR");
            ViewBag.CurrentDate = DateTime.Now.ToString(culture);
            ViewBag.UserID = _userManager.GetUserId(HttpContext.User);
            return View();
        }

        // POST: Subfunction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubfunctionID,SubfunctionTitle,SubfunctionDescription,UserID,CreationDate,UpdateDate,DeletionDate")] Subfunction subfunction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subfunction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subfunction);
        }

        // GET: Subfunction/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subfunction = await _context.Subfunction.FindAsync(id);
            if (subfunction == null)
            {
                return NotFound();
            }
            return View(subfunction);
        }

        // POST: Subfunction/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubfunctionID,SubfunctionTitle,SubfunctionDescription,UserID,CreationDate,UpdateDate,DeletionDate")] Subfunction subfunction)
        {
            if (id != subfunction.SubfunctionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    subfunction.UpdateDate = CurrentDate;

                    _context.Update(subfunction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubfunctionExists(subfunction.SubfunctionID))
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
            return View(subfunction);
        }

        // GET: Subfunction/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subfunction = await _context.Subfunction
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.SubfunctionID == id);
            if (subfunction == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", subfunction);
        }

        // POST: Subfunction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subfunction = await _context.Subfunction.FindAsync(id);
            _context.Subfunction.Remove(subfunction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubfunctionExists(int id)
        {
            return _context.Subfunction.Any(e => e.SubfunctionID == id);
        }
    }
}