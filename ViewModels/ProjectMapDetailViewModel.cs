using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class ProjectMapDetailViewModel
    {
        public string ProjectTitle { get; set; }

        public int? ProjectID { get; set; }

        [Column(TypeName = "decimal(18, 15)")]
        [RegularExpression(@"[+-]?([0-9]*[,])?[0-9]+", ErrorMessage = "xxx,yyyyyyyyyyyyyyy formatında girmeniz gerekiyor!")]
        public decimal? ProjectLongitude { get; set; }

        [Column(TypeName = "decimal(18, 15)")]
        [RegularExpression(@"[+-]?([0-9]*[,])?[0-9]+", ErrorMessage = "xxx,yyyyyyyyyyyyyyy formatında girmeniz gerekiyor!")]
        public decimal? ProjectLatitude { get; set; }

        [MaxLength(16000, ErrorMessage = "Bu alana maksimum 16000 karakter girebilirsiniz.")]
        public string? coordinates { get; set; }
    }
}
