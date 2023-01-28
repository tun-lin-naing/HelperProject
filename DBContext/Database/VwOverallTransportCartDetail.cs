using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class VwOverallTransportCartDetail
    {
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; } = null!;
        public string EngineSaleNo { get; set; } = null!;
        public string? Module { get; set; }
        public int ProcessQty { get; set; }
        public string? Location { get; set; }
        public string KitCartId { get; set; } = null!;
        public string KitCartRfid { get; set; } = null!;
        public bool IsUsed { get; set; }
        public int KitCartType { get; set; }
    }
}
