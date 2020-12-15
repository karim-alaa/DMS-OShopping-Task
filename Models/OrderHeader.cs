using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class OrderHeader
    {

        public OrderHeader()
        {
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string TaxCode {get;set;}
        public double TaxValue { get; set; }
        public string DiscountCode { get; set; }
        public double DiscountValue { get; set; }
        public double TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }
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
