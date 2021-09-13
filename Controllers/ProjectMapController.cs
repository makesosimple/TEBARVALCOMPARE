using IBBPortal.Data;
using IBBPortal.Models;
using IBBPortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> ProjectDetail(int? id)
        {

            if (id == null)
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

            var projectDetail = await _context.ProjectField.Select(m => new ProjectMapDetailViewModel
            {
                ProjectTitle = m.Project.ProjectTitle,
                ProjectID = m.ProjectID,
                ProjectLatitude = m.ProjectLatitude,
                ProjectLongitude = m.ProjectLongitude,
                coordinates = m.coordinates,
                ServiceAreaTitle = m.Project.ProjectServiceArea.ServiceAreaTitle,
                ResponsibleDepartmentTitle = m.Project.ResponsibleDepartment.DepartmentTitle,
                ProjectImportanceTitle = m.Project.ProjectImportance.ProjectImportanceTitle,
                MapIcon = m.Project.ResponsibleDepartment.MapIcon,
            }).FirstOrDefaultAsync(m => m.ProjectID == id);

            if (projectDetail == null)
            {
                return NotFound();
            }

            return View(projectDetail);
        }
    }
}
