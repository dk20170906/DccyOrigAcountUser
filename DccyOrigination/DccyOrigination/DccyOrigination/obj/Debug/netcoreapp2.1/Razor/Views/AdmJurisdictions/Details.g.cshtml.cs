#pragma checksum "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fbec49bdf820c55d69ffe562ef3136e76e36bf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdmJurisdictions_Details), @"mvc.1.0.view", @"/Views/AdmJurisdictions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdmJurisdictions/Details.cshtml", typeof(AspNetCore.Views_AdmJurisdictions_Details))]
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
#line 1 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\_ViewImports.cshtml"
using DccyOrigination;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\_ViewImports.cshtml"
using DccyOrigination.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fbec49bdf820c55d69ffe562ef3136e76e36bf6", @"/Views/AdmJurisdictions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605861197891e1742ee9875955015cabcad8ff3e", @"/Views/_ViewImports.cshtml")]
    public class Views_AdmJurisdictions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DccyOrigination.Models.SysManagement.AdmJurisdiction>
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(106, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>AdmJurisdiction</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(236, 43, false);
#line 14 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JurName));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(323, 39, false);
#line 17 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.JurName));

#line default
#line hidden
            EndContext();
            BeginContext(362, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(406, 39, false);
#line 20 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
            EndContext();
            BeginContext(445, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(489, 35, false);
#line 23 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Url));

#line default
#line hidden
            EndContext();
            BeginContext(524, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(568, 45, false);
#line 26 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MenuStyle));

#line default
#line hidden
            EndContext();
            BeginContext(613, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(657, 41, false);
#line 29 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.MenuStyle));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(742, 42, false);
#line 32 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(784, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(828, 38, false);
#line 35 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(866, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(910, 41, false);
#line 38 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepId));

#line default
#line hidden
            EndContext();
            BeginContext(951, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(995, 37, false);
#line 41 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.DepId));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1076, 51, false);
#line 44 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAuthorization));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1171, 47, false);
#line 47 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsAuthorization));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1262, 42, false);
#line 50 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsOpen));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1348, 38, false);
#line 53 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsOpen));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1430, 46, false);
#line 56 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsChildren));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1520, 42, false);
#line 59 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsChildren));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1606, 39, false);
#line 62 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pid));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1689, 35, false);
#line 65 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pid));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1768, 40, false);
#line 68 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Guid));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1852, 36, false);
#line 71 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Guid));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1932, 41, false);
#line 74 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PGuid));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2017, 37, false);
#line 77 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.PGuid));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2098, 46, false);
#line 80 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(2144, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2188, 42, false);
#line 83 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(2230, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2274, 44, false);
#line 86 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(2318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2362, 40, false);
#line 89 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2446, 47, false);
#line 92 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2493, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2537, 43, false);
#line 95 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2624, 46, false);
#line 98 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimestampV));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2714, 42, false);
#line 101 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimestampV));

#line default
#line hidden
            EndContext();
            BeginContext(2756, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2803, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b06555a2ff14245bb9534b1e62625dd", async() => {
                BeginContext(2849, 4, true);
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
#line 106 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmJurisdictions\Details.cshtml"
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
            BeginContext(2857, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2865, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e34572b68d94edbaf99609b122b47f6", async() => {
                BeginContext(2887, 12, true);
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
            BeginContext(2903, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DccyOrigination.Models.SysManagement.AdmJurisdiction> Html { get; private set; }
    }
}
#pragma warning restore 1591
