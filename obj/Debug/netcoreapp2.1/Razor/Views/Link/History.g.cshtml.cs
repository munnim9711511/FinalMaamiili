#pragma checksum "/home/muunim/FinalMaamiili/Views/Link/History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbcbdb00d541855e46d5e369309a649d404b7df6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Link_History), @"mvc.1.0.view", @"/Views/Link/History.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Link/History.cshtml", typeof(AspNetCore.Views_Link_History))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbcbdb00d541855e46d5e369309a649d404b7df6", @"/Views/Link/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Link_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 269, true);
            WriteLiteral(@"<div class="""">
<div class=""container"">
    <br>
    <h5 class=""dh right-align "" style="" "">   މާމިގިލީގައި ހުންނަ މުހިންމު ތަންތަނުގެ މަޢުލޫމާތު</h5>
            <hr>
    <br>
    <div class=""row"">
        <div class=""col s12 dh right-align"">
             <ul>
");
            EndContext();
#line 10 "/home/muunim/FinalMaamiili/Views/Link/History.cshtml"
                    foreach (var item in  ViewBag.history)
            {

#line default
#line hidden
            BeginContext(344, 44, true);
            WriteLiteral("                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 388, "\"", 445, 1);
#line 13 "/home/muunim/FinalMaamiili/Views/Link/History.cshtml"
WriteAttributeValue("", 395, Url.Action("HistoryInfo","Link",new{id=@item.Id}), 395, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(446, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(474, 10, false);
#line 14 "/home/muunim/FinalMaamiili/Views/Link/History.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(484, 73, true);
            WriteLiteral("\r\n                    </a>\r\n                    \r\n                </li>\r\n");
            EndContext();
#line 18 "/home/muunim/FinalMaamiili/Views/Link/History.cshtml"
                  
            }

#line default
#line hidden
            BeginContext(592, 89, true);
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
