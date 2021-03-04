#pragma checksum "D:\Web\ASP.NET\agungdev\agungdev\Views\Skill\Skill_Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9168a0ad4e44e402ec880663bc51cb74c14ab825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Skill_Add), @"mvc.1.0.view", @"/Views/Skill/Skill_Add.cshtml")]
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
#line 1 "D:\Web\ASP.NET\agungdev\agungdev\Views\_ViewImports.cshtml"
using agungdev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web\ASP.NET\agungdev\agungdev\Views\_ViewImports.cshtml"
using agungdev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9168a0ad4e44e402ec880663bc51cb74c14ab825", @"/Views/Skill/Skill_Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f35565587d37997cd946df8e1f481bf5f5d9d236", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Skill_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Button trigger modal -->
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalAdd"">
    Add New Skill
</button>

<!-- Modal -->
<div class=""modal fade slide-up disable-scroll"" id=""modalAdd"" tabindex=""-1"" role=""dialog"" aria-hidden=""false"">
    <div class=""modal-dialog "">
        <div class=""modal-content-wrapper"">
            <div class=""modal-content"">
                <div class=""modal-header clearfix text-left"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        <i class=""pg-close fs-14""></i>
                    </button>
                    <h5>Add <span class=""semi-bold"">New Skill</span></h5>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9168a0ad4e44e402ec880663bc51cb74c14ab8254360", async() => {
                WriteLiteral(@"
                        <div class=""form-group-attached"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""form-group form-group-default"">
                                        <label>Skill Name</label>
                                        <input type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""form-group form-group-default"">
                                        <label>Skill Value</label>
                                        <div class=""irs-wrapper blue"">
                                            <input type=""number"" min=""1"" max=""100"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                            <");
                WriteLiteral("/div>\r\n                        </div>\r\n                    ");
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
                    <div class=""pull-right"">
                        <button type=""button"" class=""btn btn-primary btn-block m-t-5"">Create</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
</div>

<div class=""modal fade slide-up disable-scroll"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-hidden=""false"">
    <div class=""modal-dialog "">
        <div class=""modal-content-wrapper"">
            <div class=""modal-content"">
                <div class=""modal-header clearfix text-left"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        <i class=""pg-close fs-14""></i>
                    </button>
                    <h5>Update <span class=""semi-bold"">Your Skill</span></h5>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9168a0ad4e44e402ec880663bc51cb74c14ab8257794", async() => {
                WriteLiteral(@"
                        <div class=""form-group-attached"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""form-group form-group-default"">
                                        <label>Skill Name</label>
                                        <input type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""form-group form-group-default"">
                                        <label>Skill Value</label>
                                        <div class=""irs-wrapper blue"">
                                            <input type=""number"" min=""1"" max=""100"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                            <");
                WriteLiteral("/div>\r\n                        </div>\r\n                    ");
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
                    <div class=""pull-right"">
                        <button type=""button"" class=""btn btn-primary btn-block m-t-5"">Update</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
</div>");
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
