using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class VwInventoryOnHand
{
    public int StoreId { get; set; }

    public string StoreName { get; set; } = null!;

    public int SkuId { get; set; }

    public string Skucode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal OnHandQty { get; set; }

    public decimal ReservedQty { get; set; }

    public decimal? AvailableQty { get; set; }

    public decimal MinQty { get; set; }

    public DateTime UpdatedAt { get; set; }
}
