using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblModuleHeader
    {
        public TblModuleHeader()
        {
            TblImportData = new HashSet<TblImportDatum>();
            TblTcartLoadingHeaders = new HashSet<TblTcartLoadingHeader>();
        }

        public long ModuleId { get; set; }
        public long EngId { get; set; }
        public string? Module { get; set; }
        public int TotalPartQty { get; set; }
        public int TotalLidqty { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual TblEngineHeader Eng { get; set; } = null!;
        public virtual ICollection<TblImportDatum> TblImportData { get; set; }
        public virtual ICollection<TblTcartLoadingHeader> TblTcartLoadingHeaders { get; set; }
    }
}
