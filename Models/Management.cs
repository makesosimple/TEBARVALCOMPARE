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
    public class Management
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManagementID { get; set; }

        [Required]
        [MaxLength(256)]
        public string ManagementTitle { get; set; }

        [MaxLength(256)]
        public string? ManagementDescription { get; set; }

        [MaxLength(32)]
        public string? TaxCode { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
