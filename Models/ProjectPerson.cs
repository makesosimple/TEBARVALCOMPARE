using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.Models
{
    public class ProjectPerson
    {
        public int ProjectPersonID { get; set; }

        public int JobFieldID { get; set; }

        public int ProjectID { get; set; }

        public int ContractorID { get; set; }

        public int JobTitleID { get; set; }

        public string? ProjectPersonDescription { get; set; }

        public bool IsInternal { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
