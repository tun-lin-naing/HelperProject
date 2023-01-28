using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblRfidmaster
    {
        public long Id { get; set; }
        public string EngineSaleNo { get; set; } = null!;
        public string Module { get; set; } = null!;
        public string PartNo { get; set; } = null!;
        public string PartDesc { get; set; } = null!;
        public string PartStatus { get; set; } = null!;
        public string Rfid { get; set; } = null!;
        public int Lidqty { get; set; }
        public int? IssueQty { get; set; }
        public string? Remark { get; set; }
        public string Location { get; set; } = null!;
        public string ProcessStatus { get; set; } = null!;
        public long? KcmasterId { get; set; }
        public bool? NeedFinalInsp { get; set; }
        public bool? IsModuleSpare { get; set; }
        public bool? IsServiceable { get; set; }
        public bool? IsLoosePart { get; set; }
        public DateTime? LabelPrintedDate { get; set; }
        public string? LabelPrintedBy { get; set; }
        public DateTime? LcreceivedDate { get; set; }
        public DateTime? LcissuedDate { get; set; }
        public string? LcissuedBy { get; set; }
        public DateTime? LcdepartedDate { get; set; }
        public DateTime? BsdepositedDate { get; set; }
        public string? BsdepositedBy { get; set; }
        public DateTime? BsretrievedDate { get; set; }
        public string? BsretrievedBy { get; set; }
        public DateTime? G2modulePartLoadingDate { get; set; }
        public string? G2modulePartLoadedBy { get; set; }
        public DateTime? G2lpartDepositedDate { get; set; }
        public string? G2lpartDepositedBy { get; set; }
        public DateTime? G2lpartRetrievedDate { get; set; }
        public string? G2lpartRetrievedBy { get; set; }
        public DateTime? G2tgdepositedDate { get; set; }
        public string? G2tgdepositedBy { get; set; }
        public DateTime? G2tgretrievedDate { get; set; }
        public string? G2tgretrievedBy { get; set; }
        public DateTime? G3receivedDate { get; set; }
        public string? G3receivedBy { get; set; }
    }
}
