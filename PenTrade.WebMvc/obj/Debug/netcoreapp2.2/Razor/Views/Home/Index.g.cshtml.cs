#pragma checksum "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e09e231be8a8ce864d27de3f1de6487c712a5dce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\_ViewImports.cshtml"
using PenTrade.WebMvc;

#line default
#line hidden
#line 2 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\_ViewImports.cshtml"
using PenTrade.WebMvc.Models;

#line default
#line hidden
#line 5 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Home\Index.cshtml"
using PenTrade.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09e231be8a8ce864d27de3f1de6487c712a5dce", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c82bc30296d4420843d33026e2fcd7af56c1ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Merchandise>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(97, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Home\Index.cshtml"
 foreach(var merchandise in Model)
{
    

#line default
#line hidden
            BeginContext(141, 14, false);
#line 10 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Home\Index.cshtml"
Write(merchandise.Id);

#line default
#line hidden
            EndContext();
            BeginContext(155, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(168, 16, false);
#line 11 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Home\Index.cshtml"
Write(merchandise.Name);

#line default
#line hidden
            EndContext();
            BeginContext(184, 26, true);
            WriteLiteral("<br />\r\n    <br /><br />\r\n");
            EndContext();
#line 13 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Home\Index.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Merchandise>> Html { get; private set; }
    }
}
#pragma warning restore 1591
