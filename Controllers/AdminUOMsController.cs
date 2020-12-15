using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DMSOShopping.Helper;
using DMSOShopping.Models;

namespace DMSOShopping.Controllers
{
    public class AdminUOMsController : Controller
    {
        private readonly DataContext _context;

        public AdminUOMsController(DataContext context)
        {
            _context = context;
        }

        // GET: AdminUOMs
        public async Task<IActionResult> Index()
        {
            return View(await _context.UOMs.ToListAsync());
        }

        // GET: AdminUOMs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uOM = await _context.UOMs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uOM == null)
            {
                return NotFound();
            }

            return View(uOM);
        }

        // GET: AdminUOMs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminUOMs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] UOM uOM)
        {
            if (ModelState.IsValid)
            {
                uOM.Id = Guid.NewGuid();
                _context.Add(uOM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uOM);
        }

        // GET: AdminUOMs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uOM = await _context.UOMs.FindAsync(id);
            if (uOM == null)
            {
                return NotFound();
            }
            return View(uOM);
        }

        // POST: AdminUOMs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Description")] UOM uOM)
        {
            if (id != uOM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uOM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UOMExists(uOM.Id))
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
            return View(uOM);
        }

        // GET: AdminUOMs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uOM = await _context.UOMs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uOM == null)
            {
                return NotFound();
            }

            return View(uOM);
        }

        // POST: AdminUOMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var uOM = await _context.UOMs.FindAsync(id);
            _context.UOMs.Remove(uOM);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UOMExists(Guid id)
        {
            return _context.UOMs.Any(e => e.Id == id);
        }
    }
}
