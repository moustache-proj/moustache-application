#pragma checksum "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\Account\Manage\_Layout-original.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b5024e86265155246ed143d08e510d6553b41f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MoustacheApp.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout_original), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout-original.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_Layout-original.cshtml", typeof(MoustacheApp.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout_original))]
namespace MoustacheApp.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\_ViewImports.cshtml"
using MoustacheApp;

#line default
#line hidden
#line 3 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\_ViewImports.cshtml"
using MoustacheApp.Areas.Identity;

#line default
#line hidden
#line 4 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\_ViewImports.cshtml"
using MoustacheApp.Models;

#line default
#line hidden
#line 1 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using MoustacheApp.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using MoustacheApp.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5024e86265155246ed143d08e510d6553b41f5", @"/Areas/Identity/Pages/Account/Manage/_Layout-original.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf39af18ab3d5eb387328f8d6670d0ee527c05b9", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfa1116fdea15389d7ed74e0d3f6ea8e8d896ed", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c3e9b7520f072a2dca29d0166d3d33a3bea86f", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout_original : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\Account\Manage\_Layout-original.cshtml"
  
    Layout = "/Areas/Identity/Pages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(61, 168, true);
            WriteLiteral("\r\n<h1>Manage your account</h1>\r\n\r\n<div>\r\n    <h4>Change your account settings</h4>\r\n    <hr />\r\n    <div class=\"canister\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(229, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b5024e86265155246ed143d08e510d6553b41f55536", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(258, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            EndContext();
            BeginContext(321, 12, false);
#line 15 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\Account\Manage\_Layout-original.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(333, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(391, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(398, 41, false);
#line 21 "D:\VU_NBIT\nef3001_project\implementation\moustache-git\MoustacheApp\Areas\Identity\Pages\Account\Manage\_Layout-original.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(439, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
