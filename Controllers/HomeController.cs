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

namespace IBBPortal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var dashboardSummary = await _context.DashboardSummaryModel.FromSqlRaw("SELECT (SELECT COUNT(ProjectID) FROM Project) AS NumberOfProjects, (SELECT COUNT(ProjectPhaseID) FROM ProjectPhase WHERE ProjectPhase.ProjectPhaseStart >= DATEADD(day, -30, GETDATE()) AND ProjectPhase.ProjectPhaseStart <= GETDATE()) AS ProjectsStartedInLastMonth, ((SELECT COUNT(ProjectID) FROM Project WHERE ProjectStatusID = 10) / ((SELECT COUNT(ProjectID) FROM Project)+1)) AS NumberOfCompletedProjects").FirstOrDefaultAsync();

            //Console.Writeln(dashboardSummary.Result.NumberOfProjects);
            //var numberOfProjects = await _context.Project.CountAsync();
            ViewBag.numberOfProjects = System.Convert.ToInt32(dashboardSummary.NumberOfProjects);
            ViewBag.numberOfProjectsInAMonth = dashboardSummary.ProjectsStartedInLastMonth;
            ViewBag.numberOfCompletedProjects = dashboardSummary.NumberOfCompletedProjects;

            var myShortcuts = await _context.ShortcutListModel.FromSqlRaw("SELECT Project.ProjectID, Project.ProjectTitle FROM Shortcuts LEFT JOIN Project ON Project.ProjectID = Shortcuts.ShortcutsProjectID WHERE Shortcuts.UserID = {0}", _userManager.GetUserId(HttpContext.User)).ToListAsync();

            ViewBag.myShortcuts = myShortcuts;

            var serviceAreaList = await _context.ServicePieChartModel.FromSqlRaw(@"SELECT
                       ServiceAreaID,
                       ServiceAreaTitle,
                       (COUNT(ProjectID)) AS NumberOfProjects
                       
                    FROM Project
                    LEFT JOIN ServiceArea ON Project.ProjectServiceAreaID = ServiceArea.ServiceAreaID
                    GROUP BY ServiceAreaID, ServiceAreaTitle
                    ORDER BY NumberOfProjects DESC
                    ").ToListAsync();

            ViewBag.serviceAreaList = serviceAreaList;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
