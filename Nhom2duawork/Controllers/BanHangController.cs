// File BanHangController.cs
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Nhom2duawork.Models;

namespace Nhom2duawork.Controllers
{
    public class BanHangController : Controller
    {
        // Action để hiển thị danh sách đơn hàng
        public IActionResult Index()
        {
            var danhSachBanHang = GetDanhSachBanHang();
            return View(danhSachBanHang);
        }

        // Helper method để lấy danh sách đơn hàng (giả định)
        private List<BanHang> GetDanhSachBanHang()
        {
            // Giả sử có một danh sách đơn hàng mẫu để trả về
            var danhSachBanHang = new List<BanHang>
            {
                new BanHang { Id = 1, NgayDatHang = DateTime.Now, TenKhachHang = "Khách hàng 1", TongTien = 500 },
                new BanHang { Id = 2, NgayDatHang = DateTime.Now, TenKhachHang = "Khách hàng 2", TongTien = 750 },
                new BanHang { Id = 3, NgayDatHang = DateTime.Now, TenKhachHang = "Khách hàng 3", TongTien = 1000 }
                // Thêm các đơn hàng khác nếu cần
            };

            return danhSachBanHang;
        }
    }
}
