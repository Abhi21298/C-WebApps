using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string name = "Indian")
        {
            return Content("the name of the cuisine is:" + name);
        }
    }
}