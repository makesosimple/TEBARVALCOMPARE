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

    //Index(nameof(UserID))]
    [Index(nameof(TransactionMessageID))]
    [Index(nameof(TransactionTypeID))]
    [Index(nameof(ProjectID))]
    [Index(nameof(TransactionLogForUserID))]
    public class TransactionLog
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionLogID { get; set; }

        public int TransactionMessageID { get; set; }
        [ForeignKey("TransactionMessageID")]
        public TransactionMessages TransactionMessage { get; set; }

        public int? TransactionTypeID { get; set; }
        [ForeignKey("TransactionTypeID")]
        public TransactionTypes TransactionType { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(512, ErrorMessage = "Bu alana maksimum 512 karakter girebilirsiniz.")]
        public string TransactionLogMessageContent { get; set; }

        public bool TransactionLogRead { get; set; }

        public string? TransactionLogForUserID { get; set; }
        [ForeignKey("TransactionLogForUserID")]
        public ApplicationUser TransactionLogForUser { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? TransactionLogSlug { get; set; }

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
