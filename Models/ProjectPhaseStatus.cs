using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    [Index(nameof(UserID))]
    public class ProjectPhaseStatus
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectPhaseStatusID { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProjectPhaseStatusTitle { get; set; }

        [MaxLength(256)]
        public string? ProjectPhaseStatusDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
