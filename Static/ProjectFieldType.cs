using System;

namespace IBBPortal.Static
{
    interface TProjectField
    {
        public int? ProjectID { get; set; }

        public string UserID { get; set; }
    
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
