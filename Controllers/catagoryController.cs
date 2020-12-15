using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using roshankhadka;

namespace roshankhadka.Controllers
{
    public class catagoryController : Controller
    {
        private Entities5 db = new Entities5();

        // GET: catagory
        public ActionResult Index()
        {
            return View(db.catageories.ToList());
        }

        // GET: catagory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catageory catageory = db.catageories.Find(id);
            if (catageory == null)
            {
                return HttpNotFound();
            }
            return View(catageory);
        }

        // GET: catagory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: catagory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cat_id,cat_name")] catageory catageory)
        {
            if (ModelState.IsValid)
            {

                db.catageories.Add(catageory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(catageory);
        }

        // GET: catagory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catageory catageory = db.catageories.Find(id);
            if (catageory == null)
            {
                return HttpNotFound();
            }
            return View(catageory);
        }

        // POST: catagory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cat_id,cat_name")] catageory catageory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catageory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catageory);
        }

        // GET: catagory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            catageory catageory = db.catageories.Find(id);
            if (catageory == null)
            {
                return HttpNotFound();
            }
            return View(catageory);
        }

        // POST: catagory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            catageory catageory = db.catageories.Find(id);
            db.catageories.Remove(catageory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
     
    }
}
