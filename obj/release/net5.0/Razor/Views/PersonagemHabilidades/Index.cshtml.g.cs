#pragma checksum "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "684da256a024162f3fe9ca2e04e00a6253b88857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonagemHabilidades_Index), @"mvc.1.0.view", @"/Views/PersonagemHabilidades/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684da256a024162f3fe9ca2e04e00a6253b88857", @"/Views/PersonagemHabilidades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonagemHabilidades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.PersonagemHabilidadeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
   ViewBag.Title = "Index"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
 if (@TempData["Mensagem"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 5 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>    \r\n");
#nullable restore
#line 6 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
 if (@TempData["MensagemErro"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 9 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>    \r\n");
#nullable restore
#line 10 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Habilidades do Personagem</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
       Write(Html.DisplayName("Personagem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
       Write(Html.DisplayName("Habilidade"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Habilidade.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>                \r\n    </tr>\r\n");
#nullable restore
#line 24 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>     \r\n            <td>");
#nullable restore
#line 27 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Personagem.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>       \r\n            <td>");
#nullable restore
#line 28 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Habilidade.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>            \r\n            <td>");
#nullable restore
#line 29 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Habilidade.Dano));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>         \r\n\t\t\r\n            <td>");
#nullable restore
#line 31 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
           Write(Html.ActionLink(
                "Deletar"
                ,"Delete"
                ,"PersonagemHabilidades"
                , new { habilidadeId = item.HabilidadeId, personagemId = item.PersonagemId } 
                , new { onclick = "return confirm('Deseja realmente deletar esta habilidade ?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            </td>                           \r\n        </tr>\r\n");
#nullable restore
#line 39 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
    }    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div>\r\n    ");
#nullable restore
#line 42 "F:\DS\Projeto_Completo\RpgMvc\Views\PersonagemHabilidades\Index.cshtml"
Write(Html.ActionLink("Retornar aos Personagens", "Index", "Personagens"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.PersonagemHabilidadeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591