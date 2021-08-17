using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace IBBPortal.Models
{

    //[Index(nameof(ProjectCoordinatorPersonID))]
    //[Index(nameof(DistrictID))]
    //[Index(nameof(ProjectFeasibilityID))]
    //[Index(nameof(ProjectExpropriationID))]
    //[Index(nameof(ProjectZoningPlanID))]
    //[Index(nameof(ProjectBoardApprovalID))]
    [Index(nameof(RequestingDepartmentID))]
    [Index(nameof(ResponsibleDepartmentID))]
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
        [Required]
        public int ProjectIBBCode { get; set; }

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

        //Is Feasibility Needed? This is for bool check.
        [Required]
        public bool IsFeasibilityNeeded { get; set; }

        //Has Related Project? This is for field check.
        [Required]
        public bool HasRelatedProject { get; set; }

        /** Project Field Tab Information **/

        //Check if Project is in İstanbul. If this value is true, districts must come to select accordingly.
        public bool IsProjectInIstanbul { get; set; }

        //Bind project to District Model
        public int? DistrictID { get; set; }
        [ForeignKey("DistrictID")]
        public District District { get; set; }

        //Not required as all project will be displayed on Map but it's for a quick reference.
        [MaxLength(256)]
        public string? ProjectAddress { get; set; }

        //Project Cost. I don't know if this field is required. Ask tomorrow.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ProjectCost { get; set; }

        public double? ProjectArea { get; set; }

        public double? ProjectConstructionArea { get; set; }

        public double? ProjectPaysageArea { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectPaftaAdaParsel { get; set; }

        //Project Physical Location and Shape (Important as this data will be projected to Map.)
        [MaxLength(512, ErrorMessage = "Bu alana maksimum 512 karakter girebilirsiniz.")]
        public string? KML { get; set; }

        [Column(TypeName = "decimal(9, 6)")]
        public decimal? ProjectLongitude { get; set; }

        [Column(TypeName = "decimal(9, 6)")]
        public decimal? ProjectLatitude { get; set; }

        public Point ProjectPoint { get; set; }

        public LineString ProjectLineString { get; set; }


        /** End of Project Field Tab Information **/

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
