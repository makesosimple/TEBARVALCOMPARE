using IBBPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class ProjectSummaryViewModel
    {
        

        public string ProjectTitle { get; set; }

        public int? ProjectYear { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectStatusDescription { get; set; }
        public int ProjectID { get; set; }
        public decimal? ProjectLatitude { get; set; }
        public decimal? ProjectLongitude { get; set; }
        public string coordinates { get; set; }
        public string ServiceAreaTitle { get; set; }
        public string ResponsibleDepartmentTitle { get; set; }
        public string ProjectImportanceTitle { get; set; }
        public string MapIcon { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectPaftaAdaParsel { get; set; }
        public string ProjectOwnerName { get; set; }
        public string ProjectManager { get; set; }
        public string BiddingTitle { get; set; }
        public string RequestingAuthorityTitle { get; set; }
        public string ProjectIBBCode { get; set; }

}
}
