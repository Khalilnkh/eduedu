#pragma checksum "C:\Users\User\source\repos\EduMap\EduMap\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e928039cfabf60bab789744e169d461d8accbf2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\User\source\repos\EduMap\EduMap\Views\_ViewImports.cshtml"
using EduMap.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\EduMap\EduMap\Views\_ViewImports.cshtml"
using EduMap.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\EduMap\EduMap\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\EduMap\EduMap\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\EduMap\EduMap\Views\_ViewImports.cshtml"
using EduMap.ComponentViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\EduMap\EduMap\Views\_ViewImports.cshtml"
using EduMap.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\EduMap\EduMap\Views\_ViewImports.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e928039cfabf60bab789744e169d461d8accbf2d", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671c461119fcdad26a19e7fd38c78e3131eb3aa7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HeaderVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assest/img/logo/logo2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eduhome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\EduMap\EduMap\Views\Shared\Components\Header\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""top"">
		    <div class=""header-top"">
		        <div class=""container"">
		            <div class=""row"">
		                <div class=""col-md-8 col-sm-8 col-xs-12"">
		                    <div class=""header-top-left"">
		                        <p>HAVE ANY QUESTION ?   ");
#nullable restore
#line 12 "C:\Users\User\source\repos\EduMap\EduMap\Views\Shared\Components\Header\Default.cshtml"
                                                    Write(Model.Settings.FirstOrDefault(s => s.Key == "Question").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral(@"		                    </div>
		                </div>
		                <div class=""col-md-4 col-sm-4 col-xs-12"">
		                    <div class=""header-top-right text-right"">
		                        <ul>
		                            <li><a href=""login.html"">login</a></li>
		                            <li><a href=""signup.html"">signup</a></li>
		                        </ul>
		                    </div>
		                </div>
		            </div>
		        </div>
		    </div>
			<div class=""header-area two header-sticky"">
				<div class=""container"">
					<div class=""row"">
						<div class=""col-md-3 col-sm-3 col-xs-6"">
							<div class=""logo"">
								<a href=""index.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e928039cfabf60bab789744e169d461d8accbf2d7310", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
							</div>
						</div>
						<div class=""col-md-9 col-sm-9 col-xs-6"">
                            <div class=""content-wrapper text-right"">
                                <!-- Main Menu Start -->
                                <div class=""main-menu"">
                                    <nav>
                                        <ul>
                                            <li><a href=""index.html"">Home</a>
                                                <ul>
                                                    <li><a href=""index.html"">Home One</a></li>
                                                    <li><a href=""index-2.html"">Home Two</a></li>
                                                    <li><a href=""index-3.html"">Home Three</a></li>
                                                    <li><a href=""index-4.html"">Home Four</a></li>
                                                    <li><a href=""index-5.html"">Home Five</a></li>
                                          ");
            WriteLiteral(@"      </ul>
                                            </li>
                                            <li><a href=""about.html"">About</a></li>
                                            <li><a href=""course.html"">courses</a>
                                                <ul>
                                                    <li><a href=""course.html"">courses</a></li>
                                                    <li><a href=""course-details.html"">courses details</a></li>
                                                </ul>
                                            </li>
                                            <li><a href=""event.html"">event</a>
                                                <ul>
                                                    <li><a href=""event.html"">event</a></li>
                                                    <li><a href=""event-left-side-bar.html"">event left sidebar</a></li>
                                                    <li><a href=""event-right-");
            WriteLiteral(@"side-bar.html"">event right sidebar</a></li>
                                                    <li><a href=""event-details.html"">event details</a></li>
                                                </ul>
                                            </li>
                                            <li class=""hidden-sm""><a href=""teacher.html"">teacher</a>
                                                <ul>
                                                    <li><a href=""teacher.html"">teacher</a></li>
                                                    <li><a href=""teacher-details.html"">teacher details</a></li>
                                                </ul>
                                            </li>
                                            <li><a href=""blog.html"">blog</a>
                                                <ul>
                                                    <li><a href=""blog.html"">blog</a></li>
                                                    <li><a href=""blog");
            WriteLiteral(@"-left-side-bar.html"">blog left sidebar</a></li>
                                                    <li><a href=""blog-right-side-bar.html"">blog righ sidebar</a></li>
                                                    <li><a href=""blog-details.html"">blog details</a></li>
                                                </ul>
                                            </li>
                                            <li><a href=""contact.html"">Contact</a></li>
                                            <li><a href=""#"">Buy Now</a>
                                        </ul>
                                    </nav>
                                </div>
                                <!--Search Form Start-->
                                <div class=""search-btn"">
                                    <ul data-toggle=""dropdown"" class=""header-search search-toggle"">
                                        <li class=""search-menu"">
                                            <i class=""fa fa-search""");
            WriteLiteral(@"></i>
                                        </li>
                                    </ul>
                                    <div class=""search"">
                                        <div class=""search-form"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e928039cfabf60bab789744e169d461d8accbf2d12982", async() => {
                WriteLiteral(@"
                                                <input type=""search"" placeholder=""Search here..."" name=""search"" />
                                                <button type=""submit"">
                                                    <span><i class=""fa fa-search""></i></span>
                                                </button>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                                <!--End of Search Form-->
                                <!-- Main Menu End -->
                            </div>
						</div>
                        <div class=""col-xs-12"">
                            <div class=""mobile-menu hidden-lg hidden-md hidden-sm""></div> 
                        </div>
					</div>
				</div>
			</div>
		</header>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HeaderVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
