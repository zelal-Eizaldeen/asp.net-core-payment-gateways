#pragma checksum "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efce01326ec2d8e3a26ea1b2c190d34d6f33a804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_LoadAllPlans), @"mvc.1.0.view", @"/Views/Checkout/LoadAllPlans.cshtml")]
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
#line 1 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml"
using Stripe;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efce01326ec2d8e3a26ea1b2c190d34d6f33a804", @"/Views/Checkout/LoadAllPlans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d938fd633361b29333d6c38f61b28eb71ba8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_LoadAllPlans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Plan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml"
  
    ViewData["Title"] = "LoadAllPlans";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml"
     foreach(var plan in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml"
                                      Write(plan.Nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>$");
#nullable restore
#line 14 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml"
                   Write(string.Format("{0:#.00}", Convert.ToDecimal(plan.Amount)/100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 15 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml"
                  Write(plan.Interval);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            ");
#nullable restore
#line 18 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml"
       Write(Html.ActionLink("Subscribe", "SubscribeToPlan", "Checkout", new { Id = plan.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch03\03_05\End\LibraryApp\LibraryApp\Views\Checkout\LoadAllPlans.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Plan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
