#pragma checksum "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a3e1d7753fe432bf2c2dcd548e85bcb10d1955"
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
#line 1 "/home/munnim/Desktop/FinalMaamiili/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/munnim/Desktop/FinalMaamiili/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0a3e1d7753fe432bf2c2dcd548e85bcb10d1955", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;height: 15%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon/red-circle-with-pdf-icon-png-20.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 1.2em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" responsive-img "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
  

ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(40, 109, true);
            WriteLiteral("\n<div class=\"container\">\n\n\n\n\n\n\n\n    <div class=\"row\">\n        <br>\n\n        <div class=\"col  m5 s12 right\">\n\n");
            EndContext();
#line 20 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
             if (ViewBag.news != null)
            {
            

#line default
#line hidden
#line 22 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
             foreach (var item in ViewBag.news)

            {




#line default
#line hidden
            BeginContext(268, 37, true);
            WriteLiteral("            <div class=\"col m12 s12\">");
            EndContext();
            BeginContext(305, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e399f5ea9b4e455e92b615dd3d30b89d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 315, "~/newsImage/", 315, 12, true);
#line 28 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 327, item.ImgUrl, 327, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(366, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
            BeginContext(374, 137, true);
            WriteLiteral("            <div class=\"col s12 right-align\" style=\"padding: 5px;\"><a class=\"dh right-align\" style=\"font-size: 29px;font-weight: bolder;\"");
            EndContext();
            BeginWriteAttribute("href", "\n                    href=\"", 511, "\"", 582, 1);
#line 31 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
WriteAttributeValue("", 538, Url.Action("Index","News",new{id=@item.Id}), 538, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(583, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(585, 10, false);
#line 31 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                                                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(595, 109, true);
            WriteLiteral("</a>\n                <br>\n                <span class=\" right-align blue-grey-text \" style=\"direction: rtl\"> ");
            EndContext();
            BeginContext(705, 9, false);
#line 33 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                                                                              Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(714, 69, true);
            WriteLiteral(" <i class=\"material-icons\">date_range</i></span>\n\n            </div>\n");
            EndContext();
#line 36 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"





            }

#line default
#line hidden
#line 41 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
             
            }

#line default
#line hidden
            BeginContext(816, 57, true);
            WriteLiteral("\n\n\n        </div>\n        <div class=\"col m4 s12 right\">\n");
            EndContext();
#line 48 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
             if (ViewBag.ImportantNews != null)
            {
            

#line default
#line hidden
#line 50 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
             foreach (var item in ViewBag.ImportantNews)

            {

#line default
#line hidden
            BeginContext(1007, 122, true);
            WriteLiteral("            <div class=\"row\">\n                <div class=\"col m6 s6 right\" style=\"padding-top: 6px;\">\n                    ");
            EndContext();
            BeginContext(1129, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e12c2ad3166d41ccaee4354d3c66e6ee", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1139, "~/newsImage/", 1139, 12, true);
#line 55 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 1151, item.ImgUrl, 1151, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1206, 87, true);
            WriteLiteral("\n\n                </div>\n                <div class=\"col m6 s6\">\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1293, "\"", 1344, 1);
#line 59 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
WriteAttributeValue("", 1300, Url.Action("Index","News",new{id=@item.Id}), 1300, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1345, 79, true);
            WriteLiteral(" class=\"right dh\" style=\"direction: rtl; font-size: 17px;font-weight: bolder;\">");
            EndContext();
            BeginContext(1425, 10, false);
#line 59 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                                                                                                                                                    Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1435, 92, true);
            WriteLiteral("</a>\n\n                    <span class=\"blue-grey-text  right-align\" style=\"direction: rtl\"> ");
            EndContext();
            BeginContext(1528, 9, false);
#line 61 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                                                                                 Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1537, 93, true);
            WriteLiteral(" <i class=\"material-icons\">date_range</i></span>\n\n                </div>\n\n            </div>\n");
            EndContext();
#line 66 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"


            }

#line default
#line hidden
#line 68 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
             
            }

#line default
#line hidden
            BeginContext(1660, 370, true);
            WriteLiteral(@"
        </div>
        <div class=""col m3 s12"" style=""border: 1px solid green;border-radius: 15px;"">
         
               <h5 class=""right-align  dhsub news-parag"" style=""direction: rtl; font-weight: bold;"">

                <i class=""material-icons""> people</i>

                އިޢުލާން

            </h5>

            <hr>

            <ul class=""right-align"">

");
            EndContext();
#line 86 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                 if (ViewBag.anouncements != null)
                {
                

#line default
#line hidden
#line 88 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                 foreach (var item in ViewBag.anouncements)

                {


#line default
#line hidden
            BeginContext(2179, 97, true);
            WriteLiteral("                <li class=\"dh\" style=\"font-family: Faruma;direction: rtl;\">\n\n                    ");
            EndContext();
            BeginContext(2276, 246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc08ce8e48b94b079e10d1431bb1e1cc", async() => {
                BeginContext(2347, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c1d138525884905bec9271b02a4e3ab", async() => {
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
                BeginContext(2457, 28, true);
                WriteLiteral("\n\n\n\n                        ");
                EndContext();
                BeginContext(2486, 10, false);
#line 99 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2496, 22, true);
                WriteLiteral("\n\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2285, "~/anounceDoc/", 2285, 13, true);
#line 94 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 2298, item.DocUrl, 2298, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2522, 177, true);
            WriteLiteral("\n                    <br>\n                    <span class=\"right-align blue-grey-text \" style=\"direction: rtl\"> <i class=\"material-icons\">date_range</i>\n                        ");
            EndContext();
            BeginContext(2700, 9, false);
#line 104 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                   Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2709, 31, true);
            WriteLiteral("</span>\n\n                </li>\n");
            EndContext();
#line 107 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"

                }

#line default
#line hidden
#line 108 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                 
                }

#line default
#line hidden
            BeginContext(2777, 408, true);
            WriteLiteral(@"


            </ul>

        </div>



    </div>

    <hr>








    <div class=""row"" style="""">

        <div class=""col m6 s12 right "">
            <h5 class=""right-align  dhsub news-parag"" style=""direction: rtl; font-weight: bold;"">

                <i class=""material-icons""> link
                </i>

                ޤަވައިދު

            </h5>
            <hr>
           <ul class=""right-align"">

");
            EndContext();
#line 144 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                 if (ViewBag.Rules != null)
                {
                

#line default
#line hidden
#line 146 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                 foreach (var item in ViewBag.Rules)

                {


#line default
#line hidden
            BeginContext(3320, 97, true);
            WriteLiteral("                <li class=\"dh\" style=\"font-family: Faruma;direction: rtl;\">\n\n                    ");
            EndContext();
            BeginContext(3417, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3e8b4ee50794b7f82c2385a8fd2f9bf", async() => {
                BeginContext(3485, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fd1cff8a96f14708bcffef3d0460e056", async() => {
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
                BeginContext(3595, 28, true);
                WriteLiteral("\n\n\n\n                        ");
                EndContext();
                BeginContext(3624, 10, false);
#line 157 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3634, 22, true);
                WriteLiteral("\n\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3426, "~/LinkPic/", 3426, 10, true);
#line 152 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 3436, item.ImgUrl, 3436, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3660, 177, true);
            WriteLiteral("\n                    <br>\n                    <span class=\"right-align blue-grey-text \" style=\"direction: rtl\"> <i class=\"material-icons\">date_range</i>\n                        ");
            EndContext();
            BeginContext(3838, 9, false);
#line 162 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                   Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(3847, 31, true);
            WriteLiteral("</span>\n\n                </li>\n");
            EndContext();
#line 165 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"

                }

#line default
#line hidden
#line 166 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                 
                }

#line default
#line hidden
            BeginContext(3915, 381, true);
            WriteLiteral(@"


            </ul>

        </div>

        <div class=""col m6 s12 right "">

            <h5 class=""right-align  dhsub news-parag"" style=""direction: rtl; font-weight: bold;"">

                <i class=""material-icons""> people</i>

                ޑައުންލޯޑް

            </h5>

            <hr>

            <ul class=""right-align"">

                   <ul class="" right-align"">
");
            EndContext();
#line 190 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                        if (ViewBag.Form != null)
                       {
                                   

#line default
#line hidden
#line 192 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                                    foreach (var item in  ViewBag.Form)
                             {

#line default
#line hidden
            BeginContext(4474, 118, true);
            WriteLiteral("                          <li class=\"dh right-align\" style=\"font-family: Faruma;direction: rtl;\">\n                    ");
            EndContext();
            BeginContext(4592, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe27a6c1c84a4ccdafa8043134c1abf5", async() => {
                BeginContext(4651, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b86852f61ef4c5b906655552b1bd057", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4733, 42, true);
                WriteLiteral("\n                    \n                    ");
                EndContext();
                BeginContext(4776, 10, false);
#line 197 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
               Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(4786, 41, true);
                WriteLiteral("\n                   \n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4601, "~/LinkPic/", 4601, 10, true);
#line 195 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4611, item.ImgUrl, 4611, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4831, 23, true);
            WriteLiteral("\n                </li>\n");
            EndContext();
#line 201 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                
            }

#line default
#line hidden
#line 202 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
              
                       }

#line default
#line hidden
            BeginContext(4911, 486, true);
            WriteLiteral(@"          
            </ul>


            </ul>



        </div>

    </div>

    <div class="""">

        <div class=""row"" style="""">
            <div class=""col s12 right"">
                <h5 class=""right-align  dhsub news-parag"" style=""direction: rtl; font-weight: bold;"">

                    <i class=""material-icons""> image

                    </i>

                    ފޮޓޯ ގެލަރީ
                </h5>
                <hr>
                <div class="" "">
                    
");
            EndContext();
#line 231 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                     if (ViewBag.gallery != null)
                    {
                       
                            
                     

                            

#line default
#line hidden
#line 237 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                             foreach (dynamic item in ViewBag.gallery)
                    {
                        var xc = item .ImgUrl.Split(',');
                            

#line default
#line hidden
            BeginContext(5725, 130, true);
            WriteLiteral("                                  <div class=\"col s12 m4 right\">\n      <div class=\"card\" >\n        <div class=\"card-image\" >     \n");
            EndContext();
#line 244 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                             for (int i = 0; i < 1; i++)
                            {
                               
                            

#line default
#line hidden
            BeginContext(6003, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(6039, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d2b739206b24a44a8a2288c64d53d97", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6049, "~/gallery/", 6049, 10, true);
#line 248 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 6059, xc[i], 6059, 6, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6094, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 249 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"

                              
                                   
                                   
                               
                            }

#line default
#line hidden
            BeginContext(6261, 114, true);
            WriteLiteral("                            </div>\n        <div class=\"card-content right\">\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6375, "\"", 6437, 1);
#line 257 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
WriteAttributeValue("", 6382, Url.Action("GallerySlider","Home",new{id=@item.Title}), 6382, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6438, 54, true);
            WriteLiteral(" class=\"dh\" style=\"direction: rtl;font-weight: bold\" >");
            EndContext();
            BeginContext(6493, 10, false);
#line 257 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                                                                                                                                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(6503, 256, true);
            WriteLiteral(@"</a>
         
        </div>
      
      </div>
    </div>
                             <!-- </div>
                                 
                                    <div class=""card-action center-align"">
                                    <a href=""");
            EndContext();
            BeginContext(6760, 54, false);
#line 266 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                                        Write(Url.Action("GallerySlider","Home",new{id=@item.Title}));

#line default
#line hidden
            EndContext();
            BeginContext(6814, 13, true);
            WriteLiteral("\" class=\"dh\">");
            EndContext();
            BeginContext(6828, 10, false);
#line 266 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                                                                                                            Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(6838, 168, true);
            WriteLiteral("</a>\n                                    </div> -->\n                                <!-- </div>\n                            \n                                </div> -->\n");
            EndContext();
#line 271 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"

                        
                    
                     
                    }

#line default
#line hidden
#line 275 "/home/munnim/Desktop/FinalMaamiili/Views/Home/Index.cshtml"
                     
                    
                  
                    }

#line default
#line hidden
            BeginContext(7159, 372, true);
            WriteLiteral(@"                </div>


            </div>









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
