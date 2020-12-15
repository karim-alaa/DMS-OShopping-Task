using DMSOShopping.Constants;
using DMSOShopping.Helper;
using DMSOShopping.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Controllers
{
    public class CartController : Controller
    {

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly DataContext _context;

        public CartController(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }


        // GET: Cart/AddToCart/5
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
                    cartItems.Add(new CartItem() { ItemId = id, Quantity = quantity });

            }
            else
                cartItems.Add(new CartItem() { ItemId = id, Quantity = quantity });

            // Save new or updated to session
            var UpdatedCartItemStr = JsonConvert.SerializeObject(cartItems);
            _httpContextAccessor.HttpContext.Session.SetString(SessionNames.CART, UpdatedCartItemStr);

            return RedirectToAction(nameof(ShowMyCart));
        }


        public IActionResult UpdateCartItem(Guid id, int quantity)
        {
            string CartItemStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            List<CartItem> cartItems = new List<CartItem>();
            if (!string.IsNullOrEmpty(CartItemStr))
            {
                cartItems = JsonConvert.DeserializeObject<List<CartItem>>(CartItemStr);

                if (cartItems.Where(ci => ci.ItemId == id).FirstOrDefault() != null)
                    cartItems.Where(ci => ci.ItemId == id).FirstOrDefault().Quantity = quantity;

                // Update session
                var UpdatedCartItemStr = JsonConvert.SerializeObject(cartItems);
                _httpContextAccessor.HttpContext.Session.SetString(SessionNames.CART, UpdatedCartItemStr);
            }

            return RedirectToAction(nameof(ShowMyCart));
        }

        public IActionResult DeleteCartItem(Guid id)
        {
            string CartItemStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            List<CartItem> cartItems = new List<CartItem>();
            if (!string.IsNullOrEmpty(CartItemStr))
            {
                cartItems = JsonConvert.DeserializeObject<List<CartItem>>(CartItemStr);

                if (cartItems.Where(ci => ci.ItemId == id).FirstOrDefault() != null)
                   cartItems.RemoveAll(i => i.ItemId == id);

                // Update session
                var UpdatedCartItemStr = JsonConvert.SerializeObject(cartItems);
                _httpContextAccessor.HttpContext.Session.SetString(SessionNames.CART, UpdatedCartItemStr);
            }

            return RedirectToAction(nameof(ShowMyCart));
        }



        public async Task<IActionResult> ShowMyCart()
        {
            string CartItemStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            List<CartItem> cartItems = new List<CartItem>();
            if (!string.IsNullOrEmpty(CartItemStr))
            {
                cartItems = JsonConvert.DeserializeObject<List<CartItem>>(CartItemStr);
                List<Guid> ItemsIds = cartItems.Select(ci => ci.ItemId).ToList();
                List<Item> items = await _context.Items.Where(i => ItemsIds.Contains(i.Id)).Include(i => i.UOM).AsNoTracking().ToListAsync();
                foreach (CartItem cartItem in cartItems)
                {
                    cartItem.Item = items.Where(i => i.Id == cartItem.ItemId).FirstOrDefault();
                }
            }
            return View(cartItems);
        }

      


    }
}
