using BatDongSan.Shared.Models.Entities.ContractsEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Contracts
{
    public class KhachHangOrderDTO
    {
        public int? KhachHangId { get; set; }
        public List<HopDong> HopDongs { get; set; } = new List<HopDong>();
    }
}
