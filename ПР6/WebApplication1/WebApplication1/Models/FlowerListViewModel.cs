using System.Collections.Generic;
using System.Web.Mvc;
using FlowerStore.Models;

namespace WebApplication1.Models
{
    public class FlowerListViewModel
    {
        public IEnumerable<Flower> Flowers { get; set; }
        public SelectList Suppliers { get; set; }
        public int? SelectedSupplierId { get; set; }
    }
}
