using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class AdvancedController : Controller
    {
        // GET: Advanced
        public ActionResult Index()
        {
            return View("index4");
        }


        public ActionResult Validate()
        {
            return PartialView("_Validate");
        }

        public ActionResult Filters()
        {
            return PartialView("_Filters");
        }

        public ActionResult Areas()
        {
            return PartialView("_Areas");
        }

        public ActionResult Unity()
        {
            return PartialView("_Unity");
        }


    }
}