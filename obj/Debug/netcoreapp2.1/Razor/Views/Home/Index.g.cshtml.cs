#pragma checksum "D:\desk\count1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ccc73a8d9277c62d4aebb0f78e973ec9a9385fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ccc73a8d9277c62d4aebb0f78e973ec9a9385fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("280px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon/red-circle-with-pdf-icon-png-20.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25px;padding-left: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 85%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\desk\count1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 59, true);
            WriteLiteral("\r\n\r\n    <div class=\"slider\">\r\n        <ul class=\"slides\">\r\n");
            EndContext();
#line 8 "D:\desk\count1\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.slider)
            {

#line default
#line hidden
            BeginContext(170, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(212, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f6a403a30f784560ac3af572fcab3d9d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 222, "~/slideImage/", 222, 13, true);
#line 11 "D:\desk\count1\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 235, item.ImgUrl, 235, 12, false);

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
            BeginContext(249, 47, true);
            WriteLiteral(" <!-- random image -->\r\n                </li>\r\n");
            EndContext();
#line 13 "D:\desk\count1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(311, 380, true);
            WriteLiteral(@"        </ul>
    </div>

<div class=""card grey lighten-4"">
     <div class=""row"">
           <div class=""col s12 m4"">
               
                   <div class=""card-content"">
             <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>    ގެލަރީ   </strong></h5><hr>
        <div class="""">
            <div class=""carousel carousel-slider center"">
");
            EndContext();
#line 25 "D:\desk\count1\Views\Home\Index.cshtml"
         foreach (var item in ViewBag.gallery)
          {

#line default
#line hidden
            BeginContext(752, 57, true);
            WriteLiteral("              <div class=\"carousel-item\">\r\n              ");
            EndContext();
            BeginContext(809, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "524af507c4944d239bbec37b59a2b6d3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 819, "~/gallery/", 819, 10, true);
#line 28 "D:\desk\count1\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 829, item.ImgUrl, 829, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(872, 28, true);
            WriteLiteral("    \r\n              </div>\r\n");
            EndContext();
#line 30 "D:\desk\count1\Views\Home\Index.cshtml"
             }

#line default
#line hidden
            BeginContext(916, 264, true);
            WriteLiteral(@"             </div>
        </div>
             </div>
             
                 <div class=""card-content"">
        <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>    އިސްތިހާރު   </strong></h5><hr>
              <div class=""container"">
");
            EndContext();
#line 38 "D:\desk\count1\Views\Home\Index.cshtml"
         foreach (var item in ViewBag.advertise)
          {

#line default
#line hidden
            BeginContext(1243, 14, true);
            WriteLiteral("              ");
            EndContext();
            BeginContext(1257, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21a777f765514faaa286b842bac2b5e2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1267, "~/LinkPic/", 1267, 10, true);
#line 40 "D:\desk\count1\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1277, item.ImgUrl, 1277, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1312, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 41 "D:\desk\count1\Views\Home\Index.cshtml"
             }

#line default
#line hidden
            BeginContext(1334, 372, true);
            WriteLiteral(@"        </div>
                 </div>
              
        </div>
           
           <div class=""col s12 m4"">
               
                   <div class=""card-content"">
               <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>   ފަހުގެ އެންގުންތައް   </strong></h5><hr>
               </div>
               <div class=""container"">
");
            EndContext();
#line 53 "D:\desk\count1\Views\Home\Index.cshtml"
                foreach (var item in ViewBag.anouncements)
                  {

#line default
#line hidden
            BeginContext(1787, 141, true);
            WriteLiteral("          <ul class=\"right-align\">\r\n              <li style=\"font-family: Faruma;direction: rtl;font-size: 20px;\">\r\n              <a href=\"\">");
            EndContext();
            BeginContext(1928, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f9f31da896d461d979a5eee9a76169b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2028, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2030, 10, false);
#line 57 "D:\desk\count1\Views\Home\Index.cshtml"
                                                                                                                         Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2040, 46, true);
            WriteLiteral("</a>\r\n             </li>\r\n          </ul>   \r\n");
            EndContext();
#line 60 "D:\desk\count1\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
            BeginContext(2108, 349, true);
            WriteLiteral(@"                      </div>
                   
           </div>

           <div class=""col s12 m4"">
            
                   <div class=""card-content"">
               <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>   ފަހުގެ ޙަބަރު   </strong></h5><hr>
               </div>
               <div class=""container"">
");
            EndContext();
#line 71 "D:\desk\count1\Views\Home\Index.cshtml"
                foreach (var item in ViewBag.news)
                    {

#line default
#line hidden
            BeginContext(2532, 65, true);
            WriteLiteral("           <div class=\"row\">\r\n               <div class=\"col s4\">");
            EndContext();
            BeginContext(2597, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "526bffa7c95b46a9891641444f94180f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2607, "~/newsImage/", 2607, 12, true);
#line 74 "D:\desk\count1\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2619, item.ImgUrl, 2619, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2676, 106, true);
            WriteLiteral("</div>\r\n                <div class=\"col s8 right-align\"><a class=\"dh right-align\" style=\"font-size: 19px;\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2782, "\"", 2834, 1);
#line 75 "D:\desk\count1\Views\Home\Index.cshtml"
WriteAttributeValue("", 2789, Url.Action("Index","News",new{id =@item.Id}), 2789, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2835, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2837, 10, false);
#line 75 "D:\desk\count1\Views\Home\Index.cshtml"
                                                                                                                                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2847, 48, true);
            WriteLiteral("</a></div>\r\n           </div>\r\n           <hr>\r\n");
            EndContext();
#line 78 "D:\desk\count1\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
            BeginContext(2917, 371, true);
            WriteLiteral(@"                   </div>
                   
           </div>

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

//materialboxed



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
