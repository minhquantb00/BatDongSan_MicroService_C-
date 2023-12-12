using BatDongSan.Shared.Models.Entities.ClientsEntityModel;
using BatDongSan.Shared.Models.Entities.Estates;
using BatDongSan.Shared.Models.Entities.Listings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Search
{
    public class SearchDTO
    {
        public string? SearchQuery { get; set; }
        public IEnumerable<KhachHang> KhachHangs { get; set; }
        public IEnumerable<NhanVien> NhanViens { get; set; }
        public IEnumerable<BatDongSan.Shared.Models.Entities.Estates.BatDongSan> BatDongSans { get; set; }
    }
}
