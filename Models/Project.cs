using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectStatusID))]
    [Index(nameof(ProjectImportanceID))]
    [Index(nameof(ProjectCoordinatorPersonID))]
    [Index(nameof(ServiceAreaID))]
    [Index(nameof(RequestingManagementID))]
    [Index(nameof(DistrictID))]
    [Index(nameof(ProjectFeasibilityID))]
    [Index(nameof(ProjectExpropriationID))]
    [Index(nameof(ProjectZoningPlanID))]
    [Index(nameof(ProjectBoardApprovalID))]
    
    public class Project
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }
        
        [MaxLength(32)]
        public string ProjectCode { get; set; }

        [MaxLength(32)]
        public string ProjectIBBCode { get; set; }

        [MaxLength(256)]
        [Required]
        public string ProjectTitle { get; set; }

        public int ProjectStatusID { get; set; }
        [MaxLength(512)]
        public string ProjectStatusDescription { get; set; }
        public int ProjectOwnerPersonID { get; set; }
        public int ProjectCoordinatorPersonID { get; set; }

        public int ServiceAreaID { get; set; }

        public int ProjectImportanceID { get; set; }

        public int RequestingManagementID { get; set; }

        [ForeignKey("RequestingManagementID")]
        public Management RequestingManagement { get; set; }

        public int ResponsibleManagementID { get; set; }

        [ForeignKey("ResponsibleManagementID")]
        public Management ResponsibleManagement { get; set; }

        public bool IsProjectInIstanbul { get; set; }
        public int DistrictID { get; set; }

        [MaxLength(256)]
        public string ProjectAddress { get; set; }


        [Column(TypeName = "decimal(12, 4)")]
        public decimal ProjectCost { get; set; }

        [Column(TypeName = "decimal(8, 4)")]
        public decimal ProjectArea { get; set; }

        [Column(TypeName = "decimal(8, 4)")]
        public decimal ProjectConstructionArea { get; set; }

        [Column(TypeName = "decimal(8, 4)")]
        public decimal ProjectPaysageArea { get; set; }

        public string ProjectPaftaAdaParsel { get; set; }

        public int ProjectFeasibilityID { get; set; }
        public int ProjectExpropriationID { get; set; }
        public int ProjectZoningPlanID { get; set; }
        public int ProjectPermissionID { get; set; }

        public int ProjectBoardApprovalID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
