using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    [Index(nameof(JobTitleID))]
    [Index(nameof(DepartmentID))]
    [Index(nameof(ContractorID))]
    [Index(nameof(UserID))]
    public class Person
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        [MaxLength(50)]
        [Required]
        public string PersonName { get; set; }

        [MaxLength(50)]
        [Required]
        public string PersonSurname { get; set; }

        [MaxLength(24)]
        public string? PersonPhone { get; set; }

        [MaxLength(256)]
        public string? PersonEmail { get; set; }

        [Required]
        public bool isInternal { get; set; } 

        public int? JobTitleID { get; set; }
        [ForeignKey("JobTitleID")]
        public JobTitle JobTitle { get; set; }

        public int? DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }

        public int? ContractorID { get; set; }
        [ForeignKey("ContractorID")]
        public Contractor Contractor { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
