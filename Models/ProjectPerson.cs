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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectPersonID { get; set; }

        //Check if Attented Person is from Inner Organization or not!
        [Required]
        public bool IsInternal { get; set; }

        //Project ID of the current chosen person
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        //Chosen Person
        public int? PersonID { get; set; }
        [ForeignKey("PersonID")]
        public Person Person { get; set; }

        //Job Title of the Person
        public int? JobTitleID { get; set; }
        [ForeignKey("JobTitleID")]
        public JobTitle JobTitle { get; set; }

        //Job Field of the Person
        public int? JobFieldID { get; set; }
        [ForeignKey("JobFieldID")]
        public JobField JobField { get; set; }

        //If IsInternal is set to false, a Contractor will be chosen by the end user. 
        public int? ContractorID { get; set; }
        [ForeignKey("ContractorID")]
        public Contractor Contractor { get; set; }

        [MaxLength(256)]
        public string? ProjectPersonDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
