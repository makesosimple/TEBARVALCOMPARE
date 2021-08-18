using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(UserID))]
    public class TransactionTypes
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionTypeID { get; set; }
        
        [Required]
        [MaxLength(64)]
        public string TransactionTypeName { get; set; }

        [MaxLength(256)]
        public string? TransactionTypeDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
