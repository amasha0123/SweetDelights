using System.ComponentModel.DataAnnotations;

namespace SweetDelights.Models
{
    public class Cake
    {
        public int CakeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public string Weight { get; set; }

        public bool IsAvailable { get; set; }
    }
}
