#pragma checksum "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a794169ae9f7c150954318997a8318d1bf9b4fef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Periodista_ListarResenas), @"mvc.1.0.view", @"/Views/Periodista/ListarResenas.cshtml")]
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
#line 1 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a794169ae9f7c150954318997a8318d1bf9b4fef", @"/Views/Periodista/ListarResenas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Periodista_ListarResenas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Resena>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Reseñas</h1>\r\n\r\n<table class=\"table\">\r\n    <tr class=\"table-info\">\r\n        <th>Fecha del partido</th>\r\n        <th>Nombre del grupo</th>\r\n        <th>Selección 1</th>\r\n        <th>Selección 2</th>\r\n        <th>Contenido</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 15 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
     foreach (var r in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
           Write(r.Partido.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
                 if (r.Partido.GetTipo() == "Grupo")
                {
                    Partido_FaseDeGrupos p = (Partido_FaseDeGrupos)r.Partido;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 22 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
                     Write(p.NombreGrupo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 23 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Es partido de eliminatoria</span>\r\n");
#nullable restore
#line 27 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>");
#nullable restore
#line 29 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
           Write(r.Partido.Seleccion1.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
           Write(r.Partido.Seleccion2.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
           Write(r.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Periodista\ListarResenas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a794169ae9f7c150954318997a8318d1bf9b4fef7643", async() => {
                WriteLiteral("Atrás");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Resena>> Html { get; private set; }
    }
}
#pragma warning restore 1591
