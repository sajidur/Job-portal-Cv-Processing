#pragma checksum "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c9c85f8e4b24cc4b8bb7b3c5d3ba46d8e6fcd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobSettings_Delete), @"mvc.1.0.view", @"/Views/JobSettings/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobSettings/Delete.cshtml", typeof(AspNetCore.Views_JobSettings_Delete))]
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
#line 1 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\_ViewImports.cshtml"
using JobPortal;

#line default
#line hidden
#line 2 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\_ViewImports.cshtml"
using JobPortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c9c85f8e4b24cc4b8bb7b3c5d3ba46d8e6fcd3", @"/Views/JobSettings/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5746195fa5c04b1f3448d93ea0c4c81300dcf6c", @"/Views/_ViewImports.cshtml")]
    public class Views_JobSettings_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobPortal.Models.JobSettings>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>JobSettings</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(301, 41, false);
#line 16 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobId));

#line default
#line hidden
            EndContext();
            BeginContext(342, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(386, 37, false);
#line 19 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobId));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(467, 44, false);
#line 22 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(555, 40, false);
#line 25 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(595, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(639, 43, false);
#line 28 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(682, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(726, 39, false);
#line 31 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(809, 43, false);
#line 34 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.vacancy));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(896, 39, false);
#line 37 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.vacancy));

#line default
#line hidden
            EndContext();
            BeginContext(935, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(979, 45, false);
#line 40 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TopSkills));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1068, 41, false);
#line 43 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TopSkills));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1153, 47, false);
#line 46 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MinorSkills));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1244, 43, false);
#line 49 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MinorSkills));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1325, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c9c85f8e4b24cc4b8bb7b3c5d3ba46d8e6fcd310137", async() => {
                BeginContext(1351, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1361, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69c9c85f8e4b24cc4b8bb7b3c5d3ba46d8e6fcd310530", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1397, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1481, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c9c85f8e4b24cc4b8bb7b3c5d3ba46d8e6fcd312455", async() => {
                    BeginContext(1503, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(1519, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1532, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobPortal.Models.JobSettings> Html { get; private set; }
    }
}
#pragma warning restore 1591