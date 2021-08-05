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

    [Index(nameof(ParentServiceAreaID))]
    [Index(nameof(UserID))]
    public class ServiceArea
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceAreaID { get; set; }

        [Required]
        [MaxLength(50)]
        public string ServiceAreaTitle { get; set; }

        [MaxLength(256)]
        public string? ServiceAreaDescription { get; set; }

        public int? ParentServiceAreaID { get; set; }
        [ForeignKey("ParentServiceAreaID")]
        public ServiceArea ParentServiceArea { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]

        public ApplicationUser User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
