#pragma checksum "/media/munnim/MUNNIM/Coun/Views/Home/MeetingSummery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "382021edb732d5111b5bc9b6e5a6863bc13a6c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MeetingSummery), @"mvc.1.0.view", @"/Views/Home/MeetingSummery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MeetingSummery.cshtml", typeof(AspNetCore.Views_Home_MeetingSummery))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"382021edb732d5111b5bc9b6e5a6863bc13a6c19", @"/Views/Home/MeetingSummery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MeetingSummery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 191, true);
            WriteLiteral("<div class=\"container\">\r\n    <h5 class=\"dh right-align\">ބައްދަލުވުންތަކުގެ ތަފްސީލް</h5>\r\n    <hr>\r\n   <div>\r\n       <div class=\"row\">\r\n           <div class=\"col s12\">\r\n               <ul>\r\n");
            EndContext();
#line 8 "/media/munnim/MUNNIM/Coun/Views/Home/MeetingSummery.cshtml"
                    foreach (var item in ViewBag.meeting)
                   {

#line default
#line hidden
            BeginContext(272, 27, true);
            WriteLiteral("                       <li>");
            EndContext();
            BeginContext(299, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1614463be9d841ca95a4c001a31a16a1", async() => {
                BeginContext(332, 28, true);
                WriteLiteral(" <h6 class=\"dh right-align\">");
                EndContext();
                BeginContext(361, 10, false);
#line 10 "/media/munnim/MUNNIM/Coun/Views/Home/MeetingSummery.cshtml"
                                                                                   Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(371, 5, true);
                WriteLiteral("</h6>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 308, "~/LinkPic/", 308, 10, true);
#line 10 "/media/munnim/MUNNIM/Coun/Views/Home/MeetingSummery.cshtml"
AddHtmlAttributeValue("", 318, item.ImgUrl, 318, 12, false);

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
            BeginContext(380, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "/media/munnim/MUNNIM/Coun/Views/Home/MeetingSummery.cshtml"
                   }

#line default
#line hidden
            BeginContext(409, 74, true);
            WriteLiteral("               </ul>\r\n           </div>\r\n       </div>\r\n   </div> \r\n</div>");
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
