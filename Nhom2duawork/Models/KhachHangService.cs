// Models/KhachHangService.cs
using System.Collections.Generic;
using System.Linq;

namespace Nhom2duawork.Models
{
    public class KhachHangService
    {
        private List<KhachHang> _khachHangs = new List<KhachHang>();

        public List<KhachHang> GetAllKhachHangs()
        {
            return _khachHangs;
        }

        public KhachHang GetKhachHangById(int id)
        {
            return _khachHangs.FirstOrDefault(kh => kh.Id == id);
        }

        public void AddKhachHang(KhachHang khachHang)
        {
            khachHang.Id = _khachHangs.Count + 1;
            _khachHangs.Add(khachHang);
        }

        public void UpdateKhachHang(KhachHang updatedKhachHang)
        {
            KhachHang existingKhachHang = _khachHangs.FirstOrDefault(kh => kh.Id == updatedKhachHang.Id);
            if (existingKhachHang != null)
            {
                existingKhachHang.TenKhachHang = updatedKhachHang.TenKhachHang;
                existingKhachHang.DiaChi = updatedKhachHang.DiaChi;
            }
        }

        public void DeleteKhachHang(int id)
        {
            KhachHang khachHangToDelete = _khachHangs.FirstOrDefault(kh => kh.Id == id);
            if (khachHangToDelete != null)
            {
                _khachHangs.Remove(khachHangToDelete);
            }
        }
    }
}

