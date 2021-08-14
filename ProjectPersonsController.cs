using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;

namespace IBBPortal
{
    public class ProjectPersonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectPersonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectPersons
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProjectPerson.Include(p => p.Contractor).Include(p => p.JobTitle).Include(p => p.Person).Include(p => p.Project).Include(p => p.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProjectPersons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerson = await _context.ProjectPerson
                .Include(p => p.Contractor)
                .Include(p => p.JobTitle)
                .Include(p => p.Person)
                .Include(p => p.Project)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPersonID == id);
            if (projectPerson == null)
            {
                return NotFound();
            }

            return View(projectPerson);
        }

        // GET: ProjectPersons/Create
        public IActionResult Create()
        {
            ViewData["ContractorID"] = new SelectList(_context.Contractor, "ContractorID", "Title");
            ViewData["JobTitleID"] = new SelectList(_context.JobTitle, "JobTitleID", "Title");
            ViewData["PersonID"] = new SelectList(_context.Person, "PersonID", "PersonName");
            ViewData["ProjectID"] = new SelectList(_context.Project, "ProjectID", "ProjectTitle");
            ViewData["UserID"] = new SelectList(_context.ApplicationUser, "Id", "Id");
            return View();
        }

        // POST: ProjectPersons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectPersonID,PersonID,ProjectID,ContractorID,JobTitleID,ProjectPersonDescription,IsInternal,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPerson projectPerson)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectPerson);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContractorID"] = new SelectList(_context.Contractor, "ContractorID", "Title", projectPerson.ContractorID);
            ViewData["JobTitleID"] = new SelectList(_context.JobTitle, "JobTitleID", "Title", projectPerson.JobTitleID);
            ViewData["PersonID"] = new SelectList(_context.Person, "PersonID", "PersonName", projectPerson.PersonID);
            ViewData["ProjectID"] = new SelectList(_context.Project, "ProjectID", "ProjectTitle", projectPerson.ProjectID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUser, "Id", "Id", projectPerson.UserID);
            return View(projectPerson);
        }

        // GET: ProjectPersons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerson = await _context.ProjectPerson.FindAsync(id);
            if (projectPerson == null)
            {
                return NotFound();
            }
            ViewData["ContractorID"] = new SelectList(_context.Contractor, "ContractorID", "Title", projectPerson.ContractorID);
            ViewData["JobTitleID"] = new SelectList(_context.JobTitle, "JobTitleID", "Title", projectPerson.JobTitleID);
            ViewData["PersonID"] = new SelectList(_context.Person, "PersonID", "PersonName", projectPerson.PersonID);
            ViewData["ProjectID"] = new SelectList(_context.Project, "ProjectID", "ProjectTitle", projectPerson.ProjectID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUser, "Id", "Id", projectPerson.UserID);
            return View(projectPerson);
        }

        // POST: ProjectPersons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectPersonID,PersonID,ProjectID,ContractorID,JobTitleID,ProjectPersonDescription,IsInternal,UserID,CreationDate,UpdateDate,DeletionDate")] ProjectPerson projectPerson)
        {
            if (id != projectPerson.ProjectPersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectPerson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectPersonExists(projectPerson.ProjectPersonID))
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
            ViewData["ContractorID"] = new SelectList(_context.Contractor, "ContractorID", "Title", projectPerson.ContractorID);
            ViewData["JobTitleID"] = new SelectList(_context.JobTitle, "JobTitleID", "Title", projectPerson.JobTitleID);
            ViewData["PersonID"] = new SelectList(_context.Person, "PersonID", "PersonName", projectPerson.PersonID);
            ViewData["ProjectID"] = new SelectList(_context.Project, "ProjectID", "ProjectTitle", projectPerson.ProjectID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUser, "Id", "Id", projectPerson.UserID);
            return View(projectPerson);
        }

        // GET: ProjectPersons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectPerson = await _context.ProjectPerson
                .Include(p => p.Contractor)
                .Include(p => p.JobTitle)
                .Include(p => p.Person)
                .Include(p => p.Project)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectPersonID == id);
            if (projectPerson == null)
            {
                return NotFound();
            }

            return View(projectPerson);
        }

        // POST: ProjectPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectPerson = await _context.ProjectPerson.FindAsync(id);
            _context.ProjectPerson.Remove(projectPerson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectPersonExists(int id)
        {
            return _context.ProjectPerson.Any(e => e.ProjectPersonID == id);
        }
    }
}
