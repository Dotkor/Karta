using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Karta.DAL;
using Karta.Models;

namespace Karta.Controllers
{
    public class RutaController : Controller
    {
        private RutaContext db = new RutaContext();


        // GET: Ruta
        public ActionResult Index()
        {
            return View(db.Ruta.ToList());
        }

        // GET: Ruta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.Ruta.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }

            double axx = ruta.Ax;
            ViewBag.kordAx = axx;
            double ayy = ruta.Ay;
            ViewBag.kordAy = ayy;
            double bxx = ruta.Bx;
            ViewBag.kordBx = bxx;
            double byy = ruta.By;
            ViewBag.kordBy = byy;
            return View(db.Ruta.ToList());
        }

        // GET: Ruta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ruta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Rutaid,ime,Ax,Ay,Bx,By")] Ruta ruta)
        {
            if (ModelState.IsValid)
            {
                db.Ruta.Add(ruta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ruta);
        }

        // GET: Ruta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.Ruta.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }
            return View(ruta);
        }

        // POST: Ruta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Rutaid,ime,Ax,Ay,Bx,By")] Ruta ruta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ruta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ruta);
        }

        // GET: Ruta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.Ruta.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }
            return View(ruta);
        }


        // POST: Ruta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ruta ruta = db.Ruta.Find(id);
            db.Ruta.Remove(ruta);
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
