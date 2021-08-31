﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{

    [Index(nameof(UserID))]
    public class ZoningPlanModificationStatus
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZoningPlanModificationStatusID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string ZoningPlanModificationStatusTitle { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? ZoningPlanModificationStatusDescription { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

    }
}
