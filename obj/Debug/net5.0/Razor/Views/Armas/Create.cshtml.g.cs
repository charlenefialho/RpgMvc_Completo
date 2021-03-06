#pragma checksum "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a27c98b2ed9f35f765e8cc803fea477ef2b64ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Armas_Create), @"mvc.1.0.view", @"/Views/Armas/Create.cshtml")]
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
#line 1 "F:\DS\Projeto_Completo\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DS\Projeto_Completo\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a27c98b2ed9f35f765e8cc803fea477ef2b64ad", @"/Views/Armas/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Armas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.ArmaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
    
    ViewBag.Title = "create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Configuração para exibir mensagem de sucesso -->\r\n");
#nullable restore
#line 7 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n       ");
#nullable restore
#line 10 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
  Write(Html.Raw(@TempData["Mensagem"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Configuração para exibir mensagem de erro -->\r\n");
#nullable restore
#line 13 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 16 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 17 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Criar uma nova arma</h2>\r\n");
#nullable restore
#line 21 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr>\r\n        \r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 28 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 30 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div> \r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 35 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
       Write(Html.LabelFor(model => model.Dano, htmlAttributes: new { @class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 37 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
           Write(Html.EditorFor(model => model.Dano, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div> \r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 42 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
       Write(Html.DisplayName("Personagem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 45 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
           Write(Html.DropDownListFor(model => 
                model.PersonagemId, new SelectList(@ViewBag.ListaPersonagens, "Id", "Nome"),
            "---Selecione---", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-6\">\r\n                <input type=\"submit\" value=\"Salvar\" class=\"btn btn-primary\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 56 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 58 "F:\DS\Projeto_Completo\RpgMvc\Views\Armas\Create.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.ArmaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
