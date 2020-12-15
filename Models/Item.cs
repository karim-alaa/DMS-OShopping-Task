using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class Item
    {

        public Item()
        {
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Name_FL {get;set;}
        public string Name_SL { get; set; }
        public string Brand { get; set; }
        public bool IsNew { get; set; }
        public double Price { get; set; }
        public bool IsFreeShipping { get; set; }
        public string SellerName { get; set; }
        public string Description { get; set; }
        public string UOM { get; set; }
        public int Quantity { get; set; }


        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateAt { get; set; }
    }
}
