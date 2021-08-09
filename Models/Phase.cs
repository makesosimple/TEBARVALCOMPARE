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
    [Index(nameof(PreviousPhaseID))]
    public class Phase
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhaseID { get; set; }

        [Required]
        [MaxLength(50)]
        public string PhaseTitle { get; set; }

        [Required]
        public int PhaseOrder { get; set; }

        [MaxLength(256)]
        public string? PhaseDescription { get; set; }

        public int? PreviousPhaseID { get; set; }
        [ForeignKey("PreviousPhaseID")]
        public Phase PreviousPhase { get; set; }

        public bool isPresentation { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
