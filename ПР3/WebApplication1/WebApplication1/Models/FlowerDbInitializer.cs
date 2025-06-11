using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FlowerStore.Models
{
    public class FlowerDbInitializer : DropCreateDatabaseAlways<FlowerContext>
    {
        protected override void Seed(FlowerContext db)
        {
            db.Flowers.Add(new Flower { Title = "Троянда", Color = "Червона", Price = 80 });
            db.Flowers.Add(new Flower { Title = "Ромашка", Color = "Біла", Price = 40 });
            db.Flowers.Add(new Flower { Title = "Тюльпан", Color = "Жовтий", Price = 60 });

            base.Seed(db);
        }
    }
}