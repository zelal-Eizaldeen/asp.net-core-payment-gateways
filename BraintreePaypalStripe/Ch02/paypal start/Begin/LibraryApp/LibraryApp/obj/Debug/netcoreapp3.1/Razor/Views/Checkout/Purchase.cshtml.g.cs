#pragma checksum "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "046bbc34f23f6e33a8b733d42806fa0cdbf688bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Purchase), @"mvc.1.0.view", @"/Views/Checkout/Purchase.cshtml")]
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
#line 1 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\_ViewImports.cshtml"
using LibraryApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046bbc34f23f6e33a8b733d42806fa0cdbf688bb", @"/Views/Checkout/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d938fd633361b29333d6c38f61b28eb71ba8ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Purchase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryApp.Data.ViewModels.BookPurchaseVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
  
    ViewData["Title"] = "Purchase";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n    <div class=\"checkout container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "046bbc34f23f6e33a8b733d42806fa0cdbf688bb5038", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 10 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
       Write(Html.HiddenFor(n => n.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\" name=\"Title\"");
                BeginWriteAttribute("asp-for", " asp-for=\"", 421, "\"", 443, 1);
#nullable restore
#line 13 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
WriteAttributeValue("", 431, Model.Title, 431, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
                                                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">Author: ");
#nullable restore
#line 15 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
                                                                      Write(Model.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">Price: ");
#nullable restore
#line 16 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
                                                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>\r\n                </div>\r\n                <img style=\"width: 90%\" class=\"card-img-bottom\"");
                BeginWriteAttribute("src", " src=\"", 818, "\"", 840, 1);
#nullable restore
#line 18 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
WriteAttributeValue("", 824, Model.Thumbnail, 824, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Card image cap\">\r\n            </div>\r\n            <section>\r\n                <div class=\"bt-drop-in-wrapper\">\r\n                    <div id=\"bt-dropin\"></div>\r\n                </div>\r\n            </section>\r\n            ");
#nullable restore
#line 25 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
       Write(Html.HiddenFor(n => n.Nonce, new { @id = "nonce"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <hr />\r\n            <button class=\"btn btn-success\" type=\"submit\"><span>Confirm payment - $");
#nullable restore
#line 27 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
                                                                              Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script src=\"https://js.braintreegateway.com/web/dropin/1.22.0/js/dropin.min.js\"></script>\r\n<script>\r\n    var client_token = \"");
#nullable restore
#line 34 "C:\Users\Ervis Trupja\Documents\PAYMENT GATEWAYS\Exercise Files\Ch02\02_05\End\LibraryApp\LibraryApp\Views\Checkout\Purchase.cshtml"
                   Write(ViewBag.ClientToken);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
    var form = document.querySelector('#payment-form');

    braintree.dropin.create({
        authorization: client_token,
        container: '#bt-dropin'
    }, function (createErr, instance) {
        form.addEventListener('submit', function (event) {
            event.preventDefault();

            instance.requestPaymentMethod(function (err, payload) {
                if (err) {
                    return;
                }
                document.querySelector('#nonce').value = payload.nonce;
                form.submit();
            });
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryApp.Data.ViewModels.BookPurchaseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
