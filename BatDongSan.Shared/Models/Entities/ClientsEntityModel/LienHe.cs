using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.ClientsEntityModel
{
    public class LienHe : BaseEntity
    {
        public int NguoiDungUngDungId { get; init; }
        public int NhanVienId { get; set; }
        public int BatDongSanId { get; set; }
        public string ChiTietLienHe { get; set; }
        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set;}
    }
}
