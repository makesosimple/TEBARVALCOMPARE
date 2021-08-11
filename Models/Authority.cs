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
    //IBB -> Makam
    [Index(nameof(UserID))]
    public class Authority
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorityID { get; set; }

        [Required]
        [MaxLength(256)]
        public string AuthorityTitle { get; set; }

        [MaxLength(256)]
        public string? AuthorityDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
