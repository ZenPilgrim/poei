using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAspNet.Controllers
{
    public class SecondController : Controller
    {
        public String Index(string msg, int ? nbr)
        {
            string result = " ";
            for (int i = 0; i < nbr; i++)
            {
                result += msg + " ";
            }
            return result;
        }

    }
}