#pragma checksum "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47008344b780fcd6d38442f6fea5dda543d67195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Horarios_Index), @"mvc.1.0.view", @"/Views/Horarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Horarios/Index.cshtml", typeof(AspNetCore.Views_Horarios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47008344b780fcd6d38442f6fea5dda543d67195", @"/Views/Horarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29bd2f65bf33ae6b21504e261012503ee463161", @"/Views/_ViewImports.cshtml")]
    public class Views_Horarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HorariosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(69, 18, true);
            WriteLiteral("\r\n<h2>Lista</h2>\r\n");
            EndContext();
            BeginContext(87, 391, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b88a84126e49ffbd9d58b845aef15d", async() => {
                BeginContext(125, 129, true);
                WriteLiteral("\r\n    <div class=\"form-actions no-color\">\r\n        <p>\r\n            Procurar:\r\n            <input type=\"text\" name=\"SearchString\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 254, "\"", 293, 1);
#line 12 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
WriteAttributeValue("", 262, Model.PagingInfo.CurrentFilter, 262, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(294, 96, true);
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Pesquisar\" class=\"btn btn-success\" />\r\n            ");
                EndContext();
                BeginContext(390, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dde53b7ca234f0bba2c9ccb58075dc1", async() => {
                    BeginContext(433, 6, true);
                    WriteLiteral("Limpar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(443, 28, true);
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(478, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(565, 497, false);
#line 22 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
           Write(Html.ActionLink(
                    Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().NomeProva),
                    "Index",
                    new {
                        @sortOrder = Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().NomeProva),
                        @sortAsc =!Model.PagingInfo.Ascending,
                        @page = Model.PagingInfo.CurrentPage,
                        @searchString = Model.PagingInfo.CurrentFilter
                }));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1118, 499, false);
#line 33 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
           Write(Html.ActionLink(
                    Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().Datainicio),
                    "Index",
                    new {
                        @sortOrder = Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().Datainicio),
                        @sortAsc =!Model.PagingInfo.Ascending,
                        @page = Model.PagingInfo.CurrentPage,
                        @searchString = Model.PagingInfo.CurrentFilter
                }));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 57, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n                ");
            EndContext();
            BeginContext(1675, 499, false);
#line 45 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
           Write(Html.ActionLink(
                    Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().DiaInteiro),
                    "Index",
                    new {
                        @sortOrder = Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().DiaInteiro),
                        @sortAsc =!Model.PagingInfo.Ascending,
                        @page = Model.PagingInfo.CurrentPage,
                        @searchString = Model.PagingInfo.CurrentFilter
                }));

#line default
#line hidden
            EndContext();
            BeginContext(2174, 57, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n                ");
            EndContext();
            BeginContext(2232, 493, false);
#line 57 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
           Write(Html.ActionLink(
                    Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().Datafim),
                    "Index",
                    new {
                        @sortOrder = Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().Datafim),
                        @sortAsc =!Model.PagingInfo.Ascending,
                        @page = Model.PagingInfo.CurrentPage,
                        @searchString = Model.PagingInfo.CurrentFilter
                }));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2781, 517, false);
#line 68 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
           Write(Html.ActionLink(
                    Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().TipoProva.Descricao),
                    "Index",
                    new {
                        @sortOrder = Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().TipoProva.Descricao),
                        @sortAsc =!Model.PagingInfo.Ascending,
                        @page = Model.PagingInfo.CurrentPage,
                        @searchString = Model.PagingInfo.CurrentFilter
                }));

#line default
#line hidden
            EndContext();
            BeginContext(3298, 57, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n                ");
            EndContext();
            BeginContext(3356, 485, false);
#line 80 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
           Write(Html.ActionLink(
                    Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().Ano),
                    "Index",
                    new {
                        @sortOrder = Html.DisplayNameFor(model => model.Horarios.FirstOrDefault().Ano),
                        @sortAsc =!Model.PagingInfo.Ascending,
                        @page = Model.PagingInfo.CurrentPage,
                        @searchString = Model.PagingInfo.CurrentFilter
                }));

#line default
#line hidden
            EndContext();
            BeginContext(3841, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 94 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
         foreach (var item in Model.Horarios)
        {

#line default
#line hidden
            BeginContext(3985, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4046, 44, false);
#line 98 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NomeProva));

#line default
#line hidden
            EndContext();
            BeginContext(4090, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4158, 45, false);
#line 101 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Datainicio));

#line default
#line hidden
            EndContext();
            BeginContext(4203, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4271, 45, false);
#line 104 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiaInteiro));

#line default
#line hidden
            EndContext();
            BeginContext(4316, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4384, 42, false);
#line 107 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Datafim));

#line default
#line hidden
            EndContext();
            BeginContext(4426, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4494, 49, false);
#line 110 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoProva.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(4543, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4611, 38, false);
#line 113 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(4649, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4716, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48c698c86f534ff1b07c9e8b83b544a0", async() => {
                BeginContext(4768, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 116 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
                                           WriteLiteral(item.HorarioId);

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
            BeginContext(4778, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(4802, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e909ac8b9e049d3968915aaacd27f54", async() => {
                BeginContext(4857, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 117 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
                                              WriteLiteral(item.HorarioId);

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
            BeginContext(4869, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(4893, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b67812b252f54d2f89af2a1ef8960555", async() => {
                BeginContext(4947, 6, true);
                WriteLiteral("Apagar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
                                             WriteLiteral(item.HorarioId);

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
            BeginContext(4957, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 121 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(5012, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 125 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
  
    var prevDisabled = !Model.PagingInfo.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.PagingInfo.HasNextPage ? "disabled" : "";

#line default
#line hidden
            BeginContext(5195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5197, 308, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c814afcfe37d47cc99fb1c9b067b2c03", async() => {
                BeginContext(5485, 16, true);
                WriteLiteral("\r\n    Previous\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
            WriteLiteral(Model.PagingInfo.CurrentSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 132 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
          WriteLiteral(Model.PagingInfo.Ascending);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortAsc"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortAsc", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortAsc"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 133 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
        WriteLiteral(Model.PagingInfo.CurrentPage-1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 134 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
               WriteLiteral(Model.PagingInfo.CurrentFilter);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchString"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchString", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchString"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5454, "btn", 5454, 3, true);
            AddHtmlAttributeValue(" ", 5457, "btn-default", 5458, 12, true);
#line 135 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
AddHtmlAttributeValue(" ", 5469, prevDisabled, 5470, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5505, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5507, 304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cee53dc82ae4cb8b98c9c50800c42c5", async() => {
                BeginContext(5795, 12, true);
                WriteLiteral("\r\n    Next\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 139 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
            WriteLiteral(Model.PagingInfo.CurrentSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 140 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
          WriteLiteral(Model.PagingInfo.Ascending);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortAsc"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortAsc", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortAsc"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 141 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
        WriteLiteral(Model.PagingInfo.CurrentPage+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 142 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
               WriteLiteral(Model.PagingInfo.CurrentFilter);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchString"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchString", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchString"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5764, "btn", 5764, 3, true);
            AddHtmlAttributeValue(" ", 5767, "btn-default", 5768, 12, true);
#line 143 "C:\Users\Utilizador\Desktop\ProjetoPrincipal\Horarios\Horarios\Views\Horarios\Index.cshtml"
AddHtmlAttributeValue(" ", 5779, nextDisabled, 5780, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HorariosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
