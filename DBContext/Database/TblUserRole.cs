using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblUserRole
    {
        public TblUserRole()
        {
            TblMenuAccessRightPermissions = new HashSet<TblMenuAccessRightPermission>();
            TblUsers = new HashSet<TblUser>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<TblMenuAccessRightPermission> TblMenuAccessRightPermissions { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
