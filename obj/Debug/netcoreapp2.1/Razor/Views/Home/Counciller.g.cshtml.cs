#pragma checksum "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb2d977afdd9927b2957b0ac6625df2f1954a5b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Counciller), @"mvc.1.0.view", @"/Views/Home/Counciller.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Counciller.cshtml", typeof(AspNetCore.Views_Home_Counciller))]
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
#line 1 "/home/muunim/FinalMaamiili/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/muunim/FinalMaamiili/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2d977afdd9927b2957b0ac6625df2f1954a5b5", @"/Views/Home/Counciller.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Counciller : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded z-depth-1 mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("team member"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("180px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("180px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 163, true);
            WriteLiteral("<div class=\"\">\r\n  <br />\r\n  <div class=\"container\">\r\n    <h5 class=\"dh right-align\">ކައުންސިލަރގެ މަޢުލޫމާތު</h5>\r\n    <hr />\r\n    <div class=\"row center-align\">\r\n");
            EndContext();
#line 7 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
       foreach (var item in ViewBag.conciller) {


#line default
#line hidden
            BeginContext(215, 68, true);
            WriteLiteral("      <div class=\"wow fadeIn\">\r\n        <h5 class=\"center-align dh\">");
            EndContext();
            BeginContext(284, 10, false);
#line 10 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(294, 223, true);
            WriteLiteral("</h5>\r\n        <hr />\r\n      </div>\r\n      <div class=\"row\">\r\n        <div class=\"center-align\">\r\n          <div class=\"col-lg-6 col-md-12 mb-5 wow fadeInLeft\">\r\n            <div class=\"col-md-6 float-left\">\r\n              ");
            EndContext();
            BeginContext(517, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0acca9303386410a8eca1637cc737bcc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 602, "~/council/", 602, 10, true);
#line 19 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 612, item.FirstPic, 612, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(743, 103, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6 float-right\">\r\n              <div class=\"h4 dh\">");
            EndContext();
            BeginContext(847, 14, false);
#line 26 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
                            Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(861, 339, true);
            WriteLiteral(@"</div>
              <h6 class=""h6 blue-grey-text mb-3 dh "" style=""direction: rtl;"">
                ކައުންސިލްގެ ރައީސް
              </h6>
            </div>
          </div>
        </div>
        <div class=""row"">
          <div class=""center-align"">
            <div class=""col s12 m6"">
              <div>
                ");
            EndContext();
            BeginContext(1200, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "691c43e10a0c4cddbc24d182720db82f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1289, "~/council/", 1289, 10, true);
#line 39 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 1299, item.SecondPic, 1299, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1439, 80, true);
            WriteLiteral("\r\n              </div>\r\n              <div>\r\n                <div class=\"h4 dh\">");
            EndContext();
            BeginContext(1520, 15, false);
#line 46 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
                              Write(item.SecondName);

#line default
#line hidden
            EndContext();
            BeginContext(1535, 332, true);
            WriteLiteral(@"</div>

                <h6 class=""h6 blue-grey-text mb-3 dh"" style=""direction: rtl;"">
                  ކައުންސިލްގެ ނައިބް ރައީސް
                </h6>
              </div>
            </div>
          </div>
          <div class=""center-align"">
            <div class=""col s12 m6"">
              <div>
                ");
            EndContext();
            BeginContext(1867, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a36f73921d334b51a32088997046ff45", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1956, "~/council/", 1956, 10, true);
#line 59 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 1966, item.TheirdPic, 1966, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2106, 80, true);
            WriteLiteral("\r\n              </div>\r\n              <div>\r\n                <div class=\"h4 dh\">");
            EndContext();
            BeginContext(2187, 15, false);
#line 66 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
                              Write(item.TheirdName);

#line default
#line hidden
            EndContext();
            BeginContext(2202, 187, true);
            WriteLiteral("</div>\r\n                <h6 class=\"h6 blue-grey-text mb-3 dh\">ކައުންސިލަރ</h6>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n\r\n");
            EndContext();
#line 75 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
           if (@item.FifthName != null)
          {

#line default
#line hidden
            BeginContext(2443, 117, true);
            WriteLiteral("              <div class=\"center-align\">\r\n            <div class=\"col s12 m6\">\r\n              <div>\r\n                ");
            EndContext();
            BeginContext(2560, 238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41c98ccdbbfe47b697cc6eae5c48cd7a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2649, "~/council/", 2649, 10, true);
#line 82 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 2659, item.FifthPic, 2659, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2798, 80, true);
            WriteLiteral("\r\n              </div>\r\n              <div>\r\n                <div class=\"h4 dh\">");
            EndContext();
            BeginContext(2879, 14, false);
#line 89 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
                              Write(item.FifthName);

#line default
#line hidden
            EndContext();
            BeginContext(2893, 140, true);
            WriteLiteral("</div>\r\n                <h6 class=\"h6 blue-grey-text mb-3 dh\">ކައުންސިލަރ</h6>\r\n              </div>\r\n            </div>\r\n          </div>\r\n");
            EndContext();
#line 94 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
          }

#line default
#line hidden
            BeginContext(3046, 10, true);
            WriteLiteral("        \r\n");
            EndContext();
#line 96 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
           if (@item.FourthName != null)
          {

#line default
#line hidden
            BeginContext(3111, 119, true);
            WriteLiteral("                <div class=\"center-align\">\r\n            <div class=\"col s12 m6\">\r\n              <div>\r\n                ");
            EndContext();
            BeginContext(3230, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c585f44e5be34ef5adf55945b7edccfb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3319, "~/council/", 3319, 10, true);
#line 103 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 3329, item.FourthPic, 3329, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3469, 80, true);
            WriteLiteral("\r\n              </div>\r\n              <div>\r\n                <div class=\"h4 dh\">");
            EndContext();
            BeginContext(3550, 15, false);
#line 110 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
                              Write(item.FourthName);

#line default
#line hidden
            EndContext();
            BeginContext(3565, 204, true);
            WriteLiteral("</div>\r\n\r\n                <h6 class=\"h6 blue-grey-text mb-3 dh\" style=\"direction: rtl;\">\r\n                  ކައުންސިލަރ\r\n                </h6>\r\n              </div>\r\n            </div>\r\n          </div>\r\n");
            EndContext();
#line 118 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
          }

#line default
#line hidden
            BeginContext(3782, 38, true);
            WriteLiteral("      \r\n        </div>\r\n      </div>\r\n");
            EndContext();
#line 122 "/home/muunim/FinalMaamiili/Views/Home/Counciller.cshtml"
      }

#line default
#line hidden
            BeginContext(3829, 30, true);
            WriteLiteral("    </div>\r\n  </div>\r\n</div>\r\n");
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
