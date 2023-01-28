using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblMenu
    {
        public TblMenu()
        {
            TblMenuAccessRightPermissions = new HashSet<TblMenuAccessRightPermission>();
        }

        public int MenuId { get; set; }
        public string MenuName { get; set; } = null!;
        public string MenuTitle { get; set; } = null!;
        public int? ParentId { get; set; }
        public string? Controller { get; set; }
        public string? Page { get; set; }
        public int MenuType { get; set; }
        public bool IncludeCreate { get; set; }
        public bool IncludeUpdate { get; set; }
        public bool IncludeDelete { get; set; }

        public virtual ICollection<TblMenuAccessRightPermission> TblMenuAccessRightPermissions { get; set; }
    }
}
