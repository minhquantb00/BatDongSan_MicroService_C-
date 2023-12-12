using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Estates
{
    public class BatDongSan : BaseEntity
    {
        public string TenBatDongSan { get; set; }
        public int ThanhPhoId { get; set; }
        public ThanhPho ThanhPho { get; set; }
        public int LoaiBatDongSanId { get; set; }
        public decimal DienTichSan { get; set; }
        public int SoLuongBanCong { get; set; }
        public decimal DienTichBanCong { get; set; }
        public int SoLuongPhongNgu { get; set; }
        public int SoPhongTam { get; set; }
        public int SoLuongGara { get; set; }
        public int SoChoDauXe { get; set; }
        public bool ChoPhepNuoiThuCung { get; set; }
        public string MoTaBatDongSan { get;set; }
        public string TrangThaiBatDongSanId { get; set; }
        public string AnhBatDongSan { get; set; }
        public int NamXayDung { get; set; }
        public string VatLieuXayDung { get; set; }
        public bool DangTrenSan { get; set; }
        public int? SoTangToaNha { get; set; }
        public int DanhSachId { get; set; }
        public LoaiBatDongSan LoaiBatDongSan { get; set; }
    }
}
