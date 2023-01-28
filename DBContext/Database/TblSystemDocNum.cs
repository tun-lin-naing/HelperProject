using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblSystemDocNum
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = null!;
        public int LastNum { get; set; }
    }
}
