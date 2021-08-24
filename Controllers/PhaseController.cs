using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using IBBPortal.Helpers;

namespace IBBPortal.Controllers
{
    public class PhaseController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public PhaseController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Board
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

                var data = _context.Phase.Select(c => new { c.PhaseID, c.PhaseTitle, c.PhaseOrder, c.isPresentation, PreviousPhaseTitle = c.PreviousPhase.PhaseTitle, UserName = c.User.UserName });

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

                for (int i = 0; i < 5; i++)
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

                var PhaseData = _context.Phase
                                    .Select(x => new {
                                        id = x.PhaseID.ToString(),
                                        text = x.PhaseOrder + ". " + x.PhaseTitle
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    PhaseData = PhaseData.Where(m => m.text.Contains(term)).OrderBy(x => x.text);
                }

                else
                {
                    PhaseData = PhaseData.OrderBy(x => x.text);
                }
                //Count 
                var totalCount = PhaseData.Count();

                //Paging   
                var passData = PhaseData.ToList();


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: Phase/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phase = await _context.Phase
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PhaseID == id);
            if (phase == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", phase);
        }

        // GET: Phase/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Phase/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhaseID,PhaseTitle,PhaseDescription,isPresentation,PhaseOrder,PreviousPhaseID,UserID,CreationDate,UpdateDate,DeletionDate")] Phase phase)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    phase.CreationDate = DateTime.Now;
                    phase.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(phase);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $" {phase.PhaseID} numaralı kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(phase);
        }

        // GET: Phase/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phase = await _context.Phase.FindAsync(id);
            if (phase == null)
            {
                return NotFound();
            }
            return View(phase);
        }

        // POST: Phase/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhaseID,PhaseTitle,PhaseDescription,isPresentation,PhaseOrder,PreviousPhaseID,UserID,CreationDate,UpdateDate,DeletionDate")] Phase phase)
        {
            if (id != phase.PhaseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var CurrentDate = DateTime.Now;
                    phase.UpdateDate = CurrentDate;

                    _context.Update(phase);
                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"{phase.PhaseID} numaralı kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhaseExists(phase.PhaseID))
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
            return View(phase);
        }

        // GET: Phase/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phase = await _context.Phase
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PhaseID == id);
            if (phase == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", phase);
        }

        // POST: Phase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phase = await _context.Phase.FindAsync(id);
            
            try
            {
                _context.Phase.Remove(phase);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{phase.PhaseID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool PhaseExists(int id)
        {
            return _context.Phase.Any(e => e.PhaseID == id);
        }
    }
}
