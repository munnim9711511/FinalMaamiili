#pragma checksum "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6920525b22b1457461a9d02efe20cc110724105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Index.cshtml", typeof(AspNetCore.Views_News_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6920525b22b1457461a9d02efe20cc110724105", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("center-align responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("484px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("750px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon/viber_PNG25.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Twitter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 33px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 81, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n  \r\n    <br>\r\n<div class=\"container center-align\">\r\n");
            EndContext();
#line 7 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
 foreach (var item in ViewBag.news)
{

#line default
#line hidden
            BeginContext(121, 27, true);
            WriteLiteral("  <meta property=\"og:title\"");
            EndContext();
            BeginWriteAttribute("content", " content=", 148, "", 168, 1);
#line 9 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 157, item.Title, 157, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(168, 34, true);
            WriteLiteral(">\r\n<meta property=\"og:description\"");
            EndContext();
            BeginWriteAttribute("content", " content=", 202, "", 222, 1);
#line 10 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 211, item.Title, 211, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(222, 28, true);
            WriteLiteral(">\r\n<meta property=\"og:image\"");
            EndContext();
            BeginWriteAttribute("content", " content=", 250, "", 283, 2);
            WriteAttributeValue("", 259, "~/newsImage/", 259, 12, true);
#line 11 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 271, item.ImgUrl, 271, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(283, 26, true);
            WriteLiteral(">\r\n<meta property=\"og:url\"");
            EndContext();
            BeginWriteAttribute("content", " content=", 309, "", 368, 2);
            WriteAttributeValue("", 318, "http://maamigilicouncil.gov.mv/News/Index/", 318, 42, true);
#line 12 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 360, item.Id, 360, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(368, 71, true);
            WriteLiteral(">\r\n    <h5 class=\"dh right-align newsHeading\" style=\"line-height: 1.5\">");
            EndContext();
            BeginContext(440, 10, false);
#line 13 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(450, 11, true);
            WriteLiteral("</h5>\r\n    ");
            EndContext();
            BeginContext(461, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62cc07393130416c91cf36bab4311dd0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 472, "~/newsImage/", 472, 12, true);
#line 14 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
AddHtmlAttributeValue("", 484, item.ImgUrl, 484, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(565, 98, true);
            WriteLiteral("\r\n    <p class=\"dh right-align news-parag\" style=\"text-align: justify;direction: rtl ;\">\r\n        ");
            EndContext();
            BeginContext(664, 9, false);
#line 16 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
   Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(673, 34, true);
            WriteLiteral("\r\n    </p>\r\n    <hr>\r\n          <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 707, "\"", 801, 2);
            WriteAttributeValue("", 714, "http://www.facebook.com/sharer.php?u=http://maamigilicouncil.gov.mv/News/Index/", 714, 79, true);
#line 19 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 793, item.Id, 793, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(802, 155, true);
            WriteLiteral(" target=\"_blank\">\r\n        <img src=\"https://simplesharebuttons.com/images/somacro/facebook.png\" alt=\"Facebook\" style=\"width: 33px;\" />\r\n    </a>\r\n      <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 957, "\"", 1044, 2);
            WriteAttributeValue("", 964, "https://twitter.com/share?url=http://maamigilicouncil.gov.mv/News/Index/", 964, 72, true);
#line 22 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 1036, item.Id, 1036, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1045, 154, true);
            WriteLiteral(" target=\"_blank\">\r\n        <img src=\"https://simplesharebuttons.com/images/somacro/twitter.png\" alt=\"Twitter\" style=\"width: 33px;\" />\r\n    </a>\r\n       <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1199, "\"", 1291, 4);
            WriteAttributeValue("", 1206, "viber://forward?text=", 1206, 21, true);
#line 25 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 1227, item.Title, 1227, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1238, "%20http://maamigilicouncil.gov.mv/News/Index/", 1238, 45, true);
#line 25 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 1283, item.Id, 1283, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1292, 27, true);
            WriteLiteral(" target=\"_blank\">\r\n        ");
            EndContext();
            BeginContext(1319, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39d9d5c589bc4aa4a84122ddaeb5ae0b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1397, 12, true);
            WriteLiteral("\r\n    </a>\r\n");
            EndContext();
#line 28 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1412, 22, true);
            WriteLiteral("</div>\r\n\r\n\r\n</div>\r\n\r\n");
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
