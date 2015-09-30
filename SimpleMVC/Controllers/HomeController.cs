using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
  
    public class HomeController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(new AboutModel());
        }

       
        public ActionResult Edit(int id)
        {
            return View(id);
        }

        [Route("EditMed10")]
        public ActionResult xxx(int id)
        {
            return RedirectToAction("Edit",new {id=10});
        }

        public ActionResult Info(int categoryId)
        {
            if (categoryId > 3)
                return new HttpStatusCodeResult(404);
            ViewBag.no = categoryId;
            return PartialView("info");
        }

        public ActionResult ToggleStyle()
        {
            if (Session["style"] == null)
                Session["style"] = "1";
            else
                Session.Remove("style");
            return RedirectToAction("Index");
        }

    }
}