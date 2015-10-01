using SimpleMVC.Filters;
using SimpleMVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    // [Authorize]
    
    public class ResultController : Controller
    {
        [ActionProfiler]
        public ActionResult Index()
        {
            return View("index1");
        }

        public ActionResult ReturnTypes()
        {
            return PartialView("_returnTypes");
        }

        [OutputCache(Duration = 42)]
        [ActionProfiler(Disable = true)]
        public JavaScriptResult Alert(string message)
        {
            var script = "alert('" + message + " " + DateTime.Now+"')";

            return JavaScript(script);
        }

        public ActionResult ViewResultRedirect()
        {
            TempData["message"] = "Redirect from ViewResultRedirect";
            ViewBag.RedirMessage = "Im lost during action redirect";
            return RedirectToAction("ViewResult");
        }

        public ViewResult ViewResult()
        {
            ViewBag.Message = "View result message";
            return View();
        }

        public PartialViewResult PartialViewResult()
        {
            return PartialView("_PartialViewResult");
        }

        public ContentResult ContentResult()
        {
            return new ContentResult()
            {
                Content = "Response content",
                ContentType = "text/plain"
            };
        }
          [ActionProfiler(Disable = true)]
        public JsonResult JsonResult()
        {
            var data = new
            {
                success = true,
                text = "Alt ok",
                Message = Enumerable.Range(1, 5).Select(r => new
                {
                    no = r,
                    Name = "Number " + r,
                }).ToArray()
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectResult()
        {
            return new RedirectResult("http://www.schantz.com", true);
        }

        public HttpStatusCodeResult HttpStatusCodeResult()
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadGateway);
        }

        public EmptyResult EmptyResult()
        {
            return new EmptyResult();
        }

        [ActionProfiler(Disable=true)]
        public FileContentResult FileContentResult()
        {
            var filename = HttpContext.Server.MapPath("~/Content/timthumb.jpg");
            return new FileContentResult(System.IO.File.ReadAllBytes(filename), "image/jpg");
        }


        public ActionResult PipeLines()
        {
            return PartialView("_PipeLines");
        }

        public ActionResult Routing()
        {
            return PartialView("_Routing");
        }

     

     
    }
}