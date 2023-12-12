using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using BatDongSan.Shared.Models.Entities.Estates;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Listings
{
    public class DanhSach : BaseEntity
    {
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public int BatDongSanId { get; set; }
        public BatDongSan.Shared.Models.Entities.Estates.BatDongSan BatDongSan { get; set; }
        public decimal Gia { get; set; }
        public decimal GiaMoiMetVuong { get; set; }
        public bool LaTuMotThuongHieu { get; set; }
        public string LinkAnh { get; set; }
        public List<BinhLuan> BinhLuans { get; set; }
        public bool IsPublic { get; set; }
        public DateTime ThoiGianXayDung { get; set; }
        public LoaiBatDongSan LoaiBatDongSan { get; set; }
        public int DanhMucId { get; set; }
        public DanhMuc DanhMuc { get; set; }
        public DiaChi DiaChi { get; set; }
        public ThongKeDanhSach ThongKeDanhSach { get; set; }
        public int NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
        public int DaiLyId { get; set; }
        public DaiLy DaiLy { get; set; }
        public LichSuGia LichSuGia { get; set; }

        [NotMapped]
        public List<LichSuGia> LichSuGias { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
