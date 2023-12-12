using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class DiaChi : BaseEntity
    {
        public string ThanhPho { get; set; }
        public string HangXom { get; set; }
        public string DuongPho { get; set; }
        public int? MaBuuChinh { get; set; }
        public string ToaDo { get; set; }
    }
}
