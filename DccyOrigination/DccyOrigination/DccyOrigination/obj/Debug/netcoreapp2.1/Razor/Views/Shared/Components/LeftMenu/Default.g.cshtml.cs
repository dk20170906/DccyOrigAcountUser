#pragma checksum "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Shared\Components\LeftMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756aeb3a442c9ea2c045225b5c88adbe670abe2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LeftMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LeftMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/LeftMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_LeftMenu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756aeb3a442c9ea2c045225b5c88adbe670abe2b", @"/Views/Shared/Components/LeftMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605861197891e1742ee9875955015cabcad8ff3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LeftMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Shared\Components\LeftMenu\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(45, 666, true);
            WriteLiteral(@"<div class=""col-md-2"">
    <ul id=""main-nav"" class=""nav nav-tabs nav-stacked"" style="""">
        <li class=""active"">
            <a href=""#"">
                <i class=""glyphicon glyphicon-th-large""></i>
                首页
            </a>
        </li>
        <li>
            <a href=""#systemSetting"" class=""nav-header collapsed"" data-toggle=""collapse"">
                <i class=""glyphicon glyphicon-cog""></i>
                系统管理
                <span class=""pull-right glyphicon glyphicon-chevron-down""></span>
            </a>
            <ul id=""systemSetting"" class=""nav nav-list collapse secondmenu"" style=""height: 0px;"">
                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 711, "\"", 750, 1);
#line 20 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Shared\Components\LeftMenu\Default.cshtml"
WriteAttributeValue("", 718, Url.Content("~/AdmUsers/Index"), 718, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(751, 78, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-user\"></i>用户管理</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 829, "\"", 864, 1);
#line 21 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Shared\Components\LeftMenu\Default.cshtml"
WriteAttributeValue("", 836, Url.Content("~/Menu/Index"), 836, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(865, 81, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-th-list\"></i>菜单管理</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 946, "\"", 991, 1);
#line 22 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Shared\Components\LeftMenu\Default.cshtml"
WriteAttributeValue("", 953, Url.Content("~/AdmDepartments/Index"), 953, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(992, 81, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-th-list\"></i>部门管理</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1112, 1);
#line 23 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Shared\Components\LeftMenu\Default.cshtml"
WriteAttributeValue("", 1080, Url.Content("~/AdmRoles/Index"), 1080, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1113, 1023, true);
            WriteLiteral(@"><i class=""glyphicon glyphicon-asterisk""></i>角色管理</a></li>
                <li><a href=""#""><i class=""glyphicon glyphicon-edit""></i>修改密码</a></li>
                <li><a href=""#""><i class=""glyphicon glyphicon-eye-open""></i>日志查看</a></li>
            </ul>
        </li>
        <li>
            <a href=""./plans.html"">
                <i class=""glyphicon glyphicon-credit-card""></i>
                物料管理
            </a>
        </li>

        <li>
            <a href=""./grid.html"">
                <i class=""glyphicon glyphicon-globe""></i>
                分发配置
                <span class=""label label-warning pull-right"">5</span>
            </a>
        </li>

        <li>
            <a href=""./charts.html"">
                <i class=""glyphicon glyphicon-calendar""></i>
                图表统计
            </a>
        </li>
        <li>
            <a href=""#"">
                <i class=""glyphicon glyphicon-fire""></i>
                关于系统
            </a>
        </li>

    </ul>
</div>");
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
