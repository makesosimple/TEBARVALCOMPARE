using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    [Index(nameof(RequestingDepartmentID))]
    [Index(nameof(RequestingAuthorityID))]
    [Index(nameof(ResponsibleDepartmentID))]
    [Index(nameof(ProjectOwnerPersonID))]
    [Index(nameof(ProjectManagerID))]
    [Index(nameof(ProjectServiceAreaID))]
    [Index(nameof(ProjectImportanceID))]
    [Index(nameof(ProjectStatusID))]
    [Index(nameof(UserID))]
    [Index(nameof(ProjectProductionRespDepartmentID))]
    [Index(nameof(ProjectTypeID))]
    [Index(nameof(ProjectAdditionalServiceAreaID))]
    public class Project
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string ProjectTitle { get; set; }

        //This will be generated in the controller
        [MaxLength(32, ErrorMessage = "Bu alana maksimum 32 karakter girebilirsiniz.")]
        public string? ProjectCode { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string ProjectIBBCode { get; set; }

        public int? RequestingDepartmentID { get; set; }
        [ForeignKey("RequestingDepartmentID")]
        public Department RequestingDepartment { get; set; }

        public int? RequestingAuthorityID { get; set; }
        [ForeignKey("RequestingAuthorityID")]
        public Authority RequestingAuthority { get; set; }

        public int? ResponsibleDepartmentID { get; set; }
        [ForeignKey("ResponsibleDepartmentID")]
        public Department ResponsibleDepartment { get; set; }

        public int? ProjectOwnerPersonID { get; set; }
        [ForeignKey("ProjectOwnerPersonID")]
        public Person ProjectOwnerPerson { get; set; }

        public int? ProjectServiceAreaID { get; set; }
        [ForeignKey("ProjectServiceAreaID")]
        public ServiceArea ProjectServiceArea { get; set; }

        public int? ProjectImportanceID { get; set; }
        [ForeignKey("ProjectImportanceID")]
        public ProjectImportance ProjectImportance { get; set; }

        public int? ProjectStatusID { get; set; }
        [ForeignKey("ProjectStatusID")]
        public ProjectStatus ProjectStatus { get; set; }

        [MaxLength(512, ErrorMessage = "Bu alana maksimum 512 karakter girebilirsiniz.")]
        public string? ProjectStatusDescription { get; set; }

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

        //Latest Updates
        public int? ProjectAdditionalServiceAreaID { get; set; }
        [ForeignKey("ProjectAdditionalServiceAreaID")]
        public ServiceArea ProjectAdditionalServiceArea { get; set; }

        public int? ProjectProductionStatusID { get; set; }
        [ForeignKey("ProjectProductionStatusID")]
        public ProjectStatus ProjectProductionStatus { get; set; }

        [MaxLength(2048, ErrorMessage = "Bu alana maksimum 2048 karakter girebilirsiniz.")]
        public string? ProjectProductionStatusDescription { get; set; }

        public int? ProjectTypeID { get; set; }
        [ForeignKey("ProjectTypeID")]
        public ProjectType ProjectType { get; set; }

        public DateTime? RespDepartmentTransferDate { get; set; }

        [MaxLength(2048, ErrorMessage = "Bu alana maksimum 2048 karakter girebilirsiniz.")]
        public string? RequestingAuthorityDescription { get; set; }
        //End of Latest Updates

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
