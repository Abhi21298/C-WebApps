using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebApplication29;
using WebApplication29.Controllers;
using WebApplication29.Models;

namespace WebApplication29.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IEnumerable<Account> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            Assert.AreEqual(1, result.ElementAt(0).AccountID);
            Assert.AreEqual(2, result.ElementAt(1).AccountID);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            Account result = controller.Get(3);

            // Assert
            Assert.AreEqual(3, result.AccountID);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            Account acc = new Account() { AccountID = 4, Name = "test1", Balance = 5000.0, Type = "Current" };
            // Act
            string result = controller.Post(acc);

            // Assert
            Assert.AreEqual("added successfully", result);
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            Account acc = new Account() { AccountID = 4, Name = "test1edited", Balance = 5000.0, Type = "Current" };
            // Act
            string result = controller.Put(4, acc);
            string result1 = controller.Put(7, acc);

            // Assert
            Assert.AreEqual("updated successfully", result);
            Assert.AreEqual("cannot update", result1);
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Delete(2);
            string result1 = controller.Delete(9);
            // Assert
            Assert.AreEqual("deleted successfully", result);
            Assert.AreEqual("cannot delete", result1);
        }
    }
}
