using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblEngineHeader
    {
        public TblEngineHeader()
        {
            TblImportData = new HashSet<TblImportDatum>();
            TblModuleHeaders = new HashSet<TblModuleHeader>();
        }

        public long EngId { get; set; }
        public string EngineSaleNo { get; set; } = null!;
        public DateTime InductionDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<TblImportDatum> TblImportData { get; set; }
        public virtual ICollection<TblModuleHeader> TblModuleHeaders { get; set; }
    }
}
