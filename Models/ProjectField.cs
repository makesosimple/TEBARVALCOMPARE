using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace IBBPortal.Models
{
    public class ProjectField
    {
        /** Project Field Tab Information **/
        //Primary Key. Common on all tables
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectFieldID { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        //Check if Project is in İstanbul. If this value is true, districts must come to select accordingly.
        public bool IsProjectInIstanbul { get; set; }

        //Bind project to District Model
        public int? DistrictID { get; set; }
        [ForeignKey("DistrictID")]
        public District District { get; set; }

        //Not required as all project will be displayed on Map but it's for a quick reference.
        [MaxLength(256)]
        public string? ProjectAddress { get; set; }

        //Project Cost. I don't know if this field is required. Ask tomorrow.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ProjectCost { get; set; }

        public double? ProjectArea { get; set; }

        public double? ProjectConstructionArea { get; set; }

        public double? ProjectPaysageArea { get; set; }

        [MaxLength(64, ErrorMessage = "Bu alana maksimum 64 karakter girebilirsiniz.")]
        public string? ProjectPaftaAdaParsel { get; set; }

        //Project Physical Location and Shape (Important as this data will be projected to Map.)
        [Column(TypeName = "varchar(MAX)")]
        public string? KML { get; set; }

        [Column(TypeName = "decimal(9, 6)")]
        public decimal? ProjectLongitude { get; set; }

        [Column(TypeName = "decimal(9, 6)")]
        public decimal? ProjectLatitude { get; set; }

        public Point ProjectPoint { get; set; }

        public LineString ProjectLineString { get; set; }

        public Polygon? ProjectPolygon { get; set; }

        [MaxLength(16000, ErrorMessage = "Bu alana maksimum 16000 karakter girebilirsiniz.")]
        public string? coordinates { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

        /** End of Project Field Tab Information **/
    }
}
