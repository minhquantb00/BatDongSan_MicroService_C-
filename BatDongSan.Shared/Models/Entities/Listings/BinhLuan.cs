using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class BinhLuan : BaseEntity
    {
        public string NoiDungBinhLuan { get; set; }
        public string DanhGiaBinhLuan { get; set; }
        public DateTime NgayDang { get; set; }
        public DanhSach DanhSach { get; set; }
    }
}
