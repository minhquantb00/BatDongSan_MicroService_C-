﻿using AutoMapper;
using BatDongSan.Shared.Models.Entities.ClientsEntityModel;
using BatDongSan.Shared.Models.Entities.ContractsEntityModel;
using BatDongSan.Shared.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Clients
{
    public class KhachHangDTO : IMapFrom<KhachHang>, IHasCustomMapping
    {
        public int Id { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string NguoiLienHe { get; set; }
        public string SoDienThoai { get; set; }

        public string Email { get; set; }
        public string ChiTietKhachHang { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public LienHe LienHe { get; set; }
        public IEnumerable<HopDong> HopDongs { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<KhachHang, KhachHangDTO>();
        }
    }
}
