﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    [Index(nameof(User))]
    public class Organization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrganizationID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur."), MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string OrganizationTitle { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? OrganizationDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
