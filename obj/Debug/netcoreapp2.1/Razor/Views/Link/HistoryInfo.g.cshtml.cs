#pragma checksum "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa0dd51967c4d4230e0319874b2a528cb07351e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Link_HistoryInfo), @"mvc.1.0.view", @"/Views/Link/HistoryInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Link/HistoryInfo.cshtml", typeof(AspNetCore.Views_Link_HistoryInfo))]
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
#line 1 "/home/munnim/Desktop/FinalMaamiili/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/munnim/Desktop/FinalMaamiili/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0dd51967c4d4230e0319874b2a528cb07351e5", @"/Views/Link/HistoryInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Link_HistoryInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 76, true);
            WriteLiteral("<div class=\"container\">\n\n<div class=\"card\" style=\"padding: 12px;\">\n\n<br>\n\n\n\n");
            EndContext();
#line 9 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"
         foreach (var item in ViewBag.history)
{


#line default
#line hidden
            BeginContext(126, 67, true);
            WriteLiteral("      <h5 class=\"dh center-align\" style=\"direction: rtl;\">\n        ");
            EndContext();
            BeginContext(194, 10, false);
#line 13 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"
   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(204, 11, true);
            WriteLiteral("\n    </h5>\n");
            EndContext();
            BeginContext(217, 68, true);
            WriteLiteral("   <div class=\"slider\">\n    <ul class=\"slides\">\n       <li>\n        ");
            EndContext();
            BeginContext(285, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f565af679662497c9f8d9952e6ab2bb0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 295, "~/GuestHousePic/", 295, 16, true);
#line 20 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"
AddHtmlAttributeValue("", 311, item.ImgUrl1, 311, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(326, 56, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n       <li>\n        ");
            EndContext();
            BeginContext(382, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a48d0501c8044e48a8fbdb50027e9c6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 392, "~/GuestHousePic/", 392, 16, true);
#line 24 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"
AddHtmlAttributeValue("", 408, item.ImgUrl2, 408, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(423, 58, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n         <li>\n        ");
            EndContext();
            BeginContext(481, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3e9594db8244469b69537476874ec54", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 491, "~/GuestHousePic/", 491, 16, true);
#line 28 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"
AddHtmlAttributeValue("", 507, item.ImgUrl3, 507, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(522, 62, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n             <li>\n        ");
            EndContext();
            BeginContext(584, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "531d49fdca7d43aea76f7aa077c88ec6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 594, "~/GuestHousePic/", 594, 16, true);
#line 32 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"
AddHtmlAttributeValue("", 610, item.ImgUrl4, 610, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(625, 62, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n             <li>\n        ");
            EndContext();
            BeginContext(687, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9439d72361d54fc0894cfb6e42a24cb0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 697, "~/GuestHousePic/", 697, 16, true);
#line 36 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"
AddHtmlAttributeValue("", 713, item.ImgUrl5, 713, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(728, 147, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n          </ul>\n  </div>\n  <div style=\"padding: 15px;\">\n\n<p class=\"dh right-align\" style=\"font-size: 19px;\">\n  ");
            EndContext();
            BeginContext(876, 9, false);
#line 44 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"
Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(885, 15, true);
            WriteLiteral("\n</p>\n  </div>\n");
            EndContext();
#line 47 "/home/munnim/Desktop/FinalMaamiili/Views/Link/HistoryInfo.cshtml"


}

#line default
#line hidden
            BeginContext(904, 52, true);
            WriteLiteral("\n\n\n\n\n</div>\n\n<div class=\"container\">\n\n</div>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
