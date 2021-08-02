using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    [Index(nameof(UserID))]
    public class ProjectStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectStatusID { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProjectStatusTitle { get; set; }

        [MaxLength(256)]
        public string? ProjectStatusDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
