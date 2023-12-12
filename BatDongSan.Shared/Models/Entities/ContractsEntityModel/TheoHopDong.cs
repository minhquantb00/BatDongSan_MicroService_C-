using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.ContractsEntityModel
{
    public class TheoHopDong : BaseEntity
    {
        public int BatDongSanId { get; set; }
        public int HopDongId { get;set; }
    }
}
