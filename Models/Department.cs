using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    //IBB -> Müdürlük
    [Index(nameof(ParentDepartmentID))]
    [Index(nameof(UserID))]
    public class Department
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }
        
        [Required]
        [MaxLength(128)]
        public string DepartmentTitle { get; set; }

        public int? ParentDepartmentID { get; set; }
        [ForeignKey("ParentDepartmentID")]
        public Department ParentDepartment { get; set; }

        public List<Department> Departments { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
