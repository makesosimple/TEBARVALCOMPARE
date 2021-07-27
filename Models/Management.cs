﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    
    public class Management
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManagementID { get; set; }

        [MaxLength(256)]
        public string ManagementTitle { get; set; }

        [MaxLength(256)]
        public string ManagementDescription { get; set; }

        [MaxLength(32)]
        public string TaxCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}