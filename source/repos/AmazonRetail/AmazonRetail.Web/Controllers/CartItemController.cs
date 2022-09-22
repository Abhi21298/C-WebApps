using AmazonRetail.Web.Data;
using AmazonRetail.Web.Helpers;
using AmazonWeb.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AmazonRetail.Web.Controllers
{
    public class CartItemController : Controller
    {
        private readonly ProductContext _context;
        

        public CartItemController(ProductContext context)
        {
            _context = context;


        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            if(cart == null)
            {
                ViewBag.cart = null;
                //ViewBag.total = null;
                return View();
            }
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(x => x.Product.UnitPrice * x.Quantity);
            return View();
        }
        private int isExist(int id)
        {
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            // var prod = await _context.Product.FirstOrDefault(i => i.Id == id);
            if(cart.Count == 0)
            {

            }
            
                for (int i = 0; i < cart.Count; i++)
                {
                    // var prod = _context.Product.Find(id);
                    if (cart[i].ProductId == id)
                    {
                        return i;
                    }

                }
          
                
            
            return -1;
            
        }
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart") == null)
            {
                List<CartItem> cart = new List<CartItem>();
                var prod = _context.Product.Find(id);
                cart.Add(new CartItem { ProductId = prod.Id, Product = prod, Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            else
            {
                List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    var prod = _context.Product.Find(id);
                    cart.Add(new CartItem { ProductId = prod.Id, Product = prod, Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);


            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            if (cart[index].Quantity == 1)
            {
                cart.RemoveAt(index);
                
                //return RedirectToAction("Index");
            }
            else
            {
                cart[index].Quantity--;
            }

            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");



        }

    }
}
