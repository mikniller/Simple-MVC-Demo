using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult Index()
        {
            return View("index2");
        }

        public ActionResult Binding()
        {
            return PartialView("_Binding");
        }

        public ActionResult Validering()
        {
            return PartialView("_Validering");
        }
    }
}