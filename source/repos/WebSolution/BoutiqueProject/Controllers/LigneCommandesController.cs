using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BoutiqueProject;
using BoutiqueProject.Models;

namespace BoutiqueProject.Controllers
{
    public class LigneCommandesController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/LigneCommandes
        public IQueryable<LigneCommande> GetLigneCommandes()
        {
            return db.LigneCommandes;
        }

        // GET: api/LigneCommandes/5
        [ResponseType(typeof(LigneCommande))]
        public IHttpActionResult GetLigneCommande(int id)
        {
            LigneCommande ligneCommande = db.LigneCommandes.Find(id);
            if (ligneCommande == null)
            {
                return NotFound();
            }

            return Ok(ligneCommande);
        }

        // PUT: api/LigneCommandes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLigneCommande(int id, LigneCommande ligneCommande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ligneCommande.Num)
            {
                return BadRequest();
            }

            db.Entry(ligneCommande).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LigneCommandeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/LigneCommandes
        [ResponseType(typeof(LigneCommande))]
        public IHttpActionResult PostLigneCommande(LigneCommande ligneCommande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LigneCommandes.Add(ligneCommande);
            db.SaveChanges();

            return Ok(ligneCommande);
            /*return CreatedAtRoute("DefaultApi", new { id = ligneCommande.Num }, ligneCommande);*/
        }

        // DELETE: api/LigneCommandes/5
        [ResponseType(typeof(LigneCommande))]
        public IHttpActionResult DeleteLigneCommande(int id)
        {
            LigneCommande ligneCommande = db.LigneCommandes.Find(id);
            if (ligneCommande == null)
            {
                return NotFound();
            }

            db.LigneCommandes.Remove(ligneCommande);
            db.SaveChanges();

            return Ok(ligneCommande);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LigneCommandeExists(int id)
        {
            return db.LigneCommandes.Count(e => e.Num == id) > 0;
        }
    }
}