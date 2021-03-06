// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covid19Casos.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Covid19Casos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Covid19Casos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\_Imports.razor"
using Covid19Casos.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nuevocaso")]
    public partial class SaveData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Nicolas\source\repos\DesafiosTecnicos\DesafiosTecnicos.Covid19Casos\Covid19Casos\Client\Pages\SaveData.razor"
       
    // Objeto de tipo CasoViewModel que capturar?? la informaci??n para
    // enviarla al modelo de datos y realizar el registro.
    // Se inicializa con algunos atributos por defecto a modo de facilitar algunas validaciones.
    public CasoViewModel Model = new CasoViewModel { Fecha = DateTime.Now, Genero = "M", Edad = 0 };

    // Metodo as??ncrono para guardar un nuevo caso de Covid.
    // Luego de realizar la operaci??n, se llamar?? al m??todo para limpiar los campos.
    async Task GuardarCaso()
    {
        await Http.PostAsJsonAsync<CasoViewModel>("covid/update", Model);

        LimpiarCampos();
    }

    // Metodo para resetear los valores de cada campo del modelo.
    void LimpiarCampos()
    {
        Model.Fecha = DateTime.Now;
        Model.Edad = 0;
        Model.Genero = "M";
        Model.Provincia = "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
