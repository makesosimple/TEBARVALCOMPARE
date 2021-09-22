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
using Microsoft.AspNetCore.Authorization;
using IBBPortal.Static;

namespace IBBPortal.Controllers
{
    public class FileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public FileController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

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

                var data = _context.File
                    .Select(c => new
                    {
                        c.FileID,
                        c.ProjectID,
                        c.FileCategoryID,
                        c.FileCategory.FileCategoryTitle,
                        FileName = c.FileName,
                        FileType = c.FileType != null ? c.FileType : "",
                        FilePath = c.FilePath != null ? c.FilePath : "",
                        FileURL = c.FileURL != null ? c.FileURL : "",
                        FileUploadType = c.FileUploadType
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

        // GET: File/Create/ProjectID
        public IActionResult Create(int id)
        {
            ViewBag.ProjectID = id;
            return PartialView("_CreateModal");
        }

        // POST: File/Create/ProjectID

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            projectPerson.CreationDate = DateTime.Now;
        //            projectPerson.UserID = _userManager.GetUserId(HttpContext.User);

        //            _context.Add(projectPerson);
        //            await _context.SaveChangesAsync();
        //            TransactionLogger.logTransaction(_context, (int)projectPerson.ProjectID, "project-person-added", _userManager.GetUserId(HttpContext.User));

        //            TempData["SuccessTitle"] = "BAŞARILI";
        //            TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
        //            return RedirectToAction(nameof(Index), new { id = projectPerson.ProjectID });
        //        }
        //        catch (Exception ex)
        //        {
        //            TempData["ErrorTitle"] = "HATA";
        //            TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
        //            return RedirectToAction(nameof(Index), new { id = projectPerson.ProjectID });
        //        }
        //    }
        //    return PartialView("_CreateModal");
        //}
    }
}
