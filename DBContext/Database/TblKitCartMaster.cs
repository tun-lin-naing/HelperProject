using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblKitCartMaster
    {
        public TblKitCartMaster()
        {
            TblTcartLoadingHeaders = new HashSet<TblTcartLoadingHeader>();
        }

        public long KcmasterId { get; set; }
        public string KitCartId { get; set; } = null!;
        public string KitCartRfid { get; set; } = null!;
        public int KitCartType { get; set; }
        public string? Module { get; set; }
        public string? UwbMac { get; set; }
        public bool? IsUsed { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<TblTcartLoadingHeader> TblTcartLoadingHeaders { get; set; }
    }
}
