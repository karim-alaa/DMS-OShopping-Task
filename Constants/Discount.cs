using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Constants
{
    public class Discount
    {
        public const string GROUP_A = "c1";
        public const string GROUP_B = "c2";
        public static Dictionary<string, double> Discounts = new Dictionary<string, double>()
        {
            { GROUP_A, 14 },
            { GROUP_B, 20 }
        };

        public static double GetDiscountValue(string discountKey)
        {
            Discounts.TryGetValue(discountKey, out double value);
            return value;
        }
    }
}
