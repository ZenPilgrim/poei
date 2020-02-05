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
    public class PersonnesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Personnes
        public ActionResult Index()
        {
            return View(db.Personne.ToList());
        }

        // GET: Personnes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personne personne = db.Personne.Find(id);
            if (personne == null)
            {
                return HttpNotFound();
            }
            return View(personne);
        }

        // GET: Personnes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personnes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nom,Prenom,Age")] Personne personne)
        {
            if (ModelState.IsValid)
            {
                db.Personne.Add(personne);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personne);
        }

        // GET: Personnes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personne personne = db.Personne.Find(id);
            if (personne == null)
            {
                return HttpNotFound();
            }
            return View(personne);
        }

        // POST: Personnes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nom,Prenom,Age")] Personne personne)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personne).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personne);
        }

        // GET: Personnes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personne personne = db.Personne.Find(id);
            if (personne == null)
            {
                return HttpNotFound();
            }
            return View(personne);
        }

        // POST: Personnes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personne personne = db.Personne.Find(id);
            db.Personne.Remove(personne);
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
