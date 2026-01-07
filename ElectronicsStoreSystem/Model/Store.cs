using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class Store
{
    public int StoreId { get; set; }

    public string StoreCode { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public string? AddressLine { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<StockBalance> StockBalances { get; set; } = new List<StockBalance>();

    public virtual ICollection<StockTransfer> StockTransferFromStores { get; set; } = new List<StockTransfer>();

    public virtual ICollection<StockTransfer> StockTransferToStores { get; set; } = new List<StockTransfer>();

    public virtual ICollection<StockTxn> StockTxns { get; set; } = new List<StockTxn>();
}
