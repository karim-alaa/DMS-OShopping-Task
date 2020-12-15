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
            // We can remove all lines that get cart in a spearate function to reuse it
            string CartStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            Cart cart = new Cart();
            if (!string.IsNullOrEmpty(CartStr))
            {
                cart = JsonConvert.DeserializeObject<Cart>(CartStr);

                if (cart.CartItems != null && cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault() != null)
                    cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault().Quantity += quantity;
                else
                    cart.CartItems.Add(new CartItem() { ItemId = id, Quantity = quantity });
            }
            else
                cart.CartItems = new List<CartItem>
                {
                    new CartItem() { ItemId = id, Quantity = quantity }
                };

            UpdateCartSession(cart);

            return RedirectToAction(nameof(ShowMyCart));
        }


        public IActionResult UpdateCartItem(Guid id, int quantity)
        {
            string CartStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            Cart cart = new Cart();
            if (!string.IsNullOrEmpty(CartStr))
            {
                cart = JsonConvert.DeserializeObject<Cart>(CartStr);

                if (cart.CartItems != null && cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault() != null)
                    cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault().Quantity = quantity;

                UpdateCartSession(cart);
            }

            return RedirectToAction(nameof(ShowMyCart));
        }

        public IActionResult DeleteCartItem(Guid id)
        {
            string CartStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            Cart cart = new Cart();
            if (!string.IsNullOrEmpty(CartStr))
            {
                cart = JsonConvert.DeserializeObject<Cart>(CartStr);

                if (cart.CartItems != null && cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault() != null)
                    cart.CartItems.RemoveAll(i => i.ItemId == id);

                UpdateCartSession(cart);
            }

            return RedirectToAction(nameof(ShowMyCart));
        }

        public async Task<IActionResult> ShowMyCart()
        {
            return View(await FullCartOrDefault());
        }

        public async Task<IActionResult> AddCouponToCart(string code)
        {
            Discount.Discounts.TryGetValue(code, out double value);

            Cart cart = await FullCartOrDefault();
            if (value == 0)
            {
                ModelState.AddModelError(nameof(cart.DiscountCode), "Coupon Code is Wrong");
                return View(nameof(ShowMyCart), cart);
            }
            else
            {
                cart.DiscountCode = code;
                cart.DiscountValue = value;
            }

            UpdateCartSession(cart);

            return View(nameof(ShowMyCart), cart);

        }

        private async Task<Cart> FullCartOrDefault()
        {
            string CartStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            if (!string.IsNullOrEmpty(CartStr))
            {
                Cart cart = JsonConvert.DeserializeObject<Cart>(CartStr);

                List<Guid> ItemsIds = cart.CartItems.Select(ci => ci.ItemId).ToList();
                List<Item> items = await _context.Items.Where(i => ItemsIds.Contains(i.Id)).Include(i => i.UOM).AsNoTracking().ToListAsync();
                foreach (CartItem cartItem in cart.CartItems)
                {
                    cartItem.Item = items.Where(i => i.Id == cartItem.ItemId).FirstOrDefault();
                }
                return cart;
            }
            return new Cart();
        }

        private void UpdateCartSession(Cart cart)
        {
            // Update or add session
            var UpdatedCartItemStr = JsonConvert.SerializeObject(cart);
            _httpContextAccessor.HttpContext.Session.SetString(SessionNames.CART, UpdatedCartItemStr);
        }


    }
}
