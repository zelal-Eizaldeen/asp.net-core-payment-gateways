#pragma checksum "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "508f02f3b364d9032e6d6662c50d30eea1ad67e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"508f02f3b364d9032e6d6662c50d30eea1ad67e7", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d938fd633361b29333d6c38f61b28eb71ba8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryApp.Data.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n");
#nullable restore
#line 8 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 col-xs-6\" style=\"padding-bottom: 35px;\">\n            <div class=\"card\">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"text-muted\">(by: ");
#nullable restore
#line 13 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml"
                                                                                 Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(") </small></h5><br />\n                    <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    ");
#nullable restore
#line 15 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml"
               Write(Html.ActionLink("Show details", "Details", "Books", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 16 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml"
               Write(Html.ActionLink("Purchase - $" +item.Price, "Purchase", "Checkout", new { id = item.Id }, new { @class = "btn btn-success pull-right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 20 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_03\End\LibraryApp\LibraryApp\Views\Books\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryApp.Data.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
