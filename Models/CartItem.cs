using DMSOShopping.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class CartItem
    {
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }

        public Item Item { get; set; }

        public double GetTotalPrice()
        {
            return Item.Price * TaxGroups.GetTaxValue(TaxGroups.TAX_EG) / 100 - Discount.GetDiscountValue(Discount.GROUP_A); 
        }
    }
}
