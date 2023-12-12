using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class ThuongHieu : BaseEntity
    {
        public string TenThuongHieu { get; set; }
        public string MoTa { get; set; }
        public string LinkAnh { get; set; }
        public string Website { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public List<DanhSach> DanhSaches { get; set; }
        public List<DaiLy> DaiLies { get; set; }
    }
}
