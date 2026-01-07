using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class StockTransferLine
{
    public long TransferLineId { get; set; }

    public long TransferId { get; set; }

    public int SkuId { get; set; }

    public decimal Qty { get; set; }

    public virtual ProductSku Sku { get; set; } = null!;

    public virtual StockTransfer Transfer { get; set; } = null!;
}
