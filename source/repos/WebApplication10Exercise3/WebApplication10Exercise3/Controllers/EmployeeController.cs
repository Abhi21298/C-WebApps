using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10Exercise3.Models;
namespace WebApplication10Exercise3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> l1 = new List<Employee>();
            l1.Add(new Employee { EmpName = "A", EmpID = 1, Designation = "B" });
            l1.Add(new Employee { EmpName = "C", EmpID = 2, Designation = "D" });
            l1.Add(new Employee { EmpName = "E", EmpID = 3, Designation = "F" });
            l1.Add(new Employee { EmpName = "G", EmpID = 4, Designation = "H" });
            l1.Add(new Employee { EmpName = "I", EmpID = 5, Designation = "J" });
            return View(l1);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            Employee e1 = new Employee() { EmpName = "C", EmpID = 3, Designation = "MNOPQ" };
            return View(e1);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string empid = Request.Form["EmpID"];
                string empname = Request.Form["EmpName"];
                string Desig = Request.Form["Designation"];
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            Employee e1 = new Employee() { EmpName = "A", EmpID = 1, Designation = "OKQ" };
            return View(e1);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, FormCollection collection)
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            Employee e1 = new Employee() { EmpName = "B", EmpID = 2, Designation = "CDEF" };
            return View(e1);
        }

        // POST: Employee/Delete/5
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
