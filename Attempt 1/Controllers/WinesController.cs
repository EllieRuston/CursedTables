using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Attempt_1.Data;
using Attempt_1.Models;

namespace Attempt_1.Controllers
{
    public class WinesController : Controller
    {
        private readonly WineZContext _context;

        public WinesController(WineZContext context)
        {
            _context = context;
        }

        // GET: Wines
        public async Task<IActionResult> Index()
        {
              return _context.Wines != null ? 
                          View(await _context.Wines.ToListAsync()) :
                          Problem("Entity set 'WineZContext.Wine'  is null.");
        }
        
        // GET: Wines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Wines == null)
            {
                return NotFound();
            }

            var wine = await _context.Wines
                .FirstOrDefaultAsync(m => m.WineID == id);
            if (wine == null)
            {
                return NotFound();
            }

            return View(wine);
        }

        // GET: Wines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WineId,WineName,Image,Price,Blurb,Quantity,Type,Category")] Wine wine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wine);
        }

        // GET: Wines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Wines == null)
            {
                return NotFound();
            }

            var wine = await _context.Wines.FindAsync(id);
            if (wine == null)
            {
                return NotFound();
            }
            return View(wine);
        }

        // POST: Wines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WineId,WineName,Image,Price,Blurb,Quantity,Type,Category")] Wine wine)
        {
            if (id != wine.WineID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WineExists(wine.WineID))
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
            return View(wine);
        }

        // GET: Wines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Wines == null)
            {
                return NotFound();
            }

            var wine = await _context.Wines
                .FirstOrDefaultAsync(m => m.WineID == id);
            if (wine == null)
            {
                return NotFound();
            }

            return View(wine);
        }

        // POST: Wines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Wines == null)
            {
                return Problem("Entity set 'WineZContext.Wine'  is null.");
            }
            var wine = await _context.Wines.FindAsync(id);
            if (wine != null)
            {
                _context.Wines.Remove(wine);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WineExists(int id)
        {
          return (_context.Wines?.Any(e => e.WineID == id)).GetValueOrDefault();
        }
    }
}
