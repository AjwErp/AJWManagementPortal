#pragma checksum "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d965c1aa286c36dc4fd04b73cc0620f683f146b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Sheets_Views_Meezan_Details), @"mvc.1.0.view", @"/Areas/Sheets/Views/Meezan/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\_ViewImports.cshtml"
using MTJ_Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\_ViewImports.cshtml"
using AJWManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d965c1aa286c36dc4fd04b73cc0620f683f146b", @"/Areas/Sheets/Views/Meezan/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3efe1dac4210f9ffdeb0fdb77659f80294005921", @"/Areas/Sheets/Views/_ViewImports.cshtml")]
    public class Areas_Sheets_Views_Meezan_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AJWManagementPortal.Models.MeezanBankIEReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutAccount.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>MeezanBankIEReport</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CDO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.CDO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cradit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cradit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imgceo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Imgceo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imggm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Imggm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imgdgm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Imgdgm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imgam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
       Write(Html.DisplayFor(model => model.Imgam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d965c1aa286c36dc4fd04b73cc0620f683f146b11696", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 77 "C:\Users\Khan computers\Source\Repos\AjwErp\AJWManagementPortal\AJWManagementPortal\Areas\Sheets\Views\Meezan\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d965c1aa286c36dc4fd04b73cc0620f683f146b13884", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AJWManagementPortal.Models.MeezanBankIEReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
