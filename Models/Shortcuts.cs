using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

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

        public string UserID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }
    }
}
