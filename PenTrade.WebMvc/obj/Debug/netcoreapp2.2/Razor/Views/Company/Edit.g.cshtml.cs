#pragma checksum "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a39f9467bb2a471983319f3f5e6033af07d3ee8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Edit), @"mvc.1.0.view", @"/Views/Company/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/Edit.cshtml", typeof(AspNetCore.Views_Company_Edit))]
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
#line 2 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a39f9467bb2a471983319f3f5e6033af07d3ee8c", @"/Views/Company/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c82bc30296d4420843d33026e2fcd7af56c1ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PenTrade.Models.Company>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveRepresentative", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMerchandise", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRepresentative", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMerchandise", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(418, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(419, 406, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a39f9467bb2a471983319f3f5e6033af07d3ee8c5556", async() => {
                BeginContext(461, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(467, 33, false);
#line 19 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(500, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(506, 43, false);
#line 20 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
Write(Html.HiddenFor(model => model.CurrentStock));

#line default
#line hidden
                EndContext();
                BeginContext(549, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(555, 43, false);
#line 21 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
Write(Html.HiddenFor(model => model.Negotiations));

#line default
#line hidden
                EndContext();
                BeginContext(598, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(604, 46, false);
#line 22 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
Write(Html.HiddenFor(model => model.Representatives));

#line default
#line hidden
                EndContext();
                BeginContext(650, 15, true);
                WriteLiteral("\r\n    Address: ");
                EndContext();
                BeginContext(666, 38, false);
#line 23 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
        Write(Html.TextBoxFor(model => model.Adress));

#line default
#line hidden
                EndContext();
                BeginContext(704, 27, true);
                WriteLiteral(" <br />\r\n    Company name: ");
                EndContext();
                BeginContext(732, 36, false);
#line 24 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
             Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(768, 50, true);
                WriteLiteral(" <br />\n    <input type=\"submit\" value=\"Edit\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(825, 51, true);
            WriteLiteral("\n\n<h2>Other representatives</h2>\n<table>\n    <tr>\r\n");
            EndContext();
#line 31 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
         foreach (var representative in Model.Representatives.Where(r => !r.Email.Equals(User.Claims.SingleOrDefault(claim => claim.Type.Equals(ClaimTypes.Email)).Value)).ToList())
        {

#line default
#line hidden
            BeginContext(1068, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(1085, 17, false);
#line 33 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
           Write(representative.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1102, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1126, 24, false);
#line 34 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
           Write(representative.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1152, 23, false);
#line 34 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
                                     Write(representative.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1177, 20, false);
#line 34 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
                                                              Write(representative.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1221, 26, false);
#line 35 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
           Write(representative.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1270, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a39f9467bb2a471983319f3f5e6033af07d3ee8c11953", async() => {
                BeginContext(1381, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-employeeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
                                                               WriteLiteral(representative.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-employeeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 36 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
                                                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["companyId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-companyId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["companyId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1391, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 37 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(1409, 57, true);
            WriteLiteral("    </tr>\n</table>\n\n<table class=\"table table-striped\">\n\n");
            EndContext();
#line 43 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
         foreach (var merch in Model.CurrentStock)
        {

#line default
#line hidden
            BeginContext(1527, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(1565, 22, false);
#line 46 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
               Write(merch.Merchandise.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1587, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1614, 32, false);
#line 47 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
               Write(merch.Merchandise.MesaurmentUnit);

#line default
#line hidden
            EndContext();
            BeginContext(1646, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1672, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a39f9467bb2a471983319f3f5e6033af07d3ee8c16422", async() => {
                BeginContext(1775, 18, true);
                WriteLiteral("Remove merchandise");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentStockId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
                                                                    WriteLiteral(merch.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentStockId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentStockId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentStockId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 48 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
                                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["companyId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-companyId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["companyId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1797, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 50 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(1831, 11, true);
            WriteLiteral("\n</table>\n\n");
            EndContext();
            BeginContext(1842, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a39f9467bb2a471983319f3f5e6033af07d3ee8c19832", async() => {
                BeginContext(1893, 28, true);
                WriteLiteral("\n    New representative id: ");
                EndContext();
                BeginContext(1922, 32, false);
#line 55 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
                      Write(Html.TextBox("RepresentativeId"));

#line default
#line hidden
                EndContext();
                BeginContext(1954, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1960, 34, false);
#line 56 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
Write(Html.Hidden("CompanyId", Model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1994, 48, true);
                WriteLiteral("\n    <input type=\"submit\" value=\"Add employee\">\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2049, 3, true);
            WriteLiteral("\n\n\n");
            EndContext();
            BeginContext(2052, 279, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a39f9467bb2a471983319f3f5e6033af07d3ee8c22491", async() => {
                BeginContext(2100, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2107, 34, false);
#line 62 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
Write(Html.Hidden("CompanyId", Model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(2141, 23, true);
                WriteLiteral("\r\n    Merchandise name:");
                EndContext();
                BeginContext(2165, 31, false);
#line 63 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
                Write(Html.TextBox("MerchandiseName"));

#line default
#line hidden
                EndContext();
                BeginContext(2196, 27, true);
                WriteLiteral(" <br />\r\n    Unit of sale: ");
                EndContext();
                BeginContext(2224, 42, false);
#line 64 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
             Write(Html.DropDownList("Unit", GetSelectList()));

#line default
#line hidden
                EndContext();
                BeginContext(2266, 58, true);
                WriteLiteral("\n    <input type=\"submit\"  value=\"Add new merchandise\"/>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
#line 5 "D:\Clueless\pentrade\pentrade\PenTrade.WebMvc\Views\Company\Edit.cshtml"
 
    public IEnumerable<SelectListItem> GetSelectList()
    {
        var collection = new List<SelectListItem>();
        foreach(var enumVal in Html.GetEnumSelectList(typeof(PenTrade.Models.MeasurmentUnit)))
        {
            collection.Add(new SelectListItem(enumVal.Text, enumVal.Value));
        }

        return collection;
    }

#line default
#line hidden
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
