using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string? FullName { get; set; }
        public string Password { get; set; } = null!;
        public string? PassId { get; set; }
        public int RoleId { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual TblUserRole Role { get; set; } = null!;
    }
}
