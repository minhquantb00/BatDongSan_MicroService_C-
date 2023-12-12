using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Users
{
    public class UserGroupMemberShip
    {
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
