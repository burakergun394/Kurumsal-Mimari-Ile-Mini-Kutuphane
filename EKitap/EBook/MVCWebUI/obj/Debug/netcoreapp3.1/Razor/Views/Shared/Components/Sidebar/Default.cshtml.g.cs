#pragma checksum "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f5aa8033dd895d6de01736a61c1d2fa622690a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Sidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Sidebar/Default.cshtml")]
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
#line 1 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\_ViewImports.cshtml"
using MVCWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\_ViewImports.cshtml"
using MVCWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f5aa8033dd895d6de01736a61c1d2fa622690a", @"/Views/Shared/Components/Sidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67de4b42a0c4efbf7b5dd9d40b254dff7d8feec3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Sidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"sidebar__inner\">\r\n    <div class=\"sidebar__most__read__books\">\r\n        <div class=\"sidebar__title\">\r\n            <h3>En Çok Okunan 5 Kitap</h3>\r\n        </div>\r\n        <div class=\"sidebar__book__details\">\r\n");
#nullable restore
#line 9 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
               var countDisplayed = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
             foreach (var item in Model.BooksByDisplayed)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"sidebar__book__detail\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f5aa8033dd895d6de01736a61c1d2fa622690a4529", async() => {
                WriteLiteral("\r\n                        <p>");
#nullable restore
#line 14 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
                      Write(countDisplayed);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 576, "\"", 637, 1);
#nullable restore
#line 15 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
WriteAttributeValue("", 582, ViewBag.BookByDisplayedImages[countDisplayed - 1].Path, 582, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <div class=\"card-book-right\">\r\n                            <h6 class=\"card-book-title\">");
#nullable restore
#line 17 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 21 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
                countDisplayed++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"sidebar__last__books\">\r\n    <div class=\"sidebar__title\">\r\n        <h3>En Son Eklenen 3 Kitap</h3>\r\n    </div>\r\n    <div class=\"sidebar__book__details\">\r\n");
#nullable restore
#line 31 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
           var countDate = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
         foreach (var item in Model.BooksByDate)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"sidebar__book__detail\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f5aa8033dd895d6de01736a61c1d2fa622690a9115", async() => {
                WriteLiteral("\r\n                <p>");
#nullable restore
#line 36 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
              Write(countDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 1376, "\"", 1427, 1);
#nullable restore
#line 37 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
WriteAttributeValue("", 1382, ViewBag.BookByDateImages[countDate - 1].Path, 1382, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"card-book-right\">\r\n                    <h6 class=\"card-book-title\">");
#nullable restore
#line 39 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 43 "D:\PROJELER\Site\EKitap\EBook\MVCWebUI\Views\Shared\Components\Sidebar\Default.cshtml"
            countDate++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
