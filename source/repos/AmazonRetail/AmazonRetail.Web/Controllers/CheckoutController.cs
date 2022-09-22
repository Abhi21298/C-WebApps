using AmazonRetail.Web.Helpers;
using AmazonWeb.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonRetail.Web.Controllers
{
    public class CheckoutController : Controller
    {   
        [Authorize]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(x => x.Product.UnitPrice * x.Quantity);
            //cart.Clear();
            return View();
        }

        [Authorize]
        public IActionResult PayIndex()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(x => x.Product.UnitPrice * x.Quantity);
            return View();
        }
        [HttpPost]
        public IActionResult PayIndex(Microsoft.AspNetCore.Http.IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                //string name = Request.Form["Name"];
                //string phone = Request.Form["Phone"];
                //string email = Request.Form["Email"];
                //string message = Request.Form["Message"];
                //contact.Add(new Contact { Name = name, Phone = phone, Email = email, Message = message });
                return RedirectToAction("Pay");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Pay()
        {
            HttpContext.Session.Remove("cart");
            return View();
        }
    }
}
