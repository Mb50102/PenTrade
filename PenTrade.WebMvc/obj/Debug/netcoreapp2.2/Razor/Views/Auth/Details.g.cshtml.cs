#pragma checksum "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Auth\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46f0e210568894f849e98b1c31780cd57b02539"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Details), @"mvc.1.0.view", @"/Views/Auth/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Details.cshtml", typeof(AspNetCore.Views_Auth_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46f0e210568894f849e98b1c31780cd57b02539", @"/Views/Auth/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c82bc30296d4420843d33026e2fcd7af56c1ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PenTrade.Models.Company>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Auth\Details.cshtml"
 foreach (var representative in Model.Representatives)
{

    

#line default
#line hidden
            BeginContext(100, 24, false);
#line 6 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Auth\Details.cshtml"
Write(representative.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(126, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(132, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
            BeginContext(145, 23, false);
#line 8 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Auth\Details.cshtml"
Write(representative.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(168, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(171, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
            BeginContext(184, 26, false);
#line 9 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Auth\Details.cshtml"
Write(representative.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(210, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(213, 8, true);
            WriteLiteral("&nbsp;\r\n");
            EndContext();
            BeginContext(226, 20, false);
#line 10 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Auth\Details.cshtml"
Write(representative.Email);

#line default
#line hidden
            EndContext();
            BeginContext(246, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 11 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Auth\Details.cshtml"
}

#line default
#line hidden
            BeginContext(257, 6, true);
            WriteLiteral("<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PenTrade.Models.Company> Html { get; private set; }
    }
}
#pragma warning restore 1591
