using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblTransactionHeader
    {
        public TblTransactionHeader()
        {
            TblTransactionDetails = new HashSet<TblTransactionDetail>();
        }

        public long TransId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionBy { get; set; } = null!;
        public string? Location { get; set; }
        public string TransactionType { get; set; } = null!;
        public string EngineSaleNo { get; set; } = null!;
        public string Module { get; set; } = null!;
        public int Qty { get; set; }
        public string? KitCartId { get; set; }
        public string? KitCartRfid { get; set; }
        public string? ToEngine { get; set; }
        public string? ToKitCartId { get; set; }
        public string? ToKitCartRfid { get; set; }

        public virtual ICollection<TblTransactionDetail> TblTransactionDetails { get; set; }
    }
}
