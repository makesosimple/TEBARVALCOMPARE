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
    public class ProjectExpropriation
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectExpropriationID { get; set; }
        public int ProjectID { get; set; }
        
        [MaxLength(256)]
        public string ProjectExpropriationDescription { get; set; }
        public bool ProjectNeedsExpropriation { get; set; }


        public DateTime? ProjectExpropriationDate { get; set; }

        [Column(TypeName = "decimal(12, 4)")]
        public decimal ProjectExpropriationCost { get; set; }

        [MaxLength(256)]
        public string ProjectExpropriationStatusDesc { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
