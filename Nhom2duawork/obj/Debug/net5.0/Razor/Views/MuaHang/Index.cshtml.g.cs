#pragma checksum "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\MuaHang\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0e4243bdb616d59fe1a474c2362611b1a4ee62ecffdda68426ac07db47de26e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MuaHang_Index), @"mvc.1.0.view", @"/Views/MuaHang/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0e4243bdb616d59fe1a474c2362611b1a4ee62ecffdda68426ac07db47de26e4", @"/Views/MuaHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"46f275256ceda2bd0728e425d31f0f5c35d3228bae4b7e4291fc0c154aa86fe6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MuaHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MuaHang>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!-- Views/MuaHang/Index.cshtml -->\r\n");
            WriteLiteral("    <h2>Danh sách Mua hàng</h2>\r\n");
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Tên Sản Phẩm</th>
                <th>Số Lượng</th>
                <th>Đơn Giá</th>
                <!-- Thêm các cột khác nếu cần -->
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\MuaHang\Index.cshtml"
             foreach (var muaHang in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\MuaHang\Index.cshtml"
                   Write(muaHang.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\MuaHang\Index.cshtml"
                   Write(muaHang.TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\MuaHang\Index.cshtml"
                   Write(muaHang.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\MuaHang\Index.cshtml"
                   Write(muaHang.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <!-- Hiển thị các giá trị khác nếu cần -->\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\ACER\Documents\Zalo Received Files\Nhom2duawork (2)\Nhom2duawork\Views\MuaHang\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MuaHang>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
