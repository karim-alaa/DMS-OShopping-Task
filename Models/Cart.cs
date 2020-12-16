using DMSOShopping.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class Cart
    {
        public Cart()
        {
            TaxCode = TaxGroups.TAX_EG;
            TaxValue = TaxGroups.GetTaxValue(TaxCode);
        }
        public List<CartItem> CartItems { get; set; }
        public string TaxCode {get;set;}
        public double TaxValue { get; set; }
        public string DiscountCode { get; set; }
        public double DiscountValue { get; set; }


        public double GetTotalWithTax()
        {
            double total = 0;
            foreach(CartItem cartItem in CartItems)
            {
                total += (cartItem.Item.Price + (cartItem.Item.Price * TaxValue / 100)) * cartItem.Quantity; 
            }
            return Math.Round(total, 2);
        }

        public double GetTotalWithTaxAndDiscount()
        {
            return Math.Round(Math.Max(0, GetTotalWithTax() - DiscountValue), 2); 
        }

    }
}
