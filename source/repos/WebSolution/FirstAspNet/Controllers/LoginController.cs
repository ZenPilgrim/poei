using FirstAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FirstAspNet.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            var Authentifie = HttpContext.User.Identity.IsAuthenticated;
            ViewData["Authentifie"] = Authentifie;
            Personne personne = null;
            if (Authentifie)
            {
                using (var db = new Model1())
                {
                    personne = (from p in db.Personnes
                                where p.Nom == HttpContext.User.Identity.
                                Name
                                select p).FirstOrDefault();
                }
            }
            return View(personne);
        }

        // POST: Login
        [HttpPost]
        public ActionResult Index(Personne personne, string returnUrl)
        {
            Personne perso = null;
            var Authentifie = HttpContext.User.Identity.IsAuthenticated;
            ViewData["Authentifie"] = Authentifie;
            if (ModelState.IsValid)
            {
                using (var db = new Model1())
                {
                    perso = (from p in db.Personnes
                             where p.Prenom.Equals(personne.Prenom) && p.Password.
                             Equals(personne.Password)
                             select p).FirstOrDefault();
                    if (perso != null)
                    {
                        FormsAuthentication.SetAuthCookie(perso.Nom.ToString(), false);
                        Authentifie = HttpContext.User.Identity.IsAuthenticated;
                        if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(
                        returnUrl))
                            return Redirect(returnUrl);
                        return Redirect("/personne/test");
                    }
                }
            }
            return View(personne);
        }

        public ActionResult Inscription()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inscription(Personne personne)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Model1())
                {
                    db.Personnes.Add(personne);
                    db.SaveChanges();
                }
                FormsAuthentication.SetAuthCookie(personne.Nom.ToString(),
                false);
                return Redirect("Index");
            }
            return View(personne);
        }

        public ActionResult Deconnexion()
        {
            FormsAuthentication.SignOut();
            return Redirect("Index");
        }
    }
}