#pragma checksum "/home/munnim/Desktop/count1/Views/Link/GuestHouse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7af16aa51fb0113ecd1811e6a416c75699ca90b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Link_GuestHouse), @"mvc.1.0.view", @"/Views/Link/GuestHouse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Link/GuestHouse.cshtml", typeof(AspNetCore.Views_Link_GuestHouse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7af16aa51fb0113ecd1811e6a416c75699ca90b", @"/Views/Link/GuestHouse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Link_GuestHouse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 251, true);
            WriteLiteral("<div class=\"card\">\r\n<div class=\"container\">\r\n    <br>\r\n    <h5 class=\"dh right-align \" style=\" \">ގެސްޓް ހައުސް ތަކުގެ މަޢުލޫމާތު</h5>\r\n            <hr>\r\n    <br>\r\n    <div class=\"row\">\r\n        <div class=\"col s12 dh right-align\">\r\n             <ul>\r\n");
            EndContext();
#line 10 "/home/munnim/Desktop/count1/Views/Link/GuestHouse.cshtml"
                    foreach (var item in  ViewBag.GH)
            {

#line default
#line hidden
            BeginContext(321, 44, true);
            WriteLiteral("                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 365, "\"", 425, 1);
#line 13 "/home/munnim/Desktop/count1/Views/Link/GuestHouse.cshtml"
WriteAttributeValue("", 372, Url.Action("GuestHouseInfo","Link",new{id=@item.Id}), 372, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(426, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(454, 10, false);
#line 14 "/home/munnim/Desktop/count1/Views/Link/GuestHouse.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(464, 73, true);
            WriteLiteral("\r\n                    </a>\r\n                    \r\n                </li>\r\n");
            EndContext();
#line 18 "/home/munnim/Desktop/count1/Views/Link/GuestHouse.cshtml"
                  
            }

#line default
#line hidden
            BeginContext(572, 89, true);
            WriteLiteral("         </ul>\r\n        </div>\r\n        \r\n         \r\n      \r\n    </div>\r\n\r\n</div>\r\n</div>");
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
