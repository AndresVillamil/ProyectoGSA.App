// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SGACOL.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using SGACOL;

#line default
#line hidden
#line 7 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using SGACOL.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/grupos")]
    public partial class Grupos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 70 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\Pages\Grupos.razor"
       
    BaseEstudiantes[] estudiantes;

    protected override async Task OnInitializedAsync()
    {
        estudiantes = await Http.GetJsonAsync<BaseEstudiantes[]>("sample-data/estudiantes.json");
    }

    public class BaseEstudiantes
    {
        public string apellidos { get; set; }

        public string nombres { get; set; }

        public string direccion { get; set; }

       public string telefono { get; set; }
    }
    
    

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
