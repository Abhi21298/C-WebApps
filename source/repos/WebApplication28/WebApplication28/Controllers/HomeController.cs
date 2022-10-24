using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication28.Models;

namespace WebApplication28.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static LoginPage lg = new LoginPage();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginTry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginTry(Microsoft.AspNetCore.Http.IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                lg.UserName = Request.Form["UserName"];
                lg.Password = Request.Form["Password"];
                
                //contact.Add(new Contact { Name = name, Phone = phone, Email = email, Message = message });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
