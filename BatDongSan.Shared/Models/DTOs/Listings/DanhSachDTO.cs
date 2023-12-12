using BatDongSan.Shared.Models.Entities.Estates;
using BatDongSan.Shared.Models.Entities.Listings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Listings
{
    public class DanhSachDTO
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string LinkAnh { get; set; }
        public int Nam { get; set; }
        public bool IsPublic { get; set; }
        public DateTime ThoiGianXayDung { get; set; }
        public decimal MetVuong { get; set; }
        public LoaiBatDongSan LoaiBatDongSan { get; set; }
        public int DanhMucId { get; set; }
        public DanhMuc DanhMuc { get; set; }
        public int NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
