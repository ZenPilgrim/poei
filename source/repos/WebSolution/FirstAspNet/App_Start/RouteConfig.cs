using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstAspNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // activer le routage par decorateur
            // routes.MapMvcAttributeRoutes();

            /*routes.MapRoute(
                name: "Second",
                url: "second/{msg}/{nbr}",
                defaults: new
                {
                    controller = "Second",
                    action = "Index",
                    msg = UrlParameter.Optional,
                    nbr = UrlParameter.Optional
                });*/


            routes.MapRoute(
                name: "Calcul",
                url: "{controller}/{action}/{n}",
                //url: "{controller}/{action}/{*chaine de carac}",
                defaults: new
                {
                    controller = "Calcul",
                    action = UrlParameter.Optional,
                    n = UrlParameter.Optional
                });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index",
                    id = UrlParameter.Optional
                }//, constraints: new { id = @"\d+" }
            );
        }
    }
}
