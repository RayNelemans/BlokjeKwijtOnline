#pragma checksum "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "def283a43afe8eafa2cefe95d7c7513b5ee57dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OverKwijt_Index), @"mvc.1.0.view", @"/Views/OverKwijt/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def283a43afe8eafa2cefe95d7c7513b5ee57dcf", @"/Views/OverKwijt/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91e3b8af9f2c3f8495b126c32dcabd59200211a", @"/Views/_ViewImports.cshtml")]
    public class Views_OverKwijt_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlokjeKwijt.Web.Models.VerzoekViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OverKwijt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def283a43afe8eafa2cefe95d7c7513b5ee57dcf4510", async() => {
                WriteLiteral(@"
    <p>
        Blok Nummer: <input type=""text"" name=""bloknr"" />
        Lengte: <input type=""text"" name=""lengte"" />
        Breedte: <input type=""text"" name=""breedte"" />
        Nopjes: <input type=""text"" name=""Nopjes"" />
        <input type=""submit"" value=""Filter"" />
    </p>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BlokjesList[0].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BlokjesList[0].BlokNummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BlokjesList[0].Lengte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BlokjesList[0].Breedte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BlokjesList[0].Hoogte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BlokjesList[0].Nopjes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BlokjesList[0].KleurId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BlokjesList[0].ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
         foreach (var item in Model.BlokjesList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BlokNummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lengte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Breedte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hoogte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nopjes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.KleurId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2410, "\"", 2452, 2);
            WriteAttributeValue("", 2416, "/Images/", 2416, 8, true);
#nullable restore
#line 75 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
WriteAttributeValue("", 2424, Url.Content(item.ImageName), 2424, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.ActionLink("Over", "Over", new { id = Model.Id, blokjeId = item.BlokNummer }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 79 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
               Write(Html.ActionLink("Kwijt", "Kwijt", new { id = Model.Id, blokjeId = item.BlokNummer }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "C:\Users\rayne\Documents\GitHub\BlokjeKwijt\BlokjeKwijt\BlokjeKwijt.Web\Views\OverKwijt\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlokjeKwijt.Web.Models.VerzoekViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
