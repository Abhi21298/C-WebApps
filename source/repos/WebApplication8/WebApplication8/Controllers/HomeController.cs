using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> students = new List<string>();
            students.Add("Abhi");
            students.Add("jeet");
            students.Add("shek");

            ViewData["Students"] = students;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            ViewBag.Name = "Abhijeet";

            ViewBag.Location = "Chennai";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}