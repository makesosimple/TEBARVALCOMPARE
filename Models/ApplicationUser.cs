﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.Models
{
    [Index(nameof(UserID))]
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [PersonalData]
        public byte[]? ProfilePicture { get; set; }

        public string? UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
