﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{
    [Index(nameof(ShortcutsUserID))]
    [Index(nameof(ShortcutsProjectID))]
    public class Shortcuts
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShortcutsID { get; set; }

        public int ShortcutsType { get; set; }

        public int ShortcutsProjectID { get; set; }
        
        public int ShortcutsUserID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}