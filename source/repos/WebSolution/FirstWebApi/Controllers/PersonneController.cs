using FirstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FirstWebApi.Controllers
{
    public class PersonneController : ApiController
    {
        List<Personne> personnes = new List<Personne>()
        {
            new Personne { Num = 1, Nom = "Morena", Prenom = "Andreas", Age = 42 },
            new Personne { Num = 2, Nom = "Benamar", Prenom = "Karim", Age = 37 },
            new Personne { Num = 3, Nom = "Paul", Prenom = "Jean", Age = 51 }
        };
        public IEnumerable<Personne> GetAllPersonnes()
        {
            return personnes;
        }

        [ResponseType(typeof(Personne))]
        public IHttpActionResult GetPersonne(int id)
        {
            var personne = personnes.FirstOrDefault((p) => p.Num == id);
            if (personne == null)
            {
                return NotFound();
            }
            return Ok(personne);
        }

        [ResponseType(typeof(Personne))]
        public IHttpActionResult PostPersonne(Personne personne)
        {
            personnes.Add(personne);
            return Ok(personne);
        }

        [ResponseType(typeof(Personne))]
        public IHttpActionResult DeletePersonne(int id)
        {
            Personne personne = personnes.Find(elt => elt.Num
            == id);
            if (personne != null)
            {
                personnes.Remove(personne);
                return Ok(personne);
            }
            return NotFound();
        }

        [ResponseType(typeof(Personne))]
        public IHttpActionResult PutPersonne(int id, Personne personne)
        {
            if (id != personne.Num)
            {
                return BadRequest();
            }
            Personne personneUpd = personnes.Find(elt => elt.Num == id);
            if (personneUpd != null)
            {
                personneUpd = personne;
                return Ok(personneUpd);
            }
            return NotFound();
        }

    }
}
