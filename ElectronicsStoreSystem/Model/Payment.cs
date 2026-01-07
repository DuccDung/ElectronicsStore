using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class Payment
{
    public long PaymentId { get; set; }

    public long? Soid { get; set; }

    public long? Poid { get; set; }

    public int MethodId { get; set; }

    public decimal Amount { get; set; }

    public DateTime PaidAt { get; set; }

    public string? RefNo { get; set; }

    public int CreatedBy { get; set; }

    public string? Note { get; set; }

    public virtual Employee CreatedByNavigation { get; set; } = null!;

    public virtual PaymentMethod Method { get; set; } = null!;

    public virtual PurchaseOrder? Po { get; set; }

    public virtual SalesOrder? So { get; set; }
}
