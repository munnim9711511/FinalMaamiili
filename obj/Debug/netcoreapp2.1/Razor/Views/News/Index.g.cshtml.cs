#pragma checksum "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc9dfef46ea5f1ca7feb33e85fd92f4c7605145"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc9dfef46ea5f1ca7feb33e85fd92f4c7605145", @"/Views/News/Index.cshtml")]
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
            BeginContext(0, 77, true);
            WriteLiteral("<div class=\"container\">\r\n  \r\n    <br>\r\n<div class=\"container center-align\">\r\n");
            EndContext();
#line 5 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
 foreach (var item in ViewBag.news)
{
  

#line default
#line hidden
            BeginContext(121, 68, true);
            WriteLiteral("    <h5 class=\"dh right-align newsHeading\" style=\"line-height: 1.5\">");
            EndContext();
            BeginContext(190, 10, false);
#line 8 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(200, 11, true);
            WriteLiteral("</h5>\r\n    ");
            EndContext();
            BeginContext(211, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d72bf6eb0b0c48be9ce79d8e4f58a63c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 222, "~/newsImage/", 222, 12, true);
#line 9 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
AddHtmlAttributeValue("", 234, item.ImgUrl, 234, 12, false);

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
            BeginContext(315, 98, true);
            WriteLiteral("\r\n    <p class=\"dh right-align news-parag\" style=\"text-align: justify;direction: rtl ;\">\r\n        ");
            EndContext();
            BeginContext(414, 9, false);
#line 11 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
   Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(423, 34, true);
            WriteLiteral("\r\n    </p>\r\n    <hr>\r\n          <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 457, "\"", 551, 2);
            WriteAttributeValue("", 464, "http://www.facebook.com/sharer.php?u=http://maamigilicouncil.gov.mv/News/Index/", 464, 79, true);
#line 14 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 543, item.Id, 543, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(552, 155, true);
            WriteLiteral(" target=\"_blank\">\r\n        <img src=\"https://simplesharebuttons.com/images/somacro/facebook.png\" alt=\"Facebook\" style=\"width: 33px;\" />\r\n    </a>\r\n      <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 707, "\"", 794, 2);
            WriteAttributeValue("", 714, "https://twitter.com/share?url=http://maamigilicouncil.gov.mv/News/Index/", 714, 72, true);
#line 17 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 786, item.Id, 786, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(795, 154, true);
            WriteLiteral(" target=\"_blank\">\r\n        <img src=\"https://simplesharebuttons.com/images/somacro/twitter.png\" alt=\"Twitter\" style=\"width: 33px;\" />\r\n    </a>\r\n       <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 949, "\"", 1041, 4);
            WriteAttributeValue("", 956, "viber://forward?text=", 956, 21, true);
#line 20 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 977, item.Title, 977, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 988, "%20http://maamigilicouncil.gov.mv/News/Index/", 988, 45, true);
#line 20 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
WriteAttributeValue("", 1033, item.Id, 1033, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1042, 27, true);
            WriteLiteral(" target=\"_blank\">\r\n        ");
            EndContext();
            BeginContext(1069, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1f0560befb84ecc97ac9df18f45ff03", async() => {
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
            BeginContext(1147, 12, true);
            WriteLiteral("\r\n    </a>\r\n");
            EndContext();
#line 23 "/home/munnim/Desktop/FinalMaamiili/Views/News/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1162, 22, true);
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
