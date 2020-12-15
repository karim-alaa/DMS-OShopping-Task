using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Models
{
    public class UOM
    {

        public UOM()
        {
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdateAt { get; set; }

    }
}
