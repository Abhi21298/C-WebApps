using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class EmployeesController : Controller
    {
        List<Employee> e1 = new List<Employee>()
        {
            new Employee { Name = "Abhi", EmployeeID = 1, Department = "IT", Salary = 52000.0},
            new Employee { Name = "raj", EmployeeID = 2, Department = "IT", Salary = 52000.0},
            new Employee { Name = "ram", EmployeeID = 3, Department = "IT", Salary = 52000.0},
        };
        // GET: Employees
        public ActionResult Count()
        {
            ViewBag.Count = e1.Count();
            
            return View();
        }

        public ActionResult Display([FromBody]int id)
        {
            Employee emp = e1[id - 1];
            ViewBag.Name = emp.Name;
            return View(emp);
        }
    }
}