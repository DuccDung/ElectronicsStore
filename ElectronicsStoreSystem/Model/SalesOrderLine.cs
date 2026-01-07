using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class SalesOrderLine
{
    public long SolineId { get; set; }

    public long Soid { get; set; }

    public int SkuId { get; set; }

    public decimal Qty { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal DiscountAmt { get; set; }

    public decimal TaxRate { get; set; }

    public string? SerialNo { get; set; }

    public decimal? LineAmount { get; set; }

    public virtual ProductSku Sku { get; set; } = null!;

    public virtual SalesOrder So { get; set; } = null!;
}
