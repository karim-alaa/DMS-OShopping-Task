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
    public class AdminItemsController : Controller
    {
        private readonly DataContext _context;

        public AdminItemsController(DataContext context)
        {
            _context = context;
        }

        // GET: AdminItems
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Items.Include(i => i.UOM);
            return View(await dataContext.ToListAsync());
        }

        // GET: AdminItems/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.UOM)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: AdminItems/Create
        public IActionResult Create()
        {
            ViewData["UOMId"] = new SelectList(_context.UOMs, "Id", "Id");
            return View();
        }

        // POST: AdminItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name_FL,Name_SL,Brand,IsNew,Price,IsFreeShipping,SellerName,Description,Quantity,UOMId")] Item item)
        {
            if (ModelState.IsValid)
            {
                item.Id = Guid.NewGuid();
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UOMId"] = new SelectList(_context.UOMs, "Id", "Id", item.UOMId);
            return View(item);
        }

        // GET: AdminItems/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            ViewData["UOMId"] = new SelectList(_context.UOMs, "Id", "Id", item.UOMId);
            return View(item);
        }

        // POST: AdminItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name_FL,Name_SL,Brand,IsNew,Price,IsFreeShipping,SellerName,Description,Quantity,UOMId")] Item item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.Id))
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
            ViewData["UOMId"] = new SelectList(_context.UOMs, "Id", "Id", item.UOMId);
            return View(item);
        }

        // GET: AdminItems/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.UOM)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: AdminItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var item = await _context.Items.FindAsync(id);
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(Guid id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}
