using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.Models
{
    public class JobField
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobFieldID { get; set; }

        [Required]
        [MaxLength(50)]
        public string JobFieldTitle { get; set; }

        [MaxLength(256)]
        public string? JobFieldDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
