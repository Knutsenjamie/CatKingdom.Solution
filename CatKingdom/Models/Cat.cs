using System.ComponentModel.DataAnnotations;

namespace CatKingdom.Models
{
    public class Cat
    {
        public int CatId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0, 23, ErrorMessage = "Age must be between 0 and 23.")]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}