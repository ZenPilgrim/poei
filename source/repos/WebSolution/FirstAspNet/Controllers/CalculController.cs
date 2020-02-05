using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAspNet.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CalculController : Controller
    {
        // GET: Calcul
        public ActionResult Produit(params int[] n)
        {
            if (n != null)
            {
                int result = 1;
                foreach (int number in n)
                    result *= number;
                ViewBag.result = result;
                return View("Somme");
            }
            else
                return View("Error");
        }
        // GET: Calcul
        public ActionResult Somme(params int[] n)
        {
            if (n != null)
            {
                int result = 0;
                foreach (int number in n)
                    result += number;
                ViewBag.result = result;
                return View();
            }
            else
                return View("Error");
        }
    }
}