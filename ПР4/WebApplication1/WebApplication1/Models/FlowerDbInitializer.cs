using System.Data.Entity;

namespace FlowerStore.Models
{
    public class FlowerDbInitializer : DropCreateDatabaseAlways<FlowerContext>
    {
        protected override void Seed(FlowerContext db)
        {
            db.Flowers.Add(new Flower
            {
                Name = "Троянда червона",
                Category = "Троянди",
                Price = 120
            });

            db.Flowers.Add(new Flower
            {
                Name = "Тюльпан білий",
                Category = "Тюльпани",
                Price = 75
            });

            db.Flowers.Add(new Flower
            {
                Name = "Ромашка польова",
                Category = "Польові",
                Price = 50
            });

            base.Seed(db);
        }
    }
}
