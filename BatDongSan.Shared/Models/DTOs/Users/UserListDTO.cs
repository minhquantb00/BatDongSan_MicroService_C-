using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Users
{
    public class UserListDTO
    {
        public IEnumerable<UserDTO> Users { get; set; }

    }
}
