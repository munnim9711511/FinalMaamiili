#pragma checksum "/media/munnim/MUNNIM/Coun/Views/Link/Bussiness.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82279c6e3d4cae51ae26fa6b07d768b55ccc8bb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Link_Bussiness), @"mvc.1.0.view", @"/Views/Link/Bussiness.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Link/Bussiness.cshtml", typeof(AspNetCore.Views_Link_Bussiness))]
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
#line 1 "/media/munnim/MUNNIM/Coun/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/media/munnim/MUNNIM/Coun/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82279c6e3d4cae51ae26fa6b07d768b55ccc8bb2", @"/Views/Link/Bussiness.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Link_Bussiness : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 108, true);
            WriteLiteral("<div class=\"container\">\r\n        <h5 class=\"dh right-align\">މާމިގިލީ ވިޔަފާރީ އާއި ގުޅޭ</h5>\r\n        <hr>\r\n");
            EndContext();
#line 4 "/media/munnim/MUNNIM/Coun/Views/Link/Bussiness.cshtml"
 foreach (var item in  ViewBag.bussines)
{

#line default
#line hidden
            BeginContext(153, 82, true);
            WriteLiteral("      <div class=\"row\">\r\n        \r\n        <div class=\"col s12\">\r\n            <h5>");
            EndContext();
            BeginContext(236, 10, false);
#line 9 "/media/munnim/MUNNIM/Coun/Views/Link/Bussiness.cshtml"
           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(246, 19, true);
            WriteLiteral("</h5>\r\n            ");
            EndContext();
            BeginContext(265, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d11cfb003d18452685cd034a0a985330", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 275, "~/LinkPic/", 275, 10, true);
#line 10 "/media/munnim/MUNNIM/Coun/Views/Link/Bussiness.cshtml"
AddHtmlAttributeValue("", 285, item.ImgUrl, 285, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(306, 35, true);
            WriteLiteral("\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(342, 9, false);
#line 12 "/media/munnim/MUNNIM/Coun/Views/Link/Bussiness.cshtml"
           Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(351, 59, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n         \r\n    </div>\r\n");
            EndContext();
#line 17 "/media/munnim/MUNNIM/Coun/Views/Link/Bussiness.cshtml"
    
}

#line default
#line hidden
            BeginContext(419, 10, true);
            WriteLiteral("  \r\n</div>");
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
