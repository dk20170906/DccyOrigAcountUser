#pragma checksum "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Error\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc60d063181325fe5842eb91f53a3df3f6d84884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Index), @"mvc.1.0.view", @"/Views/Error/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/Index.cshtml", typeof(AspNetCore.Views_Error_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc60d063181325fe5842eb91f53a3df3f6d84884", @"/Views/Error/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605861197891e1742ee9875955015cabcad8ff3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DccyOrigination.Models.ResultModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Error\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 13, true);
            WriteLiteral("\r\n\r\n<h2>错误代码：");
            EndContext();
            BeginContext(98, 15, false);
#line 7 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Error\Index.cshtml"
    Write(Model.StateCode);

#line default
#line hidden
            EndContext();
            BeginContext(113, 16, true);
            WriteLiteral("</h2>\r\n<h2>错误信息：");
            EndContext();
            BeginContext(130, 13, false);
#line 8 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Error\Index.cshtml"
    Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(143, 16, true);
            WriteLiteral("</h2>\r\n<h2>错误详情：");
            EndContext();
            BeginContext(160, 10, false);
#line 9 "C:\Users\Administrator\Desktop\DccyOrig\DccyOrigination\DccyOrigination\DccyOrigination\Views\Error\Index.cshtml"
    Write(Model.Data);

#line default
#line hidden
            EndContext();
            BeginContext(170, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DccyOrigination.Models.ResultModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
