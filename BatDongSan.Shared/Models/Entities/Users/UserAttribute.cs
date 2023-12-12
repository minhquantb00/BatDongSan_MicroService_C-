using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Users
{
    public class UserAttribute
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
