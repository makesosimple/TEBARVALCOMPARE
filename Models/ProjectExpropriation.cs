using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    //Property Status / Property Status Descriptipon
    [Index(nameof(ProjectID))]
    public class ProjectExpropriation
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectExpropriationID { get; set; }

        //Related Project ID. All projects can have only one Expropriation
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

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
