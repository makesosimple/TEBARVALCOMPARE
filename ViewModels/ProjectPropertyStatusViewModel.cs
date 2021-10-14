using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.ViewModels
{
    public class ProjectPropertyStatusViewModel
    {
        public int? ProjectID { get; set; }

        public int PropertyStatusID { get; set; }

        public string PropertyStatusTitle { get; set; }
    }
}
