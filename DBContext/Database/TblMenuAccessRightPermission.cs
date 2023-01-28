using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblMenuAccessRightPermission
    {
        public long Id { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public bool AllowMenu { get; set; }
        public bool AllowCreate { get; set; }
        public bool AllowUpdate { get; set; }
        public bool AllowDelete { get; set; }

        public virtual TblMenu Menu { get; set; } = null!;
        public virtual TblUserRole Role { get; set; } = null!;
    }
}
