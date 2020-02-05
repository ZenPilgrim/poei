using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoursScaffolding;
using CoursScaffolding.Models;

namespace CoursScaffolding.Controllers
{
    public class AdressesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Adresses
        public ActionResult Index()
        {
            var adresse = db.Adresse.Include(a => a.Personne);
            return View(adresse.ToList());
        }

        // GET: Adresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adresse adresse = db.Adresse.Find(id);
            if (adresse == null)
            {
                return HttpNotFound();
            }
            return View(adresse);
        }

        // GET: Adresses/Create
        public ActionResult Create()
        {
            ViewBag.PersonneId = new SelectList(db.Personne, "Id", "Nom");
            return View();
        }

        // POST: Adresses/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Rue,Ville,CodeP,PersonneId")] Adresse adresse)
        {
            if (ModelState.IsValid)
            {
                db.Adresse.Add(adresse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonneId = new SelectList(db.Personne, "Id", "Nom", adresse.PersonneId);
            return View(adresse);
        }

        // GET: Adresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adresse adresse = db.Adresse.Find(id);
            if (adresse == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonneId = new SelectList(db.Personne, "Id", "Nom", adresse.PersonneId);
            return View(adresse);
        }

        // POST: Adresses/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Rue,Ville,CodeP,PersonneId")] Adresse adresse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adresse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonneId = new SelectList(db.Personne, "Id", "Nom", adresse.PersonneId);
            return View(adresse);
        }

        // GET: Adresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adresse adresse = db.Adresse.Find(id);
            if (adresse == null)
            {
                return HttpNotFound();
            }
            return View(adresse);
        }

        // POST: Adresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adresse adresse = db.Adresse.Find(id);
            db.Adresse.Remove(adresse);
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
