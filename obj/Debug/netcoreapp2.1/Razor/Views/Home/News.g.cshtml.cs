#pragma checksum "/home/muunim/MaamigiliCouncil/Views/Home/News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dacee7e79a0ca4991fd68a58b47a0913e189461"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/News.cshtml", typeof(AspNetCore.Views_Home_News))]
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
#line 1 "/home/muunim/MaamigiliCouncil/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/muunim/MaamigiliCouncil/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dacee7e79a0ca4991fd68a58b47a0913e189461", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("widows: 120px;height:225px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 327, true);
            WriteLiteral(@"<div class="""">
    <div class=""container"">
        <br>
        <h4 class=""dh right-align"">
            ހަބަރު

        </h4>
        <hr>
        <div class=""row"">
            <div class=""col s12  right"">
                <!-- <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>   ފަހުގެ ޙަބަރު   </strong></h5> -->
");
            EndContext();
#line 12 "/home/muunim/MaamigiliCouncil/Views/Home/News.cshtml"
                 foreach (var item in ViewBag.news)
                {

#line default
#line hidden
            BeginContext(397, 157, true);
            WriteLiteral("                <div class=\"col m4 s12\">\n                    <div class=\"card\">\n                        <div class=\"card-image\">\n                            ");
            EndContext();
            BeginContext(554, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9c9a738a283479eb42e7987737d2d4f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 564, "~/newsImage/", 564, 12, true);
#line 17 "/home/muunim/MaamigiliCouncil/Views/Home/News.cshtml"
AddHtmlAttributeValue("", 576, item.ImgUrl, 576, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(649, 114, true);
            WriteLiteral("\n\n                        </div>\n                        <div class=\"card-content\">\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 763, "\"", 814, 1);
#line 21 "/home/muunim/MaamigiliCouncil/Views/Home/News.cshtml"
WriteAttributeValue("", 770, Url.Action("Index","News",new{id=@item.Id}), 770, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(815, 79, true);
            WriteLiteral(" class=\"right dh\" style=\"direction: rtl; font-size: 20px;font-weight: bolder;\">");
            EndContext();
            BeginContext(895, 10, false);
#line 21 "/home/muunim/MaamigiliCouncil/Views/Home/News.cshtml"
                                                                                                                                                            Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(905, 262, true);
            WriteLiteral(@"</a>
                            <br><br>
                            <br><br>
                        </div>
                        <div class=""card-action right-align"">
                            <span class="" center blue-grey-text "" style=""direction: rtl""> ");
            EndContext();
            BeginContext(1168, 9, false);
#line 26 "/home/muunim/MaamigiliCouncil/Views/Home/News.cshtml"
                                                                                     Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1177, 131, true);
            WriteLiteral(" <i class=\"material-icons\">date_range</i></span>\n\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 31 "/home/muunim/MaamigiliCouncil/Views/Home/News.cshtml"



                }

#line default
#line hidden
            BeginContext(1329, 51, true);
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>");
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
