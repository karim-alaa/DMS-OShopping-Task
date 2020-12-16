using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DMSOShopping.Helper;
using DMSOShopping.Models;
using Microsoft.AspNetCore.Http;
using DMSOShopping.Constants;
using Newtonsoft.Json;

namespace DMSOShopping.Controllers
{
    public class ItemsController : Controller
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ItemsController(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            return View(await _context.Items.Where(i => i.Quantity > 0).ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Where(m => m.Id == id).Include(i => i.UOM).FirstOrDefaultAsync();
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        private bool ItemExists(Guid id)
        {
            return _context.Items.Any(e => e.Id == id);
        }

 
     


    }
}
