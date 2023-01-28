using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblTransferHistory
    {
        public long Id { get; set; }
        public string FromEngineNo { get; set; } = null!;
        public string ToEngineNo { get; set; } = null!;
        public string Module { get; set; } = null!;
        public string PartNo { get; set; } = null!;
        public string? PartDescription { get; set; }
        public string? PartRfid { get; set; }
        public int Qty { get; set; }
        public string KitCartId { get; set; } = null!;
        public string KitCartRfid { get; set; } = null!;
        public string? ToKitCartId { get; set; }
        public string? ToKitCartRfid { get; set; }
        public string TransferBy { get; set; } = null!;
        public DateTime TransferDate { get; set; }
    }
}
