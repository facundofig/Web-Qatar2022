#pragma checksum "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d03e8376b120bc1b33d7931fb1716799a405242"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operador_Estadisticas), @"mvc.1.0.view", @"/Views/Operador/Estadisticas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d03e8376b120bc1b33d7931fb1716799a405242", @"/Views/Operador/Estadisticas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Operador_Estadisticas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Partido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""text-center mb-5"">Estadísticas</h1>

<div class=""row"">
    <figure>
        <img src=""/img/mascota_mundial.png"" alt=""Mascota del mundial"" class=""img-fluid"" />
    </figure>
    <div class=""col align-self-center"">
        <h2>Partidos con tarjeta roja que reseñó un periodista</h2>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d03e8376b120bc1b33d7931fb1716799a4052424368", async() => {
                WriteLiteral(@"
            <div class=""input-group"">
                <input type=""email"" name=""emailBuscado"" class=""form-control"" placeholder=""Email"" />

                <input type=""submit"" value=""Buscar"" class=""btn btn-outline-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table\">\r\n                <tr>\r\n                    <th>Selección 1</th>\r\n                    <th>Selección 2</th>\r\n                    <th>Fecha</th>\r\n                </tr>\r\n\r\n");
#nullable restore
#line 28 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
                 foreach (var p in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 31 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
                       Write(p.Seleccion1.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
                       Write(p.Seleccion2.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
                       Write(p.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
            WriteLiteral("            <hr />\r\n");
#nullable restore
#line 39 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Selecciones con más goles</h2>\r\n\r\n");
#nullable restore
#line 42 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
         foreach (var s in ViewBag.selecciones)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 44 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
             Write(s.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n");
#nullable restore
#line 45 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Operador\Estadisticas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n        \r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Partido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
