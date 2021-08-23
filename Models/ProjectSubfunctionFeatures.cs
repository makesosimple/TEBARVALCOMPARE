using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(SubfunctionID))]
    [Index(nameof(SubfunctionFeatureID))]
    [Index(nameof(UserID))]
    public class ProjectSubfunctionFeature
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectSubfunctionFeatureID { get; set; }

        //Current Project that we are on.
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        //Subfunction model to bind to project
        public int? SubfunctionID { get; set; }
        [ForeignKey("SubfunctionID")]
        public Subfunction Subfunction { get; set; }

        //Subfunction Feature 
        public int? SubfunctionFeatureID { get; set; }
        [ForeignKey("SubfunctionFeatureID")]
        public SubfunctionFeature SubfunctionFeature { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string SubfunctionFeatureValue { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? SubfunctionFeatureValueDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
