#pragma checksum "D:\desk\count1\Views\Home\Services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2cf3d260641b602332e9ccd7e129e6666c62f14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Services), @"mvc.1.0.view", @"/Views/Home/Services.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Services.cshtml", typeof(AspNetCore.Views_Home_Services))]
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
#line 1 "D:\desk\count1\Views\_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "D:\desk\count1\Views\_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2cf3d260641b602332e9ccd7e129e6666c62f14", @"/Views/Home/Services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Services : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 279, true);
            WriteLiteral(@"<div class=""card"">
    <div class=""container"">
        <br>
        <h5 class=""dh right-align"">ކައުންސިލްގެ ފަރާތުން  ދޭ ހިދުމަތް ތަކުގެ ތަފްސީލް</h5>
        <hr>
         <div class=""row"">
     
                <div class=""col s12"">
                     <ul class="""">
");
            EndContext();
#line 10 "D:\desk\count1\Views\Home\Services.cshtml"
                             foreach (var item in  ViewBag.services)
        {
           

#line default
#line hidden
            BeginContext(373, 156, true);
            WriteLiteral("                        <li>\r\n                        \r\n                        <h5 class=\"dh right-align\" style=\"direction: rtl\">\r\n                        ");
            EndContext();
            BeginContext(530, 10, false);
#line 16 "D:\desk\count1\Views\Home\Services.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(540, 259, true);
            WriteLiteral(@"

                        </h5>
                       
                        
                       <span>

                            <p class=""dh right-align"" style=""direction: rtl; overflow-wrap: break-word; "">
                                ");
            EndContext();
            BeginContext(800, 9, false);
#line 24 "D:\desk\count1\Views\Home\Services.cshtml"
                           Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(809, 100, true);
            WriteLiteral("\r\n                            </p>\r\n                        </span>\r\n                        </li>\r\n");
            EndContext();
#line 28 "D:\desk\count1\Views\Home\Services.cshtml"
        }

#line default
#line hidden
            BeginContext(920, 101, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n\r\n      \r\n            </div>\r\n\r\n    </div>\r\n</div>");
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
