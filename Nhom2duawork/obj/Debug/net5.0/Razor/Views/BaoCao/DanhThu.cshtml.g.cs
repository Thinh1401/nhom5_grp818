#pragma checksum "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\BaoCao\DanhThu.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a4fdac1a38af54fdf07dfb579dd2efd38fa1debcbe5d223376fa7e1f77a3bcf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoCao_DanhThu), @"mvc.1.0.view", @"/Views/BaoCao/DanhThu.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\_ViewImports.cshtml"
using Nhom2duawork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\_ViewImports.cshtml"
using Nhom2duawork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a4fdac1a38af54fdf07dfb579dd2efd38fa1debcbe5d223376fa7e1f77a3bcf5", @"/Views/BaoCao/DanhThu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"46f275256ceda2bd0728e425d31f0f5c35d3228bae4b7e4291fc0c154aa86fe6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BaoCao_DanhThu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BaoCaoDanhThu>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!-- Views/BaoCao/DanhThu.cshtml -->\r\n");
            WriteLiteral("    <h2>Danh sách Báo cáo danh thu</h2>\r\n");
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Thời Gian</th>
                <th>Doanh Thu</th>
                <!-- Thêm các cột khác nếu cần -->
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\BaoCao\DanhThu.cshtml"
             foreach (var baoCaoDanhThu in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\BaoCao\DanhThu.cshtml"
                   Write(baoCaoDanhThu.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\BaoCao\DanhThu.cshtml"
                   Write(baoCaoDanhThu.ThoiGian);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\BaoCao\DanhThu.cshtml"
                   Write(baoCaoDanhThu.DoanhThu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <!-- Hiển thị các giá trị khác nếu cần -->\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\BaoCao\DanhThu.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BaoCaoDanhThu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591