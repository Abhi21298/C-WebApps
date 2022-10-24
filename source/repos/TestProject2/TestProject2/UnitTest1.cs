using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject2
{
    public class Tests
    {
        string test_url = "http://localhost:48572/Home/Login";
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

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'Uname']"));

            searchText.SendKeys("User1Abhi");

            IWebElement searchText1 = driver.FindElement(By.CssSelector("[name = 'Pass']"));

            searchText1.SendKeys("Password123!");

            IWebElement searchButton = driver.FindElement(By.LinkText("Log in"));

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