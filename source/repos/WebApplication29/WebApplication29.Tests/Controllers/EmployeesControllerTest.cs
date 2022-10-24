using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using WebApplication29.Controllers;
using WebApplication29.Models;

namespace WebApplication29.Tests.Controllers
{
    [TestClass]
    public class EmployeesControllerTest
    {
        [TestMethod]
        public void Count()
        {
            EmployeesController controller = new EmployeesController();

            // Act
            ViewResult result = controller.Count() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ViewBag.Count);
        }

        [TestMethod]
        public void Display()
        {
            EmployeesController controller = new EmployeesController();
            Employee ep = new Employee { Name = "Abhi", EmployeeID = 1, Department = "IT", Salary = 52000.0 };

            // Act
            ViewResult result = controller.Display(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(ep.Name, result.ViewBag.Name);
        }
    }
}
