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

    [Index(nameof(UserID))]
    public class ContractorType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractorTypeID { get; set; }

        [Required]
        [MaxLength(50)]
        public string ContractorTypeTitle { get; set; }

        [MaxLength(50)]
        public string? ContractorTypeDescription { get; set; }

        public List<Contractor> RelatedContractors { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
