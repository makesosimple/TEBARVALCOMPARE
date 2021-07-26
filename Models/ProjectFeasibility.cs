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
    public class ProjectFeasibility
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectFeasibilityID { get; set; }
        public int ProjectID { get; set; }
        public int ContractorID { get; set; }
        public int PersonID { get; set; }
        public string ProjectFeasibilityOutsource { get; set; }

        public DateTime? ProjectFeasibilityDate { get; set; }

        [Column(TypeName = "decimal(12, 4)")]
        public decimal ProjectFeasibilityCost { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
