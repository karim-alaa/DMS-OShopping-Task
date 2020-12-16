using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DMSOShopping.Helper;
using DMSOShopping.Models;
using DMSOShopping.Services;
using Microsoft.AspNetCore.Http;
using DMSOShopping.Constants;
using Newtonsoft.Json;
using Razor.Templating.Core;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace DMSOShopping.Controllers
{
    public class OrdersController : Controller
    {
        private readonly DataContext _context;
        private readonly IHelper _helper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConverter _converter;

        public OrdersController(DataContext context, IHelper helper, IHttpContextAccessor httpContextAccessor, IConverter converter)
        {
            _context = context;
            _helper = helper;
            _httpContextAccessor = httpContextAccessor;
            _converter = converter;
        }


        // GET: Orders/Checkout
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        public async Task<IActionResult> Checkout(double TotalPrice)
        {
            Cart cart = await _helper.GetFullCartData();
            Customer customer = _helper.GetCustomerData();
            
            OrderHeader OrderHeader = new OrderHeader
            { 
                DiscountCode = cart.DiscountCode,
                DiscountValue = cart.DiscountValue,
                TaxCode = cart.TaxCode,
                TaxValue = cart.TaxValue,
                TotalPrice = TotalPrice,
                CustomerId = customer.Id
            };

            List<OrderDetails> orderDetails = new List<OrderDetails>();
            foreach(CartItem cartItem in cart.CartItems)
            {
                orderDetails.Add(new OrderDetails
                {
                    OrderHeader = OrderHeader,
                    ItemId = cartItem.ItemId,
                    Quantity = cartItem.Quantity,
                    Tax = cart.TaxValue,
                    Discount = cart.DiscountValue,
                    TotalPrice = (cartItem.Item.Price + (cartItem.Item.Price * cart.TaxValue / 100)) * cartItem.Quantity
                });
            }

            await _context.OrderHeaders.AddAsync(OrderHeader);
            await _context.OrderDetails.AddRangeAsync(orderDetails);
            await _context.SaveChangesAsync();

            _helper.UpdateCartSession(cart, SessionNames.INVOICE);
            _helper.RemoveCartSession();
            return View("Invoice", cart);
        }



        // GET: Orders/DownloadInvoice
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // Action -> print or donwload
        public async Task<IActionResult> DownloadInvoice(string invoiceAction)
        {
            Cart cart = await _helper.GetFullCartData(SessionNames.INVOICE);

            ViewBag.Action = invoiceAction;

            if (invoiceAction == "print")
                return View("InvoiceToPrint", cart);

            string body = await RazorTemplateEngine.RenderAsync(@"~/Views/Orders/InvoiceToPrint.cshtml", cart);


            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10, Bottom = 10 },
                DocumentTitle = "Invoice"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = body,
                FooterSettings = { FontName = "Arial", FontSize = 10, Left = "DMS-OShopping", Line = true, Right = "Page [page] of [toPage]" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);
            return File(file, "application/pdf", "Invoice.pdf");

        }



     




    }
}
