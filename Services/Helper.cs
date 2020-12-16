using DMSOShopping.Constants;
using DMSOShopping.Helper;
using DMSOShopping.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Services
{

    public interface IHelper
    {
        Task<Cart> GetFullCartData(string sessionName = SessionNames.CART);
        void UpdateCartSession(Cart cart, string sessionName = SessionNames.CART);
        void RemoveCartSession();
        Customer GetCustomerData();
    }

    public class Helper : IHelper
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Helper(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public Customer GetCustomerData()
        {
            string customerStr = _httpContextAccessor.HttpContext.Session.GetString(SessionNames.USER);
            if (!string.IsNullOrEmpty(customerStr))
            {
                Customer customer = JsonConvert.DeserializeObject<Customer>(customerStr);
                return customer;
            }
            return new Customer();
        }

        public async Task<Cart> GetFullCartData(string sessionName = SessionNames.CART)
        {
            string CartStr = _httpContextAccessor.HttpContext.Session.GetString(sessionName);
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

        public void UpdateCartSession(Cart cart, string sessionName = SessionNames.CART)
        {
            // Update or add session
            var UpdatedCartItemStr = JsonConvert.SerializeObject(cart);
            _httpContextAccessor.HttpContext.Session.SetString(sessionName, UpdatedCartItemStr);
        }

        public void RemoveCartSession()
        {
            // Remove session
            _httpContextAccessor.HttpContext.Session.Remove(SessionNames.CART);
        }

      


    }
}
