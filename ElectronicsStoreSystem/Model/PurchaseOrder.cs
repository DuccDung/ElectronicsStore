using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class PurchaseOrder
{
    public long Poid { get; set; }

    public int StoreId { get; set; }

    public int SupplierId { get; set; }

    public string Pocode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime? ExpectedDate { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public decimal Subtotal { get; set; }

    public decimal DiscountAmt { get; set; }

    public decimal TaxAmt { get; set; }

    public decimal? TotalAmt { get; set; }

    public string? Note { get; set; }

    public int CreatedBy { get; set; }

    public virtual Employee CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual Store Store { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
