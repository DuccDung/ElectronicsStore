using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class SalesOrder
{
    public long Soid { get; set; }

    public int StoreId { get; set; }

    public int? CustomerId { get; set; }

    public string Socode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime? CompletedAt { get; set; }

    public decimal Subtotal { get; set; }

    public decimal DiscountAmt { get; set; }

    public decimal TaxAmt { get; set; }

    public decimal? TotalAmt { get; set; }

    public string? Note { get; set; }

    public int CreatedBy { get; set; }

    public int SoldBy { get; set; }

    public virtual Employee CreatedByNavigation { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<SalesOrderLine> SalesOrderLines { get; set; } = new List<SalesOrderLine>();

    public virtual Employee SoldByNavigation { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
