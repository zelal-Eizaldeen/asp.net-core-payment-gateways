#pragma checksum "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55d726b7e3d6c5747fee2a44863cb3671c68c74e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_BraintreePlans), @"mvc.1.0.view", @"/Views/Checkout/BraintreePlans.cshtml")]
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
#line 1 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d726b7e3d6c5747fee2a44863cb3671c68c74e", @"/Views/Checkout/BraintreePlans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d938fd633361b29333d6c38f61b28eb71ba8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_BraintreePlans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Braintree.Plan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
  
    ViewData["Title"] = "BraintreePlans";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
     foreach(var plan in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5>");
#nullable restore
#line 12 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
                   Write(plan.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <div class=\"card-text\">\r\n                        <p>Description: ");
#nullable restore
#line 14 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
                                   Write(plan.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Plan Price: $");
#nullable restore
#line 15 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
                                   Write(plan.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Trial Period?: ");
#nullable restore
#line 16 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
                                     Write(plan.TrialPeriod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Trial Duration: ");
#nullable restore
#line 17 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
                                      Write(plan.TrialDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (days)</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
#nullable restore
#line 21 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
       Write(Html.ActionLink("Subscribe to this plan", "SubscribeToPlan", "Checkout", new { id = plan.Id }, new { @class="btn btn-success"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_08\End\LibraryApp\LibraryApp\Views\Checkout\BraintreePlans.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Braintree.Plan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
