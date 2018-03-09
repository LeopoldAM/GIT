using SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["SimpleValue"] = "Simple value Session";
            TempData["SimpleValue"] = "Simple value TempData";
            ViewBag.SimpleValue = "Simple value ViewBag";
            //ViewData['SimpleValue'] = ""; => replaced by ViewBag

            return View();
        }

        public ActionResult ActionSimpleAvecFormulaire()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActionSimpleAvecFormulaire(string value1, string value2)
        {
            ViewBag.Result = $"value 1 : {value1} - value 2 : {value2}";

            return View();
        }

        public ActionResult ActionSimpleAvecFormulairePlusModel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActionSimpleAvecFormulairePlusModel(Message message)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Result = message;
            }
            else
            {
                ViewBag.Result = "Champs non valide";
            }

            return View();
        }

        public ActionResult ActionAvecParametre(int id, string value)
        {
            ViewBag.Result = $"Id : {id} Value : {value}";

            return View();
        }
    }
}