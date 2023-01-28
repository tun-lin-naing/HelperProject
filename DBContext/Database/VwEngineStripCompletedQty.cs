using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class VwEngineStripCompletedQty
    {
        public string EngineSaleNo { get; set; } = null!;
        public string? Module { get; set; }
        public int TotalPartQty { get; set; }
        public int? ProcessQty { get; set; }
    }
}
