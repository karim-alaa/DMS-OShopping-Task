using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class OrderDetails
    {

        public OrderDetails()
        {
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double ItemPrice { get; set; }
        public double Tax { get; set; }
        public double Discount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }

        // Relations

        // Order
        public Guid OrderHeaderId { get; set; }
        [ForeignKey("OrderHeaderId")]
        public OrderHeader OrderHeader { get; set; }

        // Item
        [ForeignKey("ItemId")]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }

        // UOM
        [ForeignKey("UOMId")]
        public Guid UOMId { get; set; }
        public UOM UOM { get; set; }

    }
}
