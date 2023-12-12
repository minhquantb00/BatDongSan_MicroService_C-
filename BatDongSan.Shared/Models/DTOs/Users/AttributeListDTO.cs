using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Users
{
    public class AttributeListDTO
    {
        public List<BatDongSan.Shared.Models.DTOs.Users.AtrributeDTO> attributeDTOs { get; set; }
        public AttributeListDTO(List<AtrributeDTO> attributeDTOs)
        {
            this.attributeDTOs = attributeDTOs;
        }
    }
}
