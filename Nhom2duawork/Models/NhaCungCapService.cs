// Models/NhaCungCapService.cs

using System.Collections.Generic;
using System.Linq;

namespace Nhom2duawork.Models
{
    public class NhaCungCapService
    {
        private List<NhaCungCap> _nhaCungCaps = new List<NhaCungCap>();

        public List<NhaCungCap> GetAllNhaCungCaps()
        {
            return _nhaCungCaps;
        }

        public NhaCungCap GetNhaCungCapById(int id)
        {
            return _nhaCungCaps.FirstOrDefault(ncc => ncc.Id == id);
        }

        public void AddNhaCungCap(NhaCungCap nhaCungCap)
        {
            nhaCungCap.Id = _nhaCungCaps.Count + 1;
            _nhaCungCaps.Add(nhaCungCap);
        }

        public void UpdateNhaCungCap(NhaCungCap updatedNhaCungCap)
        {
            NhaCungCap existingNhaCungCap = _nhaCungCaps.FirstOrDefault(ncc => ncc.Id == updatedNhaCungCap.Id);
            if (existingNhaCungCap != null)
            {
                existingNhaCungCap.TenNhaCungCap = updatedNhaCungCap.TenNhaCungCap;
                //Thêm các thuộc tính khác nếu có
            }
        }

        public void DeleteNhaCungCap(int id)
        {
            NhaCungCap nhaCungCapToDelete = _nhaCungCaps.FirstOrDefault(ncc => ncc.Id == id);
            if (nhaCungCapToDelete != null)
            {
                _nhaCungCaps.Remove(nhaCungCapToDelete);
            }
        }
    }
}
