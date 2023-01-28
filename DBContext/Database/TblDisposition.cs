using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblDisposition
    {
        public long Id { get; set; }
        public long? HeaderId { get; set; }
        public string? Lidstatus { get; set; }
        public string? PartStatus { get; set; }
        public int? IssueQty { get; set; }
        public int? TotalIssueQty { get; set; }
        public DateTime? DispDate { get; set; }
        public bool? NeedFinalInsp { get; set; }
        public DateTime? FinalInspDate { get; set; }

        public virtual TblImportDatum? Header { get; set; }
    }
}
