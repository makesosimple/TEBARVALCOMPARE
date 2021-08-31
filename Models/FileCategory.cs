using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{

    [Index(nameof(ParentFileCategoryID))]
    [Index(nameof(UserID))]
    public class FileCategory
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileCategoryID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string FileCategoryTitle { get; set; }

        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string? FileCategoryFolderName { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? FileCategoryDescription { get; set; }

        public int? ParentFileCategoryID { get; set; }
        [ForeignKey("ParentFileCategoryID")]
        public FileCategory ParentFileCategory { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]

        public ApplicationUser User { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
