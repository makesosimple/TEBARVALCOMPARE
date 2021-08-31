using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(ZoningPlanStatusID1000))]
    [Index(nameof(ZoningPlanStatusID5000))]
    [Index(nameof(ZoningPlanModificationStatusID))]
    [Index(nameof(ZoningPlanResponsiblePersonID))]
    public class ProjectZoningPlan
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectZoningPlanID { get; set; }

        //Related Project ID. All projects can have only one Expropriation
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        //Zoning Plan Status 1000
        public int? ZoningPlanStatusID1000 { get; set; }
        [ForeignKey("ZoningPlanStatusID1000")]
        public ZoningPlanStatus ZoningPlanStatus1000 { get; set; }

        public DateTime? ZoningPlanDate1000 { get; set; }
        //End of Zoning Plan Status 1000

        //Zoning Plan Status 5000
        public int? ZoningPlanStatusID5000 { get; set; }
        [ForeignKey("ZoningPlanStatusID5000")]
        public ZoningPlanStatus ZoningPlanStatus5000 { get; set; }

        public DateTime? ZoningPlanDate5000 { get; set; }
        //End of Zoning Plan Status 5000

        //Zoning Plan Modification Field
        [Required]
        public bool ZoningPlanModificationNeeded { get; set; }

        [MaxLength(256)]
        public string? ZoningPlanModificationReason { get; set; }

        public DateTime? ModificationApprovalDate { get; set; }

        public DateTime? ModificationProposalDate { get; set; }

        //Related to Zoning Plan Modification Status Table
        public int? ZoningPlanModificationStatusID { get; set; }
        [ForeignKey("ZoningPlanModificationStatusID")]
        public ZoningPlanModificationStatus ZoningPlanModificationStatus { get; set; }

        //Related to Person Table
        public int? ZoningPlanResponsiblePersonID { get; set; }
        [ForeignKey("ZoningPlanResponsiblePersonID")]
        public Person ZoningPlanResponsiblePerson { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
