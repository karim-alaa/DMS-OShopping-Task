using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping.Constants
{
    public class TaxGroups
    {
        public const string TAX_EG = "TAX_EG";
        public const string TAX_USA = "TAX_USA";
        public static Dictionary<string, double> Taxes = new Dictionary<string, double>()
        {
            { TAX_EG, 14 },
            { TAX_USA, 20 }
        };


        public static double GetTaxValue(string taxKey)
        {
            Taxes.TryGetValue(taxKey, out double value);
            return value;
        }
    }
}
