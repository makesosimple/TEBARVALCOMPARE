using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        public int TransactionMessageID { get; set; }
        public int TransactionLogID { get; set; }
        public int TransactionTypeID { get; set; }
        public int ProjectID { get; set; }
        
        public string TransactionLogMessageContent { get; set; }

        public bool TransactionLogRead { get; set; }

        public string TransactionLogForUserID { get; set; }

        public string? TransactionLogSlug { get; set; }

        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
