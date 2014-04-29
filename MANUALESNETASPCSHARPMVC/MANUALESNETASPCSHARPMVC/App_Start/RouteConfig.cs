using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MANUALESNETASPCSHARPMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{parametro1}/{parametro2}",
                defaults: new { controller = "Home", action = "Index", parametro1 = UrlParameter.Optional, parametro2 = UrlParameter.Optional }
            );

            /*routes.MapRoute(
                name: "UsuarioController",
                url: "{controller}/{action}/{parametro1}/{parametro2}",
                defaults: new { parametro1 = UrlParameter.Optional, parametro2 = UrlParameter.Optional }
            );*/
        }
    }
}
