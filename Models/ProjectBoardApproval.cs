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
    public class ProjectBoardApproval
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectBoardApprovalID { get; set; }
        public int ProjectID { get; set; }
        public int BoardID { get; set; }
       

        public DateTime? ProjectBoardApprovalDate { get; set; }

        [MaxLength(256)]
        public string ProjectBoardApprovalReason { get; set; }

        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
