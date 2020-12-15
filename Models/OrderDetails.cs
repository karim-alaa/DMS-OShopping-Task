using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [DisplayName("Total Price")]
        public double TotalPrice { get; set; }
        [DisplayName("Item Price")]
        public double ItemPrice { get; set; }
        public double Tax { get; set; }
        public double Discount { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }
        [ScaffoldColumn(false)]
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

    }
}
