using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(ContractorID))]
    [Index(nameof(PersonID))]
    [Index(nameof(UserID))]
    public class ProjectFeasibility
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectFeasibilityID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public bool IsFeasibilityNeeded { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        public int? ContractorID { get; set; }
        [ForeignKey("ContractorID")]
        public Contractor Contractor { get; set; }

        public int? PersonID { get; set; }
        [ForeignKey("PersonID")]
        public Person Person { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string ProjectFeasibilityOutsource { get; set; }

        public DateTime? ProjectFeasibilityDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProjectFeasibilityCost { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
