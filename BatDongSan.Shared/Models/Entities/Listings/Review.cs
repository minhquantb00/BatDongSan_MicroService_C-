using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class Review : BaseEntity
    {
        public string TieuDeReview { get; set; }
        public string NoiDung { get; set; }
        public string DanhGiaXepHang { get; set; }
        public DateTime ThoiGianDang { get; set; }
        public int DanhSachId { get; set; }
        public DanhSach DanhSach { get; set; }

    }
}
