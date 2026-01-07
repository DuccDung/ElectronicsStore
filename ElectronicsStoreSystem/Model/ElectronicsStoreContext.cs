using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsStoreSystem.Model;

public partial class ElectronicsStoreContext : DbContext
{
    public ElectronicsStoreContext()
    {
    }

    public ElectronicsStoreContext(DbContextOptions<ElectronicsStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductSku> ProductSkus { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SalesOrder> SalesOrders { get; set; }

    public virtual DbSet<SalesOrderLine> SalesOrderLines { get; set; }

    public virtual DbSet<StockBalance> StockBalances { get; set; }

    public virtual DbSet<StockTransfer> StockTransfers { get; set; }

    public virtual DbSet<StockTransferLine> StockTransferLines { get; set; }

    public virtual DbSet<StockTxn> StockTxns { get; set; }

    public virtual DbSet<StockTxnLine> StockTxnLines { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<VwInventoryOnHand> VwInventoryOnHands { get; set; }

    public virtual DbSet<VwSalesByDay> VwSalesByDays { get; set; }

    public virtual DbSet<VwTopSellingSku> VwTopSellingSkus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("DB_ConnectionString"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__Brand__DAD4F3BEDFC95751");

            entity.ToTable("Brand");

            entity.HasIndex(e => e.BrandName, "UQ__Brand__2206CE9B521BF7CE").IsUnique();

            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.BrandName).HasMaxLength(100);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Category__19093A2B793E3D53");

            entity.ToTable("Category");

            entity.HasIndex(e => new { e.ParentId, e.CategoryName }, "UQ_Category").IsUnique();

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(150);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Category_Parent");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B8645976E2");

            entity.ToTable("Customer");

            entity.HasIndex(e => e.CustomerCode, "UQ__Customer__066785219BCA0375").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.AddressLine).HasMaxLength(300);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.CustomerCode).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(120);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.TaxCode).HasMaxLength(30);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF10417DF98");

            entity.ToTable("Employee");

            entity.HasIndex(e => e.EmployeeCode, "UQ__Employee__1F64254854C98A3C").IsUnique();

            entity.HasIndex(e => e.Username, "UQ__Employee__536C85E48EB7534B").IsUnique();

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.AddressLine).HasMaxLength(300);
            entity.Property(e => e.BaseSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(120);
            entity.Property(e => e.EmployeeCode).HasMaxLength(20);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PasswordHash).HasMaxLength(256);
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.Username).HasMaxLength(60);

            entity.HasOne(d => d.Role).WithMany(p => p.Employees)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Role");

            entity.HasOne(d => d.Store).WithMany(p => p.Employees)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Store");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__9B556A5806E72111");

            entity.ToTable("Payment");

            entity.HasIndex(e => new { e.Poid, e.PaidAt }, "IX_Payment_PO").IsDescending(false, true);

            entity.HasIndex(e => new { e.Soid, e.PaidAt }, "IX_Payment_SO").IsDescending(false, true);

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MethodId).HasColumnName("MethodID");
            entity.Property(e => e.Note).HasMaxLength(300);
            entity.Property(e => e.PaidAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.RefNo).HasMaxLength(80);
            entity.Property(e => e.Soid).HasColumnName("SOID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Employee");

            entity.HasOne(d => d.Method).WithMany(p => p.Payments)
                .HasForeignKey(d => d.MethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Method");

            entity.HasOne(d => d.Po).WithMany(p => p.Payments)
                .HasForeignKey(d => d.Poid)
                .HasConstraintName("FK_Payment_PO");

            entity.HasOne(d => d.So).WithMany(p => p.Payments)
                .HasForeignKey(d => d.Soid)
                .HasConstraintName("FK_Payment_SO");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.MethodId).HasName("PK__PaymentM__FC681FB124CAB930");

            entity.ToTable("PaymentMethod");

            entity.HasIndex(e => e.MethodName, "UQ__PaymentM__218CFB17AB7C2CD0").IsUnique();

            entity.Property(e => e.MethodId).HasColumnName("MethodID");
            entity.Property(e => e.MethodName).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6ED8397E07C");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.WarrantyMonths).HasDefaultValue(12);

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_Product_Brand");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Category");
        });

        modelBuilder.Entity<ProductSku>(entity =>
        {
            entity.HasKey(e => e.SkuId).HasName("PK__ProductS__AED6CBB533A142DD");

            entity.ToTable("ProductSKU");

            entity.HasIndex(e => e.ProductId, "IX_ProductSKU_ProductID");

            entity.HasIndex(e => e.Skucode, "UQ__ProductS__E6769AAD8613D5DA").IsUnique();

            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Skucode)
                .HasMaxLength(30)
                .HasColumnName("SKUCode");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.Vatrate)
                .HasDefaultValue(10.00m)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("VATRate");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSkus)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSKU_Product");

            entity.HasOne(d => d.Unit).WithMany(p => p.ProductSkus)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSKU_Unit");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.Poid).HasName("PK__Purchase__5F02A2F46D4CB723");

            entity.ToTable("PurchaseOrder");

            entity.HasIndex(e => new { e.StoreId, e.OrderDate }, "IX_PO_StoreDate").IsDescending(false, true);

            entity.HasIndex(e => e.Pocode, "UQ__Purchase__40ACF5B8479369B0").IsUnique();

            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExpectedDate).HasPrecision(0);
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.OrderDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Pocode)
                .HasMaxLength(30)
                .HasColumnName("POCode");
            entity.Property(e => e.ReceivedDate).HasPrecision(0);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.TaxAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmt)
                .HasComputedColumnSql("(([Subtotal]-[DiscountAmt])+[TaxAmt])", true)
                .HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PO_Employee");

            entity.HasOne(d => d.Store).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PO_Store");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PO_Supplier");
        });

        modelBuilder.Entity<PurchaseOrderLine>(entity =>
        {
            entity.HasKey(e => e.PolineId).HasName("PK__Purchase__07B9D34252605FCE");

            entity.ToTable("PurchaseOrderLine");

            entity.HasIndex(e => new { e.Poid, e.SkuId }, "UQ_POL").IsUnique();

            entity.Property(e => e.PolineId).HasColumnName("POLineID");
            entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LineAmount)
                .HasComputedColumnSql("([QtyOrdered]*[UnitCost]-[DiscountAmt])", true)
                .HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.QtyOrdered).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.QtyReceived).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.TaxRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Po).WithMany(p => p.PurchaseOrderLines)
                .HasForeignKey(d => d.Poid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POL_PO");

            entity.HasOne(d => d.Sku).WithMany(p => p.PurchaseOrderLines)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POL_SKU");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE3AAF67215F");

            entity.ToTable("Role");

            entity.HasIndex(e => e.RoleName, "UQ__Role__8A2B6160508DFCBE").IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.RoleName).HasMaxLength(100);
        });

        modelBuilder.Entity<SalesOrder>(entity =>
        {
            entity.HasKey(e => e.Soid).HasName("PK__SalesOrd__A7FF33622E882212");

            entity.ToTable("SalesOrder");

            entity.HasIndex(e => new { e.StoreId, e.OrderDate }, "IX_SO_StoreDate").IsDescending(false, true);

            entity.HasIndex(e => e.Socode, "UQ__SalesOrd__27B177430B40D708").IsUnique();

            entity.Property(e => e.Soid).HasColumnName("SOID");
            entity.Property(e => e.CompletedAt).HasPrecision(0);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.OrderDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Socode)
                .HasMaxLength(30)
                .HasColumnName("SOCode");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("NEW");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmt)
                .HasComputedColumnSql("(([Subtotal]-[DiscountAmt])+[TaxAmt])", true)
                .HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SalesOrderCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SO_Created");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesOrders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_SO_Customer");

            entity.HasOne(d => d.SoldByNavigation).WithMany(p => p.SalesOrderSoldByNavigations)
                .HasForeignKey(d => d.SoldBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SO_SoldBy");

            entity.HasOne(d => d.Store).WithMany(p => p.SalesOrders)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SO_Store");
        });

        modelBuilder.Entity<SalesOrderLine>(entity =>
        {
            entity.HasKey(e => e.SolineId).HasName("PK__SalesOrd__599D1435E4F46745");

            entity.ToTable("SalesOrderLine");

            entity.HasIndex(e => e.Soid, "IX_SOL_SO");

            entity.Property(e => e.SolineId).HasColumnName("SOLineID");
            entity.Property(e => e.DiscountAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LineAmount)
                .HasComputedColumnSql("([Qty]*[UnitPrice]-[DiscountAmt])", true)
                .HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.Soid).HasColumnName("SOID");
            entity.Property(e => e.TaxRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Sku).WithMany(p => p.SalesOrderLines)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOL_SKU");

            entity.HasOne(d => d.So).WithMany(p => p.SalesOrderLines)
                .HasForeignKey(d => d.Soid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SOL_SO");
        });

        modelBuilder.Entity<StockBalance>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.SkuId });

            entity.ToTable("StockBalance");

            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.MinQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OnHandQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReservedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Sku).WithMany(p => p.StockBalances)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockBalance_SKU");

            entity.HasOne(d => d.Store).WithMany(p => p.StockBalances)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockBalance_Store");
        });

        modelBuilder.Entity<StockTransfer>(entity =>
        {
            entity.HasKey(e => e.TransferId).HasName("PK__StockTra__9549017176BD4994");

            entity.ToTable("StockTransfer");

            entity.Property(e => e.TransferId).HasColumnName("TransferID");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.FromStoreId).HasColumnName("FromStoreID");
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.ReceivedAt).HasPrecision(0);
            entity.Property(e => e.ShippedAt).HasPrecision(0);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DRAFT");
            entity.Property(e => e.ToStoreId).HasColumnName("ToStoreID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StockTransfers)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfer_Employee");

            entity.HasOne(d => d.FromStore).WithMany(p => p.StockTransferFromStores)
                .HasForeignKey(d => d.FromStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfer_FromStore");

            entity.HasOne(d => d.ToStore).WithMany(p => p.StockTransferToStores)
                .HasForeignKey(d => d.ToStoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfer_ToStore");
        });

        modelBuilder.Entity<StockTransferLine>(entity =>
        {
            entity.HasKey(e => e.TransferLineId).HasName("PK__StockTra__8C4B24CFB7E7A7DF");

            entity.ToTable("StockTransferLine");

            entity.HasIndex(e => new { e.TransferId, e.SkuId }, "UQ_TransferLine").IsUnique();

            entity.Property(e => e.TransferLineId).HasColumnName("TransferLineID");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.TransferId).HasColumnName("TransferID");

            entity.HasOne(d => d.Sku).WithMany(p => p.StockTransferLines)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferLine_SKU");

            entity.HasOne(d => d.Transfer).WithMany(p => p.StockTransferLines)
                .HasForeignKey(d => d.TransferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferLine_Transfer");
        });

        modelBuilder.Entity<StockTxn>(entity =>
        {
            entity.HasKey(e => e.StockTxnId).HasName("PK__StockTxn__DBFF6D98B6D68FDA");

            entity.ToTable("StockTxn");

            entity.HasIndex(e => new { e.StoreId, e.TxnDate }, "IX_StockTxn_StoreDate").IsDescending(false, true);

            entity.Property(e => e.StockTxnId).HasColumnName("StockTxnID");
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.RefId).HasColumnName("RefID");
            entity.Property(e => e.RefType).HasMaxLength(20);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.TxnDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.TxnType).HasMaxLength(20);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StockTxns)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTxn_Employee");

            entity.HasOne(d => d.Store).WithMany(p => p.StockTxns)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTxn_Store");
        });

        modelBuilder.Entity<StockTxnLine>(entity =>
        {
            entity.HasKey(e => e.StockTxnLineId).HasName("PK__StockTxn__0F8C9B4D49A3C879");

            entity.ToTable("StockTxnLine");

            entity.HasIndex(e => e.SkuId, "IX_StockTxnLine_SKU");

            entity.HasIndex(e => e.StockTxnId, "IX_StockTxnLine_Txn");

            entity.Property(e => e.StockTxnLineId).HasColumnName("StockTxnLineID");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SerialNo).HasMaxLength(100);
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.StockTxnId).HasColumnName("StockTxnID");
            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Sku).WithMany(p => p.StockTxnLines)
                .HasForeignKey(d => d.SkuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTxnLine_SKU");

            entity.HasOne(d => d.StockTxn).WithMany(p => p.StockTxnLines)
                .HasForeignKey(d => d.StockTxnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTxnLine_Txn");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK__Store__3B82F0E11DB42B3C");

            entity.ToTable("Store");

            entity.HasIndex(e => e.StoreCode, "UQ__Store__02A384F88F55E6E4").IsUnique();

            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.AddressLine).HasMaxLength(300);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Email).HasMaxLength(120);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.StoreCode).HasMaxLength(20);
            entity.Property(e => e.StoreName).HasMaxLength(200);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE666949956CEF8");

            entity.ToTable("Supplier");

            entity.HasIndex(e => e.SupplierCode, "UQ__Supplier__44BE981BC5C96C5C").IsUnique();

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.AddressLine).HasMaxLength(300);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Email).HasMaxLength(120);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.SupplierCode).HasMaxLength(20);
            entity.Property(e => e.SupplierName).HasMaxLength(200);
            entity.Property(e => e.TaxCode).HasMaxLength(30);
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK__Unit__44F5EC9536580016");

            entity.ToTable("Unit");

            entity.HasIndex(e => e.UnitName, "UQ__Unit__B5EE6678BD7EBCE2").IsUnique();

            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UnitName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwInventoryOnHand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_InventoryOnHand");

            entity.Property(e => e.AvailableQty).HasColumnType("decimal(19, 2)");
            entity.Property(e => e.MinQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OnHandQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.ReservedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.Skucode)
                .HasMaxLength(30)
                .HasColumnName("SKUCode");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.StoreName).HasMaxLength(200);
            entity.Property(e => e.UpdatedAt).HasPrecision(0);
        });

        modelBuilder.Entity<VwSalesByDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SalesByDay");

            entity.Property(e => e.Revenue).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.StoreName).HasMaxLength(200);
        });

        modelBuilder.Entity<VwTopSellingSku>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TopSellingSKU");

            entity.Property(e => e.AmountSold).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.QtySold).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SkuId).HasColumnName("SkuID");
            entity.Property(e => e.Skucode)
                .HasMaxLength(30)
                .HasColumnName("SKUCode");
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.StoreName).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
