using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppICC.Data;
using WebAppICC.Views;

namespace WebAppICC.Controllers
{
    public class ICCCricketsController : Controller
    {
        private ICCCricketDbContext db = new ICCCricketDbContext();

        // GET: ICCCrickets
        public ActionResult Index()
        {
            return View(db.ICCCrickets.ToList());
        }

        // GET: ICCCrickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICCCricket iCCCricket = db.ICCCrickets.Find(id);
            if (iCCCricket == null)
            {
                return HttpNotFound();
            }
            return View(iCCCricket);
        }

        // GET: ICCCrickets/Create
        public ActionResult Create()
        {
            return View(new ICCCricket());
        }

        // POST: ICCCrickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,NOWC")] ICCCricket iCCCricket)
        {
            if (ModelState.IsValid)
            {
                db.ICCCrickets.Add(iCCCricket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iCCCricket);
        }

        // GET: ICCCrickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICCCricket iCCCricket = db.ICCCrickets.Find(id);
            if (iCCCricket == null)
            {
                return HttpNotFound();
            }
            return View(iCCCricket);
        }

        // POST: ICCCrickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,NOWC")] ICCCricket iCCCricket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iCCCricket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iCCCricket);
        }

        // GET: ICCCrickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ICCCricket iCCCricket = db.ICCCrickets.Find(id);
            if (iCCCricket == null)
            {
                return HttpNotFound();
            }
            return View(iCCCricket);
        }

        // POST: ICCCrickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ICCCricket iCCCricket = db.ICCCrickets.Find(id);
            db.ICCCrickets.Remove(iCCCricket);
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
