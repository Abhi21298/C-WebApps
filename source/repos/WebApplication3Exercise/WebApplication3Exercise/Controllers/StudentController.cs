using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3Exercise.Models;

namespace WebApplication3Exercise.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Studentdetails()
        {
            var studdet = new Studentslist();
            //var l1 = studdet.GetStudents();
            studdet.StudID = 1;
            studdet.StudName = "Abhijeet";
            studdet.StudAge = 22;
            return View(studdet);
        }

        public ActionResult FileDisplay()
        {
            return File(Server.MapPath("~/Content/Site.css"),"text/css");
        }

        public ActionResult JSONDisplay(string name = "Indian")
        {
            return Json(new { Message = name , Name = "Abhijeet Rao " },JsonRequestBehavior.AllowGet);
        }

    }
}