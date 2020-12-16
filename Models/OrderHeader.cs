using DMSOShopping.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class OrderHeader
    {

        public OrderHeader()
        {
            OrderDate = RequestDate = DueDate = CreatedAt = UpdateAt = DateTime.Now;
            Status = OrderStatuses.PENDING;
        }

        public Guid Id { get; set; }
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Request Date")]
        public DateTime RequestDate { get; set; }
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        [DisplayName("Tax Code")]
        public string TaxCode {get;set;}
        [DisplayName("Tax Value")]
        public double TaxValue { get; set; }
        [DisplayName("Discount Code")]
        public string DiscountCode { get; set; }
        [DisplayName("Discount Value")]
        public double DiscountValue { get; set; }
        [DisplayName("Total Price")]
        public double TotalPrice { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdateAt { get; set; }


        // Relations
        
        // Customer
        public Guid CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        // OrderDetails
        [InverseProperty("OrderHeader")]
        public List<OrderDetails> OrderDetails { get; set; }

    }
}
