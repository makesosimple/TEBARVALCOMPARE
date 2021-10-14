using IBBPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class EditProjectFieldViewModel
    {
        public string ProjectTitle { get; set; }

        public ProjectField ProjectField { get; set; }

        public ProjectBoardApproval? ProjectBoardApproval { get; set; }

        public ProjectZoningPlan? ProjectZoningPlan { get; set; }

        public ProjectExpropriation? ProjectExpropriation { get; set; }

        //Send Multiple Select Property Status
        public List<ProjectPropertyStatusViewModel> ChosenPropertyStatus { get; set; }

        //Recieve Multiple Select Property Status
        public int[] PropertyStatus { get; set; }
        public ProjectPermission? ProjectPermission { get; set; }
    }
}
