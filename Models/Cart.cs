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

    }
}
