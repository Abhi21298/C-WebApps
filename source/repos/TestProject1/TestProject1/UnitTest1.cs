using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject1
{
    public class Selenium_Demo
    {
        string test_url = "https://www.google.com";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_Search()
        {
            //Assert.Pass();
            driver.Url = test_url;

            System.Threading.Thread.Sleep(2000);

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

            searchText.SendKeys("SSN College of Engineering");

            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));

            searchButton.Click();

            System.Threading.Thread.Sleep(6000);

            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}