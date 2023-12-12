using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Errors
{
    public class ErrorDTO
    {
        public int? RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId.ToString());
    }
}
