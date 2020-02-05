using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAspNet.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                ViewData["id"] = id;
                return View();
            }
            else return View("Home");
        }

        /*[Route("~index/{id:int}")]
        public ActionResult Index(int id)
        {
            var list = new List<int>();
            list.Add(2);
            list.Add(1);
            list.Add(7);
            ViewData["list"] = list;
            ViewBag.list = list;

            ViewBag.id = id;
            return View();
        }*/
    }
}