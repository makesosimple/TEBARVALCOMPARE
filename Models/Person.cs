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
    public class Person
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        [MaxLength(50)]
        public string PersonName { get; set; }

        [MaxLength(50)]
        public string PersonSurname { get; set; }

        [MaxLength(24)]
        public string PersonPhone { get; set; }

        [MaxLength(256)]
        public string PersonEmail { get; set; }

        public bool PersonInternal
        { get; set; }

        public int JobTitleID { get; set; }

        public int DepartmentID { get; set; }

        public int ContractorID { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}
