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
    [Index(nameof(SubfunctionID))]
    public class SubfunctionFeature
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubfunctionFeatureID { get; set; }

        [Required]
        [MaxLength(50)]
        public string SubfunctionFeatureTitle { get; set; }

        [MaxLength(256)]
        public string SubfunctionFeatureDescription { get; set; }
        public string SubfunctionMeasurementUnit { get; set; }

        public int SubfunctionID { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
