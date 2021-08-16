using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(PersonID))]
    [Index(nameof(JobTitleID))]
    [Index(nameof(ProjectID))]
    public class ProjectRole
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectRoleID { get; set; }
        public int PersonID { get; set; }

        public int JobTitleID { get; set; }

        public int ProjectID { get; set; }
        public int ProjectTeamCategoryID { get; set; }
        public int ContractorID { get; set; }

        [MaxLength(256)]
        public string ProjectRoleDescription { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
