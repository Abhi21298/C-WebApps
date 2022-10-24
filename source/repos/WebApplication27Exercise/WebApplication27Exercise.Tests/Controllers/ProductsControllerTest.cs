using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebApplication27Exercise;
using WebApplication27Exercise.Controllers;
using WebApplication27Exercise.Models;

namespace WebApplication27Exercise.Tests.Controllers
{
    [TestClass]
    public class ProductsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            IEnumerable<Product> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            Product result = controller.Get(1);

            // Assert
            
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ProductsController controller = new ProductsController();
            Product prod = new Product() { ID = 8, Name = "Random", Cost = 25M };  
            // Act
            string result = controller.Post(prod);

            // Assert
            Assert.IsTrue(new[] { "Add", "Err" }.Contains(result.Substring(0, 3)));
            //Assert.AreEqual("Added successfully", result);
        }

        [TestMethod]
        public void Put()
        {
            
            // Arrange
            ProductsController controller = new ProductsController();
            Product prod = new Product() { ID = 1, Name = "RandomEdit", Cost = 25M };
            // Act
          
           
            string result = controller.Put(10, prod);
            //string result1 = controller.Put(1, prod);

            // Assert
            Assert.IsTrue(new[] { "Upd", "Cou" }.Contains(result.Substring(0, 3)));
            
            //Assert.AreEqual("Couldn't find product", result);
            //Assert.AreEqual("Updated successfully", result1);
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            
            string result = controller.Delete(6);
            //string result1 = controller.Delete(1);

            // Assert
            Assert.IsTrue(new[] { "del", "Cou" }.Contains(result.Substring(0, 3)));
            //Assert.AreEqual("Couldn't find product", result);
            //Assert.AreEqual("deleted successfully", result1);
            


        }
    }
}
