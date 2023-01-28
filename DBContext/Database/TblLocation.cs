using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblLocation
    {
        public int Id { get; set; }
        public string Location { get; set; } = null!;
    }
}
