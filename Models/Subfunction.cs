﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    [Index(nameof(UserID))]
    public class Subfunction
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubfunctionID { get; set; }

        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        [MaxLength(50, ErrorMessage = "Bu alana maksimum 50 karakter girebilirsiniz.")]
        public string SubfunctionTitle { get; set; }

        [MaxLength(256, ErrorMessage = "Bu alana maksimum 256 karakter girebilirsiniz.")]
        public string? SubfunctionDescription { get; set; }

        public List<SubfunctionFeature> RelatedSubfunctionFeatures { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }
    }
}
