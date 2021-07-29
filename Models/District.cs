﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(CityID))]
    [Index(nameof(UserID))]
    public class District
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DistrictID { get; set; }

        public int DistrictCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string DistrictName { get; set; }

        public int CityID { get; set; }
        [ForeignKey("CityID")]
        public City City { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public IdentityUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
