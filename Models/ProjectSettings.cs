using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IBBPortal.Models
{
    [Index(nameof(ProjectID))]
    [Index(nameof(UserID))]
    public class ProjectSettings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectSettingsID { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
        
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public int Priority { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public bool HideOrShow { get; set; }

        public int? ProjectObjectID { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectUID { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectGlobalID { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectFileNumber { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectPackageNumber { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
