using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblPrintJob
    {
        public int Id { get; set; }
        public string? EngineSaleNo { get; set; }
        public string? Module { get; set; }
        public string? PartNo { get; set; }
        public string? PartDesc { get; set; }
        public string? PartStatus { get; set; }
        public string? Rfid { get; set; }
        public int? PartQty { get; set; }
    }
}
