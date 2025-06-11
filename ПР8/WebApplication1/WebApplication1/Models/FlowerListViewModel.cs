using System.Web.Mvc;
using FlowerStore.Models;
using PagedList;           
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class FlowerListViewModel
    {
        public IPagedList<Flower> Flowers { get; set; }

        public SelectList Suppliers { get; set; }
        public int? SelectedSupplierId { get; set; }
    }
}
