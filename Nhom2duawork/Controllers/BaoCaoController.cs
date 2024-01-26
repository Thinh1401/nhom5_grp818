// Controllers/BaoCaoController.cs
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Nhom2duawork.Models;
using Nhom2duawork.Models;

namespace Nhom2duawork.Controllers
{
    public class BaoCaoController : Controller
    {
        public IActionResult DanhThu()
        {
            var danhSachBaoCaoDanhThu = GetDanhSachBaoCaoDanhThu();
            return View(danhSachBaoCaoDanhThu);
        }

        private List<BaoCaoDanhThu> GetDanhSachBaoCaoDanhThu()
        {
            // Logic để lấy danh sách báo cáo danh thu từ nguồn dữ liệu
            // Nếu có lỗi ở đây, hãy kiểm tra xem đã trả về danh sách hợp lệ chưa
            return new List<BaoCaoDanhThu>
            {
                new BaoCaoDanhThu { Id = 1, ThoiGian = DateTime.Now, DoanhThu = 1500 },
                new BaoCaoDanhThu { Id = 2, ThoiGian = DateTime.Now, DoanhThu = 2000 },
                new BaoCaoDanhThu { Id = 3, ThoiGian = DateTime.Now, DoanhThu = 2500 }
                // Thêm các báo cáo danh thu khác nếu cần
            };
        }
    }
}
