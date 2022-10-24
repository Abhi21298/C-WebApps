using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1Exercise1.Models;
namespace WebApplication1Exercise1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Name = "Abhijeet";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Name = "Abhijeet";
            return View();
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //string newstring = new string() { "NotsoSecretCode" };
            List<string> newstring = new List<string>();
            newstring.Add("Books");
            newstring.Add("Apples");
            ViewData["name"] = newstring;
            //ViewData["name"] = newstring;
            return View();
        }
    }
}