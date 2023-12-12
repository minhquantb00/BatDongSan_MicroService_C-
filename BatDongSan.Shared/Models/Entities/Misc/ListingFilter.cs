using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Misc
{
    public class ListingFilter
    {
        public string Id { get; set; }
        public string Ten { get; set; }
        public int BatDongSanId { get; set; }
        public decimal? GiaThanh { get; set; }
        public string TieuDe { get; set; }
        public string MoTa { get; set; }
        public string LinkAnh { get; set; }
        public int? Nam { get; set; }
        public DateTime? ThoiGianXayDung { get; set; }
        public int? LoaiBatDongSanId { get; set; }
        public int? DanhMucId { get; set; }
        public int? NhanVienId { get; set; }

        public int? DienTichToiThieu { get; set; }
        public int? DienTichToiDa { get; set; }
        public int? GiaToiThieu { get; set; }
        public int? GiaToiDa { get; set; }
        public int? GiaToiThieuTrenMoiMetVuong { get; set; }
        public int? GiaToiDaTrenMoiMetVuong { get; set; }
    }
}
