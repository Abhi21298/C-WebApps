using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8Exercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> l2 = new List<string>();
            l2.Add("Samsung");
            l2.Add("iPhone");
            l2.Add("OnePlus");

            ViewData["Stud"] = l2;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Name = "Jeet";
            ViewBag.Profession = "ASD";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}