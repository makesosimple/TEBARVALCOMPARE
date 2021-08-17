using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(PhaseID))]
    [Index(nameof(ProjectPhaseStatusID))]
    public class ProjectPhase
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectPhaseID { get; set; }
        public int ProjectID { get; set; }

       
        public int PhaseID { get; set; }
        public int ProjectPhaseStatusID { get; set; }
        public DateTime ProjectPhaseStart { get; set; }
        public DateTime ProjectPhaseFinish { get; set; }

        public DateTime? ProjectPhaseRecordedStart { get; set; }
        public DateTime? ProjectPhaseRecordedFinish { get; set; }

        public int? ProjectPhaseTimeExtension { get; set; }

        public DateTime? ProjectPhaseTimeExtentedFinish { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? ProjectPhaseExtensionReason { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string ProjectPhaseStatusDescription { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}
