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
    [Index(nameof(CityID))]
    [Index(nameof(DistrictID))]
    [Index(nameof(UserID))]
    [Index(nameof(ContractorTypeID))]
    public class Contractor
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractorID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        [MaxLength(32)]
        public string TaxCode { get; set; }

        [MaxLength(32)]
        public string TaxOffice { get; set; }

        public int? CityID { get; set; }
        [ForeignKey("CityID")]
        public City City { get; set; }

        public int? DistrictID { get; set; }
        [ForeignKey("DistrictID")]
        public District District { get; set; }

        public int ContractorTypeID { get; set; }
        [ForeignKey("ContractorTypeID")]
        public ContractorType ContractorType { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [MaxLength(32)]
        public string PhoneNumber { get; set; }

        #nullable enable
        [MaxLength(256)]
        public string? Description { get; set; }

        [MaxLength(256)]
        public string? Address { get; set; }

        [MaxLength(128)]
        public string? Email { get; set; }

        [MaxLength(256)]
        public string? Website { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
