using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class StockTxnLine
{
    public long StockTxnLineId { get; set; }

    public long StockTxnId { get; set; }

    public int SkuId { get; set; }

    public decimal Qty { get; set; }

    public decimal? UnitCost { get; set; }

    public string? SerialNo { get; set; }

    public virtual ProductSku Sku { get; set; } = null!;

    public virtual StockTxn StockTxn { get; set; } = null!;
}
