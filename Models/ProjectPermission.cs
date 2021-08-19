using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    public class ProjectPermission
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectPermissionID { get; set; }

        //Related to Project Table. This is needed just for ID but just in case client wants project related information on this tab, Attach o Project Object.
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        [Required]
        public bool IsPermissionNeeded { get; set; }

        [MaxLength(256)]
        public string? ProjectPermissionProvider { get; set; }

        public DateTime? ProjectPermissionDate { get; set; }

        [MaxLength(256)]
        public string? ProjectPermissionReason { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
