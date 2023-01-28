using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblTcartLoadingHeader
    {
        public TblTcartLoadingHeader()
        {
            TblTcartLoadingDetails = new HashSet<TblTcartLoadingDetail>();
        }

        public long Id { get; set; }
        public long ModuleId { get; set; }
        public long KcmasterId { get; set; }
        public string? Location { get; set; }
        public int ProcessQty { get; set; }
        public bool IsCleaningNecessary { get; set; }
        public string? ProcessStatus { get; set; }
        public string? Remarks { get; set; }
        public string PartLoadedBy { get; set; } = null!;
        public DateTime PartLoadedDate { get; set; }
        public string? ClnreceivedBy { get; set; }
        public DateTime? ClnreceivedDate { get; set; }
        public string? ClncompletedBy { get; set; }
        public DateTime? ClncompletedDate { get; set; }
        public string? Gate1ReceivedBy { get; set; }
        public DateTime? Gate1ReceivedDate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public virtual TblKitCartMaster Kcmaster { get; set; } = null!;
        public virtual TblModuleHeader Module { get; set; } = null!;
        public virtual ICollection<TblTcartLoadingDetail> TblTcartLoadingDetails { get; set; }
    }
}
