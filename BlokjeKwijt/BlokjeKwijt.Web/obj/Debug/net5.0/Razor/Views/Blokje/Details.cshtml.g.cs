#pragma checksum "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e598c77c55bda5a5cdcc735cd60a362b7ae7005b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blokje_Details), @"mvc.1.0.view", @"/Views/Blokje/Details.cshtml")]
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
#line 1 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\_ViewImports.cshtml"
using BlokjeKwijt.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\_ViewImports.cshtml"
using BlokjeKwijt.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e598c77c55bda5a5cdcc735cd60a362b7ae7005b", @"/Views/Blokje/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91e3b8af9f2c3f8495b126c32dcabd59200211a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blokje_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlokjeKwijt.Web.Models.BlokjeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Blokje details</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BlokNummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayFor(model => model.BlokNummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lengte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lengte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Breedte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Breedte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hoogte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hoogte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nopjes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nopjes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KleurId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayFor(model => model.KleurId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1814, "\"", 1857, 2);
            WriteAttributeValue("", 1820, "/Images/", 1820, 8, true);
#nullable restore
#line 59 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
WriteAttributeValue("", 1828, Url.Content(Model.ImageName), 1828, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 64 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Blokje\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e598c77c55bda5a5cdcc735cd60a362b7ae7005b9824", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlokjeKwijt.Web.Models.BlokjeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
