#pragma checksum "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd30ce51d6e97e679fe3fdb7abd9f9d4ed1783d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MoQuizDetails_Details), @"mvc.1.0.view", @"/Views/MoQuizDetails/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MoQuizDetails/Details.cshtml", typeof(AspNetCore.Views_MoQuizDetails_Details))]
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
#line 1 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\_ViewImports.cshtml"
using MoustacheApp;

#line default
#line hidden
#line 3 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\_ViewImports.cshtml"
using MoustacheApp.Areas.Identity;

#line default
#line hidden
#line 4 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\_ViewImports.cshtml"
using MoustacheApp.Extensions;

#line default
#line hidden
#line 5 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\_ViewImports.cshtml"
using MoustacheApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd30ce51d6e97e679fe3fdb7abd9f9d4ed1783d9", @"/Views/MoQuizDetails/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46388d910ae4e9e65779d2a9973ac2726979d4ae", @"/Views/_ViewImports.cshtml")]
    public class Views_MoQuizDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoustacheApp.Models.MoQuizDetail>
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
  
    ViewData["Title"] = "Quiz Details";

#line default
#line hidden
            BeginContext(91, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(98, 17, false);
#line 7 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(115, 109, true);
            WriteLiteral("</h3>\r\n<hr />\r\n<div class=\"canister\">\r\n    <dl class=\"canister\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(225, 38, false);
#line 12 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(263, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(325, 34, false);
#line 15 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(359, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(420, 46, false);
#line 18 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PreviousId));

#line default
#line hidden
            EndContext();
            BeginContext(466, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(528, 42, false);
#line 21 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.PreviousId));

#line default
#line hidden
            EndContext();
            BeginContext(570, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(631, 43, false);
#line 24 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Current));

#line default
#line hidden
            EndContext();
            BeginContext(674, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(736, 39, false);
#line 27 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Current));

#line default
#line hidden
            EndContext();
            BeginContext(775, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(836, 44, false);
#line 30 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CommonId));

#line default
#line hidden
            EndContext();
            BeginContext(880, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(942, 40, false);
#line 33 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.CommonId));

#line default
#line hidden
            EndContext();
            BeginContext(982, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1043, 40, false);
#line 36 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1145, 36, false);
#line 39 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1242, 47, false);
#line 42 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Information));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1351, 43, false);
#line 45 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Information));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1455, 40, false);
#line 48 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1557, 36, false);
#line 51 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1654, 45, false);
#line 54 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Published));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1761, 41, false);
#line 57 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Published));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1863, 44, false);
#line 60 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Attempts));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1969, 40, false);
#line 63 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Attempts));

#line default
#line hidden
            EndContext();
            BeginContext(2009, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2070, 42, false);
#line 66 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Played));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2174, 38, false);
#line 69 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Played));

#line default
#line hidden
            EndContext();
            BeginContext(2212, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2273, 45, false);
#line 72 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Randomise));

#line default
#line hidden
            EndContext();
            BeginContext(2318, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2380, 41, false);
#line 75 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Randomise));

#line default
#line hidden
            EndContext();
            BeginContext(2421, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2482, 47, false);
#line 78 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestToPlay));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2591, 43, false);
#line 81 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuestToPlay));

#line default
#line hidden
            EndContext();
            BeginContext(2634, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2695, 45, false);
#line 84 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuizStart));

#line default
#line hidden
            EndContext();
            BeginContext(2740, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2802, 41, false);
#line 87 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuizStart));

#line default
#line hidden
            EndContext();
            BeginContext(2843, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2904, 45, false);
#line 90 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeLimit));

#line default
#line hidden
            EndContext();
            BeginContext(2949, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3011, 41, false);
#line 93 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeLimit));

#line default
#line hidden
            EndContext();
            BeginContext(3052, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3113, 48, false);
#line 96 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ResultLocked));

#line default
#line hidden
            EndContext();
            BeginContext(3161, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3223, 44, false);
#line 99 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.ResultLocked));

#line default
#line hidden
            EndContext();
            BeginContext(3267, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3328, 47, false);
#line 102 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockedUntil));

#line default
#line hidden
            EndContext();
            BeginContext(3375, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3437, 43, false);
#line 105 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockedUntil));

#line default
#line hidden
            EndContext();
            BeginContext(3480, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3527, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd30ce51d6e97e679fe3fdb7abd9f9d4ed1783d919467", async() => {
                BeginContext(3573, 4, true);
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
#line 110 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\MoQuizDetails\Details.cshtml"
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
            BeginContext(3581, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3589, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd30ce51d6e97e679fe3fdb7abd9f9d4ed1783d921814", async() => {
                BeginContext(3611, 12, true);
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
            BeginContext(3627, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoustacheApp.Models.MoQuizDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
