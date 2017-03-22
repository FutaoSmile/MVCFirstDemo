using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //自定义路由
            routes.MapRoute(
               name: "MyRoute",
               url: "{controller}/{action}/{NO}/{Name}",
               defaults: new { controller = "HelloWorld", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
