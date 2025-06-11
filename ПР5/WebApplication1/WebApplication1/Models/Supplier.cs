using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlowerStore.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Flower> Flowers { get; set; }

        public static implicit operator Supplier(string v)
        {
            throw new NotImplementedException();
        }
    }
}
