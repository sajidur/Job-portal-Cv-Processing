#pragma checksum "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eee31b03742a87578936ab799ab4a5656ed89c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobSettings_Details), @"mvc.1.0.view", @"/Views/JobSettings/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobSettings/Details.cshtml", typeof(AspNetCore.Views_JobSettings_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eee31b03742a87578936ab799ab4a5656ed89c1", @"/Views/JobSettings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5746195fa5c04b1f3448d93ea0c4c81300dcf6c", @"/Views/_ViewImports.cshtml")]
    public class Views_JobSettings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobPortal.Models.JobSettings>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>JobSettings</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(255, 41, false);
#line 15 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobId));

#line default
#line hidden
            EndContext();
            BeginContext(296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(340, 37, false);
#line 18 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobId));

#line default
#line hidden
            EndContext();
            BeginContext(377, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(421, 44, false);
#line 21 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(465, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(509, 40, false);
#line 24 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(549, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(593, 43, false);
#line 27 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(636, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(680, 39, false);
#line 30 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company));

#line default
#line hidden
            EndContext();
            BeginContext(719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(763, 43, false);
#line 33 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.vacancy));

#line default
#line hidden
            EndContext();
            BeginContext(806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(850, 39, false);
#line 36 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.vacancy));

#line default
#line hidden
            EndContext();
            BeginContext(889, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(933, 45, false);
#line 39 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TopSkills));

#line default
#line hidden
            EndContext();
            BeginContext(978, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1022, 41, false);
#line 42 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.TopSkills));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1107, 47, false);
#line 45 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MinorSkills));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1198, 43, false);
#line 48 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
       Write(Html.DisplayFor(model => model.MinorSkills));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1288, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eee31b03742a87578936ab799ab4a5656ed89c19409", async() => {
                BeginContext(1334, 4, true);
                WriteLiteral("Edit");
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
#line 53 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\JobSettings\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1342, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1350, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eee31b03742a87578936ab799ab4a5656ed89c111749", async() => {
                BeginContext(1372, 12, true);
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
            BeginContext(1388, 10, true);
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