using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class ScoreController : Controller
    {
        public ActionResult CreateScore()
        {
            ViewBag.Message = "Klar til at oprette ny ";
            return View(new ScoreModel());
        }

        [HttpPost]
        public ActionResult CreateScore(ScoreModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Ny Score oprettet, gemt i databasen og postet på facebook";
                return View("ShowScore", model);
            }
            else
            {
                ViewBag.Message = "Kunne ikke oprette ny score";
            }
            return View(model);
        }
    }
}