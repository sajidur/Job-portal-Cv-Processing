#pragma checksum "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\Home\JobSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c07c4c370e26754f548ee3734ae734e12d8bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_JobSettings), @"mvc.1.0.view", @"/Views/Home/JobSettings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/JobSettings.cshtml", typeof(AspNetCore.Views_Home_JobSettings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c07c4c370e26754f548ee3734ae734e12d8bde", @"/Views/Home/JobSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5746195fa5c04b1f3448d93ea0c4c81300dcf6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_JobSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Rex Web Solution Bangladesh\Job-portal-Cv-Processing\JobPortal\Views\Home\JobSettings.cshtml"
  
    ViewBag.Title = "Job Settings";

#line default
#line hidden
            BeginContext(44, 75, true);
            WriteLiteral("<div class=\"container\">\r\n    <div><h3>Add Jobs</h3></div>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(119, 1760, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7c07c4c370e26754f548ee3734ae734e12d8bde3949", async() => {
                BeginContext(139, 1733, true);
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputEmail4"">Job Id</label>
                <input type=""text"" class=""form-control"" id=""inputEmail4"" placeholder=""Unique Job Id"" name=""JobId"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputPassword4"">Job Title</label>
                <input type=""text"" class=""form-control"" id=""inputPassword4"" placeholder=""Job Title"" name=""JobTitle"">
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputEmail4"">Company</label>
                <input type=""text"" class=""form-control"" id=""inputEmail4"" placeholder=""Company"" name=""Company"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputPassword4"">Vacancy</label>
                <input type=""text"" class=""form-control"" id=""inputPassword4"" placeholder=""Number of Vacancy"" n");
                WriteLiteral(@"ame=""vacancy"">
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputCity"">Top Skill</label>
                <input type=""text"" class=""form-control"" id=""inputCity"" placeholder=""User Comma (,) to seperate skill"" name=""TopSkills"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputCity"">Minor Skill</label>
                <input type=""text"" class=""form-control"" id=""inputCity"" placeholder=""User Comma (,) to seperate skill"" name=""MinorSkills"">
            </div>
        </div>        
        <button type=""submit"" class=""btn btn-primary"">Save</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1879, 8, true);
            WriteLiteral("\r\n</div>");
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
