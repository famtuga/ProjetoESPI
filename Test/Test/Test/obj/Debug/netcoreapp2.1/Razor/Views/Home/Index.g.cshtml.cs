#pragma checksum "C:\Users\ivomi\source\repos\Test\Test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0727c321f99186fdad6ce9b41914324898be11cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ivomi\source\repos\Test\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#line 2 "C:\Users\ivomi\source\repos\Test\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0727c321f99186fdad6ce9b41914324898be11cf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ivomi\source\repos\Test\Test\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 3820, true);
            WriteLiteral(@"
<!-- About Section -->
<section id=""about"" class=""about-section text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 mx-auto"">
                <h2 class=""text-white mb-4"">Built with Bootstrap 4</h2>
                <p class=""text-white-50"">
                    Grayscale is a free Bootstrap theme created by Start Bootstrap. It can be yours right now, simply download the template on
                    <a href=""http://startbootstrap.com/template-overviews/grayscale/"">the preview page</a>. The theme is open source, and you can use it for any purpose, personal or commercial.
                </p>
            </div>
        </div>
        <img src=""img/ipad.png"" class=""img-fluid"" alt="""">
    </div>
</section>
<!-- Projects Section -->
<section id=""projects"" class=""projects-section bg-light"">
    <div class=""container"">
        <!-- Featured Project Row -->
        <div class=""row align-items-center no-gutters mb-4 mb-lg-5"">
            <div class");
            WriteLiteral(@"=""col-xl-8 col-lg-7"">
                <img class=""img-fluid mb-3 mb-lg-0"" src=""img/bg-masthead.jpg"" alt="""">
            </div>
            <div class=""col-xl-4 col-lg-5"">
                <div class=""featured-text text-center text-lg-left"">
                    <h4>Shoreline</h4>
                    <p class=""text-black-50 mb-0"">Grayscale is open source and MIT licensed. This means you can use it for any project - even commercial projects! Download it, customize it, and publish your website!</p>
                </div>
            </div>
        </div>
        <!-- Project One Row -->
        <div class=""row justify-content-center no-gutters mb-5 mb-lg-0"">
            <div class=""col-lg-6"">
                <img class=""img-fluid"" src=""img/demo-image-01.jpg"" alt="""">
            </div>
            <div class=""col-lg-6"">
                <div class=""bg-black text-center h-100 project"">
                    <div class=""d-flex h-100"">
                        <div class=""project-text w-100 my-auto text-");
            WriteLiteral(@"center text-lg-left"">
                            <h4 class=""text-white"">Misty</h4>
                            <p class=""mb-0 text-white-50"">An example of where you can put an image of a project, or anything else, along with a description.</p>
                            <hr class=""d-none d-lg-block mb-0 ml-0"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Project Two Row -->
        <div class=""row justify-content-center no-gutters"">
            <div class=""col-lg-6"">
                <img class=""img-fluid"" src=""img/demo-image-02.jpg"" alt="""">
            </div>
            <div class=""col-lg-6 order-lg-first"">
                <div class=""bg-black text-center h-100 project"">
                    <div class=""d-flex h-100"">
                        <div class=""project-text w-100 my-auto text-center text-lg-right"">
                            <h4 class=""text-white"">Mountains</h4>
                            <p clas");
            WriteLiteral(@"s=""mb-0 text-white-50"">Another example of a project with its respective description. These sections work well responsively as well, try this theme on a small screen!</p>
                            <hr class=""d-none d-lg-block mb-0 mr-0"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Signup Section -->
<section id=""signup"" class=""signup-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10 col-lg-8 mx-auto text-center"">
                <i class=""far fa-paper-plane fa-2x mb-2 text-white""></i>
                <h2 class=""text-white mb-5"">Subscribe to receive updates!</h2>
                ");
            EndContext();
            BeginContext(3865, 304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55f1dd35e6884ff68fff394b354b0e00", async() => {
                BeginContext(3898, 264, true);
                WriteLiteral(@"
                    <input type=""email"" class=""form-control flex-fill mr-0 mr-sm-2 mb-3 mb-sm-0"" id=""inputEmail"" placeholder=""Enter email address..."">
                    <button type=""submit"" class=""btn btn-primary mx-auto"">Subscribe</button>
                ");
                EndContext();
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
            EndContext();
            BeginContext(4169, 62, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591