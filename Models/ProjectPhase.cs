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

        [MaxLength(256)]
        public string ProjectPhaseStatusDescription { get; set; }

        public int PhaseOrder { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}
