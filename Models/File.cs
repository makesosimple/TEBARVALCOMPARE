using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    public class File
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileID { get; set; }
        public int ProjectID { get; set; }
        public int FileCategoryID { get; set; }
        public int BiddingID { get; set; }


        [MaxLength(256)]
        public string FileName { get; set; }

        [MaxLength(6)]
        public string FileType { get; set; }

        [MaxLength(512)]
        public string FilePath { get; set; }
        [MaxLength(512)]
        public string FileURL { get; set; }

        public int FileStatus { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
