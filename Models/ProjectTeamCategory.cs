using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    
    public class ProjectTeamCategory
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectTeamCategoryID { get; set; }

        [MaxLength(50)]
        public string ProjectTeamCategoryTitle { get; set; }
        [MaxLength(50)]
        public string ProjectTeamCategoryDescription { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
