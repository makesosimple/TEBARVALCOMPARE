using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(ZoningPlanStatus1000))]
    [Index(nameof(ZoningPlanStatus5000))]
    [Index(nameof(ZoningPlanModificationStatus))]
    [Index(nameof(ZoningPlanResponsiblePersonID))]
    public class ProjectZoningPlan
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectZoningPlanID { get; set; }
        public int ProjectID { get; set; }
        public int ZoningPlanStatus1000 { get; set; }
        public int ZoningPlanStatus5000 { get; set; }
        public DateTime? ZoningPlanDate1000 { get; set; }
        public DateTime? ZoningPlanDate5000 { get; set; }

        public bool ZoningPlanModificationNeeded { get; set; }
        public string ZoningPlanModificationReason { get; set; }

        public DateTime? ModificationApprovalDate { get; set; }
        public DateTime? ModificationProposallDate { get; set; }
        public int ZoningPlanModificationStatus { get; set; }
        public int ZoningPlanResponsiblePersonID { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
