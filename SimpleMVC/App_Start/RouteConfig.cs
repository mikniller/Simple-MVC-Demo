﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //enable attribute routing
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "home_Edit",
                url: "Edit/{id}",
                defaults: new { controller = "Home", action = "Edit" },
                constraints: new { id = "\\d+" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
         
        }
    }
}