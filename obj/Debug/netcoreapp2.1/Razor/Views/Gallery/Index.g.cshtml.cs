#pragma checksum "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e51d4376108d70f9b58b07a57629da7adad53fb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/Index.cshtml", typeof(AspNetCore.Views_Gallery_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51d4376108d70f9b58b07a57629da7adad53fb2", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(5, 17, false);
#line 2 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(27, 136, true);
            WriteLiteral("\r\n<div class=\"\">\r\n  <div class=\"container\">\r\n    <br>\r\n    <div class=\"row\">\r\n      <h5 class=\"dh right-align\">ގެލަރީ</h5>\r\n      <hr>\r\n");
            EndContext();
#line 11 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
   if (ViewBag.gallery != null)
                    {
                       
                            
                      
                    

#line default
#line hidden
#line 16 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
                     foreach (dynamic item in ViewBag.gallery)
                    {
                        var xc = item .ImgUrl.Split(',');

                            

#line default
#line hidden
#line 20 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
                             for (int i = 0; i < 1; i++)
                            {

#line default
#line hidden
            BeginContext(535, 208, true);
            WriteLiteral("                                <div class=\"col m3 s12\">\r\n                                <div class=\"card\">\r\n                                    <div class=\"card-image\">\r\n                                    ");
            EndContext();
            BeginContext(743, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aec02a4d172a41eb8d73ada84b8a0c70", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 753, "~/gallery/", 753, 10, true);
#line 25 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
AddHtmlAttributeValue("", 763, xc[i], 763, 6, false);

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
            BeginContext(771, 232, true);
            WriteLiteral("\r\n                                   \r\n                                    </div>\r\n                                 \r\n                                    <div class=\"card-action center-align\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1003, "\"", 1065, 1);
#line 30 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
WriteAttributeValue("", 1010, Url.Action("GallerySlider","Home",new{id=@item.Title}), 1010, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1066, 10, true);
            WriteLiteral(" class=\"\">");
            EndContext();
            BeginContext(1077, 10, false);
#line 30 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
                                                                                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 130, true);
            WriteLiteral("</a>\r\n                                    </div>\r\n                                </div>\r\n                                </div>\r\n");
            EndContext();
#line 34 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
                               
                            }

#line default
#line hidden
#line 35 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
                             
                            

                        
                    
                     
                    }

#line default
#line hidden
#line 41 "/home/muunim/FinalMaamiili/Views/Gallery/Index.cshtml"
                     
                    }

#line default
#line hidden
            BeginContext(1430, 271, true);
            WriteLiteral(@"
    </div>
    <br>
  </div>
</div>

<script>
  var instance = M.Carousel.init({
    fullWidth: true,
    indicators: true
  });

  // Or with jQuery

  $('.carousel.carousel-slider').carousel({
    fullWidth: true,
    indicators: true
  });
</script>");
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
