#pragma checksum "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7f328f8114fd5352f85c8579fec11c08b4a7827"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f328f8114fd5352f85c8579fec11c08b4a7827", @"/Views/Listado/Estudiante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9f1ae559f257361c99cf9152593990b082a2b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Listado_Estudiante : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 70px; background-color: #910222; color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #910222; color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Listado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
   
   Categoria cat = new Categoria();
   var listCategoria=@Model.Categorias;
   string id="", rpta="", edit="";
 

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
      <th style=""color: white;"" scope=""col"">Editar</th>
    </tr>
  </thead>
  <tb");
            WriteLiteral("ody>\r\n");
#nullable restore
#line 34 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
       foreach (Requerimiento req in @Model.Mostrar)
      {
        id = "Modal"+@req.ID;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n          <th scope=\"row\">");
#nullable restore
#line 38 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                     Write(req.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n          <td>");
#nullable restore
#line 39 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         Write(req.Fecha_Inicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
           if(@req.Fecha_Fin!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 41 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
           Write(req.Fecha_Fin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
          }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>----</td>\r\n");
#nullable restore
#line 44 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 46 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
           if(@req.Consejero_ID!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 47 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
           Write(req.Consejero_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
          }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>----</td>\r\n");
#nullable restore
#line 50 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
          } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
           for(int i=0; i<@listCategoria.Count; i++){
              

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
               if(listCategoria[i].ID==@req.Tipo_Req){
                cat=listCategoria[i];
                break;
              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td>");
#nullable restore
#line 58 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         Write(cat.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 59 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
         Write(req.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n          <td>\r\n              <button type=\"button\" class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 62 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                                                         Write(id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Ver Detalle</button>\r\n          </td>\r\n\r\n          <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2096, "\"", 2104, 1);
#nullable restore
#line 65 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
WriteAttributeValue("", 2101, id, 2101, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-hidden=""true"" style=""color: black;"">
              <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                  <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Detalle del requerimiento:</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                      <span aria-hidden=""true"">&times;</span>
                    </button>
                  </div>
                  <div class=""modal-body"">
                    <textarea type=""text""  style=""background-color: #910222; color:white;"" class=""form-control"" readonly>");
#nullable restore
#line 75 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                                                                                    Write(req.Detalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n          </div>\r\n\r\n");
#nullable restore
#line 81 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
           if(@req.Respuesta!=null){

            rpta = "Rpta"+@req.ID;

            

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>\r\n                <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 86 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                                                          Write(rpta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Ver Respuesta</button>\r\n            </td>\r\n");
            WriteLiteral("            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 3204, "\"", 3214, 1);
#nullable restore
#line 89 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
WriteAttributeValue("", 3209, rpta, 3209, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-hidden=""true"" style=""color: black;"">
                <div class=""modal-dialog"" role=""document"">
                  <div class=""modal-content"">
                    <div class=""modal-header"">
                      <h5 class=""modal-title"">Respuesta del consejero:</h5>
                      <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                      </button>
                    </div>
                    <div class=""modal-body"">
                      <textarea type=""text""  style=""background-color: #910222; color:white;"" class=""form-control"" readonly>");
#nullable restore
#line 99 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                                                                                      Write(req.Respuesta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 104 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"

          }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n              <button class=\"btn btn-danger\" style=\"pointer-events: none;\" type=\"button\" disabled>Ver Respuesta</button>\r\n            </td>\r\n");
#nullable restore
#line 109 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
          } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 111 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
           if(@req.Estado=="PENDIENTE"){

            edit= "Edit"+@req.ID;

            

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>\r\n                <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 116 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                                                           Write(edit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Editar</button>\r\n            </td>\r\n");
            WriteLiteral("            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 4509, "\"", 4519, 1);
#nullable restore
#line 119 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
WriteAttributeValue("", 4514, edit, 4514, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-hidden=""true"" style=""color: black;"">
              <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                  <div class=""modal-header"">
                    <h5 class=""modal-title"">Editar Requerimiento:</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                      <span aria-hidden=""true"">&times;</span>
                    </button>
                  </div>
                  <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f328f8114fd5352f85c8579fec11c08b4a782717862", async() => {
                WriteLiteral("\r\n                      <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7f328f8114fd5352f85c8579fec11c08b4a782718197", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                        WriteLiteral(req.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 131 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => req.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <label>Tipo:</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f328f8114fd5352f85c8579fec11c08b4a782720621", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 134 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                           foreach (Categoria cate in listCategoria)
                          {
                            if(@cate.ID==@req.Tipo_Req){

#line default
#line hidden
#nullable disable
                    WriteLiteral("                              ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f328f8114fd5352f85c8579fec11c08b4a782721266", async() => {
#nullable restore
#line 137 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                           Write(cate.Nombre);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                 WriteLiteral(cate.ID);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 138 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                            }else{

#line default
#line hidden
#nullable disable
                    WriteLiteral("                              ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f328f8114fd5352f85c8579fec11c08b4a782723789", async() => {
#nullable restore
#line 139 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                                  Write(cate.Nombre);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 139 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                                 WriteLiteral(cate.ID);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 140 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
                            }
                          }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 133 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => req.Tipo_Req);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                      </div>\r\n                      <div class=\"form-group\">\r\n                        <label>Descripcion del Problema:</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f328f8114fd5352f85c8579fec11c08b4a782727595", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 146 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
AddHtmlAttributeValue("", 6186, req.Detalle, 6186, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 146 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => req.Detalle);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                      </div>\r\n                      <div class=\"form-group\">\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n                      </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
#nullable restore
#line 156 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"

          }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n              <button class=\"btn btn-primary\" style=\"pointer-events: none;\" type=\"button\" disabled>Editar</button>\r\n            </td>\r\n");
#nullable restore
#line 161 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n");
#nullable restore
#line 164 "D:\VSCode_Workspace\ConsejeriaEPICS\Views\Listado\Estudiante.cshtml"
      } 

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n</div>");
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
