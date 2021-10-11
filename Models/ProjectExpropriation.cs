using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IBBPortal.Static;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    [Index(nameof(ProjectID))]
    [Index(nameof(ExpropriationStatusID))]
    [Index(nameof(UserID))]
    public class ProjectExpropriation : TProjectField
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectExpropriationID { get; set; }

        //Related Project ID. All projects can have only one Expropriation
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        [MaxLength(256)]
        public string? PropertyStatusDescription { get; set; }

        public int? ExpropriationStatusID { get; set; }
        [ForeignKey("ExpropriationStatusID")]
        public ExpropriationStatus ExpropriationStatus { get; set; }

        [MaxLength(256)]
        public string? ProjectExpropriationDescription { get; set; }

        [Required]
        public bool ProjectNeedsExpropriation { get; set; }

        public DateTime? ProjectExpropriationDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProjectExpropriationCost { get; set; }

        [MaxLength(256)]
        public string? ProjectExpropriationStatusDesc { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
