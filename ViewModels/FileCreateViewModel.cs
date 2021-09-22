using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class FileCreateViewModel
    {
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public int FileUploadType { get; set; }

        public int? ProjectID { get; set; }

        public int? FileCategoryID { get; set; }

        public int? ProjectBiddingID { get; set; }

        [MaxLength(1024, ErrorMessage = "Bu alana maksimum 1024 karakter girebilirsiniz.")]
        public string? FileURL { get; set; }

    }
}
