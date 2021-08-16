using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(ProjectID))]
    [Index(nameof(RelatedProjectID))]
    [Index(nameof(RelationTypeID))]
    public class ProjectRelation
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectRelationID { get; set; }
        public int ProjectID { get; set; }

       
        public int RelatedProjectID { get; set; }
        public int RelationTypeID { get; set; }

        [ForeignKey("RelationTypeID")]
        public RelationType RelationType { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}
