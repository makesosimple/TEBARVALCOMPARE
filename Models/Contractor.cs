using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    [Index(nameof(CityID))]
    [Index(nameof(DistrictID))]
    [Index(nameof(UserID))]
    [Index(nameof(ContractorTypeID))]
    public class Contractor
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractorID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string Title { get; set; }

        [MaxLength(32, ErrorMessage = "Bu alana maksimum 32 karakter girebilirsiniz.")]
        public string TaxCode { get; set; }

        [MaxLength(32, ErrorMessage = "Bu alana maksimum 32 karakter girebilirsiniz.")]
        public string TaxOffice { get; set; }

        public int? CityID { get; set; }
        [ForeignKey("CityID")]
        public City City { get; set; }

        public int? DistrictID { get; set; }
        [ForeignKey("DistrictID")]
        public District District { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public int ContractorTypeID { get; set; }
        [ForeignKey("ContractorTypeID")]

        public ContractorType ContractorType { get; set; }

        public List<Person> RelatedPeople{ get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [MaxLength(32, ErrorMessage = "Bu alana maksimum 32 karakter girebilirsiniz.")]
        public string PhoneNumber { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? Description { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? Address { get; set; }

        [MaxLength(128, ErrorMessage = "Bu alana maksimum 128 karakter girebilirsiniz.")]
        public string? Email { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? Website { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
