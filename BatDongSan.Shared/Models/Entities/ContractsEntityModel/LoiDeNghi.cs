using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using BatDongSan.Shared.Models.Entities.ClientsEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.ContractsEntityModel
{
    public class LoiDeNghi : BaseEntity
    {
        public string TieuDe { get; set; }
        public string MoTa { get; set; }
        public string NoiDung { get; set; }
        public bool IsPublic { get; set; }
        public bool DaHoanTat { get; set; }
        [ForeignKey("KhachHangId")]
        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }
        public int NhanVienId { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int GiaoDichId { get; set; }
    }
}
