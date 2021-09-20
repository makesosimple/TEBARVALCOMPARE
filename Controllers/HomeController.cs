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
            var dashboardSummary = await _context.DashboardSummaryModel.FromSqlRaw("SELECT (SELECT COUNT(ProjectID) FROM Project WHERE DeletionDate IS NULL) AS NumberOfProjects, (SELECT COUNT(ProjectPhaseID) FROM ProjectPhase WHERE ProjectPhase.ProjectPhaseStart >= DATEADD(day, -30, GETDATE()) AND ProjectPhase.ProjectPhaseStart <= GETDATE()) AS ProjectsStartedInLastMonth, ((SELECT COUNT(ProjectID) FROM Project WHERE ProjectStatusID = 10 AND DeletionDate IS NULL) / ((SELECT COUNT(ProjectID) FROM Project WHERE DeletionDate IS NULL)+1)) AS NumberOfCompletedProjects").FirstOrDefaultAsync();

            //Console.Writeln(dashboardSummary.Result.NumberOfProjects);
            //var numberOfProjects = await _context.Project.CountAsync();
            ViewBag.numberOfProjects = System.Convert.ToInt32(dashboardSummary.NumberOfProjects);
            ViewBag.numberOfProjectsInAMonth = dashboardSummary.ProjectsStartedInLastMonth;
            ViewBag.numberOfCompletedProjects = dashboardSummary.NumberOfCompletedProjects;


            //List myShortcuts = new List();
            //try
            //{
            // Console.WriteLine("_userManager.GetUserId(HttpContext.User)=", _userManager.GetUserId(HttpContext.User));
            var myShortcuts = await _context.ShortcutListModel.FromSqlRaw("SELECT Project.ProjectID, Project.ProjectTitle FROM Shortcuts LEFT JOIN Project ON Project.ProjectID = Shortcuts.ShortcutsProjectID WHERE Shortcuts.UserID = {0} AND Project.DeletionDate IS NULL", _userManager.GetUserId(HttpContext.User)).ToListAsync();
            //} catch (Exception e)
            //{
            //myShortcuts = "";
            //}

            var myLog = await _context.TransactionLog.OrderByDescending(c => c.TransactionLogID).Take(10).ToListAsync();
                
                
                /*Select(c => new { c.TransactionLogID, c.TransactionLogMessageContent, c.ProjectID, c.TransactionLogRead, c.UpdateDate}).
                OrderByDescending(c => c.TransactionLogID).ToList();*/

            ViewBag.myLog = myLog;

            ViewBag.myShortcuts = myShortcuts;

            var serviceAreaList = await _context.ServicePieChartModel.FromSqlRaw(@"SELECT
                       Project.ProjectStatusID AS ServiceAreaID,
                       ProjectStatusTitle AS ServiceAreaTitle,
                       (COUNT(ProjectID)) AS NumberOfProjects
                       
                    FROM Project
                    LEFT JOIN ProjectStatus ON Project.ProjectStatusID = ProjectStatus.ProjectStatusID
                    WHERE Project.DeletionDate IS NULL
                    GROUP BY Project.ProjectStatusID, ProjectStatus.ProjectStatusTitle
                    ORDER BY NumberOfProjects DESC
                    ").ToListAsync();
              
             var projectCountByYear = await _context.DashboardLineGraphModel.FromSqlRaw(@"SELECT 
                    
                    ProjectYear,
                    COUNT(ProjectID) AS NumberOfProjects
                    
                    FROM Project
                    WHERE Project.DeletionDate IS NULL
                    GROUP BY ProjectYear
                    ORDER BY ProjectYear ASC
                    
            ").ToListAsync();



            

            ViewBag.serviceAreaList = serviceAreaList;
            ViewBag.projectCountByYear = projectCountByYear;

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
