#pragma checksum "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03991b1e068f70d06d86ddf3a9ecf3c11bc0893b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstudanteDisciplinas_Index), @"mvc.1.0.view", @"/Views/EstudanteDisciplinas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EstudanteDisciplinas/Index.cshtml", typeof(AspNetCore.Views_EstudanteDisciplinas_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03991b1e068f70d06d86ddf3a9ecf3c11bc0893b", @"/Views/EstudanteDisciplinas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29bd2f65bf33ae6b21504e261012503ee463161", @"/Views/_ViewImports.cshtml")]
    public class Views_EstudanteDisciplinas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Horarios.Models.EstudanteDisciplina>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 104, true);
            WriteLiteral("\r\n<h2>Lista</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(205, 46, false);
#line 13 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Disciplina));

#line default
#line hidden
            EndContext();
            BeginContext(251, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(369, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(418, 58, false);
#line 22 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Disciplina.DisciplinaId));

#line default
#line hidden
            EndContext();
            BeginContext(476, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(532, 65, false);
#line 25 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(597, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(618, 71, false);
#line 26 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(689, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(710, 69, false);
#line 27 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(779, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\EstudanteDisciplinas\Index.cshtml"
}

#line default
#line hidden
            BeginContext(818, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Horarios.Models.EstudanteDisciplina>> Html { get; private set; }
    }
}
#pragma warning restore 1591
