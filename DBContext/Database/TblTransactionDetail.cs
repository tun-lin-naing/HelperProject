using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblTransactionDetail
    {
        public long TransDetailId { get; set; }
        public long HeaderId { get; set; }
        public string PartNo { get; set; } = null!;
        public string PartDesc { get; set; } = null!;
        public string? PartRfid { get; set; }
        public int? PartQty { get; set; }
        public string? Remark { get; set; }
        public string? PartStatus { get; set; }

        public virtual TblTransactionHeader Header { get; set; } = null!;
    }
}
