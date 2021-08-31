using IBBPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class DashboardSummaryModel
    {
        public Int32 NumberOfProjects { get; set; }
        public Int32 ProjectsStartedInLastMonth { get; set; }
        public Int32 NumberOfCompletedProjects { get; set; }
    }
}
