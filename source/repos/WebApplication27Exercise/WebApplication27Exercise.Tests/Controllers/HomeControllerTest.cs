using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebApplication27Exercise;
using WebApplication27Exercise.Controllers;

namespace WebApplication27Exercise.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
