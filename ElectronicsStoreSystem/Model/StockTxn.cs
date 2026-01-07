using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class StockTxn
{
    public long StockTxnId { get; set; }

    public int StoreId { get; set; }

    public string TxnType { get; set; } = null!;

    public string? RefType { get; set; }

    public long? RefId { get; set; }

    public DateTime TxnDate { get; set; }

    public int CreatedBy { get; set; }

    public string? Note { get; set; }

    public virtual Employee CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<StockTxnLine> StockTxnLines { get; set; } = new List<StockTxnLine>();

    public virtual Store Store { get; set; } = null!;
}
