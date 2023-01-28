using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblTempTransactionType
    {
        public long Id { get; set; }
        public string? Location { get; set; }
        public string? TransactionType { get; set; }
    }
}
