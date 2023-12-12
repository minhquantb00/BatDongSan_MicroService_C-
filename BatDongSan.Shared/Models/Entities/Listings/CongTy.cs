using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using BatDongSan.Shared.Models.Entities.Estates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class CongTy : BaseEntity
    {
        public CongTy() : base()
        {
            BatDongSans = new List<BatDongSan.Shared.Models.Entities.Estates.BatDongSan>();
            DanhSaches = new List<DanhSach>();
            NhanViens = new List<NhanVien>();

        }
        public string TenCongTy { get; set; }
        public string MoTaCongTy { get; set; }
        public int SoNhanVien { get; set; }
        public IEnumerable<NhanVien> NhanViens { get; init; }
        public IEnumerable<DanhSach> DanhSaches { get; set; }
        public IEnumerable<BatDongSan.Shared.Models.Entities.Estates.BatDongSan> BatDongSans { get; set; }
    }
}
