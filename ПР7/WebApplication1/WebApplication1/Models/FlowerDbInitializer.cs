using System.Data.Entity;

namespace FlowerStore.Models
{
    public class FlowerDbInitializer : DropCreateDatabaseAlways<FlowerContext>
    {
        protected override void Seed(FlowerContext db)
        {
            var s1 = new Supplier { Name = "Квіти України" };
            var s2 = new Supplier { Name = "Flora Import" };

            db.Suppliers.Add(s1);
            db.Suppliers.Add(s2);

            db.Flowers.Add(new Flower
            {
                Name = "Троянда червона",
                Category = "Троянди",
                Price = 120,
                Supplier = s1
            });

            db.Flowers.Add(new Flower
            {
                Name = "Тюльпан білий",
                Category = "Тюльпани",
                Price = 75,
                Supplier = s2
            });

            db.Flowers.Add(new Flower
            {
                Name = "Ромашка польова",
                Category = "Польові",
                Price = 50,
                Supplier = s1
            });


            db.Flowers.Add(new Flower
            {
                Name = "Лаванда фіолетова",
                Category = "Ароматні",
                Price = 90,
                Supplier = s1
            });

            db.Flowers.Add(new Flower
            {
                Name = "Орхідея білосніжна",
                Category = "Орхідеї",
                Price = 150,
                Supplier = s2
            });

            db.Flowers.Add(new Flower
            {
                Name = "Нарцис жовтий",
                Category = "Польові",
                Price = 60,
                Supplier = s1
            });

            db.Flowers.Add(new Flower
            {
                Name = "Гіацинт рожевий",
                Category = "Весняні",
                Price = 80,
                Supplier = s2
            });

            base.Seed(db);
        }
    }
}
