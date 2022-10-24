using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult ProductsDetails(string name  = "Tea")
        {
            var prod = new ProductDetails();
            prod.ProductID = 1;
            prod.ProductName = name;
            prod.Cost = 400.0;
            return View(prod);
        }

        public ActionResult redirectingpage(string name = "Random")
        {
            //return RedirectToAction("Index", "Product", new { name = name });
            //return RedirectToRoute("Default", new { Controller = "Home", action = "About" });
            return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = name, name = "Abhijeet Rao " }, JsonRequestBehavior.AllowGet);
        }

       
    }
}