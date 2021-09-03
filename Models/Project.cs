using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    [Index(nameof(RequestingDepartmentID))]
    [Index(nameof(ResponsibleDepartmentID))]
    [Index(nameof(ProjectOwnerPersonID))]
    [Index(nameof(ProjectManagerID))]
    [Index(nameof(ProjectServiceAreaID))]
    [Index(nameof(ProjectImportanceID))]
    [Index(nameof(ProjectStatusID))]
    [Index(nameof(UserID))]
    [Index(nameof(ProjectProductionRespDepartmentID))]
    public class Project
    {   
        //Primary Key. Common on all tables
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        //Sample Porject Title Easy. Not sure if that must be 256 characters long.
        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string ProjectTitle { get; set; }

        //This will be generated in the controller
        [MaxLength(32, ErrorMessage = "Bu alana maksimum 32 karakter girebilirsiniz.")]
        public string? ProjectCode { get; set; }

        //Input field. Value will come from the end-user.
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string ProjectIBBCode { get; set; }

        //Requesting Department. Bind to Department Model.
        public int? RequestingDepartmentID { get; set; }
        [ForeignKey("RequestingDepartmentID")]
        public Department RequestingDepartment { get; set; }

        //Responsible Department. Bind to Department Model.
        public int? ResponsibleDepartmentID { get; set; }
        [ForeignKey("ResponsibleDepartmentID")]
        public Department ResponsibleDepartment { get; set; }

        //Project Owner. Bind to Person Model.
        public int? ProjectOwnerPersonID { get; set; }
        [ForeignKey("ProjectOwnerPersonID")]
        public Person ProjectOwnerPerson { get; set; }

        //Project Service Area. Bind to Service Area Model.
        public int? ProjectServiceAreaID { get; set; }
        [ForeignKey("ProjectServiceAreaID")]
        public ServiceArea ProjectServiceArea { get; set; }

        //Project Importance. Bind to Project Importance Model.
        public int? ProjectImportanceID { get; set; }
        [ForeignKey("ProjectImportanceID")]
        public ProjectImportance ProjectImportance { get; set; }

        //Project Status. Bind To Project Status Model
        public int? ProjectStatusID { get; set; }
        [ForeignKey("ProjectStatusID")]
        public ProjectStatus ProjectStatus { get; set; }

        //Project Status Description. Not needed by the user but keep information just in case.
        [MaxLength(512)]
        public string? ProjectStatusDescription { get; set; }

        //Project Status Description Date. Not needed by the user but keep information just in case.
        public DateTime? ProjectStatusDescriptionDate { get; set; }

        //This Value will come from the Bidding tab!
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? EstimatedProjectCost { get; set; }

        //Project Right Column Section
        public int? ProjectObjectID { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectUID { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectGlobalID { get; set; }

        public int? ProjectYear { get; set; }

        public int? ProjectProductionRespDepartmentID { get; set; }
        [ForeignKey("ProjectProductionRespDepartmentID")]
        public Department ProjectProductionRespDepartment { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectFileNumber { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectPackageNumber { get; set; }

        public int? ProjectManagerID { get; set; }
        [ForeignKey("ProjectManagerID")]
        public Person ProjectManager { get; set; }

        [MaxLength(1024, ErrorMessage = "Bu alana maksimum 1024 karakter girebilirsiniz.")]
        public string? ProjectProductionName { get; set; }

        public DateTime? ProjectEndTime { get; set; }

        public DateTime? ProjectProductionEndTime { get; set; }
        //End of Project Right Column Section

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
        

        //public int ProjectCoordinatorPersonID { get; set; }

        //public int ProjectFeasibilityID { get; set; }
        //public int ProjectExpropriationID { get; set; }
        //public int ProjectZoningPlanID { get; set; }
        //public int ProjectPermissionID { get; set; }

        //public int ProjectBoardApprovalID { get; set; }

    }
}
