using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace IBBPortal.Models
{
    [Index(nameof(ProjectID))]
    [Index(nameof(ProjectExpropriationID))]
    [Index(nameof(PropertyStatusID))]
    public class RelProjectPropertyStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? ProjectExpropriationID { get; set; }
        [ForeignKey("ProjectExpropriationID")]
        public ProjectExpropriation ProjectExpropriation { get; set; }

        public int? ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }

        public int? PropertyStatusID { get; set; }
        [ForeignKey("PropertyStatusID")]
        public PropertyStatus PropertyStatus { get; set; }
    }
}
