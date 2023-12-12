using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.ContractsEntityModel
{
    public class LoaiHopDong : BaseEntity
    {
        public string TenLoaiHopDong { get; set; }
        public decimal PhanTramChiPhi { get; set; }
    }
}
