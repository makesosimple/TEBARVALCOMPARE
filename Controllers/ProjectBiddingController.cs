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
using System.Globalization;

namespace IBBPortal.Controllers
{
    public class ProjectBiddingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProjectBiddingController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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
                var cultureInfo = CultureInfo.CreateSpecificCulture("tr-TR");

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

                var data = _context.ProjectBidding
                    .Select(c => new
                    {
                        c.ProjectBiddingID,
                        c.ProjectID,
                        c.BiddingTitle,
                        PhaseTitle = c.ProjectPhase.Phase.PhaseTitle,
                        DepartmentTitle = c.Department.DepartmentTitle,
                        ContractorTitle = c.Contractor.Title,
                        BiddingContractCost = c.BiddingContractCost.ToString("N2", cultureInfo),
                        BiddingProgressPayment = c.BiddingProgressPayment.ToString("N2", cultureInfo)
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

        // GET: ProjectBidding/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectBidding = await _context.ProjectBidding
                .Include(p => p.Contractor)
                .Include(p => p.Department)
                .Include(p => p.Project)
                .Include(p => p.ProjectPhase)
                .ThenInclude(p => p.Phase)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectBiddingID == id);
                    
            if (projectBidding == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", projectBidding);
        }

        // GET: ProjectBidding/Create
        public IActionResult Create(int id)
        {
            ViewBag.ProjectID = id;
            return PartialView("_CreateModal");
        }

        // POST: ProjectBidding/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectBiddingID,ProjectID,BiddingTitle,ProjectPhaseID,DepartmentID,BiddingCode,BiddingDate,BiddingContractCost,BiddingProgressPayment,ContractorID,BiddingDescription,CreationDate,UpdateDate,DeletionDate")] ProjectBidding projectBidding)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    projectBidding.CreationDate = DateTime.Now;
                    projectBidding.UserID = _userManager.GetUserId(HttpContext.User);

                    _context.Add(projectBidding);
                    await _context.SaveChangesAsync();
                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu.";
                    return RedirectToAction(nameof(Index), new { id = projectBidding.ProjectID });
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index), new { id = projectBidding.ProjectID });
                }
            }
            return PartialView("_CreateModal");
        }

        // GET: ProjectBidding/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectBidding = await _context.ProjectBidding
                .Include(p => p.Contractor)
                .Include(p => p.Department)
                .Include(p => p.Project)
                .Include(p => p.ProjectPhase)
                .ThenInclude(p => p.Phase)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectBiddingID == id);

            if (projectBidding == null)
            {
                return NotFound();
            }
            return PartialView("_EditModal", projectBidding);
        }

        // POST: ProjectBidding/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProjectBidding(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectBiddingToUpdate = await _context.ProjectBidding.FindAsync(id);

            projectBiddingToUpdate.UpdateDate = DateTime.Now;


            if (await TryUpdateModelAsync<ProjectBidding>(projectBiddingToUpdate, "",
                x => x.BiddingTitle, x => x.ProjectPhaseID, x => x.DepartmentID, x => x.BiddingCode, x => x.BiddingDate, 
                x => x.BiddingContractCost, x => x.BiddingProgressPayment, x => x.ContractorID, 
                x => x.BiddingDescription, x => x.UpdateDate))
            {
                try
                {

                    await _context.SaveChangesAsync();

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectBiddingExists(projectBiddingToUpdate.ProjectBiddingID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = projectBiddingToUpdate.ProjectID });
            }
            return View(projectBiddingToUpdate);
        }

        // GET: ProjectBidding/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectBidding = await _context.ProjectBidding
                .Include(p => p.Contractor)
                .Include(p => p.Department)
                .Include(p => p.Project)
                .Include(p => p.ProjectPhase)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProjectBiddingID == id);
            if (projectBidding == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", projectBidding);
        }

        // POST: ProjectBidding/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectBidding = await _context.ProjectBidding.FindAsync(id);
            try
            {
                _context.ProjectBidding.Remove(projectBidding);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{projectBidding.ProjectBiddingID} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index), new { id = projectBidding.ProjectID });
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index), new { id = projectBidding.ProjectID });
            }
        }

        private bool ProjectBiddingExists(int id)
        {
            return _context.ProjectBidding.Any(e => e.ProjectBiddingID == id);
        }
    }
}
