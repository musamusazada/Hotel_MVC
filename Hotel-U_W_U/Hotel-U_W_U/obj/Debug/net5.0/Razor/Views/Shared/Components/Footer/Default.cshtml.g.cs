#pragma checksum "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e96b395db64db7377f6b8aa7239171fad0a136e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\_ViewImports.cshtml"
using Hotel_U_W_U;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\_ViewImports.cshtml"
using Hotel_U_W_U.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\_ViewImports.cshtml"
using Hotel_U_W_U.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\_ViewImports.cshtml"
using Hotel_U_W_U.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e96b395db64db7377f6b8aa7239171fad0a136e", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd69bfe50d588db2ea64362d18513f4ca8e44b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"footer-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"footer-logo\">\r\n                    <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e96b395db64db7377f6b8aa7239171fad0a136e4572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                </div>
            </div>
        </div>
        <div class=""row pb-50"">
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-footer-widget"">
                    <h5>Location</h5>
                    <div class=""widget-text"">
                        <i class=""fa fa-map-marker""></i>
                        <p>");
#nullable restore
#line 17 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\Shared\Components\Footer\Default.cshtml"
                      Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-footer-widget"">
                    <h5>Reception</h5>
                    <div class=""widget-text"">
                        <i class=""fa fa-phone""></i>
                        <p>");
#nullable restore
#line 26 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\Shared\Components\Footer\Default.cshtml"
                      Write(Model.receptionPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-footer-widget"">
                    <h5>Shuttle Service</h5>
                    <div class=""widget-text"">
                        <i class=""fa fa-phone""></i>
                        <p>");
#nullable restore
#line 35 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\Shared\Components\Footer\Default.cshtml"
                      Write(Model.shuffleServicePhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-sm-6"">
                <div class=""single-footer-widget"">
                    <h5>Restaurant</h5>
                    <div class=""widget-text"">
                        <i class=""fa fa-phone""></i>
                        <p>");
#nullable restore
#line 44 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Views\Shared\Components\Footer\Default.cshtml"
                      Write(Model.restaurantPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""copyright-area"">
        <div class=""container"">
            <div class=""copyright-text"">
                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
            </div>
            <div class=""privacy-links"">
                <a href=""https://musamusazada.github.io/"">Musa Musazada</a>

            </div>
        </div>
    </div>
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591