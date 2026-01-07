using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class VwTopSellingSku
{
    public int StoreId { get; set; }

    public string StoreName { get; set; } = null!;

    public int SkuId { get; set; }

    public string Skucode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal? QtySold { get; set; }

    public decimal? AmountSold { get; set; }
}
