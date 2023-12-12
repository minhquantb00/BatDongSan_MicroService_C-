using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Users
{
    public class UserRoleMapping
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
