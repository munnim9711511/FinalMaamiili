#pragma checksum "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b625fd64584d922fbd4f9ae8bce950671a81cac3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GallerySlider), @"mvc.1.0.view", @"/Views/Home/GallerySlider.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GallerySlider.cshtml", typeof(AspNetCore.Views_Home_GallerySlider))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b625fd64584d922fbd4f9ae8bce950671a81cac3", @"/Views/Home/GallerySlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GallerySlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("materialboxed responsive-img "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 337px;height: 206px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 80, true);
            WriteLiteral("<div class=\"container center-align\">\n    <div class=\"row\">\n\n        <br><br>\n\n\n\n");
            EndContext();
#line 8 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"
         foreach (var item in ViewBag.Gallery)
        {

#line default
#line hidden
            BeginContext(137, 60, true);
            WriteLiteral("        <h4 class=\"dh newsHeading \" style=\"direction: rtl;\">");
            EndContext();
            BeginContext(198, 10, false);
#line 10 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(208, 19, true);
            WriteLiteral("</h4>\n        <hr>\n");
            EndContext();
#line 12 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"
        var x = item .ImgUrl.Split(',');


        

#line default
#line hidden
#line 15 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"
         foreach (var s in x)
        {

#line default
#line hidden
            BeginContext(310, 65, true);
            WriteLiteral("        <div class=\"col m3 s12\" style=\"padding-bottom: 10px;\">\n\n\n");
            EndContext();
#line 20 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"
             if (s != null)
            {



#line default
#line hidden
            BeginContext(419, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(431, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "77c77734d54a4694a053b18bca40b95a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 441, "~/gallery/", 441, 10, true);
#line 24 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"
AddHtmlAttributeValue("", 451, s, 451, 2, false);

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
            BeginContext(536, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 25 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"



            }

#line default
#line hidden
            BeginContext(554, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 31 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"


        }

#line default
#line hidden
#line 33 "/home/munnim/Desktop/FinalMaamiili/Views/Home/GallerySlider.cshtml"
         




        }

#line default
#line hidden
            BeginContext(596, 21, true);
            WriteLiteral("\n\n\n    </div>\n\n</div>");
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
