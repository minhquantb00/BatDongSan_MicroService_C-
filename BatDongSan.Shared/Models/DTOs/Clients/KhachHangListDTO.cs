using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Clients
{
    public class KhachHangListDTO
    {
        public IEnumerable<KhachHangDTO> KhachHangList { get; set; }
    }
}
