using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Users
{
    public class UserEntity : BaseEntity
    {
        public UserEntity()
        {
            UserAttributes = new List<UserAttribute>(); 
            UserGroupMemberShips = new List<UserGroupMemberShip>();
            UserRoleMappings = new List<UserRoleMapping>();
        }
        public string Email { get; set; }
        public string EmailRangBuoc { get; set; }
        public bool EmailDaKichHoat { get; set; }
        public bool Enable { get; set; }
        public string FederationLink { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RealmId { get; set; }
        public string Username { get; set; }
        public long? ThoiGianTao { get; set; }
        public string DichVuLienKetTaiKhoanNganHang { get; set; }
        public int NotBefore { get; set; }

        public virtual ICollection<UserAttribute> UserAttributes { get; set; }
        public virtual ICollection<UserGroupMemberShip> UserGroupMemberShips { get; set; }
        public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; }
    }
}
