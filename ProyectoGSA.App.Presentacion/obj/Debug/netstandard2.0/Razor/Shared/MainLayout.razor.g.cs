#pragma checksum "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7e16c3790f04713868da97859b0186e1d3db6d4"
// <auto-generated/>
#pragma warning disable 1591
namespace SGACOL.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using SGACOL;

#line default
#line hidden
#line 7 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\_Imports.razor"
using SGACOL.Shared;

#line default
#line hidden
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<SGACOL.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <h2>Sistema de Gestión Académica</h2>\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#line 15 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\ProyectoGSA.App\ProyectoGSA.App.Presentacion\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
