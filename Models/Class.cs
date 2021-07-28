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

    public class JobTitle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobTitleID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(256)]
        public string? JobDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}
