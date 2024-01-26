// Controllers/MuaHangController.cs
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Nhom2duawork.Models;

namespace Nhom2duawork.Controllers
{
    public class MuaHangController : Controller
    {
        public IActionResult Index()
        {
            var danhSachMuaHang = GetDanhSachMuaHang();
            return View(danhSachMuaHang);
        }

        private List<MuaHang> GetDanhSachMuaHang()
        {
            // Logic để lấy danh sách mua hàng từ nguồn dữ liệu
            // Nếu có lỗi ở đây, hãy kiểm tra xem đã trả về danh sách hợp lệ chưa
            return new List<MuaHang>
            {
                new MuaHang { Id = 1, TenSanPham = "Sản phẩm 1", SoLuong = 2, DonGia = 100 },
                new MuaHang { Id = 2, TenSanPham = "Sản phẩm 2", SoLuong = 1, DonGia = 150 },
                new MuaHang { Id = 3, TenSanPham = "Sản phẩm 3", SoLuong = 3, DonGia = 200 }
                // Thêm các mua hàng khác nếu cần
            };
        }
    }
}
