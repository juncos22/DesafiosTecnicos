#pragma checksum "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec76822760741dc811348fcd6c636d106cce2291"
// <auto-generated/>
#pragma warning disable 1591
namespace Covid19Casos.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Covid19Casos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Covid19Casos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Covid19Casos.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Covid19 Casos</h1>\r\n\r\nAplicacion Web para consultar casos relacionados al SarsCovid19\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row m-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.AddMarkupContent(5, "<h4>Formulario de Filtrado</h4>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                          Busqueda

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                    ConsultarInformacion

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label>Fecha de Inicio</label>\r\n                ");
                __Blazor.Covid19Casos.Client.Pages.Index.TypeInference.CreateInputDate_0(__builder2, 13, 14, "form-control", 15, 
#nullable restore
#line 16 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                              Busqueda.FechaInicio

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Busqueda.FechaInicio = __value, Busqueda.FechaInicio)), 17, () => Busqueda.FechaInicio);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Fecha de Fin</label>\r\n                ");
                __Blazor.Covid19Casos.Client.Pages.Index.TypeInference.CreateInputDate_1(__builder2, 22, 23, "form-control", 24, 
#nullable restore
#line 20 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                              Busqueda.FechaFin

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Busqueda.FechaFin = __value, Busqueda.FechaFin)), 26, () => Busqueda.FechaFin);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "<label>Edad de Inicio</label>\r\n                ");
                __Blazor.Covid19Casos.Client.Pages.Index.TypeInference.CreateInputNumber_2(__builder2, 31, 32, "form-control", 33, 
#nullable restore
#line 24 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                                Busqueda.EdadInicio

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Busqueda.EdadInicio = __value, Busqueda.EdadInicio)), 35, () => Busqueda.EdadInicio);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "<label>Edad de Fin</label>\r\n                ");
                __Blazor.Covid19Casos.Client.Pages.Index.TypeInference.CreateInputNumber_3(__builder2, 40, 41, "form-control", 42, 
#nullable restore
#line 28 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                                Busqueda.EdadFin

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Busqueda.EdadFin = __value, Busqueda.EdadFin)), 44, () => Busqueda.EdadFin);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "<label>Género</label>\r\n                ");
                __Blazor.Covid19Casos.Client.Pages.Index.TypeInference.CreateInputSelect_4(__builder2, 49, 50, "form-control", 51, 
#nullable restore
#line 32 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                                Busqueda.Genero

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Busqueda.Genero = __value, Busqueda.Genero)), 53, () => Busqueda.Genero, 54, (__builder3) => {
                    __builder3.AddMarkupContent(55, "<option value=\"M\">Masculino</option>\r\n                    ");
                    __builder3.AddMarkupContent(56, "<option value=\"F\">Femenino</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label>Provincia</label>\r\n                ");
                __Blazor.Covid19Casos.Client.Pages.Index.TypeInference.CreateInputSelect_5(__builder2, 61, 62, "form-control", 63, 
#nullable restore
#line 39 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                                Busqueda.Provincia

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Busqueda.Provincia = __value, Busqueda.Provincia)), 65, () => Busqueda.Provincia, 66, (__builder3) => {
#nullable restore
#line 40 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                     foreach (var provincia in provincias)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(67, "option");
                    __builder3.AddAttribute(68, "value", 
#nullable restore
#line 42 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                        provincia

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(69, 
#nullable restore
#line 42 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                    provincia

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 43 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.AddMarkupContent(71, "<button type=\"submit\" class=\"btn btn-primary btn-block\">Buscar Casos</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-md-8");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "class", "btn btn-secondary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                                     LimpiarFiltros

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Limpiar Filtros");
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
         if (Response == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "<p><em>Cargando información...</em></p>");
#nullable restore
#line 55 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
        }
        else if (Response.Data == null)
        {
            if (Response.Mensaje != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "class", "text-danger");
            __builder.AddContent(82, 
#nullable restore
#line 60 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                        Response.Mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(83, "<p class=\"text-info\">No hay información disponible.</p>");
#nullable restore
#line 65 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "table");
            __builder.AddAttribute(85, "class", "table table-hover");
            __builder.AddMarkupContent(86, "<thead class=\"bg-info\"><tr><th>Fecha</th>\r\n                        <th>Edad</th>\r\n                        <th>Genero</th>\r\n                        <th>Provincia</th></tr></thead>\r\n                ");
            __builder.OpenElement(87, "tbody");
#nullable restore
#line 79 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                     foreach (var item in Response.Data)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "tr");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 82 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                 item.Fecha.Date.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                            ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, 
#nullable restore
#line 83 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                 item.Edad

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(94, " años");
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                             if (item.Genero == "M")
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(95, "<td>Masculino</td>");
#nullable restore
#line 87 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "<td>Femenino</td>");
#nullable restore
#line 91 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(97, "td");
            __builder.AddContent(98, 
#nullable restore
#line 92 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                                 item.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\nicol\source\repos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\Index.razor"
       
    public CasoResponse Response { get; set; }
    public BusquedaViewModel Busqueda = new BusquedaViewModel();
    public List<string> provincias = new List<string>();

    async Task LimpiarFiltros()
    {
        Busqueda.FechaInicio = DateTime.Now;
        Busqueda.FechaFin = DateTime.Now;
        Busqueda.EdadInicio = 0;
        Busqueda.EdadFin = 0;
        Busqueda.Genero = "M";
        Busqueda.Provincia = provincias[0];

        Response = null;

        await CargarInformacion();
    }

    void CargarProvincias()
    {
        if (Response != null && Response.Data != null)
        {
            foreach (var item  in Response.Data)
            {
                if (!provincias.Contains(item.Provincia))
                {
                    provincias.Add(item.Provincia);
                }
            }
        }
    }

    async Task CargarInformacion()
    {
        Response = await Http.GetFromJsonAsync<CasoResponse>("covid");
    }

    protected override async Task OnInitializedAsync()
    {
        Busqueda.Genero = "M";
        Busqueda.FechaInicio = DateTime.Now;
        Busqueda.FechaFin = DateTime.Now;

        await CargarInformacion();

        CargarProvincias();
        Busqueda.Provincia = provincias[0];
    }

    async Task ConsultarInformacion()
    {
        Response = null;
        Response = await Http.GetFromJsonAsync<CasoResponse>($"covid/total?FechaInicio={Busqueda.FechaInicio}&FechaFin={Busqueda.FechaFin}&EdadInicio={Busqueda.EdadInicio}&EdadFin={Busqueda.EdadFin}&Genero={Busqueda.Genero}&Provincia={Busqueda.Provincia}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Covid19Casos.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
