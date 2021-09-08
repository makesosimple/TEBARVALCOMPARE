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
using IBBPortal.ViewModels;
using System.Collections.Generic;

namespace IBBPortal.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UserController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: User
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult JSONData()
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

                var data = _context.Users.Select(c => new { c.Id, c.UserName, FullName = c.FirstName + " " + c.LastName, c.Email });
                var fullData = data;
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

                for (int i = 0; i < 3; i++)
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
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = passData, fullData = fullData });

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

                var UserData = _context.Users
                                    .Select(x => new {
                                        id = x.Id,
                                        text = x.FirstName + " " + x.LastName
                                    });

                if (!String.IsNullOrEmpty(term))
                {
                    UserData = UserData.Where(m => m.text.Contains(term));
                }

                //Count 
                var totalCount = UserData.Count();

                //Paging   
                var passData = UserData.ToList().Take(10);


                //Returning Json Data  
                return Json(new { results = passData, totalCount = totalCount });

            }

            catch (Exception)
            {
                throw;
            }
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return PartialView("_DetailsModal", applicationUser);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = new ApplicationUser { 
                        FirstName = model.FirstName, 
                        LastName = model.LastName, 
                        UserName = model.UserName, 
                        Email = model.Email,
                        EmailConfirmed = true,
                        LockoutEnabled = false,
                    };

                    user.CreationDate = DateTime.Now;
                    user.UserID = _userManager.GetUserId(HttpContext.User);

                    await _userManager.CreateAsync(user, model.Password);

                    var roleToAdd = await _roleManager.FindByIdAsync(model.RoleID);

                    await _userManager.AddToRoleAsync(user, roleToAdd.NormalizedName);

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla oluşturuldu:" + user.FirstName;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorTitle"] = "HATA";
                    TempData["ErrorMessage"] = $"Kayıt oluşturulamadı.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }

        // GET: Role/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUserToEdit = await _context.Users.FindAsync(id);

            if (applicationUserToEdit == null)
            {
                return NotFound();
            }

            var relatedUserRole = await _context.UserRoles.Where(x => x.UserId == id).FirstOrDefaultAsync();
            var relatedRole = await _context.Roles.Where( x => x.Id == relatedUserRole.RoleId).FirstOrDefaultAsync();

            UserEditViewModel model = new UserEditViewModel
            {
                FirstName = applicationUserToEdit.FirstName,
                LastName = applicationUserToEdit.LastName,
                UserName = applicationUserToEdit.UserName,
                Email = applicationUserToEdit.Email,
                RoleID = relatedRole.Id,
                Role = relatedRole
            };
            return View(model);
        }

        // POST: Role/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(string? id, UserEditViewModel model)
        {

            if (id == null)
            {
                return NotFound();
            }

            var userToUpdate = await _context.Users.FindAsync(id);

            if (model.FirstName != userToUpdate.FirstName)
            {
                userToUpdate.FirstName = model.FirstName;
            }

            if (model.LastName != userToUpdate.LastName)
            {
                userToUpdate.LastName = model.LastName;
            }

            if (model.UserName != userToUpdate.UserName)
            {
                userToUpdate.UserName = model.UserName;
            }

            if (model.Email != userToUpdate.Email)
            {
                userToUpdate.Email = model.Email;
            }

            userToUpdate.UpdateDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                try
                {
                    var roleToAdd = await _roleManager.FindByIdAsync(model.RoleID);

                    await _userManager.AddToRoleAsync(userToUpdate, roleToAdd.NormalizedName);

                    await _userManager.UpdateAsync(userToUpdate);

                    TempData["SuccessTitle"] = "BAŞARILI";
                    TempData["SuccessMessage"] = $"Kayıt başarıyla düzenlendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationUserExists(userToUpdate.Id))
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
            return View(userToUpdate);
        }

        // GET: Role/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return PartialView("_DeleteModal", applicationUser);
        }

        // POST: Role/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var applicationUser = await _context.Users.FindAsync(id);
            try
            {
                _context.Users.Remove(applicationUser);
                await _context.SaveChangesAsync();
                TempData["SuccessTitle"] = "BAŞARILI";
                TempData["SuccessMessage"] = $"{applicationUser.Id} numaralı kayıt başarıyla silindi.";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                TempData["ErrorTitle"] = "HATA";
                TempData["ErrorMessage"] = $"Bu değer, başka alanlarda kullanımda olduğu için silemezsiniz. Lütfen sistem yöneticinizle görüşün.";
                return RedirectToAction(nameof(Index));
            }
        }

        private bool ApplicationUserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
