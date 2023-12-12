using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class ThongKeDanhSach
    {
        [Key]
        public int Id { get; set; }
        public int SoLuotXem { get; set; }
        public int SoLuotLuu { get; set; }
        public int SoLuotBinhLuan { get; set; }
        public int SoLuotDanhGia { get; set; }
        public int SoLuotThue { get; set; }
        public int SoLuotBaoCao { get; set; }
        public LichSuGia LichSuGia { get; set; }
    }
}
