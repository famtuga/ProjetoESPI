#pragma checksum "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c413b30a0d191182c3ca0d5a2f019ba09aa0b746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backoffice_MostrarEstudantes), @"mvc.1.0.view", @"/Views/Backoffice/MostrarEstudantes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Backoffice/MostrarEstudantes.cshtml", typeof(AspNetCore.Views_Backoffice_MostrarEstudantes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c413b30a0d191182c3ca0d5a2f019ba09aa0b746", @"/Views/Backoffice/MostrarEstudantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b9414be4159e7a80efa14ee9d63690903c1eb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Backoffice_MostrarEstudantes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Horarios.Models.Estudante>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 650, true);
            WriteLiteral(@"<div class=""bread_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <ol class=""breadcrumb"">
                    <li><a href=""/"">Horarios</a></li>
                    <li class=""active"">Estudante</li>
                </ol>
            </div>
        </div>
    </div>
</div>
<div class=""container"">
    <div class=""row"">
        <section class=""page col-sm-12"">
            <div class=""row"">
                <table class=""table table-condensed"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(739, 40, false);
#line 25 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(779, 615, true);
            WriteLiteral(@"
                            </th>
                            <th>
                                Email
                            </th>
                            <th>
                                NumeroEstudante
                            </th>
                            <th>
                                Ano
                            </th>
                            <th>
                                EstadoEstudante
                            </th>
                           <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 43 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1475, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1584, 39, false);
#line 47 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1739, 40, false);
#line 50 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1895, 50, false);
#line 53 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NumeroEstudante));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2061, 38, false);
#line 56 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2215, 50, false);
#line 59 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EstadoEstudante));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 222, true);
            WriteLiteral("\r\n                                </td>\r\n                               \r\n                                <td>\r\n                                    <button class=\"btn btn-toolbar\">\r\n                                        ");
            EndContext();
            BeginContext(2487, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac3a84f088a45bb849d1db4ce22be48", async() => {
                BeginContext(2541, 6, true);
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
#line 64 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                                                               WriteLiteral(item.EstudanteId);

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
            BeginContext(2551, 161, true);
            WriteLiteral("\r\n                                    </button> |\r\n                                    <button class=\"btn btn-default\">\r\n                                        ");
            EndContext();
            BeginContext(2712, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "240930dd7dce4c5a86e12a7cbff0ac63", async() => {
                BeginContext(2769, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                                                                  WriteLiteral(item.EstudanteId);

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
            BeginContext(2781, 123, true);
            WriteLiteral("\r\n                                    </button>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 71 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Backoffice\MostrarEstudantes.cshtml"
                        }

#line default
#line hidden
            BeginContext(2931, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Horarios.Models.Estudante>> Html { get; private set; }
    }
}
#pragma warning restore 1591