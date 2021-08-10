﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    //[Index(nameof(ProjectCoordinatorPersonID))]
    //[Index(nameof(DistrictID))]
    //[Index(nameof(ProjectFeasibilityID))]
    //[Index(nameof(ProjectExpropriationID))]
    //[Index(nameof(ProjectZoningPlanID))]
    //[Index(nameof(ProjectBoardApprovalID))]
    [Index(nameof(RequestingManagementID))]
    [Index(nameof(ResponsibleManagementID))]
    [Index(nameof(ProjectOwnerPersonID))]
    [Index(nameof(ProjectServiceAreaID))]
    [Index(nameof(ProjectImportanceID))]
    [Index(nameof(ProjectStatusID))]
    [Index(nameof(UserID))]

    public class Project
    {   
        //Primary Key. Common on all tables
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        //Sample Porject Title Easy. Not sure if that must be 256 characters long.
        [MaxLength(256)]
        [Required]
        public string ProjectTitle { get; set; }

        //This will be generated in the controller
        [MaxLength(32)]
        public string? ProjectCode { get; set; }

        //Input field. Value will come from the end-user.
        [MaxLength(32)]
        public string? ProjectIBBCode { get; set; }

        //Requesting Management. Bind to Management Model.
        [Required]
        public int RequestingManagementID { get; set; }

        [ForeignKey("RequestingManagementID")]
        public Management RequestingManagement { get; set; }

        //Responsible Management. Bind to Management Model.
        [Required]
        public int ResponsibleManagementID { get; set; }
        [ForeignKey("ResponsibleManagementID")]
        public Management ResponsibleManagement { get; set; }

        //Project Owner. Bind to Person Model.
        [Required]
        public int ProjectOwnerPersonID { get; set; }
        [ForeignKey("ProjectOwnerPersonID")]
        public Person ProjectOwnerPerson { get; set; }

        //Project Service Area. Bind to Service Area Model.
        [Required]
        public int ProjectServiceAreaID { get; set; }
        [ForeignKey("ProjectServiceAreaID")]
        public ServiceArea ProjectServiceArea { get; set; }

        //Project Importance. Bind to Project Importance Model.
        [Required]
        public int ProjectImportanceID { get; set; }
        [ForeignKey("ProjectImportanceID")]
        public ProjectImportance ProjectImportance { get; set; }

        //Project Status. Bind To Project Status Model
        [Required]
        public int ProjectStatusID { get; set; }
        [ForeignKey("ProjectStatusID")]
        public ProjectStatus ProjectStatus { get; set; }

        //Project Status Description. Not needed by the user but keep information just in case.
        [MaxLength(512)]
        public string? ProjectStatusDescription { get; set; }

        //Project Status Description Date. Not needed by the user but keep information just in case.
        public DateTime? ProjectStatusDescriptionDate { get; set; }

        //Is Feasibility Needed? This is for bool check.
        [Required]
        public bool IsFeasibilityNeeded { get; set; }

        //Has Related Project? This is for field check.
        [Required]
        public bool HasRelatedProject { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
        

        //public int ProjectCoordinatorPersonID { get; set; }

        //public bool IsProjectInIstanbul { get; set; }
        //public int DistrictID { get; set; }

        //[MaxLength(256)]
        //public string ProjectAddress { get; set; }


        //[Column(TypeName = "decimal(12, 4)")]
        //public decimal ProjectCost { get; set; }

        //[Column(TypeName = "decimal(8, 4)")]
        //public decimal ProjectArea { get; set; }

        //[Column(TypeName = "decimal(8, 4)")]
        //public decimal ProjectConstructionArea { get; set; }

        //[Column(TypeName = "decimal(8, 4)")]
        //public decimal ProjectPaysageArea { get; set; }

        //public string ProjectPaftaAdaParsel { get; set; }

        //public int ProjectFeasibilityID { get; set; }
        //public int ProjectExpropriationID { get; set; }
        //public int ProjectZoningPlanID { get; set; }
        //public int ProjectPermissionID { get; set; }

        //public int ProjectBoardApprovalID { get; set; }

    }
}
