using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Roles
{
    public class QuyenNhanVienDTO
    {
        public int? NhanVienId { get; set; }
        public string? Name { get; set; }
        public string[]? RoleName { get; set; }
    }
}
