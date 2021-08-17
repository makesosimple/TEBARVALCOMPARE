using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    [Index(nameof(UserID))]
    [Index(nameof(SubfunctionID))]
    public class SubfunctionFeature
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubfunctionFeatureID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string SubfunctionFeatureTitle { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? SubfunctionFeatureDescription { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string SubfunctionMeasurementUnit { get; set; }

        public int? SubfunctionID { get; set; }
        [ForeignKey("SubfunctionID")]
        public Subfunction Subfunction { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
