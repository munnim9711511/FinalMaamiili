#pragma checksum "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3487daea18b7a0ef9c9c3b7ab27daba2a4ddb9a2"
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
#line 1 "/home/muunim/MaamigiliCouncil/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/muunim/MaamigiliCouncil/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3487daea18b7a0ef9c9c3b7ab27daba2a4ddb9a2", @"/Views/Home/Counciller.cshtml")]
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
            BeginContext(0, 167, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <br>\r\n<div class=\"container\">\r\n    <h5 class=\"dh right-align\">  ކައުންސިލަރގެ މަޢުލޫމާތު</h5>\r\n    <hr>\r\n<div class=\"row center-align\">\r\n\r\n\r\n");
            EndContext();
#line 10 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
 foreach (var item in ViewBag.conciller)
{
  

#line default
#line hidden
            BeginContext(216, 61, true);
            WriteLiteral("    <div class=\"wow fadeIn\">\r\n      <h5 class=\"center-align\">");
            EndContext();
            BeginContext(278, 10, false);
#line 14 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(288, 187, true);
            WriteLiteral("</h5>\r\n      <hr>\r\n    </div>\r\n    <div class=\"row\">\r\n    <div class=\"center-align\">\r\n      <div class=\"col-lg-6 col-md-12 mb-5 wow fadeInLeft\">\r\n        <div class=\"col-md-6 float-left\">");
            EndContext();
            BeginContext(475, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fba28e2ea4748ecbc1dbdd5f45403b7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 526, "~/council/", 526, 10, true);
#line 20 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 536, item.FirstPic, 536, 14, false);

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
            BeginContext(600, 82, true);
            WriteLiteral("</div>\r\n        <div class=\"col-md-6 float-right\">\r\n          <div class=\"h4 dh\"> ");
            EndContext();
            BeginContext(683, 14, false);
#line 22 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
                         Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(697, 279, true);
            WriteLiteral(@"</div>
          <h6 class=""h6 blue-grey-text mb-3 dh "" style=""direction: rtl;"">ކައުންސިލްގެ ރައީސް </h6>
        </div>
      </div>
      </div>  
      <div class=""row"">
          <div class=""center-align"">
              <div class=""col s12 m6"">
                <div >");
            EndContext();
            BeginContext(976, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd7e2d8f8a7144a7bfb16ae64e2c13db", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1027, "~/council/", 1027, 10, true);
#line 30 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 1037, item.SecondPic, 1037, 15, false);

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
            BeginContext(1102, 66, true);
            WriteLiteral("</div>\r\n                <div >\r\n                  <div class=\"h4\">");
            EndContext();
            BeginContext(1169, 15, false);
#line 32 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
                             Write(item.SecondName);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 323, true);
            WriteLiteral(@"</div>
                  
                  <h6 class=""h6 blue-grey-text mb-3 dh"" style=""direction: rtl;"">ކައުންސިލްގެ ނައިބް ރައީސް  </h6>
                  
                </div>
              </div>
              </div>
        <div class=""center-align"">
      <div class=""col s12 m6"">
        
        <div >");
            EndContext();
            BeginContext(1507, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e1f0288381e4ef8ae1a2d2efe49db87", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1558, "~/council/", 1558, 10, true);
#line 42 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 1568, item.TheirdPic, 1568, 15, false);

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
            BeginContext(1633, 50, true);
            WriteLiteral("</div>\r\n        <div >\r\n          <div class=\"h4\">");
            EndContext();
            BeginContext(1684, 15, false);
#line 44 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
                     Write(item.TheirdName);

#line default
#line hidden
            EndContext();
            BeginContext(1699, 268, true);
            WriteLiteral(@"</div>
          <h6 class=""h6 blue-grey-text mb-3 dh"">ކައުންސިލަރ </h6>
          
        </div>
      </div>
      </div>

    

  </div>


  <div class=""row"">
        <div class=""center-align"">
      <div class=""col s12 m6"">
        
        <div >");
            EndContext();
            BeginContext(1967, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "17ae7131b4e24de6ad9b32d6b2b2f69f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2018, "~/council/", 2018, 10, true);
#line 60 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 2028, item.FifthPic, 2028, 14, false);

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
            BeginContext(2092, 50, true);
            WriteLiteral("</div>\r\n        <div >\r\n          <div class=\"h4\">");
            EndContext();
            BeginContext(2143, 14, false);
#line 62 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
                     Write(item.FifthName);

#line default
#line hidden
            EndContext();
            BeginContext(2157, 213, true);
            WriteLiteral("</div>\r\n          <h6 class=\"h6 blue-grey-text mb-3 dh\">ކައުންސިލަރ </h6>\r\n          \r\n        </div>\r\n      </div>\r\n      </div>\r\n\r\n      <div class=\"center-align\">\r\n      <div class=\"col s12 m6\">\r\n        <div >");
            EndContext();
            BeginContext(2370, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bebe723cf2a41fca8e26f7c306f658c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2421, "~/council/", 2421, 10, true);
#line 71 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 2431, item.FourthPic, 2431, 15, false);

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
            BeginContext(2496, 50, true);
            WriteLiteral("</div>\r\n        <div >\r\n          <div class=\"h4\">");
            EndContext();
            BeginContext(2547, 15, false);
#line 73 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
                     Write(item.FourthName);

#line default
#line hidden
            EndContext();
            BeginContext(2562, 208, true);
            WriteLiteral("</div>\r\n          \r\n          <h6 class=\"h6 blue-grey-text mb-3 dh\" style=\"direction: rtl;\">ކައުންސިލްގެ ނައިބް ރައީސް  </h6>\r\n          \r\n        </div>\r\n      </div>\r\n      </div>\r\n\r\n  </div>\r\n\r\n \r\n</div>\r\n");
            EndContext();
#line 85 "/home/muunim/MaamigiliCouncil/Views/Home/Counciller.cshtml"
}

#line default
#line hidden
            BeginContext(2773, 30, true);
            WriteLiteral("\r\n\r\n</div>\r\n</div>\r\n\r\n\r\n</div>");
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
