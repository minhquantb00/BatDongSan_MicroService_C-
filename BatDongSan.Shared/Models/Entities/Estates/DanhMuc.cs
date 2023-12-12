using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Estates
{
    public class DanhMuc : BaseEntity
    {
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }
        public IEnumerable<BatDongSan> BatDongSans { get; init; } = new List<BatDongSan>();
        public int BatDongSanId { get; set; }
        public BatDongSan BatDongSan { get; set; }
    }
}
