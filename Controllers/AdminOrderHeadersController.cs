﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DMSOShopping.Helper;
using DMSOShopping.Models;
using DMSOShopping.Constants;
using Microsoft.AspNetCore.Authorization;

namespace DMSOShopping.Controllers
{
    [Authorize(Roles = Roles.ADMIN)]
    public class AdminOrderHeadersController : Controller
    {
        private readonly DataContext _context;

        public AdminOrderHeadersController(DataContext context)
        {
            _context = context;
        }

        // GET: AdminOrderHeaders
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.OrderHeaders.Include(o => o.Customer);
            return View(await dataContext.ToListAsync());
        }

        // GET: AdminOrderHeaders/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderHeader = await _context.OrderHeaders
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderHeader == null)
            {
                return NotFound();
            }

            return View(orderHeader);
        }

        // GET: AdminOrderHeaders/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Username");
            return View();
        }

        // POST: AdminOrderHeaders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderDate,RequestDate,DueDate,Status,TaxCode,TaxValue,DiscountCode,DiscountValue,TotalPrice,CustomerId")] OrderHeader orderHeader)
        {
            if (ModelState.IsValid)
            {
                orderHeader.Id = Guid.NewGuid();
                _context.Add(orderHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Username", orderHeader.CustomerId);
            return View(orderHeader);
        }

        // GET: AdminOrderHeaders/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderHeader = await _context.OrderHeaders.FindAsync(id);
            if (orderHeader == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Username", orderHeader.CustomerId);
            return View(orderHeader);
        }

        // POST: AdminOrderHeaders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,OrderDate,RequestDate,DueDate,Status,TaxCode,TaxValue,DiscountCode,DiscountValue,TotalPrice,CustomerId")] OrderHeader orderHeader)
        {
            if (id != orderHeader.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderHeader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderHeaderExists(orderHeader.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Username", orderHeader.CustomerId);
            return View(orderHeader);
        }

        // GET: AdminOrderHeaders/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderHeader = await _context.OrderHeaders
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderHeader == null)
            {
                return NotFound();
            }

            return View(orderHeader);
        }

        // POST: AdminOrderHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var orderHeader = await _context.OrderHeaders.FindAsync(id);
            _context.OrderHeaders.Remove(orderHeader);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderHeaderExists(Guid id)
        {
            return _context.OrderHeaders.Any(e => e.Id == id);
        }
    }
}
