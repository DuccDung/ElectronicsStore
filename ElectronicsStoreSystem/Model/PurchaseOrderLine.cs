using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class PurchaseOrderLine
{
    public long PolineId { get; set; }

    public long Poid { get; set; }

    public int SkuId { get; set; }

    public decimal QtyOrdered { get; set; }

    public decimal QtyReceived { get; set; }

    public decimal UnitCost { get; set; }

    public decimal DiscountAmt { get; set; }

    public decimal TaxRate { get; set; }

    public decimal? LineAmount { get; set; }

    public virtual PurchaseOrder Po { get; set; } = null!;

    public virtual ProductSku Sku { get; set; } = null!;
}
