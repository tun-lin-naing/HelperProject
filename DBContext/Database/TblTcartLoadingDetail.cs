using System;
using System.Collections.Generic;

namespace DBContext.Database
{
    public partial class TblTcartLoadingDetail
    {
        public long Id { get; set; }
        public long? HeaderId { get; set; }
        public string? Rfid { get; set; }

        public virtual TblTcartLoadingHeader? Header { get; set; }
    }
}
