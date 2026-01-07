using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class ProductSku
{
    public int SkuId { get; set; }

    public int ProductId { get; set; }

    public int UnitId { get; set; }

    public string Skucode { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? Model { get; set; }

    public string? Color { get; set; }

    public string? SpecJson { get; set; }

    public decimal Vatrate { get; set; }

    public decimal CostPrice { get; set; }

    public decimal SalePrice { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<SalesOrderLine> SalesOrderLines { get; set; } = new List<SalesOrderLine>();

    public virtual ICollection<StockBalance> StockBalances { get; set; } = new List<StockBalance>();

    public virtual ICollection<StockTransferLine> StockTransferLines { get; set; } = new List<StockTransferLine>();

    public virtual ICollection<StockTxnLine> StockTxnLines { get; set; } = new List<StockTxnLine>();

    public virtual Unit Unit { get; set; } = null!;
}
