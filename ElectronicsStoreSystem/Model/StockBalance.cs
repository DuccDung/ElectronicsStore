using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class StockBalance
{
    public int StoreId { get; set; }

    public int SkuId { get; set; }

    public decimal OnHandQty { get; set; }

    public decimal ReservedQty { get; set; }

    public decimal MinQty { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ProductSku Sku { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
