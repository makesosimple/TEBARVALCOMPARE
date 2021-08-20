using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq.Dynamic.Core;
using IBBPortal.Helpers;

namespace IBBPortal.Controllers
{
    public class ShortcutsController : Controller
    {


        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ShortcutsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ShortcutsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShortcutsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShortcutsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShortcutsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShortcutsController/Edit/5
        public ActionResult Edit(int id, Shortcuts shortcut)
        {
            
            return View();
        }

        // GET: ShortcutsController/Add/5
        public ActionResult Add(int id)
        {
            var userID = _userManager.GetUserId(HttpContext.User);
            var entity = _context.Shortcuts.FirstOrDefault(item => item.ShortcutsProjectID == id && item.UserID == userID);
            var retId = 0;

            // Validate entity is not null
            if (entity != null)
            {

                
                _context.Shortcuts.Remove(entity);

                // Save changes in database
                _context.SaveChanges();
                retId = 0;
            } else
            {
                var shortCut = new Shortcuts();
                shortCut.ShortcutsProjectID = id;
                shortCut.UserID = userID;
                shortCut.CreationDate = DateTime.Now;
                _context.Shortcuts.Add(shortCut);
                _context.SaveChanges();
                retId = shortCut.ShortcutsID;
            }

            return Json(new { ProjectID = id, ShortcutsID = retId });
        }

        // POST: ShortcutsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShortcutsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShortcutsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
