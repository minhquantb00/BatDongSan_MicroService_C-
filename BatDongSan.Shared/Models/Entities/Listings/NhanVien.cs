using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using BatDongSan.Shared.Models.Entities.Estates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class NhanVien : BaseEntity
    {
        public NhanVien() : base()
        {
            DanhSaches = new List<DanhSach>();
            BatDongSans = new List<BatDongSan.Shared.Models.Entities.Estates.BatDongSan>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CongTy CongTy { get; set; }
        public IEnumerable<DanhSach> DanhSaches { get; set; }
        public IEnumerable<BatDongSan.Shared.Models.Entities.Estates.BatDongSan> BatDongSans { get; set; }
    }
}
