using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlasmanShovels.Data;
using PlasmanShovels.Models;

namespace PlasmanShovels.Controllers
{
    public class ShovelsController : Controller
    {
        private readonly PlasmanShovelsContext _context;

        public ShovelsController(PlasmanShovelsContext context)
        {
            _context = context;
        }

        // GET: Shovels
        public async Task<IActionResult> Index(string searchString)
        {
            var shovels = from s in _context.Shovel
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                shovels = shovels.Where(s => s.Usage.Contains(searchString));
            }

            return View(await shovels.ToListAsync());
        }

        // GET: Shovels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shovel = await _context.Shovel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shovel == null)
            {
                return NotFound();
            }

            return View(shovel);
        }

        // GET: Shovels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shovels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company,Usage,Material,Price,Type,Weight,Rating")] Shovel shovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shovel);
        }

        // GET: Shovels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shovel = await _context.Shovel.FindAsync(id);
            if (shovel == null)
            {
                return NotFound();
            }
            return View(shovel);
        }

        // POST: Shovels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company,Usage,Material,Price,Type,Weight,Rating")] Shovel shovel)
        {
            if (id != shovel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShovelExists(shovel.Id))
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
            return View(shovel);
        }

        // GET: Shovels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shovel = await _context.Shovel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shovel == null)
            {
                return NotFound();
            }

            return View(shovel);
        }

        // POST: Shovels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shovel = await _context.Shovel.FindAsync(id);
            _context.Shovel.Remove(shovel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShovelExists(int id)
        {
            return _context.Shovel.Any(e => e.Id == id);
        }
    }
}
