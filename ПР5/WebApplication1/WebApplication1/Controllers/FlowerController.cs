using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using FlowerStore.Models;

namespace AspNetIdentityApp.Controllers
{
    public class FlowerController : Controller
    {
        private FlowerContext db = new FlowerContext();

        // GET: Flower
        public ActionResult Index()
        {
            var flowers = db.Flowers.Include(f => f.Supplier).ToList();
            return View(flowers);
        }

        // GET: Flower/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Flower flower = db.Flowers.Include(f => f.Supplier).FirstOrDefault(f => f.Id == id);
            if (flower == null) return HttpNotFound();
            return View(flower);
        }

        // GET: Flower/Create
        public ActionResult Create()
        {
            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name");
            return View();
        }

        // POST: Flower/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Category,Price,SupplierId")] Flower flower)
        {
            if (ModelState.IsValid)
            {
                db.Flowers.Add(flower);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", flower.SupplierId);
            return View(flower);
        }

        // GET: Flower/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Flower flower = db.Flowers.Find(id);
            if (flower == null) return HttpNotFound();

            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", flower.SupplierId);
            return View(flower);
        }

        // POST: Flower/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Category,Price,SupplierId")] Flower flower)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flower).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SupplierId = new SelectList(db.Suppliers, "Id", "Name", flower.SupplierId);
            return View(flower);
        }

        // GET: Flower/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Flower flower = db.Flowers.Include(f => f.Supplier).FirstOrDefault(f => f.Id == id);
            if (flower == null) return HttpNotFound();
            return View(flower);
        }

        // POST: Flower/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Flower flower = db.Flowers.Find(id);
            db.Flowers.Remove(flower);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}
