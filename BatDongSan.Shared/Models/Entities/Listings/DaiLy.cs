using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using BatDongSan.Shared.Models.Entities.ContractsEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class DaiLy : BaseEntity
    {
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiLienHe { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string ChiTietDaiLy { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public IEnumerable<HopDong> HopDongs { get; set; }
        public ThuongHieu ThuongHieu { get; set; }
        public List<DanhSach> DanhSaches { get; set; }
    }
}
