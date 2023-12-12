using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using BatDongSan.Shared.Models.Entities.ClientsEntityModel;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.ContractsEntityModel
{
    public class HopDong : BaseEntity
    {
        [ForeignKey("KhachHangId")]
        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }
        public string NhanVienId { get; set; }
        public int LoaiHopDongId { get; set; }
        public string ChiTietHopDong { get; set; }
        public int PhuongThucThanhToanId { get; set; }
        public int SoLuongHoaDon { get; set; }
        public decimal SoTienThanhToan { get; set; }
        public decimal PhanTramChiPhi { get; set; }
        public decimal SoTienPhi { get; set; }
        public DateTime NgayKy { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int GiaoDichId { get; set; }
    }
}
