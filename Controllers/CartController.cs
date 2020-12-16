using DMSOShopping.Constants;
using DMSOShopping.Helper;
using DMSOShopping.Models;
using DMSOShopping.Services;
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
        private readonly IHelper _helper;

        public CartController(DataContext context, IHttpContextAccessor httpContextAccessor, IHelper helper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _helper = helper;
        }

        // GET: Cart/AddToCart/5
        public async Task<IActionResult> AddToCart(Guid id, int quantity)
        {
            // We can remove all lines that get cart in a spearate function to reuse it
            string CartStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            Cart cart = new Cart();
            Item item = await _context.Items.Where(i => i.Id == id).Include(i => i.UOM).FirstOrDefaultAsync();

            if (!string.IsNullOrEmpty(CartStr))
            {
                cart = JsonConvert.DeserializeObject<Cart>(CartStr);

                if (cart.CartItems != null && cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault() != null)
                {
                    CartItem targetTargetItem = cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault();
                    targetTargetItem.Quantity += quantity;
                    quantity = targetTargetItem.Quantity;
                }
                else
                    cart.CartItems.Add(new CartItem() { ItemId = id, Quantity = quantity });
            }
            else
                cart.CartItems = new List<CartItem>
                {
                    new CartItem() { ItemId = id, Quantity = quantity }
                };

            if (item.Quantity < quantity)
            {
                ViewBag.Error = Messages.E_NO_ENOUGH_ITEMS;
                return View("../Items/Details",item);
            }
            _helper.UpdateCartSession(cart);

            Cart fullCart = await _helper.GetFullCartData();
            return View(nameof(ShowMyCart), fullCart);
        }


        public async Task<IActionResult> UpdateCartItem(Guid id, int quantity)
        {
            string CartStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.CART);
            Cart cart = new Cart();
            if (!string.IsNullOrEmpty(CartStr))
            {
                cart = JsonConvert.DeserializeObject<Cart>(CartStr);

                if (cart.CartItems != null && cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault() != null) 
                {
                    Item item = await _context.Items.Where(i => i.Id == id).FirstOrDefaultAsync();
                    if (item.Quantity >= quantity)
                        cart.CartItems.Where(ci => ci.ItemId == id).FirstOrDefault().Quantity = quantity;
                    else
                        ViewBag.Error = Messages.E_NO_ENOUGH_ITEMS;
                }
                
                _helper.UpdateCartSession(cart);
            }
            Cart fullCart = await _helper.GetFullCartData();
            return View(nameof(ShowMyCart), fullCart);
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

                _helper.UpdateCartSession(cart);
            }

            return RedirectToAction(nameof(ShowMyCart));
        }

        public async Task<IActionResult> ShowMyCart()
        {
            return View(await _helper.GetFullCartData());
        }

        public async Task<IActionResult> AddCouponToCart(string code)
        {
            Discount.Discounts.TryGetValue(code, out double value);

            Cart cart = await _helper.GetFullCartData();
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

            _helper.UpdateCartSession(cart);

            return View(nameof(ShowMyCart), cart);

        }


    }
}
