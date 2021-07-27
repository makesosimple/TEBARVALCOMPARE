using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(ProjectPhaseID))]
    [Index(nameof(ContractorID))]
    [Index(nameof(DepartmentID))]
    public class Bidding
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BiddingID { get; set; }
        public int ProjectID { get; set; }
        public int ProjectPhaseID { get; set; }
        [MaxLength(32)]
        public string BiddingCode { get; set; }

        [MaxLength(256)]
        public string BiddingTitle { get; set; }

        [MaxLength(256)]
        public string BiddingDescription { get; set; }
       


        public DateTime? BiddingDate { get; set; }

        [Column(TypeName = "decimal(12, 4)")]
        public decimal BiddingContractCost { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal BiddingProgressPayment { get; set; }

        public int ContractorID { get; set; }
        public int DepartmentID { get; set; }

        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
