#pragma checksum "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce2fb4fa319c57f0c77529c506b17329e614faf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Horarios_Details), @"mvc.1.0.view", @"/Views/Horarios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Horarios/Details.cshtml", typeof(AspNetCore.Views_Horarios_Details))]
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
#line 1 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\_ViewImports.cshtml"
using Horarios;

#line default
#line hidden
#line 2 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\_ViewImports.cshtml"
using Horarios.Models;

#line default
#line hidden
#line 3 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\_ViewImports.cshtml"
using Horarios.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2fb4fa319c57f0c77529c506b17329e614faf4", @"/Views/Horarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29bd2f65bf33ae6b21504e261012503ee463161", @"/Views/_ViewImports.cshtml")]
    public class Views_Horarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Horarios.Models.Horario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 122, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <h4>Horario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(200, 45, false);
#line 14 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeProva));

#line default
#line hidden
            EndContext();
            BeginContext(245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(289, 41, false);
#line 17 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeProva));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(374, 46, false);
#line 20 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Datainicio));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 42, false);
#line 23 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Datainicio));

#line default
#line hidden
            EndContext();
            BeginContext(506, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(550, 46, false);
#line 26 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaInteiro));

#line default
#line hidden
            EndContext();
            BeginContext(596, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(640, 42, false);
#line 29 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaInteiro));

#line default
#line hidden
            EndContext();
            BeginContext(682, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(726, 43, false);
#line 32 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Datafim));

#line default
#line hidden
            EndContext();
            BeginContext(769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(813, 39, false);
#line 35 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Datafim));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(896, 45, false);
#line 38 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(985, 41, false);
#line 41 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1070, 39, false);
#line 44 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1153, 35, false);
#line 47 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1235, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d62ece8d6e9469e870e58bcb3435d44", async() => {
                BeginContext(1288, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Details.cshtml"
                           WriteLiteral(Model.HorarioId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1298, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1306, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b79fb8ba9834ac2a45e0abbbaa49487", async() => {
                BeginContext(1328, 23, true);
                WriteLiteral("Voltar ao menu anterior");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1355, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Horarios.Models.Horario> Html { get; private set; }
    }
}
#pragma warning restore 1591
