#pragma checksum "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "011fa9164a8e8ff60dc50c582c27de48d43118ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ShowMyCart), @"mvc.1.0.view", @"/Views/Cart/ShowMyCart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\karim\source\repos\DMSOShopping\Views\_ViewImports.cshtml"
using DMSOShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karim\source\repos\DMSOShopping\Views\_ViewImports.cshtml"
using DMSOShopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"011fa9164a8e8ff60dc50c582c27de48d43118ce", @"/Views/Cart/ShowMyCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ea659fc5b693f625f31e98052bfd1ebcae7a25", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_ShowMyCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DMSOShopping.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-item-product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline py-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCouponToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-style-1 btn-secondary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-style-1 btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("checkout-address.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
  
    ViewData["Title"] = "My Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>My Cart</h1>\r\n\r\n<div>\r\n");
#nullable restore
#line 12 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
     if (Model.CartItems == null || Model.CartItems.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h> You have not items in your cart.</h>\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011fa9164a8e8ff60dc50c582c27de48d43118ce10081", async() => {
                WriteLiteral("Discover More Items");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
    }
    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">
        <div class=""container pb-5 mb-2"">
            <!-- Alert-->
            <div class=""alert alert-info alert-dismissible fade show text-center mb-30""><span class=""alert-close"" data-dismiss=""alert""></span><i class=""fe-icon-award""></i>&nbsp;&nbsp;New Free Coupons <strong>C1 and C2</strong>, Save from $50 to $100! </div>
");
#nullable restore
#line 25 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
               double TotalCartPrice = 0; double TotalCartPriceWithDiscount = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
             foreach (CartItem cartItem in @Model.CartItems)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Cart Item-->\r\n                <div class=\"cart-item d-md-flex justify-content-between\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011fa9164a8e8ff60dc50c582c27de48d43118ce13121", async() => {
                WriteLiteral(" <span class=\"remove-item\"><i class=\"fa fa-times\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                           WriteLiteral(cartItem.ItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"px-3 my-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011fa9164a8e8ff60dc50c582c27de48d43118ce15643", async() => {
                WriteLiteral("\r\n                            <div class=\"cart-item-product-info\">\r\n                                <h4 class=\"cart-item-product-title\">");
#nullable restore
#line 35 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                               Write(cartItem.Item.Name_FL);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 35 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                        Write(cartItem.Item.Name_SL);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4><span><strong>UOM:</strong> ");
#nullable restore
#line 35 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                                                               Write(cartItem.Item.UOM.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span><span>\r\n                                    <strong>Free Shipping:</strong> ");
#nullable restore
#line 36 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                     if (cartItem.Item.IsFreeShipping)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>YES</span>");
#nullable restore
#line 37 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                     }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>NO</span>");
#nullable restore
#line 39 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                   WriteLiteral(cartItem.Item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"px-3 my-3 text-center\">\r\n                        <div class=\"cart-item-label\">Quantity</div>\r\n\r\n\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011fa9164a8e8ff60dc50c582c27de48d43118ce20532", async() => {
                WriteLiteral("\r\n                            <input name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2386, "\"", 2410, 1);
#nullable restore
#line 49 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
WriteAttributeValue("", 2394, cartItem.ItemId, 2394, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" class=\"form-control\" />\r\n                            <div class=\"input-group mb-3\">\r\n                                <input type=\"number\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 2579, "\"", 2605, 1);
#nullable restore
#line 51 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
WriteAttributeValue("", 2587, cartItem.Quantity, 2587, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" min=""1"" max=""10"" class=""form-control"" />
                                <div class=""input-group-append"">
                                    <button type=""submit"" rel=""tooltip"" class=""btn btn-outline-secondary""><i class=""fa fa-pencil""></i></button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    </div>\r\n                    <div class=\"px-3 my-3 text-center\">\r\n                        <div class=\"cart-item-label\">PRICE</div><span class=\"text-xl font-weight-medium\">$");
#nullable restore
#line 65 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                     Write(cartItem.Item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"px-3 my-3 text-center\">\r\n                        <div class=\"cart-item-label\">TAX</div><span class=\"text-xl font-weight-medium\">");
#nullable restore
#line 68 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                  Write(Model.TaxValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                    <div class=\"px-3 my-3 text-center\">\r\n");
#nullable restore
#line 72 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                           double total = (cartItem.Item.Price + (cartItem.Item.Price * Model.TaxValue / 100)) * cartItem.Quantity;
                            TotalCartPrice += total;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"cart-item-label\">TOTAL</div><span class=\"text-xl font-weight-medium\">$");
#nullable restore
#line 75 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                     Write(Math.Round(total, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 78 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
               TotalCartPriceWithDiscount = TotalCartPrice - Model.DiscountValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
             if (!string.IsNullOrEmpty(Model.DiscountCode))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 86 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                 Write(Model.DiscountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Coupon Applied, You Will Save Total Of $");
#nullable restore
#line 86 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                             Write(Model.DiscountValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 87 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <!-- Coupon + Subtotal-->\r\n            <div class=\"d-sm-flex justify-content-between align-items-center text-center text-sm-left\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011fa9164a8e8ff60dc50c582c27de48d43118ce27211", async() => {
                WriteLiteral("\r\n                    <label class=\"sr-only\">Coupon code</label>\r\n                    <input class=\"form-control form-control-sm my-2 mr-3\" name=\"code\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 4620, "\"", 4647, 1);
#nullable restore
#line 94 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
WriteAttributeValue("", 4628, Model.DiscountCode, 4628, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"c1 or c2\"");
                BeginWriteAttribute("required", " required=\"", 4671, "\"", 4682, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011fa9164a8e8ff60dc50c582c27de48d43118ce28225", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 95 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DiscountCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" &nbsp;\r\n                    <button class=\"btn btn-style-1 btn-secondary btn-sm my-2 mx-auto mx-sm-0\" type=\"submit\">Apply Coupon</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"py-2\"><span class=\"d-inline-block align-middle text-sm text-muted font-weight-medium text-uppercase mr-2\">Subtotal:</span><span class=\"d-inline-block align-middle text-xl font-weight-medium\">$");
#nullable restore
#line 98 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                                                                                                                                       Write(Math.Round(TotalCartPrice, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                <div class=\"py-2\"><span class=\"d-inline-block align-middle text-sm text-muted font-weight-medium text-uppercase mr-2\">Discount:</span><span class=\"d-inline-block align-middle text-xl font-weight-medium\">$");
#nullable restore
#line 99 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                                                                                                                                       Write(Model.DiscountValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                <div class=\"py-2\"><span class=\"d-inline-block align-middle text-sm text-muted font-weight-medium text-uppercase mr-2\">TOTAL:</span><span class=\"d-inline-block align-middle text-xl font-weight-medium\">$");
#nullable restore
#line 100 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                                                                                                                                    Write(Math.Round(Math.Abs(TotalCartPriceWithDiscount), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n\r\n            <!-- Buttons-->\r\n            <hr class=\"my-2\">\r\n            <div class=\"row pt-3 pb-5 mb-2\">\r\n                <div class=\"col-sm-6 mb-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011fa9164a8e8ff60dc50c582c27de48d43118ce33725", async() => {
                WriteLiteral("<i class=\"fe-icon-refresh-ccw\"></i>&nbsp;Back To Items");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                <div class=\"col-sm-6 mb-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "011fa9164a8e8ff60dc50c582c27de48d43118ce35272", async() => {
                WriteLiteral("<i class=\"fe-icon-credit-card\"></i>&nbsp;Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_17.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cart", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"
                                                                                                                                                                           WriteLiteral(Model);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cart"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cart", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cart"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 111 "C:\Users\karim\source\repos\DMSOShopping\Views\Cart\ShowMyCart.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DMSOShopping.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
