using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(FileCategoryID))]
    [Index(nameof(ProjectBiddingID))]
    [Index(nameof(UserID))]
    public class File
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public int FileUploadType { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        public int? FileCategoryID { get; set; }
        [ForeignKey("FileCategoryID")]
        public FileCategory FileCategory { get; set; }

        public int? ProjectBiddingID { get; set; }
        [ForeignKey("ProjectBiddingID")]
        public ProjectBidding ProjectBidding { get; set; }

        [MaxLength(4096, ErrorMessage = "Bu alana maksimum 4096 karakter girebilirsiniz.")]
        public string? FileTags { get; set; }

        [MaxLength(512, ErrorMessage = "Bu alana maksimum 512 karakter girebilirsiniz.")]
        public string? FileName { get; set; }

        [MaxLength(6, ErrorMessage = "Bu alana maksimum 6 karakter girebilirsiniz.")]
        public string? FileType { get; set; }

        [MaxLength(1024, ErrorMessage = "Bu alana maksimum 1024 karakter girebilirsiniz.")]
        public string? FilePath { get; set; }

        [MaxLength(1024, ErrorMessage = "Bu alana maksimum 1024 karakter girebilirsiniz.")]
        public string? FileURL { get; set; }

        public string? UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
