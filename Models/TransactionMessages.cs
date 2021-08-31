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

    [Index(nameof(UserID))]
    //[Index(nameof(SubfunctionID))]
    [Index(nameof(TransactionTypeID))]
    public class TransactionMessages
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionMessageID { get; set; }

        public int? TransactionTypeID { get; set; }
        [ForeignKey("TransactionTypeID")]
        public TransactionTypes TransactionType { get; set; }
        
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string TransactionMessageContent { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? TransactionMessageDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        public string? TransactionMessageSlug { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
