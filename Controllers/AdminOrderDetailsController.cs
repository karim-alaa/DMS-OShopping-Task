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
    public class AdminOrderDetailsController : Controller
    {
        private readonly DataContext _context;

        public AdminOrderDetailsController(DataContext context)
        {
            _context = context;
        }

        // GET: AdminOrderDetails
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.OrderDetails.Include(o => o.Item).Include(o => o.OrderHeader);
            return View(await dataContext.ToListAsync());
        }

        // GET: AdminOrderDetails/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails
                .Include(o => o.Item)
                .Include(o => o.OrderHeader)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

        // GET: AdminOrderDetails/Create
        public IActionResult Create()
        {
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Id");
            ViewData["OrderHeaderId"] = new SelectList(_context.OrderHeaders, "Id", "Id");
            return View();
        }

        // POST: AdminOrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity,TotalPrice,ItemPrice,Tax,Discount,OrderHeaderId,ItemId")] OrderDetails orderDetails)
        {
            if (ModelState.IsValid)
            {
                orderDetails.Id = Guid.NewGuid();
                _context.Add(orderDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Id", orderDetails.ItemId);
            ViewData["OrderHeaderId"] = new SelectList(_context.OrderHeaders, "Id", "Id", orderDetails.OrderHeaderId);
            return View(orderDetails);
        }

        // GET: AdminOrderDetails/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails.FindAsync(id);
            if (orderDetails == null)
            {
                return NotFound();
            }
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Id", orderDetails.ItemId);
            ViewData["OrderHeaderId"] = new SelectList(_context.OrderHeaders, "Id", "Id", orderDetails.OrderHeaderId);
            return View(orderDetails);
        }

        // POST: AdminOrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Quantity,TotalPrice,ItemPrice,Tax,Discount,OrderHeaderId,ItemId")] OrderDetails orderDetails)
        {
            if (id != orderDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderDetailsExists(orderDetails.Id))
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
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Id", orderDetails.ItemId);
            ViewData["OrderHeaderId"] = new SelectList(_context.OrderHeaders, "Id", "Id", orderDetails.OrderHeaderId);
            return View(orderDetails);
        }

        // GET: AdminOrderDetails/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetails = await _context.OrderDetails
                .Include(o => o.Item)
                .Include(o => o.OrderHeader)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return View(orderDetails);
        }

        // POST: AdminOrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var orderDetails = await _context.OrderDetails.FindAsync(id);
            _context.OrderDetails.Remove(orderDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderDetailsExists(Guid id)
        {
            return _context.OrderDetails.Any(e => e.Id == id);
        }
    }
}
