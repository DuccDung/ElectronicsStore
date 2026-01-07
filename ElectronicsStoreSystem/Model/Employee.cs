using System;
using System.Collections.Generic;

namespace ElectronicsStoreSystem.Model;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int StoreId { get; set; }

    public int RoleId { get; set; }

    public string EmployeeCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? AddressLine { get; set; }

    public DateOnly? HireDate { get; set; }

    public decimal? BaseSalary { get; set; }

    public string Username { get; set; } = null!;

    public byte[] PasswordHash { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<SalesOrder> SalesOrderCreatedByNavigations { get; set; } = new List<SalesOrder>();

    public virtual ICollection<SalesOrder> SalesOrderSoldByNavigations { get; set; } = new List<SalesOrder>();

    public virtual ICollection<StockTransfer> StockTransfers { get; set; } = new List<StockTransfer>();

    public virtual ICollection<StockTxn> StockTxns { get; set; } = new List<StockTxn>();

    public virtual Store Store { get; set; } = null!;
}
