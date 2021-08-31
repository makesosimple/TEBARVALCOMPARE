using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(PhaseID))]
    [Index(nameof(UserID))]
    [Index(nameof(ProjectPhaseStatusID))]
    public class ProjectPhase
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectPhaseID { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
       
        public int? PhaseID { get; set; }
        [ForeignKey("PhaseID")]
        public Phase Phase { get; set; }

        public int? ProjectPhaseStatusID { get; set; }
        [ForeignKey("ProjectPhaseStatusID")]
        public ProjectPhaseStatus ProjectPhaseStatus { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? ProjectPhaseStatusDescription { get; set; }

        public DateTime? ProjectPhaseStart { get; set; }

        public DateTime? ProjectPhaseFinish { get; set; }

        public DateTime? ProjectPhaseRecordedStart { get; set; }

        public DateTime? ProjectPhaseRecordedFinish { get; set; }

        public int? ProjectPhaseTimeExtension { get; set; }

        public DateTime? ProjectPhaseTimeExtentedFinish { get; set; }

        [MaxLength(512, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? ProjectPhaseExtensionReason { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
