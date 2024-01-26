// File BaoGia.cs
using System;

namespace Nhom2duawork.Models
{
    public class BaoGia
    {
        public int Id { get; set; }
        public DateTime NgayTao { get; set; }
        public string TenKhachHang { get; set; }
        public decimal TongGiaTri { get; set; }
        public int GiaTong { get; internal set; }
        // Các thuộc tính khác của báo giá
    }
}
