using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstAspNet.Models;
using FirstAspNet.ViewModels;

namespace FirstAspNet.Controllers
{
    [Authorize(Roles = "Admin,User")]
    public class PersonneController : Controller
    {
        // GET: Personne
        public ActionResult Test(int? id)
        {
            var liste = new List<int>();
            liste.Add(2);
            liste.Add(1);

            liste.Add(7);

            Personne personne = new Personne()
            {
                Num = 1,
                Nom = "Wick",
                Prenom = "John"
            };
            ViewData["personne"] = personne;
            ViewBag.personne = personne;

            PersonneViewModel personneViewModel = new PersonneViewModel()
            {
                Id = id ?? 5,
                Personne = personne
            };
            return View(personneViewModel);

        }
    }
}