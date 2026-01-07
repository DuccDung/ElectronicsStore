using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class VwSalesByDay
{
    public int StoreId { get; set; }

    public string StoreName { get; set; } = null!;

    public DateOnly? SalesDate { get; set; }

    public int? OrdersCount { get; set; }

    public decimal? Revenue { get; set; }
}
