#pragma checksum "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13768affac3dbc9250310cf21ddb8e14327a546d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Domotica_mysql.Areas.Usuarios.Models.Usuarios.Areas_Usuarios_Views_Usuarios_Index), @"mvc.1.0.view", @"/Areas/Usuarios/Views/Usuarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Usuarios/Views/Usuarios/Index.cshtml", typeof(Domotica_mysql.Areas.Usuarios.Models.Usuarios.Areas_Usuarios_Views_Usuarios_Index))]
namespace Domotica_mysql.Areas.Usuarios.Models.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 6 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\_ViewImports.cshtml"
using Domotica_mysql.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13768affac3dbc9250310cf21ddb8e14327a546d", @"/Areas/Usuarios/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3546b4148b3acb4e8059128ecd6232afe93d23ae", @"/Areas/Usuarios/Views/_ViewImports.cshtml")]
    public class Areas_Usuarios_Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataPaginador<InputModelRegistrar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Registrar/Registrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var list = Model.List;

#line default
#line hidden
            BeginContext(159, 301, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <section class=""Usuarios"">
        <div class=""row"">
            <div class=""col-12"">
                <h1> Usuarios </h1>
                

            </div>
            <div class=""row"">
                <div class=""col-12 col-sm-3"">
                    ");
            EndContext();
            BeginContext(460, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13768affac3dbc9250310cf21ddb8e14327a546d5746", async() => {
                BeginContext(539, 9, true);
                WriteLiteral("Registrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(552, 313, true);
            WriteLiteral(@"
                </div>
                
            </div>
         </div>
            <div class=""row mt-4"">
                <div class=""col-12"">
                    <table class=""tabla"">
                        <thead>
                            <tr>
                                <th scope=""col"">");
            EndContext();
            BeginContext(866, 48, false);
#line 28 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Input.Imagen));

#line default
#line hidden
            EndContext();
            BeginContext(914, 55, true);
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
            EndContext();
            BeginContext(970, 47, false);
#line 29 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Input.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 55, true);
            WriteLiteral("</th>\r\n                                <th scope=\"col\">");
            EndContext();
            BeginContext(1073, 46, false);
#line 30 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Input.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 109, true);
            WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 34 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
                             foreach (var item in list)
                            {
                                var imagen = item.Imagen;

#line default
#line hidden
            BeginContext(1375, 112, true);
            WriteLiteral("                            <tr>\r\n                                <td>    \r\n                                    ");
            EndContext();
            BeginContext(1487, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13768affac3dbc9250310cf21ddb8e14327a546d9750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1515, "~/images/fotos/", 1515, 15, true);
#line 39 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
AddHtmlAttributeValue("", 1530, imagen, 1530, 7, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1548, 149, true);
            WriteLiteral("\r\n                                </td>\r\n                                \r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1698, 40, false);
#line 43 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1854, 39, false);
#line 46 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 110, true);
            WriteLiteral("\r\n                                </td>\r\n                                \r\n                            </tr>\r\n");
            EndContext();
#line 50 "G:\Desarrollo de aplicaciones\asp.net\Domotica-mysql\Domotica-mysql\Areas\Usuarios\Views\Usuarios\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2034, 218, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n            \r\n        \r\n        <div class=\"col-12\">\r\n\r\n        </div>\r\n    </section>\r\n</div>\r\n    \r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataPaginador<InputModelRegistrar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
