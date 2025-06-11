using System.ComponentModel.DataAnnotations;

namespace FlowerStore.Models
{
    public class Flower
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
