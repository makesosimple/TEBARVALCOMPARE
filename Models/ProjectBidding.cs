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
    [Index(nameof(ProjectPhaseID))]
    [Index(nameof(ContractorID))]
    [Index(nameof(DepartmentID))]
    [Index(nameof(UserID))]
    public class ProjectBidding
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectBiddingID { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string BiddingTitle { get; set; }

        public int? ProjectPhaseID { get; set; }
        [ForeignKey("ProjectPhaseID")]
        public ProjectPhase ProjectPhase { get; set; }

        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(32, ErrorMessage = "Bu alana maksimum 32 karakter girebilirsiniz.")]
        public string BiddingCode { get; set; }

        public DateTime? BiddingDate { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BiddingContractCost { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BiddingProgressPayment { get; set; }
         
        public int? ContractorID { get; set; }
        [ForeignKey("ContractorID")]
        public Contractor Contractor { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? BiddingDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
