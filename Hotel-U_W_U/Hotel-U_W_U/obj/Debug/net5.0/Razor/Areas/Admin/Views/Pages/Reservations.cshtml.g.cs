#pragma checksum "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\Pages\Reservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b88ed242a20e31e6a1efbc9a5cdf37e0be73c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pages_Reservations), @"mvc.1.0.view", @"/Areas/Admin/Views/Pages/Reservations.cshtml")]
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
#line 1 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel_U_W_U;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel_U_W_U.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel_U_W_U.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\_ViewImports.cshtml"
using Hotel_U_W_U.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b88ed242a20e31e6a1efbc9a5cdf37e0be73c9d", @"/Areas/Admin/Views/Pages/Reservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd69bfe50d588db2ea64362d18513f4ca8e44b74", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pages_Reservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/plugins-init/datatables.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""content-body"">
    <div class=""container-fluid"">
        <div class=""row page-titles mx-0"">
            <div class=""col-sm-6 p-md-0"">
                <div class=""welcome-text"">
                    <h4>Browser Reservations</h4>
                    <span class=""ml-1"">Datatable</span>
                </div>
            </div>
            <div class=""col-sm-6 p-md-0 justify-content-sm-end mt-2 mt-sm-0 d-flex"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Table</a></li>
                    <li class=""breadcrumb-item active""><a href=""javascript:void(0)"">Datatable</a></li>
                </ol>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Datatable</h4>
                    </div>
                    <div class=""card-body"">
               ");
            WriteLiteral(@"         <div class=""table-responsive"">
                            <table id=""example2"" class=""display"" style=""width:100%"">
                                <thead>
                                    <tr>
                                        <th>ID</th>
                                        <th>RoomID</th>
                                        <th>CheckIn</th>
                                        <th>CheckOut</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 36 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\Pages\Reservations.cshtml"
                                     foreach (var res in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 39 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\Pages\Reservations.cshtml"
                                           Write(res.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 40 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\Pages\Reservations.cshtml"
                                           Write(res.roomID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 41 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\Pages\Reservations.cshtml"
                                           Write(res.checkIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 42 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\Pages\Reservations.cshtml"
                                           Write(res.checkOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Hotel-U_W_U\Hotel-U_W_U\Areas\Admin\Views\Pages\Reservations.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>ID</th>
                                        <th>RoomID</th>
                                        <th>CheckIn</th>
                                        <th>CheckOut</th>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b88ed242a20e31e6a1efbc9a5cdf37e0be73c9d8841", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b88ed242a20e31e6a1efbc9a5cdf37e0be73c9d9880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
