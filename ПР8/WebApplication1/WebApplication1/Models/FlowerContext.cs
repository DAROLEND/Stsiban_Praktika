using System.Data.Entity;

namespace FlowerStore.Models
{
    public class FlowerContext : DbContext
    {
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }

}
