using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class Customer
    {
        public Customer()
        {
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

        public Guid Id { get; set; }
        [DisplayName("Description in English")]
        public string Description_FL { get; set; }
        [DisplayName("Description in Arabic")]
        public string Description_SL { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Is Admin")]
        public bool IsAdmin { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdateAt { get; set; }

        // Relations

        // OrderHeader
        [InverseProperty("Customer")]
        public List<OrderHeader> OrderHeaders { get; set; }

    }
}
