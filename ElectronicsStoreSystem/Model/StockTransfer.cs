using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class StockTransfer
{
    public long TransferId { get; set; }

    public int FromStoreId { get; set; }

    public int ToStoreId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? ShippedAt { get; set; }

    public DateTime? ReceivedAt { get; set; }

    public int CreatedBy { get; set; }

    public string? Note { get; set; }

    public virtual Employee CreatedByNavigation { get; set; } = null!;

    public virtual Store FromStore { get; set; } = null!;

    public virtual ICollection<StockTransferLine> StockTransferLines { get; set; } = new List<StockTransferLine>();

    public virtual Store ToStore { get; set; } = null!;
}
