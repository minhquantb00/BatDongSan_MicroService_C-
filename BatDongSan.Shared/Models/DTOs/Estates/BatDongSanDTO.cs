using BatDongSan.Shared.Models.Entities.Estates;
using BatDongSan.Shared.Models.Entities.Listings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Estates
{
    public class BatDongSanDTO
    {
        public int Id { get; set; }
        public string TenHopDong { get; set; }
        public int ThanhPhoId { get; set; }
        public ThanhPho ThanhPho { get; set; }
        public int LoaiHopDongId { get; set; } 
        public decimal DienTichSan { get; set; }
        public int SoLuongBanCong { get; set; }
        public decimal DienTichBanCong { get; set; }
        public int SoLuongPhongNgu { get; set; }
        public int SoLuongPhongTam { get; set; }
        public int SoLuongGara { get; set; }
        public int SoChoDauXe { get; set; }
        public bool ChoPhepThuCung { get; set; }
        public string MoTaBatDongSan { get; set; }
        public int TrangThaiBatDongSanId { get; set; }
        public string LinkAnh { get; set; }
        public int NamXayDung { get; set; }
        public DanhSach DanhSach { get; set; }
        public LoaiBatDongSan LoaiBatDongSan { get; set ; }

    }
}
