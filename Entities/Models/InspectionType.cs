using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class InspectionType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "InspectionType Name is required")]
        [StringLength(20)]
        public string? Name { get; set; }
    }
}