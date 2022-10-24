using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10Exercise3.Models;
namespace WebApplication10Exercise3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> st = new List<Student>();
            st.Add(new Student { StudID = 2, StudName = "Abhijeet", Age = 18 });
            st.Add(new Student { StudID = 1, StudName = "Abhishek", Age = 19 });
            st.Add(new Student { StudID = 3, StudName = "Abhiraj", Age = 12 });
            //var Orders = from s in st
            //orderby s.Age
            //group s by s.StudID;
            st = st.OrderBy(s => s.Age).ToList();
            ViewBag.Message = "Ordered by age";  
                    
                                       
            return View(st);
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            Student s1 = new Student() { StudID = 4, StudName = "Ram", Age = 20 };
            return View(s1);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            List<string> st = new List<string>();
            st.Add("Rnadom1");
            st.Add("Rnadom2");
            ViewData["names"] = st;
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string StudID = Request.Form["StudID"];
                string StudName = Request.Form["StudName"];
                string age = Request.Form["Age"];
                
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
            Student s1 = new Student() { StudID = 5, StudName = "Ramu", Age = 21 };
            
            return View(s1);
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
            Student s1 = new Student() { StudID = 5, StudName = "Raj", Age = 14 };
            return View(s1);
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
