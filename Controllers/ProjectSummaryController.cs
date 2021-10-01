using IBBPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using IBBPortal.Data;
using System.Threading.Tasks;
using IBBPortal.ViewModels;
using System;
using System.Linq;

namespace IBBPortal.Controllers
{
    [Authorize]
    public class ProjectSummaryController : Controller
    {
        private readonly ILogger<ProjectSummaryController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProjectSummaryController(ILogger<ProjectSummaryController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project.Select(m => new ProjectSummaryViewModel
            {
                ProjectTitle = m.ProjectTitle,
                ProjectID = m.ProjectID,
                ProjectLatitude = _context.ProjectField.FirstOrDefault(b => b.ProjectID == m.ProjectID).ProjectLatitude,
                ProjectLongitude = _context.ProjectField.FirstOrDefault(b => b.ProjectID == m.ProjectID).ProjectLongitude,
                coordinates = _context.ProjectField.FirstOrDefault(b => b.ProjectID == m.ProjectID).coordinates,
                ServiceAreaTitle = m.ProjectServiceArea.ServiceAreaTitle,
                ResponsibleDepartmentTitle = m.ResponsibleDepartment.DepartmentTitle,
                ProjectImportanceTitle = m.ProjectImportance.ProjectImportanceTitle,
                MapIcon = m.ResponsibleDepartment.MapIcon,
                ProjectAddress = _context.ProjectField.FirstOrDefault(b => b.ProjectID == m.ProjectID).ProjectAddress,
                ProjectPaftaAdaParsel = _context.ProjectField.FirstOrDefault(b => b.ProjectID == m.ProjectID).ProjectPaftaAdaParsel,
                ProjectOwnerName = m.ProjectOwnerPerson.PersonName + " " + m.ProjectOwnerPerson.PersonSurname,
                ProjectManager = m.ProjectManager.PersonName + " " + m.ProjectManager.PersonSurname,
                BiddingTitle = _context.ProjectBidding.FirstOrDefault(b => b.ProjectID == m.ProjectID).BiddingTitle,
                RequestingAuthorityTitle = m.RequestingAuthority.AuthorityTitle,
                ProjectIBBCode = m.ProjectIBBCode,

            }).FirstOrDefaultAsync(m => m.ProjectID == id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }
    }
}
