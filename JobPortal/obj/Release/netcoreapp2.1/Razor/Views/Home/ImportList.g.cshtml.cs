#pragma checksum "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e18adfc3454d859731fe46ce3129fc8150aaaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ImportList), @"mvc.1.0.view", @"/Views/Home/ImportList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ImportList.cshtml", typeof(AspNetCore.Views_Home_ImportList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e18adfc3454d859731fe46ce3129fc8150aaaf", @"/Views/Home/ImportList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5746195fa5c04b1f3448d93ea0c4c81300dcf6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ImportList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobPortal.Models.EmailMessage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
  
    ViewData["Title"] = "ImportList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 34, true);
            WriteLiteral("\r\n<h2>ImportList</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(180, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83dc7629f84245a7acc07d4bde140027", async() => {
                BeginContext(203, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(217, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(310, 40, false);
#line 17 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.DisplayNameFor(model => model.From));

#line default
#line hidden
            EndContext();
            BeginContext(350, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(406, 43, false);
#line 20 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(449, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(505, 40, false);
#line 23 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(545, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(601, 38, false);
#line 26 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.DisplayNameFor(model => model.CV));

#line default
#line hidden
            EndContext();
            BeginContext(639, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(757, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(806, 39, false);
#line 35 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.DisplayFor(modelItem => item.From));

#line default
#line hidden
            EndContext();
            BeginContext(845, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(901, 42, false);
#line 38 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(943, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(999, 39, false);
#line 41 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1094, 37, false);
#line 44 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.DisplayFor(modelItem => item.CV));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1187, 65, false);
#line 47 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1273, 71, false);
#line 48 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1365, 69, false);
#line 49 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Mobashwir Hasan\Documents\GitHub\JobPortal\JobPortal\Views\Home\ImportList.cshtml"
}

#line default
#line hidden
            BeginContext(1473, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobPortal.Models.EmailMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
