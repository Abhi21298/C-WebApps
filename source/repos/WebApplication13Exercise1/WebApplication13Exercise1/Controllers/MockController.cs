using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13Exercise1.Controllers
{
    public class MockController : Controller
    {
        // GET: MockController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MockController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MockController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MockController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MockController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MockController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MockController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MockController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
