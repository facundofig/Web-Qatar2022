#pragma checksum "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc91a5097545fa931df94207c9914c7e4a18979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partido_PartidosEntreFechas), @"mvc.1.0.view", @"/Views/Partido/PartidosEntreFechas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc91a5097545fa931df94207c9914c7e4a18979", @"/Views/Partido/PartidosEntreFechas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Partido_PartidosEntreFechas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Partido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row text-center mb-5"">
    <figure class=""col"">
        <img src=""/img/mascota_mundial.png"" alt=""Mascota del mundial"" class=""img-fluid"" />
    </figure>

    <div class=""col align-self-center"">
        <h1>Partidos jugados entre ciertas fechas</h1>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cc91a5097545fa931df94207c9914c7e4a189794757", async() => {
                WriteLiteral(@"
            <label>Fecha inicial: </label>
            <input type=""date"" name=""fechaInicial"" />

            <label>Fecha final: </label>
            <input type=""date"" name=""fechaFinal"" />

            <input type=""submit"" value=""Buscar"" class=""btn btn-primary mt-4 mb-4"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 25 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr class=\"table-info\">\r\n            <th>Selecciones</th>\r\n            <th>Goles</th>\r\n            <th>Tarjetas amarillas</th>\r\n            <th>Tarjetas rojas</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 35 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
         foreach (var p in Model)
        {
            int golesSeleccion1 = 0;
            int golesSeleccion2 = 0;
            int amarillasSeleccion1 = 0;
            int amarillasSeleccion2 = 0;
            int rojasSeleccion1 = 0;
            int rojasSeleccion2 = 0;

            foreach (var i in p.GetIncidencias())
            {
                if (i.Jugador.Pais.Equals(p.Seleccion1.Pais))
                {
                    if (i.Tipo == Dominio.TipoIncidencia.Gol)
                    {
                        golesSeleccion1++;
                    }
                    else if (i.Tipo == Dominio.TipoIncidencia.Amonestado)
                    {
                        amarillasSeleccion1++;
                    }
                    else
                    {
                        rojasSeleccion1++;
                    }
                }
                else if (i.Jugador.Pais.Equals(p.Seleccion2.Pais))
                {
                    if (i.Tipo == Dominio.TipoIncidencia.Gol)
                    {
                        golesSeleccion2++;
                    }
                    else if (i.Tipo == Dominio.TipoIncidencia.Amonestado)
                    {
                        amarillasSeleccion2++;
                    }
                    else
                    {
                        rojasSeleccion2++;
                    }
                }
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 79 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
               Write(p.Seleccion1.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 79 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
                                            Write(p.Seleccion2.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
               Write(p.Seleccion1.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 81 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
                                          Write(golesSeleccion1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    ");
#nullable restore
#line 82 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
               Write(p.Seleccion2.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 82 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
                                          Write(golesSeleccion2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
               Write(p.Seleccion1.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 85 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
                                          Write(amarillasSeleccion1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    ");
#nullable restore
#line 86 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
               Write(p.Seleccion2.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 86 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
                                          Write(amarillasSeleccion2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
               Write(p.Seleccion1.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 89 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
                                          Write(rojasSeleccion1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    ");
#nullable restore
#line 90 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
               Write(p.Seleccion2.Pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 90 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
                                          Write(rojasSeleccion2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 93 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 95 "G:\Mi unidad\ORT - ATI\Semestre_2\Programacion_2\Obligatorios\Obligatorio2\Implementacion\WebApp\Views\Partido\PartidosEntreFechas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cc91a5097545fa931df94207c9914c7e4a1897914016", async() => {
                WriteLiteral("Atrás");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
