using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IBBPortal.Models
{

    [Index(nameof(ProjectID))]
    [Index(nameof(SubfunctionID))]
    [Index(nameof(SubfunctionFeatureID))]
    public class ProjectSubfunctionFeatures
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectSubfunctionFeaturesID { get; set; }

        //Current Project that we are on.
        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        //Subfunction model to bind to project
        public int? SubfunctionID { get; set; }
        [ForeignKey("SubfunctionID")]
        public Subfunction Subfunction { get; set; }

        //Subfunction Feature 
        public int? SubfunctionFeatureID { get; set; }
        [ForeignKey("SubfunctionFeatureID")]
        public SubfunctionFeature SubfunctionFeature { get; set; }

        public float SubfunctionFeatureValueFloat { get; set; }
        public string SubfunctionFeatureValueString { get; set; }

        public string SubfunctionFeatureValueDescription { get; set; }



        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DeletionDate { get; set; }

    }
}
