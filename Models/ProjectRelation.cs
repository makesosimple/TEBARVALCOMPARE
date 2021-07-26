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
    [Index(nameof(ProjectID))]
    [Index(nameof(RelatedProjectID))]
    public class ProjectRelation
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectRelationID { get; set; }
        public int ProjectID { get; set; }

       
        public int RelatedProjectID { get; set; }
        public int RelationType { get; set; }
        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}
