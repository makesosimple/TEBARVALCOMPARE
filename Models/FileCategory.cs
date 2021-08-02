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

    [Index(nameof(ParentFileCategoryID))]
    [Index(nameof(UserID))]
    public class FileCategory
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileCategoryID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FileCategoryTitle { get; set; }

        [MaxLength(50)]
        public string? FileCategoryFolderName { get; set; }

        [MaxLength(256)]
        public string? FileCategoryDescription { get; set; }

        public int? ParentFileCategoryID { get; set; }
        [ForeignKey("ParentFileCategoryID")]
        public FileCategory ParentFileCategory { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]

        public IdentityUser User { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
