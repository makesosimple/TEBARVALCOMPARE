using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IBBPortal.Models
{
    [Index(nameof(ProjectID))]
    [Index(nameof(UserID))]
    public class ProjectProduction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectProductionID { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        public DateTime? FoundationDate { get; set; }

        public DateTime? OpeningDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Cost { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? EstimatedCost { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ApproximateCost { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ContractCost { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ContractIncrementCost { get; set; }

        public DateTime? ApproximateCostDate { get; set; }

        public DateTime? ContractStartingDate { get; set; }

        public DateTime? StartingDate { get; set; }

        public DateTime? ContractEndingDate { get; set; }

        public DateTime? EndingDate { get; set; }
        
        public int? PhysicalCompletionRatio { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalProgressPaymentCost { get; set; }

        public int? MonetaryCompletionRatio { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
