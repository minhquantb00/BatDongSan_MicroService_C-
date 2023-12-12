using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Users
{
    public class UsernameLoginFailure
    {
        public int RealmId { get; set; }
        public string Username { get; set; }
        public int? FailedLoginNotBefore { get; set; }
        public long?  LastFailure { get; set; }
        public string LastIpFailure { get; set; }
        public int? NumFailures { get; set; }
    }
}
