#pragma checksum "C:\Users\User\source\repos\EduMap\EduMap\Views\Shared\Components\ProTeacher\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2baf1689c8b8b858b17d0723998f48def7b187bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProTeacher_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProTeacher/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2baf1689c8b8b858b17d0723998f48def7b187bd", @"/Views/Shared/Components/ProTeacher/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671c461119fcdad26a19e7fd38c78e3131eb3aa7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProTeacher_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProTeacher>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n    <div class=\"notice-right\">\r\n");
#nullable restore
#line 5 "C:\Users\User\source\repos\EduMap\EduMap\Views\Shared\Components\ProTeacher\Default.cshtml"
         foreach (ProTeacher proTeacher in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"single-notice-right mb-25 pb-25\">\r\n                <h3>");
#nullable restore
#line 8 "C:\Users\User\source\repos\EduMap\EduMap\Views\Shared\Components\ProTeacher\Default.cshtml"
               Write(proTeacher.MainTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p>");
#nullable restore
#line 9 "C:\Users\User\source\repos\EduMap\EduMap\Views\Shared\Components\ProTeacher\Default.cshtml"
              Write(proTeacher.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n");
#nullable restore
#line 11 "C:\Users\User\source\repos\EduMap\EduMap\Views\Shared\Components\ProTeacher\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProTeacher>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
