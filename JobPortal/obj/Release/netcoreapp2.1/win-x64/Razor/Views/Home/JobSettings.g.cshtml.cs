#pragma checksum "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\JobSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4432137cd40a763486c52c19facb4273d9f3f4d7"
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
#line 1 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\_ViewImports.cshtml"
using JobPortal;

#line default
#line hidden
#line 2 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\_ViewImports.cshtml"
using JobPortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4432137cd40a763486c52c19facb4273d9f3f4d7", @"/Views/Home/JobSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5746195fa5c04b1f3448d93ea0c4c81300dcf6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_JobSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\JobSettings.cshtml"
  
    ViewBag.Title = "Job Settings";

#line default
#line hidden
            BeginContext(44, 75, true);
            WriteLiteral("<div class=\"container\">\r\n    <div><h3>Add Jobs</h3></div>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(119, 1651, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "103aeaa7eb81430b8f9c28dc37eb2efc", async() => {
                BeginContext(125, 1638, true);
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputEmail4"">Job Id</label>
                <input type=""text"" class=""form-control"" id=""inputEmail4"" placeholder=""Unique Job Id"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputPassword4"">Job Title</label>
                <input type=""text"" class=""form-control"" id=""inputPassword4"" placeholder=""Job Title"">
            </div>
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputEmail4"">Company</label>
                <input type=""text"" class=""form-control"" id=""inputEmail4"" placeholder=""Company"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputPassword4"">Vacancy</label>
                <input type=""text"" class=""form-control"" id=""inputPassword4"" placeholder=""Number of Vacancy"">
            </div>
        </div>
       ");
                WriteLiteral(@" <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""inputCity"">Top Skill</label>
                <input type=""text"" class=""form-control"" id=""inputCity"" placeholder=""User Comma (,) to seperate skill"">
            </div>
            <div class=""form-group col-md-6"">
                <label for=""inputCity"">Minor Skill</label>
                <input type=""text"" class=""form-control"" id=""inputCity"" placeholder=""User Comma (,) to seperate skill"">
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1770, 8, true);
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
