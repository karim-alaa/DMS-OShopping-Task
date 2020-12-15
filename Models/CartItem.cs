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
    }
}
