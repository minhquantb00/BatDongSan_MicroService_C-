using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.ClientsEntityModel
{
    public class KhachHang : BaseEntity
    {
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string NguoiLienHe { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public LienHe LienHe { get; set; }

    }
}
