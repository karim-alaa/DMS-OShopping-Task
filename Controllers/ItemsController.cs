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
            return View(await _context.Items.ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .FirstOrDefaultAsync(m => m.Id == id);
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


        // GET: Items/AddToCart/5
        public IActionResult AddToCart(Guid id, int quantity)
        {
            string CartItemStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            List<CartItem> cartItems = new List<CartItem>();
            if (!string.IsNullOrEmpty(CartItemStr))
            {
                cartItems = JsonConvert.DeserializeObject<List<CartItem>>(CartItemStr);
                
                if (cartItems.Where(ci => ci.ItemId == id).FirstOrDefault() != null)
                    cartItems.Where(ci => ci.ItemId == id).FirstOrDefault().Quantity += quantity;
                else
                    cartItems.Add(new CartItem() { ItemId = id, Quantity = quantity});

            }
            else
                cartItems.Add(new CartItem() { ItemId = id, Quantity = quantity });

            // Save new or updated to session
            var UpdatedCartItemStr = JsonConvert.SerializeObject(cartItems);
            _httpContextAccessor.HttpContext.Session.SetString(SessionNames.CART, UpdatedCartItemStr);

            return RedirectToAction(nameof(ListCartData));
        }

        public async Task<IActionResult> ListCartData()
        {
            string CartItemStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            List<CartItem> cartItems = JsonConvert.DeserializeObject<List<CartItem>>(CartItemStr);
            List<Guid> ItemsIds = cartItems.Select(ci => ci.ItemId).ToList();
            List<Item> items = await _context.Items.Where(i => ItemsIds.Contains(i.Id)).AsNoTracking().ToListAsync();
            foreach(CartItem cartItem in cartItems)
            {
                cartItem.Item = items.Where(i => i.Id == cartItem.ItemId).FirstOrDefault();
            }
            return View(cartItems);
        }


    }
}
