using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{

    [Index(nameof(ParentServiceAreaID))]
    [Index(nameof(UserID))]
    public class ServiceArea
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceAreaID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string ServiceAreaTitle { get; set; }

        public int? ServiceAreaLevel { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? ServiceAreaDescription { get; set; }

        public int? ParentServiceAreaID { get; set; }
        [ForeignKey("ParentServiceAreaID")]
        public ServiceArea ParentServiceArea { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]

        public ApplicationUser User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
