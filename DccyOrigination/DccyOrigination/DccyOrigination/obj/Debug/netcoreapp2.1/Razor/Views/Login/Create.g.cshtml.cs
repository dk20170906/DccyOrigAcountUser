#pragma checksum "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Login\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae15e21993e1136f11248a92e1ff778502f038f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Create), @"mvc.1.0.view", @"/Views/Login/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Create.cshtml", typeof(AspNetCore.Views_Login_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae15e21993e1136f11248a92e1ff778502f038f5", @"/Views/Login/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605861197891e1742ee9875955015cabcad8ff3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Login\Create.cshtml"
  
    ViewData["Title"] = "用户注册";
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
            BeginContext(94, 5, true);
            WriteLiteral("<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 99, "\"", 152, 1);
#line 6 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Login\Create.cshtml"
WriteAttributeValue("", 106, Url.Content("~/loginstatic/css/register.css"), 106, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(153, 259, true);
            WriteLiteral(@" rel=""stylesheet"" />
<!--顶部-->
<div class=""top"">
    <div class=""imgs"">
        <img src=""images/logo.jpg"" align=""bottom"">
    </div>
    <div class=""t_title"">欢迎注册</div>
    <div class=""t_right"">
        <span style=""color: gray"">已有账号</span>
        ");
            EndContext();
            BeginContext(413, 31, false);
#line 15 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Login\Create.cshtml"
   Write(Html.ActionLink("请登陆", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(444, 73, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<!--左边框-->\r\n<div class=\"left\"></div>\r\n<!--中间区域-->\r\n");
            EndContext();
            BeginContext(517, 3016, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bb29c78c76b4a419fb6c5b7ab10b969", async() => {
                BeginContext(578, 1179, true);
                WriteLiteral(@"
    <div class=""middle"">
        <div class=""m_top""></div>
        <!--注册信息-->
        <div class=""item"">
            <div class=""i_name"">
                <label for=""username"">用户名</label>
            </div>
            <div class=""i_left"">
                <input type=""text"" id=""username"">
            </div>
            <div class=""i_right""></div>
        </div>
        <div class=""item"">
            <div class=""i_name"">
                <label for=""password"">密码</label>
            </div>
            <div class=""i_left"">
                <input type=""password"" id=""password"">
            </div>
            <div class=""i_right""></div>
        </div>
        <div class=""item"">
            <div class=""i_name"">
                <label for=""repassword"">重复密码</label>
            </div>
            <div class=""i_left"">
                <input type=""password"" id=""repassword"">
            </div>
            <div class=""i_right""></div>
        </div>
        <div class=""item"">
            <di");
                WriteLiteral("v class=\"i_name\">\r\n                <label>所在地</label>\r\n            </div>\r\n            <div class=\"i_left\">\r\n                <select>\r\n                    ");
                EndContext();
                BeginContext(1757, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85676b32b0d344c39348466f82fafe19", async() => {
                    BeginContext(1765, 2, true);
                    WriteLiteral("中国");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1776, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1798, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc825fd595146c585310edcef3b45f0", async() => {
                    BeginContext(1806, 2, true);
                    WriteLiteral("外国");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1817, 75, true);
                WriteLiteral("\r\n                </select>\r\n                <select>\r\n                    ");
                EndContext();
                BeginContext(1892, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e23667266c4d4bb37c9cd69955e152", async() => {
                    BeginContext(1900, 2, true);
                    WriteLiteral("北京");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1911, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1933, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a9204f08f5a418fb0f90206f06ba2eb", async() => {
                    BeginContext(1941, 2, true);
                    WriteLiteral("外省");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1952, 1574, true);
                WriteLiteral(@"
                </select>
            </div>
            <div class=""i_right""></div>
        </div>
        <div class=""item"">
            <div class=""i_name"">
                <label>性别</label>
            </div>
            <div class=""i_left"">
                <div class=""sex"">
                    <label for=""main"">男</label><input type=""radio"" name=""sex"" id=""main"">
                </div>
                <div class=""sex"">
                    <label for=""femain"">女</label><input type=""radio"" name=""sex"" id=""femain"">
                </div>

            </div>
            <div class=""i_right""></div>
        </div>
        <div class=""item"">
            <div class=""i_name"">
                <label>爱好</label>
            </div>
            <div class=""i_left"">
                <div class=""i_like"">
                    <label for=""box"">足球</label> <input type=""checkbox"" id=""box"">
                </div>
                <div class=""i_like"">
                    <label for=""moiv"">电影</label> <inp");
                WriteLiteral(@"ut type=""checkbox"" id=""moiv"">
                </div>
                <div class=""i_like"">
                    <label for=""girl"">美女</label> <input type=""checkbox"" id=""girl"">
                </div>
            </div>
            <div class=""i_right""></div>
        </div>
        <!--立即注册-->
        <div class=""item"">
            <div class=""i_name"">
                <label></label>
            </div>
            <div class=""register"">
                <input type=""submit"" value=""立即注册"">
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Login\Create.cshtml"
AddHtmlAttributeValue("", 531, Url.Action("Create","AdmUser"), 531, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(3533, 33, true);
            WriteLiteral("\r\n<div class=\"right\"></div>\r\n\r\n\r\n");
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
