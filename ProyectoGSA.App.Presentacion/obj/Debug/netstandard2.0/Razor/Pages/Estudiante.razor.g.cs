#pragma checksum "C:\AppVers2\ProyectoSGA.App\ProyectoGSA.App.Presentacion\Pages\Estudiante.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4532e08e9416dc722c5c9ef56c9424504f04ea6"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/estudiante")]
    public partial class Estudiante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Personas</h1>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<section>\r\n    <h2>Información del Estudiante</h2>\r\n    <fieldset>\r\n      <legend>Título</legend>\r\n      \r\n        <form class=\"row justify-cont-center\">\r\n          <div class=\"container px-4\">\r\n            <div class=\"row gx-5\">\r\n              <div class=\"col\">\r\n                  <label for=\"Nombres\">Nombres:</label><br>\r\n                  <input type=\"text\" id=\"IdNombres\" name=\"Nombres\" class=\"form-control\">\r\n              </div>  \r\n              <div class=\"col\">\r\n                  <label for=\"Apellidos\">Apellidos:</label><br>\r\n                  <input type=\"text\" id=\"IdApellidos\" name=\"Apellidos\" class=\"form-control\">\r\n              </div>\r\n              <div class=\"col\">\r\n                  <label for=\"Identificacion\">No. Identificacion:</label><br>\r\n                  <input type=\"text\" id=\"Id\" name=\"Identificacion\" class=\"form-control\">\r\n              </div> \r\n            </div>  \r\n          </div>\r\n        </form><br>\r\n\r\n        <form class=\"row justify-cont-center\">\r\n          <div class=\"container px-4\">\r\n            <div class=\"row gx-5\">\r\n              <div class=\"col\">\r\n                <label for=\"Telefono\">Telefono de Contacto:</label><br>\r\n                <input type=\"text\" id=\"IdTelefono\" name=\"Telefono\" class=\"form-control\">\r\n              </div>\r\n              <div class=\"col\">\r\n                <label for=\"Correo\">Correo electronico:</label><br>\r\n                <input type=\"text\" id=\"IdCorreo\" name=\"Correo\" class=\"form-control\">\r\n              </div>\r\n              <div class=\"col\">\r\n                <label for=\"Direccion\">Direccion Residencial:</label><br>\r\n                <input type=\"text\" id=\"IdDireccion\" name=\"Direccion\" class=\"form-control\"> \r\n              </div>\r\n            </div>\r\n          </div>\r\n        </form><br>\r\n      </fieldset>  \r\n</section>\r\n");
            __builder.AddMarkupContent(2, "<div>\r\n  <button type=\"button\" class=\"btn btn-success\">Guardar  </button>\r\n</div><br>\r\n\r\n");
            __builder.AddMarkupContent(3, @"<section>
    <h2>Vínculo Académico</h2>
    <fieldset>
      
      <div>
          
          <button type=""button"" class=""btn btn-link"">Estudiante  </button>
          
      </div>
      
    </fieldset> 
</section>
>>>>>>> Version Beta 1.0");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
