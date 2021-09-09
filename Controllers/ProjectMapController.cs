using IBBPortal.Data;
using IBBPortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.Controllers
{
    public class ProjectMapController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProjectMapController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: https://localhost:44360/ProjectMap/ProjectDetail/?projectID=168
        public async Task<IActionResult> ProjectDetail(int? projectID)
        {

            if (projectID == null)
            {
                return NotFound();
            }

            /*var projectField = await _context.ProjectField
                //.Include(m => m.Project.ProjectTitle)
                .Include(m => m.coordinates)
                //.Include(m => m.Project.ProjectIBBCode)
                .Include(m => m.ProjectLatitude)
                .Include(m => m.ProjectLongitude)
                .FirstOrDefaultAsync(m => m.ProjectID == projectID);*/

            var projectDetail = await _context.ProjectField.Select(m => new
            {
                ProjectTitle = m.Project.ProjectTitle,
                m.ProjectID,
                m.ProjectLatitude,
                m.ProjectLongitude,
                m.coordinates,
            }).FirstOrDefaultAsync(m => m.ProjectID == projectID);

            if (projectDetail == null)
            {
                return NotFound();
            }

            ViewBag.projectDetail = projectDetail;
            //ViewBag.projectField = projectField;

            return View();
        }
    }
}
