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
#line 2 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\Pages\LiPersonas.razor"
using ProyectoGSA.App.Dominio.Entidades;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/lipersonas")]
    public partial class LiPersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 53 "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\Pages\LiPersonas.razor"
 

    public List<Persona> ListaPersonas = new List<Persona>();
    //public string id ="0";

        protected override Task OnInitializedAsync()
        {
           Persona persona1 = new Persona();
           persona1.id = 1;
           persona1.nombres = "Andres";
           persona1.apellidos = "Villamil";
           persona1.identificacion = "79962837";
           persona1.telefono = "2272783";
           persona1.mail = "andres@gmail.com";
           persona1.direccion = "Calle 78 # 120 -90";
           Persona persona2 = new Persona();
           persona2.id = 2;
           persona2.nombres = "Diana";
           persona2.apellidos = "Villamil";
           persona2.identificacion = "79962837";
           persona2.telefono = "2272783";
           persona2.mail = "andres@gmail.com";
           persona2.direccion = "Calle 78 # 120 -90"; 

            ListaPersonas.Add(persona1);
            ListaPersonas.Add(persona2);

            

            return base.OnInitializedAsync();
        }


#line default
#line hidden
    }
}
#pragma warning restore 1591
