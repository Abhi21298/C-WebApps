using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployController : Controller
    {
        // GET: Employ
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult details()
        {
            return View();
        }

        public ActionResult Department()
        {
            return View();
        }
    }
}