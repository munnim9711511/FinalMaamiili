#pragma checksum "/home/munnim/Desktop/FinalMaamiili/Views/Admin/UpdateNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45595194456cdfdb8cc68549f2cf594799f6395c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateNew), @"mvc.1.0.view", @"/Views/Admin/UpdateNew.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateNew.cshtml", typeof(AspNetCore.Views_Admin_UpdateNew))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45595194456cdfdb8cc68549f2cf594799f6395c", @"/Views/Admin/UpdateNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/munnim/Desktop/FinalMaamiili/Views/Admin/UpdateNew.cshtml"
  
    Layout="~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(54, 29, true);
            WriteLiteral("\n<div class=\"container\">\n    ");
            EndContext();
            BeginContext(83, 1284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "821d2cb13acf44b584a822e69fe8662e", async() => {
                BeginContext(176, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 7 "/home/munnim/Desktop/FinalMaamiili/Views/Admin/UpdateNew.cshtml"
     foreach (var item in    ViewBag.news)
    {

#line default
#line hidden
                BeginContext(226, 128, true);
                WriteLiteral("         <div class=\"row\">\n            <div class=\"col m8 input-field\">\n                <input type=\"text\" name=\"Title\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 354, "\"", 373, 1);
#line 11 "/home/munnim/Desktop/FinalMaamiili/Views/Admin/UpdateNew.cshtml"
WriteAttributeValue("", 362, item.Title, 362, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(374, 255, true);
                WriteLiteral(" style=\"font-family: Faruma;direction: rtl;\">\n                <label for=\"\">Title</label>\n            </div>\n        </div> \n          <div class=\"row hide\">\n            <div class=\"col m8 input-field\">\n                <input type=\"Id\" name=\"Id\"  required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 629, "\"", 645, 1);
#line 17 "/home/munnim/Desktop/FinalMaamiili/Views/Admin/UpdateNew.cshtml"
WriteAttributeValue("", 637, item.Id, 637, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(646, 546, true);
                WriteLiteral(@" style=""font-family: Faruma;direction: rtl;"">
                <label for="""">Id</label>
            </div>
        </div>
         <div class=""row"">
            <div class=""col m8"">
                <label for="""">Image</label>
                <br>

                <input type=""file"" name=""NewsPic""  value="""">
            </div>
        </div>
        <div class=""row"">
            <div class=""col m8 input-field"">
          <textarea id=""textarea1"" class=""materialize-textarea dh ""required  name=""Text"" style=""direction: rtl;text-align: justify;"">");
                EndContext();
                BeginContext(1193, 9, false);
#line 31 "/home/munnim/Desktop/FinalMaamiili/Views/Admin/UpdateNew.cshtml"
                                                                                                                                Write(item.Text);

#line default
#line hidden
                EndContext();
                BeginContext(1202, 91, true);
                WriteLiteral("</textarea>\n                <label for=\"\">News</label>\n            </div>\n        </div>  \n");
                EndContext();
#line 35 "/home/munnim/Desktop/FinalMaamiili/Views/Admin/UpdateNew.cshtml"


    }

#line default
#line hidden
                BeginContext(1301, 59, true);
                WriteLiteral("      <input type=\"submit\" value=\"update\" class=\"btn\">\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "/home/munnim/Desktop/FinalMaamiili/Views/Admin/UpdateNew.cshtml"
AddHtmlAttributeValue("", 97, Url.Action("UpdateNews","Admin"), 97, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 7, true);
            WriteLiteral("\n</div>");
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
