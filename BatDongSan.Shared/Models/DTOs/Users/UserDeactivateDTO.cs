using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.DTOs.Users
{
    public class UserDeactivateDTO
    {
        public Guid SubjectId { get; set; }
        public string Username { get; set; }
        public string IsActive { get; set; }
    }
}
