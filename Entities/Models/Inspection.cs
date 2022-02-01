using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Inspection
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string? Status { get; set; }

        [StringLength(200)]
        public string? Comment { get; set; }

        [StringLength(200)]
        public string? Note { get; set; }

        [ForeignKey(nameof(InspectionType))]
        public int InspectionTypeId { get; set; }

        public InspectionType? InspectionType { get; set; }

    }
}
