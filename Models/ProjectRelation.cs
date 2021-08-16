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
    [Index(nameof(RelationTypeID))]
    public class ProjectRelation
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectRelationID { get; set; }

        //Current Project that we are on.
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        //Related Project that we want to bind to Current Project.
        public int? RelatedProjectID { get; set; }
        [ForeignKey("RelatedProjectID")]
        public Project RelatedProject { get; set; }

        //Project to Project Relation Type.
        public int? RelationTypeID { get; set; }
        [ForeignKey("RelationTypeID")]
        public RelationType RelationType { get; set; }

        //Add a description type just in case the relation is unclear to new users or to top level executives.
        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? ProjectRelationDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
