#pragma checksum "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d85a4c92e8886c544ca3ab793435f294782f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Listado_Estudiante), @"mvc.1.0.view", @"/Views/Listado/Estudiante.cshtml")]
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
#line 1 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\_ViewImports.cshtml"
using ConsejeriaEPICS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\_ViewImports.cshtml"
using ConsejeriaEPICS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d85a4c92e8886c544ca3ab793435f294782f60", @"/Views/Listado/Estudiante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9f1ae559f257361c99cf9152593990b082a2b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Listado_Estudiante : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
   
   Categoria cat = new Categoria();
   var listCategoria=@Model.Categorias;
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
 <section id=""hero"" class=""d-flex justify-content-center align-items-center"">
    <div class=""container position-relative"" data-aos=""zoom-in"" data-aos-delay=""100"">

      <h1>Ver Estados de Requerimientos<br></h1>
      <h1>  Visualiza el estado de todos tus requerimientos</h1>
    </div>
  </section>
  <br>

<div class=""container"">
 <table class=""table"" >
  <thead>
    <tr style=""background-color: #910222;"">
      <th style=""color: white;"" scope=""col"">ID Requerimiento</th>
      <th style=""color: white;"" scope=""col"">Fecha Inicio</th>
      <th style=""color: white;"" scope=""col"">Fecha Finalizacion</th>
      <th style=""color: white;"" scope=""col"">ID Consejero</th> 
      <th style=""color: white;"" scope=""col"">Tipo de Requerimiento</th>
      <th style=""color: white;"" scope=""col"">Estado</th>
      <th style=""color: white;"" scope=""col"">Detalle</th>
      <th style=""color: white;"" scope=""col"">Respuesta</th>
    </tr>
  </thead>
  <tbody>
    <tr>
");
#nullable restore
#line 33 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
       foreach (Requerimiento req in @Model.Mostrar)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <th scope=\"row\">");
#nullable restore
#line 35 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                   Write(req.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <td>");
#nullable restore
#line 36 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
       Write(req.Fecha_Inicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         if(@req.Fecha_Fin!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>");
#nullable restore
#line 38 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         Write(req.Fecha_Fin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>----</td>\r\n");
#nullable restore
#line 41 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         if(@req.Consejero_ID!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>");
#nullable restore
#line 44 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         Write(req.Consejero_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>----</td>\r\n");
#nullable restore
#line 47 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         for(int i=0; i<@listCategoria.Count; i++){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
             if(listCategoria[i].ID==@req.Tipo_Req){
              cat=listCategoria[i];
              break;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
             
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 55 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
       Write(cat.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 56 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
       Write(req.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n          <button type=\"button\" class=\"btn btn-success\" data-bs-container=\"body\" data-bs-toggle=\"popover\" data-bs-placement=\"bottom\" data-bs-content=\"");
#nullable restore
#line 58 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                                                                                                                 Write(req.Detalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Ver Detalle</button>\r\n        </td>\r\n");
#nullable restore
#line 61 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         if(@req.Respuesta!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>\r\n            <button type=\"button\" class=\"btn btn-danger\" data-bs-container=\"body\" data-bs-toggle=\"popover\" data-bs-placement=\"bottom\" data-bs-content=\"");
#nullable restore
#line 63 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                                                                                                                  Write(req.Respuesta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Ver Respuesta</button>\r\n          </td>\r\n");
#nullable restore
#line 65 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>\r\n            <button class=\"btn btn-danger\" style=\"pointer-events: none;\" type=\"button\" disabled>Ver Respuesta</button>\r\n          </td>\r\n");
#nullable restore
#line 69 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
          
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    \r\n  </tbody>\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
