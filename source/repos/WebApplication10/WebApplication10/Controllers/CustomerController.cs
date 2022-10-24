using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class CustomerController : Controller
    {
        //public List<Customer> customer = new List<Customer>();
        // GET: Student
        public ActionResult Index()
        {
             List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { Name = "Abhi", Surname = "Rao", Age = 22, Gender = "Male" });
            customer.Add(new Customer { Name = "Jeet", Surname = "Rao", Age = 22, Gender = "Male" });
            customer.Add(new Customer { Name = "SHek", Surname = "Prem", Age = 22, Gender = "Male" });
            return View(customer);
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            Customer customer = new Customer() { Name = "Rajesh", Surname = "Kumar", Age = 25, Gender = "male" };
            return View(customer);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                string name = Request.Form["name"];
                string surname = Request.Form["surname"];
                string age = Request.Form["age"];
                string gender = Request.Form["gender"];
                // TODO: Add insert logic here
                //customer.Add(new Customer { Name = name, Surname = surname, Age = Convert.ToInt32(age), Gender = gender });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            Customer customer = new Customer() { Name = "Rocky", Surname = "Ram", Age = 25, Gender = "male" };
            return View(customer);
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            Customer customer = new Customer() { Name = "Jeet", Surname = "Ram", Age = 15, Gender = "male" };
            return View(customer);
        }

        // POST: Student/Delete/5
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
