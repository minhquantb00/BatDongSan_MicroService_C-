using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Estates
{
    public class ThanhPho : BaseEntity
    {
        public string TenThanhPho { get; set; }
        public int QuocGiaId { get; set; }
        public QuocGia QuocGia { get; set; }
        public IEnumerable<BatDongSan> BatDongSans { get; set; }
    }
}
