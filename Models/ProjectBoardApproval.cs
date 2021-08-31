using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    public class ProjectBoardApproval
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectBoardApprovalID { get; set; }
        
        //Related to Project Table. This is needed just for ID but just in case client wants project related information on this tab, Attach o Project Object.
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        [Required]
        public bool IsBoardApprovalNeeded { get; set; }

        //Related to Board Table.
        public int? BoardID { get; set; }
        [ForeignKey("BoardID")]
        public Board Board { get; set; }

        public DateTime? ProjectBoardApprovalDate { get; set; }

        [MaxLength(256)]
        public string? ProjectBoardApprovalReason { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
