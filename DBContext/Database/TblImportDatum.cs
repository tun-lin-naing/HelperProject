using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblImportDatum
    {
        public TblImportDatum()
        {
            TblDispositions = new HashSet<TblDisposition>();
        }

        public long PartId { get; set; }
        public long EngId { get; set; }
        public long ModuleId { get; set; }
        public int? EngineType { get; set; }
        public string? LidStatus { get; set; }
        public string? Lid { get; set; }
        public string? NextHigherLid { get; set; }
        public string? LidDescription { get; set; }
        public string? PartRequested { get; set; }
        public string? Disp { get; set; }
        public string? Notif { get; set; }
        public int LidQty { get; set; }
        public string? Pnstatus { get; set; }
        public string? PartIssued { get; set; }
        public int IssuedQty { get; set; }
        public int QtyOn { get; set; }
        public string? PartOn { get; set; }
        public DateTime? DateOn { get; set; }
        public string? StampOn { get; set; }
        public string? FinalInsp { get; set; }
        public string? SwapFlag { get; set; }
        public string? Cxcomments { get; set; }
        public string? Fit { get; set; }
        public string? ResultsRecording { get; set; }
        public string? Bxcomments { get; set; }
        public string? PartOff { get; set; }
        public string? StampOff { get; set; }
        public DateTime? DateOff { get; set; }
        public string? PlannedSb { get; set; }
        public string? PlanPn { get; set; }
        public string? Snon { get; set; }
        public string? ValOn { get; set; }
        public string? Snoff { get; set; }
        public string? ValOff { get; set; }
        public string? DefectType { get; set; }
        public string? DefectCode { get; set; }
        public string? InspectionFindings { get; set; }
        public string? KitRef { get; set; }
        public string? SectCode { get; set; }
        public string? User { get; set; }
        public string? Section { get; set; }

        public virtual TblEngineHeader Eng { get; set; } = null!;
        public virtual TblModuleHeader Module { get; set; } = null!;
        public virtual ICollection<TblDisposition> TblDispositions { get; set; }
    }
}
