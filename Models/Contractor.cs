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

        public int CityID { get; set; }

        public int DistrictID { get; set; }

        [Required]
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }

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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}
