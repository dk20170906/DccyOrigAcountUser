#pragma checksum "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "122b0e0e649e1e83cbc42574f662d18a9435f681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdmDepartments_Delete), @"mvc.1.0.view", @"/Views/AdmDepartments/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdmDepartments/Delete.cshtml", typeof(AspNetCore.Views_AdmDepartments_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"122b0e0e649e1e83cbc42574f662d18a9435f681", @"/Views/AdmDepartments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605861197891e1742ee9875955015cabcad8ff3e", @"/Views/_ViewImports.cshtml")]
    public class Views_AdmDepartments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DccyOrigination.Models.SysManagement.AdmDepartment>
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(103, 174, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>AdmDepartment</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(278, 43, false);
#line 15 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepName));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(365, 39, false);
#line 18 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DepName));

#line default
#line hidden
            EndContext();
            BeginContext(404, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(448, 39, false);
#line 21 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pid));

#line default
#line hidden
            EndContext();
            BeginContext(487, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(531, 35, false);
#line 24 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pid));

#line default
#line hidden
            EndContext();
            BeginContext(566, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(610, 40, false);
#line 27 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Guid));

#line default
#line hidden
            EndContext();
            BeginContext(650, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(694, 36, false);
#line 30 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Guid));

#line default
#line hidden
            EndContext();
            BeginContext(730, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(774, 41, false);
#line 33 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PGuid));

#line default
#line hidden
            EndContext();
            BeginContext(815, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(859, 37, false);
#line 36 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PGuid));

#line default
#line hidden
            EndContext();
            BeginContext(896, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(940, 46, false);
#line 39 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1030, 42, false);
#line 42 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1116, 44, false);
#line 45 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1204, 40, false);
#line 48 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1288, 47, false);
#line 51 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1379, 43, false);
#line 54 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1466, 46, false);
#line 57 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TimestampV));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1556, 42, false);
#line 60 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TimestampV));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1636, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f48a4504d3624d6ab97154aa66b4eca0", async() => {
                BeginContext(1662, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1672, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "018e15be4db0421fb8264e13cba8fbd3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmDepartments\Delete.cshtml"
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
                BeginContext(1708, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1792, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5faf20ea40a141e09b242dc9e7cb6981", async() => {
                    BeginContext(1814, 12, true);
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
                BeginContext(1830, 6, true);
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
            BeginContext(1843, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DccyOrigination.Models.SysManagement.AdmDepartment> Html { get; private set; }
    }
}
#pragma warning restore 1591
