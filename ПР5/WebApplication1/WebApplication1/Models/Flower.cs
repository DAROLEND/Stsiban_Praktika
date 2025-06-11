using System.ComponentModel.DataAnnotations;

namespace FlowerStore.Models
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }
    }

}
