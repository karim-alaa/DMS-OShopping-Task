using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Name in English")]
        public string Name_FL {get;set;}
        [DisplayName("Name in Arabic")]
        public string Name_SL { get; set; }
        public string Brand { get; set; }
        [DisplayName("Is New")]
        public bool IsNew { get; set; }
        public double Price { get; set; }
        [DisplayName("Is Free Shipping")]
        public bool IsFreeShipping { get; set; }
        [DisplayName("Seller Name")]
        public string SellerName { get; set; }
        public string Description { get; set; }
        [DisplayName("Avaliable in Stock")]
        public int Quantity { get; set; }


        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdateAt { get; set; }

        // UOM
        [ForeignKey("UOMId")]
        public Guid UOMId { get; set; }
        public UOM UOM { get; set; }

    }
}
