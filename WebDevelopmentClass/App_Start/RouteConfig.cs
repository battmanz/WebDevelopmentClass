using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDevelopmentClass
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MinMaxDemo",
                url: "Lesson/MinMaxDemo",
                defaults: new { controller = "Lesson", action = "MinMaxDemo" }
            );

            routes.MapRoute(
                name: "CenteredContentDemo",
                url: "Lesson/CenteredContentDemo",
                defaults: new { controller = "Lesson", action = "CenteredContentDemo" }
            );

            routes.MapRoute(
                name: "FixedPositioningDemo",
                url: "Lesson/FixedPositioningDemo",
                defaults: new { controller = "Lesson", action = "FixedPositioningDemo" }
            );
            
            routes.MapRoute(
                name: "Lessons",
                url: "Lesson/{id}",
                defaults: new { controller = "Lesson", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
