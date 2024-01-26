// File BanHang.cs
using System;

namespace Nhom2duawork.Models
{
    public class BanHang
    {
        public int Id { get; set; }
        public DateTime NgayDatHang { get; set; }
        public string TenKhachHang { get; set; }
        public decimal TongTien { get; set; }

        // Các thuộc tính và phương thức khác của đơn hàng

        public BanHang()
        {
            // Hàm tạo mặc định
        }

        public BanHang(int id, DateTime ngayDatHang, string tenKhachHang, decimal tongTien)
        {
            Id = id;
            NgayDatHang = ngayDatHang;
            TenKhachHang = tenKhachHang;
            TongTien = tongTien;

            // Khởi tạo các thuộc tính khác nếu cần
        }
    }
}
