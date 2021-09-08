using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    //IBB -> Müdürlük
    [Index(nameof(ParentDepartmentID))]
    [Index(nameof(UserID))]
    public class Department
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }
        
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(128, ErrorMessage = "Bu alana maksimum 128 karakter girebilirsiniz.")]
        public string DepartmentTitle { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? MapIcon { get; set; }

        public int? ParentDepartmentID { get; set; }
        [ForeignKey("ParentDepartmentID")]
        public Department ParentDepartment { get; set; }

        public List<Person> RelatedPeople { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
