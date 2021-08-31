using IBBPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class ServicePieChartModel
    {
        public Int32 ServiceAreaID { get; set; }
        public string ServiceAreaTitle { get; set; }
        public Int32 NumberOfProjects { get; set; }

    }
}
