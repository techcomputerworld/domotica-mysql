#pragma checksum "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eec0258396440290ae6a7d7582b00844abf3bc34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Views\_ViewImports.cshtml"
using Domotica_mysql;

#line default
#line hidden
#line 2 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Views\_ViewImports.cshtml"
using Domotica_mysql.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eec0258396440290ae6a7d7582b00844abf3bc34", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f148acbf90bca89bc01fc550f382b5172f16707e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(38, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(43, 17, false);
#line 4 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(60, 10, true);
            WriteLiteral("</h2>\n<h3>");
            EndContext();
            BeginContext(71, 19, false);
#line 5 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(90, 170, true);
            WriteLiteral("</h3>\n\n<div class=\"container-fluid\">\n    <p>Esta aplicación web sirve para gestionar empresas de distintos campos, agrícultura, negocios online, facturación </p>\n</div>\n\n");
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
