using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;


namespace TEBARVALCOMPARE.Models
{

    [Index(nameof(CityCode))]
    [Index(nameof(UserID))]
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public int CityCode { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string CityName { get; set; }

        public List<District> RelatedDistricts { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
