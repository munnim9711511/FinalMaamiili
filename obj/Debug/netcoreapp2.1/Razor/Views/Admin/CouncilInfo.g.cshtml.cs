#pragma checksum "/home/munnim/Desktop/count1/Views/Admin/CouncilInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a684dd2830c4b1776e546f6b785cba279986bee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CouncilInfo), @"mvc.1.0.view", @"/Views/Admin/CouncilInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CouncilInfo.cshtml", typeof(AspNetCore.Views_Admin_CouncilInfo))]
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
#line 1 "/home/munnim/Desktop/count1/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/munnim/Desktop/count1/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a684dd2830c4b1776e546f6b785cba279986bee7", @"/Views/Admin/CouncilInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CouncilInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("CouncilInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/munnim/Desktop/count1/Views/Admin/CouncilInfo.cshtml"
  
    Layout="~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(54, 110, true);
            WriteLiteral("\n<div class=\"container\">\n    <h5>Concilers Info</h5>\n    <div class=\"row\">\n        <div class=\"\">\n            ");
            EndContext();
            BeginContext(164, 3103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f86a93c35c94ace8835de838a7e64f0", async() => {
                BeginContext(235, 3025, true);
                WriteLiteral(@"
             <div class=""row"">
                   <div class=""col m6 s12 input-field"">
                       <input type=""text"" name =""title"" >
                       <label for="""">Titile</label>
                   </div>
               </div>
               <div class=""row"">
                   <div class=""col m6 s12 input-field"">
                       <input type=""text"" name =""FirstName""  >
                       <label for="""">Conciler name</label>
                   </div>
               </div> 
                 <div class=""row"">
                   <div class=""col m6 s12 "">
                       <label for="""">photo</label>
                        <br>
                       <input type=""file"" name =""pic""  >
                   </div>
               </div>
                  <div class=""row"">
                   <div class=""col m6 s12 input-field"">
                       <input type=""text"" name =""SecondName""  >
                       <label for="""">Conciler name</label>
                   </div>
            ");
                WriteLiteral(@"   </div> 
                 <div class=""row"">
                   <div class=""col m6 s12 "">
                       <label for="""">photo</label>
                        <br>
                       <input type=""file"" name =""pic"" >
                   </div>
               </div> 
                  <div class=""row"">
                   <div class=""col m6 s12 input-field"">
                       <input type=""text"" name =""TheirdName""  >
                       <label for="""">Conciler name</label>
                   </div>
               </div> 
                 <div class=""row"">
                   <div class=""col m6 s12 "">
                       <label for="""">photo</label>
                        <br>
                       <input type=""file"" name =""pic""  >
                   </div>
               </div> 

               <div class=""row"">
                   <div class=""col m6 s12 input-field"">
                       <input type=""text"" name =""FourthName""  >
                       <label for="""">Conciler name</label>
     ");
                WriteLiteral(@"              </div>
               </div> 
                 <div class=""row"">
                   <div class=""col m6 s12 "">
                       <label for="""">photo</label>
                        <br>
                       <input type=""file"" name =""pic""  >
                   </div>
               </div>

               <div class=""row"">
                   <div class=""col m6 s12 input-field"">
                       <input type=""text"" name =""FifthName""  >
                       <label for="""">Conciler name</label>
                   </div>
               </div> 
                 <div class=""row"">
                   <div class=""col m6 s12 "">
                       <label for="""">photo</label>
                        <br>
                       <input type=""file"" name =""pic""  >
                   </div>
               </div>

               <div class=""row"">
                      <input type=""submit"" value=""upload"" class=""btn""/>
               </div> 

            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3267, 33, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
