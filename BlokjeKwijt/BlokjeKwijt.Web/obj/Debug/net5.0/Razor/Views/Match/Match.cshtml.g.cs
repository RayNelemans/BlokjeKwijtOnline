#pragma checksum "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9447311b4ad2655a66ab8ff9ab64d96ca811cb61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Match_Match), @"mvc.1.0.view", @"/Views/Match/Match.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9447311b4ad2655a66ab8ff9ab64d96ca811cb61", @"/Views/Match/Match.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91e3b8af9f2c3f8495b126c32dcabd59200211a", @"/Views/_ViewImports.cshtml")]
    public class Views_Match_Match : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlokjeKwijt.Web.Models.MatchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Match", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
  
    ViewData["Title"] = "Match";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gekozen verzoek</h1>\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 11 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayNameFor(model => model.Verzoek.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 14 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayFor(model => model.Verzoek.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayNameFor(model => model.Verzoek.BlokjeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayFor(model => model.Verzoek.BlokjeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayNameFor(model => model.Verzoek.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayFor(model => model.Verzoek.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayNameFor(model => model.Verzoek.BlokjeOverKwijt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayFor(model => model.Verzoek.BlokjeOverKwijt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayNameFor(model => model.Verzoek.BlokjesVerzoekStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
       Write(Html.DisplayFor(model => model.Verzoek.BlokjesVerzoekStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<h1>Mogelijke matches</h1>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9447311b4ad2655a66ab8ff9ab64d96ca811cb617452", async() => {
                WriteLiteral("\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 49 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                   Write(Html.DisplayNameFor(model => model.VerzoekenList[0].Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 52 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                   Write(Html.DisplayNameFor(model => model.VerzoekenList[0].BlokjeId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 55 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                   Write(Html.DisplayNameFor(model => model.VerzoekenList[0].Naam));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 58 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                   Write(Html.DisplayNameFor(model => model.VerzoekenList[0].BlokjeOverKwijt));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 61 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                   Write(Html.DisplayNameFor(model => model.VerzoekenList[0].BlokjesVerzoekStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 66 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                 foreach (var item in Model.VerzoekenList)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 70 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 73 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BlokjeId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 76 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Naam));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 79 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BlokjeOverKwijt));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 82 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BlokjesVerzoekStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                       Write(Html.ActionLink("Match", "Match", new { id = item.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 88 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\Match\Match.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Match\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlokjeKwijt.Web.Models.MatchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
