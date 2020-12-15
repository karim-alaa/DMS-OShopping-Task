using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; }
        public string TaxCode {get;set;}
        public string TaxValue { get; set; }
        public string DiscountCode { get; set; }
        public string DiscountValue { get; set; }

    }
}
