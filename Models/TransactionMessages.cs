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
    [Index(nameof(SubfunctionID))]
    public class TransactionMessages
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionMessageID { get; set; }
        public int TransactionTypeID { get; set; }
        
        public string TransactionMessageContent { get; set; }

        [MaxLength(256)]
        public string TransactionMessageDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
