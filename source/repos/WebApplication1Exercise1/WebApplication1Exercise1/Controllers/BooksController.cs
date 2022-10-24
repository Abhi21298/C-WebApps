using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1Exercise1.Models;
namespace WebApplication1Exercise1.Controllers
{
    public class BooksController : Controller
    {
        
        // GET: Books
        public ActionResult Index()
        {
            //ViewData["Name"] = ViewData["name"];
            List<Books> l1 = new List<Books>();
            l1.Add(new Books { BookID = 1, BookName = "HP1", Price = 200.0 });
            l1.Add(new Books { BookID = 2, BookName = "HP2", Price = 200.0 });
            l1.Add(new Books { BookID = 3, BookName = "HP3", Price = 200.0 });
            
            return View(l1);
            
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                
                int bookid = Convert.ToInt32(Request.Form["BookName"]);
                string bookname = Request.Form["BookName"];
                double bookcost = Convert.ToDouble(Request.Form["BookName"]);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
