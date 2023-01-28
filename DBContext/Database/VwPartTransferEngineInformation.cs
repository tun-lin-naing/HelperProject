using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class VwPartTransferEngineInformation
    {
        public string EngineSaleNo { get; set; } = null!;
        public string Module { get; set; } = null!;
        public int? ProcessQty { get; set; }
        public int? TotalLidqty { get; set; }
        public DateTime? InductionDate { get; set; }
    }
}
