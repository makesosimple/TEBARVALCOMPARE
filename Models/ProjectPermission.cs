using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IBBPortal.Static;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    [Index(nameof(ProjectID))]
    [Index(nameof(OrganizationID))]
    [Index(nameof(UserID))]
    public class ProjectPermission : TProjectField
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectPermissionID { get; set; }

        //Related to Project Table. This is needed just for ID but just in case client wants project related information on this tab, Attach o Project Object.
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        //Related to Organization Table. Evert Permission can be given by only one Organization.
        public int? OrganizationID { get; set; }
        [ForeignKey("OrganizationID")]
        public Organization Organization { get; set; }

        [Required]
        public bool IsPermissionNeeded { get; set; }

        public DateTime? ProjectPermissionDate { get; set; }

        [MaxLength(256)]
        public string? ProjectPermissionReason { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
