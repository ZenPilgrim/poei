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
    public class CommandesController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Commandes
        public IQueryable<Commande> GetCommandes()
        {
            return db.Commandes;
        }

        // GET: api/Commandes/5
        [ResponseType(typeof(Commande))]
        public IHttpActionResult GetCommande(int id)
        {
            Commande commande = db.Commandes.Find(id);
            if (commande == null)
            {
                return NotFound();
            }

            return Ok(commande);
        }

        // PUT: api/Commandes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCommande(int id, Commande commande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != commande.Num)
            {
                return BadRequest();
            }

            db.Entry(commande).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommandeExists(id))
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

        // POST: api/Commandes
        [ResponseType(typeof(Commande))]
        public IHttpActionResult PostCommande(Commande commande)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Commandes.Add(commande);
            db.SaveChanges();

            return Ok(commande);
            /*return CreatedAtRoute("DefaultApi", new { id = commande.Num }, commande);*/
        }

        // DELETE: api/Commandes/5
        [ResponseType(typeof(Commande))]
        public IHttpActionResult DeleteCommande(int id)
        {
            Commande commande = db.Commandes.Find(id);
            if (commande == null)
            {
                return NotFound();
            }

            db.Commandes.Remove(commande);
            db.SaveChanges();

            return Ok(commande);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CommandeExists(int id)
        {
            return db.Commandes.Count(e => e.Num == id) > 0;
        }
    }
}