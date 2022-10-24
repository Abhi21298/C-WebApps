using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationLAST.Data;
using WebApplicationLAST.Models;

namespace WebApplicationLAST.Controllers
{
    public class StudsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Studs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stud.ToListAsync());
        }

        // GET: Studs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Stud
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stud == null)
            {
                return NotFound();
            }

            return View(stud);
        }

        // GET: Studs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CustomerID,CustomerName,RegisterationDate,orderHistory")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stud);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stud);
        }

        // GET: Studs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Stud.FindAsync(id);
            if (stud == null)
            {
                return NotFound();
            }
            return View(stud);
        }

        // POST: Studs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CustomerID,CustomerName,RegisterationDate,orderHistory")] Stud stud)
        {
            if (id != stud.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stud);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudExists(stud.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(stud);
        }

        // GET: Studs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stud = await _context.Stud
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stud == null)
            {
                return NotFound();
            }

            return View(stud);
        }

        // POST: Studs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stud = await _context.Stud.FindAsync(id);
            _context.Stud.Remove(stud);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudExists(int id)
        {
            return _context.Stud.Any(e => e.ID == id);
        }
    }
}
