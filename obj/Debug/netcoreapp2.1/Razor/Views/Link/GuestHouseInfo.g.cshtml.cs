#pragma checksum "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd1daf333e33b7610410ab5611fe745ee8c1b9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Link_GuestHouseInfo), @"mvc.1.0.view", @"/Views/Link/GuestHouseInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Link/GuestHouseInfo.cshtml", typeof(AspNetCore.Views_Link_GuestHouseInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd1daf333e33b7610410ab5611fe745ee8c1b9f", @"/Views/Link/GuestHouseInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Link_GuestHouseInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 72, true);
            WriteLiteral("<div class=\"container\">\n\n<div class=\"\" style=\"padding: 12px;\">\n\n<br>\n\n\n\n");
            EndContext();
#line 9 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
         foreach (var item in ViewBag.GuestInfo)
{


#line default
#line hidden
            BeginContext(124, 67, true);
            WriteLiteral("      <h5 class=\"dh center-align\" style=\"direction: rtl;\">\n        ");
            EndContext();
            BeginContext(192, 10, false);
#line 13 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(202, 11, true);
            WriteLiteral("\n    </h5>\n");
            EndContext();
            BeginContext(215, 68, true);
            WriteLiteral("   <div class=\"slider\">\n    <ul class=\"slides\">\n       <li>\n        ");
            EndContext();
            BeginContext(283, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9fd2c1fc183849f286af3001cc870c06", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 293, "~/GuestHousePic/", 293, 16, true);
#line 20 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
AddHtmlAttributeValue("", 309, item.ImgUrl1, 309, 13, false);

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
            BeginContext(324, 56, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n       <li>\n        ");
            EndContext();
            BeginContext(380, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a18bc03d6bc745fa892a1cd0279a09b4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 390, "~/GuestHousePic/", 390, 16, true);
#line 24 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
AddHtmlAttributeValue("", 406, item.ImgUrl2, 406, 13, false);

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
            BeginContext(421, 58, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n         <li>\n        ");
            EndContext();
            BeginContext(479, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba882ec174b44315aea067d67778b740", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 489, "~/GuestHousePic/", 489, 16, true);
#line 28 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
AddHtmlAttributeValue("", 505, item.ImgUrl3, 505, 13, false);

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
            BeginContext(520, 62, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n             <li>\n        ");
            EndContext();
            BeginContext(582, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d51a4a5be5114802a71b2fcc6ab32ced", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 592, "~/GuestHousePic/", 592, 16, true);
#line 32 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
AddHtmlAttributeValue("", 608, item.ImgUrl4, 608, 13, false);

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
            BeginContext(623, 62, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n             <li>\n        ");
            EndContext();
            BeginContext(685, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2be93714d9e74d0b904364daf268ee8d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 695, "~/GuestHousePic/", 695, 16, true);
#line 36 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
AddHtmlAttributeValue("", 711, item.ImgUrl5, 711, 13, false);

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
            BeginContext(726, 167, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n          </ul>\n  </div>\n  <div style=\"padding: 15px;\">\n    <p class=\" dh right-align\" style=\"font-size: 19px;\">\n   ފޯން ނަމްބަރު :");
            EndContext();
            BeginContext(894, 19, false);
#line 43 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
             Write(item.ConatactNumber);

#line default
#line hidden
            EndContext();
            BeginContext(913, 74, true);
            WriteLiteral(" 960 00\n</p>\n    <p class=\" dh right-align\" style=\"font-size: 19px;\" >\n   ");
            EndContext();
            BeginContext(988, 10, false);
#line 46 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(998, 72, true);
            WriteLiteral(":  އީމެއިލް\n</p>\n\n<p class=\"dh right-align\" style=\"font-size: 19px;\">\n  ");
            EndContext();
            BeginContext(1071, 9, false);
#line 50 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"
Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 15, true);
            WriteLiteral("\n</p>\n  </div>\n");
            EndContext();
#line 53 "/home/munnim/Desktop/FinalMaamiili/Views/Link/GuestHouseInfo.cshtml"


}

#line default
#line hidden
            BeginContext(1099, 52, true);
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
