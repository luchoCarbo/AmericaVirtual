#pragma checksum "C:\Users\lcarb\source\repos\AmericaVirtual\AmericaVirtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a87e0366330798434c09b3d4b0af2b68e82d4f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\lcarb\source\repos\AmericaVirtual\AmericaVirtual\Views\_ViewImports.cshtml"
using AmericaVirtual;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lcarb\source\repos\AmericaVirtual\AmericaVirtual\Views\_ViewImports.cshtml"
using AmericaVirtual.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87e0366330798434c09b3d4b0af2b68e82d4f0d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52081a303f924fe982bac53279251a442a6532ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AmericaVirtual.Models.ViewModels.Interfaces.ITemperatureViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fontawesome-free-5.15.2-web/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fontawesome-free-5.15.2-web/js/all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lcarb\source\repos\AmericaVirtual\AmericaVirtual\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h2 class=""h2 ""><b>SERVICIO DEL CLIMA</b></h2>
    <hr style=""display: block; height: 1px; border: 0; border-top: 1px solid #ff0000; margin: 1em 0; padding: 0;"">
</div>

<div class=""row justify-content-around"">

    <div style=""background-color:white"" class=""col-5 rounded p-3"">
        <h4 class=""h4 text-center"" style=""color:#4c3aeb"">Seleccioná la zona</h4>
        <hr style=""display: block; height: 1px; border: 0; border-top: 1px solid #4c3aeb; margin: 1em 0; padding: 0;"">

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87e0366330798434c09b3d4b0af2b68e82d4f0d6493", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""pais_control"">País</label>
                <select class=""form-control"" id=""pais_control"" aria-describedby=""pais"" placeholder=""Seleccione un país"">
                </select>
            </div>
            <div class=""form-group"">
                <label for=""ciudad_control"">Ciudad</label>
                <select class=""form-control"" id=""ciudad_control"" aria-describedby=""ciudad"" placeholder=""Seleccione una ciudad"">
                </select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Buscar"" class=""form-control bg-danger text-white"" id=""buscar_control"" aria-describedby=""buscar"" placeholder=""Buscar"">
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </div>

    <div style=""background-color:white"" class=""col-5 rounded p-3"">
        <h4 class=""h4 text-center"" style=""color:#4c3aeb"">Reporte</h4>
        <hr style=""display: block; height: 1px; border: 0; border-top: 1px solid #4c3aeb; margin: 1em 0; padding: 0;"">

        <div class=""col-12"">
            <div class=""row justify-content-between"">
                <div class=""col-8"">
                    <small id=""paisSeleccionado"" class=""form-text text-muted"">#PaisSeleccionado</small>
                </div>
                <div class=""col-12"">
                    <h6 id=""ciudadSeleccionada"" class=""form-text text-muted"">#CiudadSeleccionada</h6>
                </div>
                <div class=""col-4"">
                    <h4 id=""diaActual"" class=""form-text text-muted"">#DiaActual</h4>
                    <h4 id=""pronostico"" class=""form-text text-muted"">#Pronostico</h4>
                    <h2 id=""grados"" style=""margin-top:20%; margin-bottom:20%"" class=""form-text text-muted"">#22&#8451;</h");
            WriteLiteral(@"2>
                    <h6 id=""gradosFahrenheit "" class=""form-text text-muted"">#GradosFahrenheit </h6>
                </div>
                <div class=""col-4 text-right"">
                    <span class=""fas fa-sun fa-7x""></span>
                    <small id=""precipitaciones"" class=""form-text text-muted"">#precipitationces</small>
                    <small id=""humedad"" class=""form-text text-muted"">#humedad</small>
                    <small id=""viento"" class=""form-text text-muted"">#viento</small>
                </div>
            </div>
        </div>

    </div>

</div>

<div class=""row rounded justify-content-center"" style=""background-color:white; margin-top:5%"">
        <div class=""col-2"">
            <div class=""border-right"">
                <h6 class=""h4"" style=""color:#4c3aeb"">Lunes</h6>
                <span class=""fas fa-cloud-sun fa-7x""></span>
                <h2 id=""grados"" style=""margin-top:20%; margin-bottom:20%"" class=""form-text text-muted"">#22&#8451;</h2>
             ");
            WriteLiteral(@"   <h6 id=""gradosFahrenheit "" class=""form-text text-muted"">#GradosFahrenheit </h6>
            </div>
        </div>
        <div class=""col-2"">
            <div class=""border-right"">
                <h6 class=""h4"" style=""color:#4c3aeb"">Lunes</h6>
                <span class=""fas fa-cloud-sun fa-7x""></span>
                <h2 id=""grados"" style=""margin-top:20%; margin-bottom:20%"" class=""form-text text-muted"">#22&#8451;</h2>
                <h6 id=""gradosFahrenheit "" class=""form-text text-muted"">#GradosFahrenheit </h6>
            </div>
        </div>
        <div class=""col-2"">
            <div class=""border-right"">
                <h6 class=""h4"" style=""color:#4c3aeb"">Lunes</h6>
                <span class=""fas fa-cloud-sun fa-7x""></span>
                <h2 id=""grados"" style=""margin-top:20%; margin-bottom:20%"" class=""form-text text-muted"">#22&#8451;</h2>
                <h6 id=""gradosFahrenheit "" class=""form-text text-muted"">#GradosFahrenheit </h6>
            </div>
        </div>
      ");
            WriteLiteral(@"  <div class=""col-2"">
            <div class=""border-right"">
                <h6 class=""h4"" style=""color:#4c3aeb"">Lunes</h6>
                <span class=""fas fa-cloud-sun fa-7x""></span>
                <h2 id=""grados"" style=""margin-top:20%; margin-bottom:20%"" class=""form-text text-muted"">#22&#8451;</h2>
                <h6 id=""gradosFahrenheit "" class=""form-text text-muted"">#GradosFahrenheit </h6>
            </div>
        </div>
        <div class=""col-2"">
            <div");
            BeginWriteAttribute("class", " class=\"", 5006, "\"", 5014, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <h6 class=""h4"" style=""color:#4c3aeb"">Lunes</h6>
                <span class=""fas fa-cloud-sun fa-7x""></span>
                <h2 id=""grados"" style=""margin-top:20%; margin-bottom:20%"" class=""form-text text-muted"">#22&#8451;</h2>
                <h6 id=""gradosFahrenheit "" class=""form-text text-muted"">#GradosFahrenheit </h6>
            </div>
        </div>
</div>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87e0366330798434c09b3d4b0af2b68e82d4f0d12967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87e0366330798434c09b3d4b0af2b68e82d4f0d14011", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87e0366330798434c09b3d4b0af2b68e82d4f0d15055", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87e0366330798434c09b3d4b0af2b68e82d4f0d16099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 112 "C:\Users\lcarb\source\repos\AmericaVirtual\AmericaVirtual\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87e0366330798434c09b3d4b0af2b68e82d4f0d17989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#iniciarSesionBoton').click(() => {
                if (!$('#divBoton').hasClass('show')) {
                    $('#divBoton').addClass('show');
                    $('#iniciarSesionCuadro').addClass('show');
                }
                else if ($('#divBoton').hasClass('show')) {
                    $('#divBoton').removeClass('show');
                    $('#iniciarSesionCuadro').removeClass('show');
                }
                
            });
        });

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AmericaVirtual.Models.ViewModels.Interfaces.ITemperatureViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591