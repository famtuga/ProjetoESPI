#pragma checksum "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1dc27ef72b18c3f42a33b266fa41e3715c0f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HorarioDisciplinas_Index), @"mvc.1.0.view", @"/Views/HorarioDisciplinas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HorarioDisciplinas/Index.cshtml", typeof(AspNetCore.Views_HorarioDisciplinas_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1dc27ef72b18c3f42a33b266fa41e3715c0f7a", @"/Views/HorarioDisciplinas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29bd2f65bf33ae6b21504e261012503ee463161", @"/Views/_ViewImports.cshtml")]
    public class Views_HorarioDisciplinas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Horarios.Models.HorarioDisciplina>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 104, true);
            WriteLiteral("\r\n<h2>Lista</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(203, 43, false);
#line 13 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Horario));

#line default
#line hidden
            EndContext();
            BeginContext(246, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(302, 46, false);
#line 16 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Disciplina));

#line default
#line hidden
            EndContext();
            BeginContext(348, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(466, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(515, 52, false);
#line 25 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Horario.HorarioId));

#line default
#line hidden
            EndContext();
            BeginContext(567, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(623, 58, false);
#line 28 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disciplina.DisciplinaId));

#line default
#line hidden
            EndContext();
            BeginContext(681, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(737, 65, false);
#line 31 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(802, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(823, 71, false);
#line 32 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(894, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(915, 69, false);
#line 33 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(984, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\HorarioDisciplinas\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1023, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Horarios.Models.HorarioDisciplina>> Html { get; private set; }
    }
}
#pragma warning restore 1591