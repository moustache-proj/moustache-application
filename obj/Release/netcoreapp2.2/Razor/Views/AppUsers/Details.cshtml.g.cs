#pragma checksum "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fc94f8e47aed668e8a323c2269cdefa9211ab09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppUsers_Details), @"mvc.1.0.view", @"/Views/AppUsers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AppUsers/Details.cshtml", typeof(AspNetCore.Views_AppUsers_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fc94f8e47aed668e8a323c2269cdefa9211ab09", @"/Views/AppUsers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46388d910ae4e9e65779d2a9973ac2726979d4ae", @"/Views/_ViewImports.cshtml")]
    public class Views_AppUsers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoustacheApp.Models.AppUser>
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
  
    ViewData["Title"] = "User Details";

#line default
#line hidden
            BeginContext(86, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(93, 17, false);
#line 7 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(110, 92, true);
            WriteLiteral("</h3>\r\n<hr />\r\n<div>\r\n    <dl class=\"canister\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(203, 42, false);
#line 12 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(245, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(307, 34, false);
#line 15 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(341, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(402, 45, false);
#line 18 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Anonymous));

#line default
#line hidden
            EndContext();
            BeginContext(447, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(509, 41, false);
#line 21 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Anonymous));

#line default
#line hidden
            EndContext();
            BeginContext(550, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(611, 44, false);
#line 24 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(655, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(717, 40, false);
#line 27 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(757, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(818, 43, false);
#line 30 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AltName));

#line default
#line hidden
            EndContext();
            BeginContext(861, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(923, 39, false);
#line 33 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.AltName));

#line default
#line hidden
            EndContext();
            BeginContext(962, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1023, 41, false);
#line 36 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1126, 37, false);
#line 39 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1224, 50, false);
#line 42 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1336, 46, false);
#line 45 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmailConfirmed));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1443, 53, false);
#line 48 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1558, 49, false);
#line 51 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1668, 50, false);
#line 54 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1780, 46, false);
#line 57 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
            EndContext();
            BeginContext(1826, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1887, 46, false);
#line 60 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1995, 42, false);
#line 63 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2098, 44, false);
#line 66 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Disabled));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2204, 40, false);
#line 69 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Disabled));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2305, 47, false);
#line 72 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisableDate));

#line default
#line hidden
            EndContext();
            BeginContext(2352, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2414, 43, false);
#line 75 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisableDate));

#line default
#line hidden
            EndContext();
            BeginContext(2457, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2520, 46, false);
#line 78 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisabledBy));

#line default
#line hidden
            EndContext();
            BeginContext(2566, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2630, 42, false);
#line 81 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisabledBy));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2719, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fc94f8e47aed668e8a323c2269cdefa9211ab0915745", async() => {
                BeginContext(2765, 4, true);
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
#line 86 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Views\AppUsers\Details.cshtml"
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
            BeginContext(2773, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2781, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fc94f8e47aed668e8a323c2269cdefa9211ab0918086", async() => {
                BeginContext(2803, 12, true);
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
            BeginContext(2819, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoustacheApp.Models.AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
