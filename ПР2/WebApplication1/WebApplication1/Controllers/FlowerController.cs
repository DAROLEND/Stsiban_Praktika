using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FlowerStore.Models;

namespace FlowerStore.Controllers
{
    public class FlowerController : Controller
    {
        FlowerContext db = new FlowerContext();

        public ActionResult Index()
        {
            ViewBag.Flowers = db.Flowers;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.FlowerId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Дякуємо, " + purchase.Person + ", за покупку!";
        }
    }
}