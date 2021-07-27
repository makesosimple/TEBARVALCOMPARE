﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    public class ProjectPermission
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectPermissionID { get; set; }
        public int ProjectID { get; set; }

        [MaxLength(256)]
        public string ProjectPermissionProvider { get; set; }
       

        public DateTime? ProjectPermissionDate { get; set; }

        [MaxLength(256)]
        public string ProjectPermissionReason { get; set; }

        

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
