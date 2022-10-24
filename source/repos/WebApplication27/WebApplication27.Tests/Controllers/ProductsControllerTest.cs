using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication27.Controllers;
using WebApplication27.Models;

namespace WebApplication27.Tests.Controllers
{
    [TestClass]
    public class ProductsControllerTest
    {
        [TestMethod]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = GetTestproducts();
            var controller = new ProductsController(testProducts);

            var result = controller.GetAllProducts() as List<Product>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public async Task GetAllProductsAsync_ShouldReturnAllProducts()
        {
            var testProducts = GetTestproducts();
            var controller = new ProductsController(testProducts);

            var result = await controller.GetAllProductsAsync() as List<Product>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public void GetProduct_ShouldReturnCorrectProducts()
        {
            var testProducts = GetTestproducts();
            var controller = new ProductsController(testProducts);

            var result = controller.GetProduct(4);
            Assert.IsNotNull(result);
            //Assert.AreEqual(testProducts.Count, result.Count);
        }

        [TestMethod]
        public void GetProduct_ShouldNotFindProduct()
        {
            var testProducts = GetTestproducts();
            var controller = new ProductsController(testProducts);

            var result = controller.GetProduct(999);
          
            //Assert.IsInstanceOfType(result, typeof(Nullable));
            //Assert.Fail(result);
            Assert.IsNull(result);
            //Assert.AreEqual(testProducts.Count, result.Count);
        }
        private List<Product> GetTestproducts()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product { ID = 1, Name = "Demo1", Price = 1 });
            testProducts.Add(new Product { ID = 2, Name = "Demo2", Price = 13.65M });
            testProducts.Add(new Product { ID = 3, Name = "Demo3", Price = 12M });
            testProducts.Add(new Product { ID = 4, Name = "Demo4", Price = 11M });
            return testProducts;
        }
    }
}
