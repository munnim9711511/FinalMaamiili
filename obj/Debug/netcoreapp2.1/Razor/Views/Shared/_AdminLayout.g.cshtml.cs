#pragma checksum "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c0be9fbe548194795e61aca8afc678528b97eb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AdminLayout.cshtml", typeof(AspNetCore.Views_Shared__AdminLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c0be9fbe548194795e61aca8afc678528b97eb6", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/angular.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/materialize/css/materialize.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/materialize/js/materialize.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon/admin.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html ng-app=\"app\">\n");
            EndContext();
            BeginContext(37, 827, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a6370314a4e4455b0344c804539925c", async() => {
                BeginContext(43, 118, true);
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
                EndContext();
                BeginContext(162, 17, false);
#line 7 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(179, 24, true);
                WriteLiteral(" - coouncil</title>\n    ");
                EndContext();
                BeginContext(203, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36a26b5380b6438a9c35efe622c82037", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                BeginContext(248, 99, true);
                WriteLiteral("\n\n      <link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\n    ");
                EndContext();
                BeginContext(347, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7492e9a3eef849289ed750e3b7972209", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(395, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(400, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf17f0090f94fab85761d4474973478", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(443, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(448, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483bee575e3d4e7881f6c8a8f5cdf133", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(483, 45, true);
                WriteLiteral("\n     <!-- Compiled and minified CSS -->\n    ");
                EndContext();
                BeginContext(528, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c8dc32b7fbc4e6baba813c792affbe5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(596, 135, true);
                WriteLiteral("\n    <!-- <link  rel=\"stylesheet\" href=\"~\\materialize\\css\\materialize.min.css\"> -->\n\n    <!-- Compiled and minified JavaScript -->\n    ");
                EndContext();
                BeginContext(731, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19f34ce4f67d4a3dac06a5c3cb64a90f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(790, 19, true);
                WriteLiteral("\n            \n\n    ");
                EndContext();
                BeginContext(809, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d7b7d75d7dc4098aedccb2a0922d80f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(845, 12, true);
                WriteLiteral("\n    \n\n\n   \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(864, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(865, 2643, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c7429eed2a4433d8a2a983f43ce603c", async() => {
                BeginContext(872, 150, true);
                WriteLiteral("\n  \n\n  <ul id=\"slide-out\" class=\"sidenav\" style=\"padding: 5px;\">\n    <li><div class=\"user-view center-align\">\n      <div class=\"background\" >\n        ");
                EndContext();
                BeginContext(1022, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3033a9ee960644f4b24eb92233d048a3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1066, 77, true);
                WriteLiteral("\n      </div>\n      <br><br> <br>\n      <br>\n     \n    </div></li>\n\n    <!-- ");
                EndContext();
                BeginContext(1144, 4, false);
#line 41 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
    Write(User);

#line default
#line hidden
                EndContext();
                BeginContext(1148, 5, true);
                WriteLiteral(" -->\n");
                EndContext();
#line 42 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
     if(User.IsInRole("Administrator"))
    {

#line default
#line hidden
                BeginContext(1199, 10, true);
                WriteLiteral("    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1209, "\"", 1244, 1);
#line 44 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1216, Url.Action("Users","Admin"), 1216, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1245, 65, true);
                WriteLiteral(" class=\"dh right-align\">ލޮގްވާ މުވަޒަފުން މެނޭޖް ކުރުން</a></li>\n");
                EndContext();
#line 45 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
    

    }

#line default
#line hidden
                BeginContext(1322, 54, true);
                WriteLiteral("  \n    <li><div class=\"divider\"></div></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1376, "\"", 1417, 1);
#line 50 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1383, Url.Action("CouncilInfo","Admin"), 1383, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1418, 73, true);
                WriteLiteral(" class=\"dh right-align\">ކައުންސިލަރުންގެ މަޢުލޫމާތު </a></li>\n\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1491, "\"", 1525, 1);
#line 52 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1498, Url.Action("News","Admin"), 1498, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1526, 68, true);
                WriteLiteral(" class=\"dh right-align\">ޙަބަރު ޝާއިރު ކުރުމަށް </a></li>\n     <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1594, "\"", 1634, 1);
#line 53 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1601, Url.Action("UpdateNews","Admin"), 1601, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1635, 85, true);
                WriteLiteral("  class=\"dh right-align\">ޝާއިރު ކުރި ޙަބަރު އަށް އިސްލާހުގެނުމަށް</a></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1720, "\"", 1756, 1);
#line 54 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1727, Url.Action("Slider","Admin"), 1727, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1757, 82, true);
                WriteLiteral(" class=\"dh right-align\">ފޮޓޯ ސްލައިޑަރ  ފޮޓޯލުމަށް</a></li>\n    <!-- <li><a href=\"");
                EndContext();
                BeginContext(1840, 31, false);
#line 55 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
                 Write(Url.Action("UploadDoc","Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(1871, 36, true);
                WriteLiteral("\">upload doc</a></li> -->\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1907, "\"", 1947, 1);
#line 56 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1914, Url.Action("UpdateLink","Admin"), 1914, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1948, 73, true);
                WriteLiteral(" class=\"dh right-align\">ލިންކްތަކަށް މަޢުލޫމާތު </a></li>\n    \n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2021, "\"", 2069, 1);
#line 58 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 2028, Url.Action("UpdateLinkContetnt","Admin"), 2028, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2070, 144, true);
                WriteLiteral(" class=\"dh right-align\">ލިންކް އަޕްޑޭޓް ކުރުން</a></li>\n    \n    <h6 class=\"dh right-align\">ކެފޭ އަދި ރެސްޓޯރަންޓް</h6>\n    <hr>\n    \n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2214, "\"", 2249, 1);
#line 63 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 2221, Url.Action("Cafey","Admin"), 2221, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2250, 93, true);
                WriteLiteral(" class=\"dh right-align\">ކެފޭ އަދި ރެސްޓޯރަންޓް ތަކުގެ މަޢުލޫމާތު  </a></li>\n    <li>\n      <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\"", 2343, "\"", 2383, 1);
#line 65 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 2351, Url.Action("Bussiness","Admin"), 2351, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2384, 149, true);
                WriteLiteral(" class=\"dh right-align\">ވިޔަފާރި</a>\n    </li>\n     \n    <h6 class=\"dh right-align\"> ގެސްޓް ހައުސް ތަކުގެ މަޢުލޫމާތު </h6>\n    <hr>\n    <li>\n      <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2533, "\"", 2577, 1);
#line 71 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 2540, Url.Action("GuestHouseInfo","Admin"), 2540, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2578, 153, true);
                WriteLiteral(" class=\"dh right-align\"> ގެސްޓް ހައުސް</a>\n    </li>  <h6 class=\"dh right-align\"> މާމިގިލީ މުހިންމު ތަންތަނުގެ މަޢުލޫމާތު</h6>\n    <hr>\n    <li>\n      <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2731, "\"", 2778, 1);
#line 75 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 2738, Url.Action("ImportantLocation","Admin"), 2738, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2779, 148, true);
                WriteLiteral(" class=\"dh right-align\"> މުހިންމު ތަންތަނުގެ މަޢުލޫމާތު</a>\n    </li>\n\n    <h6 class=\"dh right-align\">\n      ކަލަންޑަރު\n    </h6>\n     <li>\n      <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2927, "\"", 2965, 1);
#line 82 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 2934, Url.Action("Calander","Admin"), 2934, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2966, 81, true);
                WriteLiteral(" class=\"dh right-align\"> މުހިންމު ތަންތަނުގެ މަޢުލޫމާތު</a>\n    </li>\n     <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3047, "\"", 3084, 1);
#line 84 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 3054, Url.Action("Gallery","Admin"), 3054, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3085, 50, true);
                WriteLiteral(" class=\"dh right-align\">ގެލަރީ</a></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3135, "\"", 3177, 1);
#line 85 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 3142, Url.Action("Anouncements","Admin"), 3142, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3178, 97, true);
                WriteLiteral(" class=\"dh right-align\">އެންގުންތައް</a></li>\n    \n    <li><a class=\"waves-effect dh right-align\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3275, "\"", 3313, 1);
#line 87 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 3282, Url.Action("Logout","Account"), 3282, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3314, 163, true);
                WriteLiteral(" >ލޮގްއައުޓް</a></li>\n  </ul>\n\n  <a href=\"#\" data-target=\"slide-out\" class=\"sidenav-trigger\"><i class=\"material-icons\">menu</i></a>\n\n  <div class=\"container\">\n    ");
                EndContext();
                BeginContext(3478, 12, false);
#line 93 "/home/muunim/MaamigiliCouncil/Views/Shared/_AdminLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3490, 11, true);
                WriteLiteral("\n  </div>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3508, 9, true);
            WriteLiteral("\n</html>\n");
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
