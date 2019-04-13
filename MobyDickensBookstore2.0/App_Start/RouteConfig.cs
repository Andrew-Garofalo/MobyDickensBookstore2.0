using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MobyDickensBookstore2._0
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        routes.MapRoute(
            name: "Search",
            url: "Search/{id}",
            defaults: new { controller = "Home", action = "Search", id = UrlParameter.Optional }
        );

        routes.MapRoute(
            name: "Book",
            url: "Book/{id}",
            defaults: new { controller = "Home", action = "Book", id = UrlParameter.Optional }
        );


        routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );
    }
}
}
