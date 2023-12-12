using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class LichSuGia
    {
        public int Id { get; set; }

        [NotMapped]
        public Dictionary<DateTime, double> DuLieuLichSuGia { get; set; }

        [NotMapped]
        public Dictionary<DateTime, double> DuLieuLichSuThue { get; set; }

        [NotMapped]
        public Dictionary<DateTime, int> DuLieuLichSuDeNghi { get; set; }

        [NotMapped]
        public Dictionary<DateTime, int> DuLieuLichSuTimKiem { get; set; }

        [NotMapped]
        public Dictionary<DateTime, int> DuLieuLichSuLuotXem { get; set; }

        [ForeignKey(nameof(DanhSachId))]
        public DanhSach DanhSach { get; set; }
        public int DanhSachId { get; set; }
    }
}
