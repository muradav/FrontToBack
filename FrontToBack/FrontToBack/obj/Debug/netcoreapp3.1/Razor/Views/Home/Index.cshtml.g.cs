#pragma checksum "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6acf5e3abc6f157f45129f1d1e16f77f90407d1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6acf5e3abc6f157f45129f1d1e16f77f90407d1b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c30d05ecf3fc0053e5548247a0098d13855844", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/h1-custom-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n\r\n        <!-- SLIDER START -->\r\n\r\n        <section id=\"slider\">\r\n            <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 13 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                 foreach (var item in Model.Sliders)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b5627", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 288, "~/img/", 288, 6, true);
#nullable restore
#line 15 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 294, item.ImageUrl, 294, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 16 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"container context pl-lg-5 ml-lg-3\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-5\">\r\n                        <div class=\"text\">\r\n                            <h1>");
#nullable restore
#line 22 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                           Write(Html.Raw(Model.SliderContent.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <h1>you mean it</h1>\r\n                            <p class=\"text-black-50 d-none d-sm-block\">");
#nullable restore
#line 24 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                  Write(Model.SliderContent.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        </div>\r\n                        <div class=\"img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b8513", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 889, "~/img/", 889, 6, true);
#nullable restore
#line 27 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 895, Model.SliderContent.ImageUrl, 895, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SLIDER END -->

        <!-- PRODUCTS START -->

        <section id=""products"">
            <div class=""container"">
                <div class=""row pt-5"">
                    <div class=""col-12 d-flex justify-content-between"">
                        <ul class=""category-mobile d-md-none list-unstyled"">
                            <li>
                                <a");
            BeginWriteAttribute("href", " href=\"", 1456, "\"", 1463, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                                <i class=\"fas fa-caret-down\"></i>\r\n                                <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1706, "\"", 1713, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1785, "\"", 1792, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1872, "\"", 1879, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1957, "\"", 1964, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2044, "\"", 2051, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2129, "\"", 2136, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2213, "\"", 2220, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                                </ul>\r\n                            </li>\r\n                        </ul>\r\n                        <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2476, "\"", 2483, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 59 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                             foreach (var item in Model.Categories)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <li><a");
            BeginWriteAttribute("href", " href=\"", 2649, "\"", 2656, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 61 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                  Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 61 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 62 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <ul class=\"list-unstyled\">\r\n                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2891, "\"", 2898, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2"">Filter</a>
                                <i class=""fas fa-caret-down""></i>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""row"">
                   ");
#nullable restore
#line 73 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
              Write(await Component.InvokeAsync("Product",4));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </section>

        <!-- PRODUCTS END -->

        <!-- ABOUT START -->

        <section id=""about"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-lg-6"">
                        <div class=""img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b15459", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3575, "~/img/", 3575, 6, true);
#nullable restore
#line 87 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3581, Model.AboutImage.ImageUrl, 3581, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div
                                class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                                <i class=""fas fa-play fa-lg""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                            <h1>");
#nullable restore
#line 96 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                           Write(Html.Raw(Model.AboutContent.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p class=\"py-3\">");
#nullable restore
#line 97 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                       Write(Model.AboutContent.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <ul class=\"list-unstyled\">\r\n                                <li class=\"mt-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b18337", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Hand picked just\r\n                                    for you.</li class=\"mt-3\">\r\n                                <li class=\"mt-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b19671", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Unique flower\r\n                                    arrangements</li>\r\n                                <li class=\"mt-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b20991", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" Best way to say
                                    you care.</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- ABOUT END -->

        <!-- EXPERTS START -->

        <section id=""experts"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>Flower Experts</h1>
                            <p class=""text-black-50"">A perfect blend of creativity, energy, communication, happiness and
                                love. Let us arrange
                                a smile for you.</p>
                        </div>
                    </div>
                </div>
                <div class=""row pb-5"">
");
#nullable restore
#line 129 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                     foreach (var item in Model.Experts)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b23608", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5953, "~/img/", 5953, 6, true);
#nullable restore
#line 134 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5959, item.ImageUrl, 5959, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                <h6>");
#nullable restore
#line 137 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 138 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                    Write(item.Proffesion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 142 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-3""></div>
                    <div class=""col-lg-3""></div>
                    <div class=""col-lg-3""></div>
                </div>
            </div>
        </section>

        <!-- EXPERTS END -->

        <!-- SUBSCRIBE START -->

        <section id=""subscribe"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-12"">
                        <div class=""content text-center py-5"">
                            <h3>Join The Colorful Bunch!</h3>
                            <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                                <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                                <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                            </div>
                        </div>
                    </div>
                </div>
  ");
            WriteLiteral(@"          </div>
        </section>

        <!-- SUBSCRIBE END -->

        <!-- BLOG START -->

        <section id=""blog"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>From our Blog</h1>
                            <p class=""text-black-50"">A perfect blend of creativity, energy, communication, happiness and
                                love. Let us arrange
                                a smile for you.</p>
                        </div>
                    </div>
                </div>
                <div class=""row pb-5"">
");
#nullable restore
#line 187 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                     foreach (var item in Model.Blogs)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"col-md-6 col-lg-4\">\r\n                        <div class=\"item\">\r\n                            <div class=\"img position-relative\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b28656", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8391, "~/img/", 8391, 6, true);
#nullable restore
#line 192 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8397, item.ImageUrl, 8397, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                    <span>");
#nullable restore
#line 194 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                     Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text mt-3 text-center px-5\">\r\n                                <h5>");
#nullable restore
#line 198 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 199 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                    Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 203 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </section>

        <!-- BLOG END -->

        <!-- SAY START -->

        <section id=""say"">
            <div class=""container"">
                <div class=""row py-5 justify-content-center"">
                    <div class=""col-md-8 col-xl-6"">
                        <div class=""owl-carousel say"">
");
#nullable restore
#line 217 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                             foreach (var item in Model.Florists)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <div>\r\n                                <div class=\"item text-center\">\r\n                                    <div class=\"img d-flex justify-content-center\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b32769", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9684, "~/img/", 9684, 6, true);
#nullable restore
#line 222 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9690, item.ImageUrl, 9690, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"text text-muted pt-3 pb-5\">\r\n                                        <i>");
#nullable restore
#line 225 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                      Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i>\r\n                                    </div>\r\n                                    <div class=\"author\">\r\n                                        <h6>");
#nullable restore
#line 228 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-black-50\">");
#nullable restore
#line 229 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                            Write(item.Proffesion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 233 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SAY END -->

        <!-- INSTAGRAM START -->

        <section id=""instagram"">
            <div class=""owl-carousel instagram"">
");
#nullable restore
#line 246 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                 foreach (var item in Model.SocialAddressFlorists)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6acf5e3abc6f157f45129f1d1e16f77f90407d1b36531", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10690, "~/img/", 10690, 6, true);
#nullable restore
#line 248 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10696, item.ImageUrl, 10696, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 249 "C:\Users\HP\Desktop\Development\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n                #FIORELLO\r\n            </div>\r\n        </section>\r\n\r\n        <!-- INSTAGRAM END -->\r\n\r\n    </main>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
