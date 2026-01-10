using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ElectronicsStoreSystem.Model;
using ElectronicsStoreSystem.Model.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElectronicsStoreSystem.View
{
    public partial class DashboardHomeForm : Form
    {
        private readonly BindingSource _bsProducts = new BindingSource();
        private readonly BindingSource _bsCart = new BindingSource();

        private readonly List<CartItemVM> _cart = new List<CartItemVM>();

        // TODO: bạn thay bằng employee đang đăng nhập
        private int _currentEmployeeId = 2;

        public class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
        }

        public DashboardHomeForm()
        {
            InitializeComponent();

            SetupProductsGrid();
            SetupCartGrid();

            LoadStores();
            LoadCategoryBrand();
            LoadPaymentMethods();

            dgvProducts.DataSource = _bsProducts;
            dgvCart.DataSource = _bsCart;

            _bsCart.DataSource = _cart;
            RefreshCartUI();
        }

        // ---------------- UI GRID SETUP ----------------

        private void SetupProductsGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SKUCode",
                HeaderText = "SKU",
                FillWeight = 25
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Tên sản phẩm",
                FillWeight = 45
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SalePrice",
                HeaderText = "Giá bán",
                FillWeight = 15,
                DefaultCellStyle = { Format = "N0" }
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AvailableQty",
                HeaderText = "Tồn",
                FillWeight = 15,
                DefaultCellStyle = { Format = "N0" }
            });
        }

        private void SetupCartGrid()
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SKUCode",
                HeaderText = "SKU",
                ReadOnly = true,
                FillWeight = 25
            });
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Tên",
                ReadOnly = true,
                FillWeight = 45
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                HeaderText = "SL",
                ReadOnly = false,
                FillWeight = 15,
                DefaultCellStyle = { Format = "N0" }
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Giá",
                ReadOnly = true,
                FillWeight = 15,
                DefaultCellStyle = { Format = "N0" }
            });

            // nút xóa
            var btnDel = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "X",
                UseColumnTextForButtonValue = true,
                Width = 40
            };
            dgvCart.Columns.Add(btnDel);

            dgvCart.CellContentClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                if (dgvCart.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    _cart.RemoveAt(e.RowIndex);
                    RefreshCartUI();
                }
            };
        }

        // ---------------- LOAD FILTERS ----------------

        private void LoadStores()
        {
            using var db = new ElectronicsStoreContext();

            var stores = db.Stores.AsNoTracking()
                .OrderBy(x => x.StoreName)
                .Select(x => new ComboItem
                {
                    Id = x.StoreId,
                    Name = x.StoreCode + " | " + x.StoreName
                })
                .ToList();

            cboStore.DataSource = stores;
            cboStore.DisplayMember = "Name";
            cboStore.ValueMember = "Id";

            if (stores.Count > 0)
                cboStore.SelectedIndex = 0;
        }

        private void LoadCategoryBrand()
        {
            using var db = new ElectronicsStoreContext();

            var categories = db.Categories.AsNoTracking()
                .OrderBy(x => x.CategoryName)
                .Select(x => new ComboItem { Id = x.CategoryId, Name = x.CategoryName })
                .ToList();
            categories.Insert(0, new ComboItem { Id = 0, Name = "Tất cả" });

            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";
            cboCategory.SelectedValue = 0;

            var brands = db.Brands.AsNoTracking()
                .OrderBy(x => x.BrandName)
                .Select(x => new ComboItem { Id = x.BrandId, Name = x.BrandName })
                .ToList();
            brands.Insert(0, new ComboItem { Id = 0, Name = "Tất cả" });

            cboBrand.DataSource = brands;
            cboBrand.DisplayMember = "Name";
            cboBrand.ValueMember = "Id";
            cboBrand.SelectedValue = 0;
        }

        private void LoadPaymentMethods()
        {
            using var db = new ElectronicsStoreContext();

            var methods = db.PaymentMethods.AsNoTracking()
                .OrderBy(x => x.MethodName)
                .Select(x => new ComboItem { Id = x.MethodId, Name = x.MethodName })
                .ToList();

            cboPaymentMethod.DataSource = methods;
            cboPaymentMethod.DisplayMember = "Name";
            cboPaymentMethod.ValueMember = "Id";

            if (methods.Count > 0) cboPaymentMethod.SelectedIndex = 0;
        }

        // ---------------- KPI ----------------
        private int GetSelectedStoreId()
        {
            if (cboStore.SelectedItem is ComboItem item) return item.Id;
            return 0;
        }

        private void RefreshKpi()
        {
            if (cboStore.SelectedValue == null) return;
            int storeId = GetSelectedStoreId();
            if (storeId <= 0) return;
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);

            using var db = new ElectronicsStoreContext();

            var revenue = db.SalesOrders.AsNoTracking()
                .Where(x => x.StoreId == storeId && x.OrderDate >= today && x.OrderDate < tomorrow && x.Status == "COMPLETED")
                .Sum(x => (decimal?)x.TotalAmt) ?? 0m;

            var profit =
                (from sol in db.SalesOrderLines.AsNoTracking()
                 join so in db.SalesOrders.AsNoTracking() on sol.Soid equals so.Soid
                 join sku in db.ProductSkus.AsNoTracking() on sol.SkuId equals sku.SkuId
                 where so.StoreId == storeId && so.OrderDate >= today && so.OrderDate < tomorrow && so.Status == "COMPLETED"
                 select (sku.SalePrice - sku.CostPrice) * sol.Qty
                ).Sum(x => (decimal?)x) ?? 0m;

            var orders = db.SalesOrders.AsNoTracking()
                .Count(x => x.StoreId == storeId && x.OrderDate >= today && x.OrderDate < tomorrow && x.Status == "COMPLETED");

            var lowStock = db.StockBalances.AsNoTracking()
                .Count(x => x.StoreId == storeId && x.OnHandQty < x.MinQty);

            lblRevenueValue.Text = revenue.ToString("N0");
            lblProfitValue.Text = profit.ToString("N0");
            lblOrdersValue.Text = orders.ToString();
            lblLowStockValue.Text = lowStock.ToString();
        }

        // ---------------- PRODUCTS LOAD + FILTER ----------------

        private void LoadProducts()
        {
            if (cboStore.SelectedValue == null) return;
            int storeId = GetSelectedStoreId();
            if (storeId <= 0) return;
            int categoryId = cboCategory.SelectedValue == null ? 0 : Convert.ToInt32(cboCategory.SelectedValue);
            int brandId = cboBrand.SelectedValue == null ? 0 : Convert.ToInt32(cboBrand.SelectedValue);

            string keyword = (txtKeyword.Text ?? "").Trim().ToLower();

            using var db = new ElectronicsStoreContext();

            var q =
                from sku in db.ProductSkus.AsNoTracking()
                join p in db.Products.AsNoTracking() on sku.ProductId equals p.ProductId
                join c in db.Categories.AsNoTracking() on p.CategoryId equals c.CategoryId
                join b in db.Brands.AsNoTracking() on p.BrandId equals b.BrandId
                join sb in db.StockBalances.AsNoTracking()
                    on new { StoreId = storeId, SkuId = sku.SkuId }
                    equals new { sb.StoreId, sb.SkuId } into sbJoin
                from sb in sbJoin.DefaultIfEmpty()
                where sku.IsActive && p.IsActive
                select new PosProductVM
                {
                    SkuId = sku.SkuId,
                    ProductId = p.ProductId,
                    SKUCode = sku.Skucode,
                    ProductName = p.ProductName,
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    BrandId = b.BrandId,
                    BrandName = b.BrandName,
                    SalePrice = sku.SalePrice,
                    CostPrice = sku.CostPrice,
                    AvailableQty = (sb == null ? 0 : (sb.OnHandQty - sb.ReservedQty))
                };

            if (categoryId > 0)
                q = q.Where(x => x.CategoryId == categoryId);

            if (brandId > 0)
                q = q.Where(x => x.BrandId == brandId);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                q = q.Where(x =>
                    x.SKUCode.ToLower().Contains(keyword) ||
                    x.ProductName.ToLower().Contains(keyword) ||
                    x.BrandName.ToLower().Contains(keyword) ||
                    x.CategoryName.ToLower().Contains(keyword));
            }

            var data = q.OrderBy(x => x.ProductName).ToList();
            _bsProducts.DataSource = data;
        }

        // ---------------- CART ----------------

        private void AddToCart(PosProductVM p)
        {
            if (p.AvailableQty <= 0)
            {
                MessageBox.Show("Sản phẩm đã hết hàng.");
                return;
            }

            var existing = _cart.FirstOrDefault(x => x.SkuId == p.SkuId);
            if (existing == null)
            {
                _cart.Add(new CartItemVM
                {
                    SkuId = p.SkuId,
                    SKUCode = p.SKUCode,
                    ProductName = p.ProductName,
                    Qty = 1,
                    UnitPrice = p.SalePrice,
                    UnitCost = p.CostPrice
                });
            }
            else
            {
                // check tồn theo số lượng mới
                var newQty = existing.Qty + 1;
                if (newQty > p.AvailableQty)
                {
                    MessageBox.Show($"Không đủ tồn. Tồn khả dụng: {p.AvailableQty:N0}");
                    return;
                }
                existing.Qty = newQty;
            }

            RefreshCartUI();
        }

        private void RefreshCartUI()
        {
            _bsCart.ResetBindings(false);

            decimal total = _cart.Sum(x => x.LineTotal);
            lblCartTotalValue.Text = total.ToString("N0");
        }

        // Khi user sửa Qty trực tiếp
        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCart.Rows[e.RowIndex].DataBoundItem is not CartItemVM item) return;

            if (item.Qty <= 0)
            {
                _cart.Remove(item);
                RefreshCartUI();
                return;
            }

            // check tồn lại
            if (_bsProducts.DataSource is List<PosProductVM> products)
            {
                var p = products.FirstOrDefault(x => x.SkuId == item.SkuId);
                if (p != null && item.Qty > p.AvailableQty)
                {
                    MessageBox.Show($"Không đủ tồn. Tồn khả dụng: {p.AvailableQty:N0}");
                    item.Qty = p.AvailableQty;
                }
            }

            RefreshCartUI();
        }

        // ---------------- CHECKOUT ----------------

        private async void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cboStore.SelectedValue == null) { MessageBox.Show("Vui lòng chọn cửa hàng."); return; }
            if (cboPaymentMethod.SelectedValue == null) { MessageBox.Show("Vui lòng chọn phương thức thanh toán."); return; }
            if (_cart.Count == 0) { MessageBox.Show("Giỏ hàng trống."); return; }

            int storeId = Convert.ToInt32(cboStore.SelectedValue);
            int methodId = Convert.ToInt32(cboPaymentMethod.SelectedValue);

            var confirm = MessageBox.Show("Xác nhận thanh toán?", "Thanh toán",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var ok = await CheckoutAsync(storeId, methodId);
            if (ok)
            {
                MessageBox.Show("Thanh toán thành công!");
                _cart.Clear();
                RefreshCartUI();
                LoadProducts();
                RefreshKpi();
            }
        }

        private async System.Threading.Tasks.Task<bool> CheckoutAsync(int storeId, int paymentMethodId)
        {
            using var db = new ElectronicsStoreContext();
            using var tx = await db.Database.BeginTransactionAsync();

            try
            {
                // 1) check tồn lần cuối (tránh mua trùng)
                foreach (var item in _cart)
                {
                    var sb = await db.StockBalances
                        .FirstOrDefaultAsync(x => x.StoreId == storeId && x.SkuId == item.SkuId);

                    var available = sb == null ? 0 : (sb.OnHandQty - sb.ReservedQty);
                    if (available < item.Qty)
                    {
                        MessageBox.Show($"Không đủ tồn cho {item.SKUCode}. Còn {available:N0}, cần {item.Qty:N0}");
                        await tx.RollbackAsync();
                        return false;
                    }
                }

                // 2) tạo SalesOrder
                decimal subtotal = _cart.Sum(x => x.LineTotal);

                var so = new SalesOrder
                {
                    Socode = "SO" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    StoreId = storeId,
                    Status = "COMPLETED",
                    SoldBy = _currentEmployeeId,
                    CreatedBy = _currentEmployeeId,
                    Subtotal = subtotal,
                    DiscountAmt = 0,
                    TaxAmt = 0,
                    Note = "Bán tại dashboard"
                };

                db.SalesOrders.Add(so);
                await db.SaveChangesAsync();

                // 3) SalesOrderLine
                foreach (var item in _cart)
                {
                    db.SalesOrderLines.Add(new SalesOrderLine
                    {
                        Soid = so.Soid,
                        SkuId = item.SkuId,
                        Qty = item.Qty,
                        UnitPrice = item.UnitPrice,
                        DiscountAmt = 0,
                        TaxRate = 0
                    });
                }
                await db.SaveChangesAsync();

                // 4) Payment
                // Lưu ý TotalAmt là computed column -> sau SaveChanges thì EF có thể đọc lại, nhưng để chắc thì dùng subtotal
                db.Payments.Add(new Payment
                {
                    Soid = so.Soid,
                    MethodId = paymentMethodId,
                    Amount = subtotal,
                    CreatedBy = _currentEmployeeId,
                    Note = "Thanh toán bán hàng"
                });
                await db.SaveChangesAsync();

                // 5) StockTxn OUT
                var st = new StockTxn
                {
                    StoreId = storeId,
                    TxnType = "OUT",
                    RefType = "SO",
                    RefId = so.Soid,
                    CreatedBy = _currentEmployeeId,
                    Note = "Xuất bán"
                };
                db.StockTxns.Add(st);
                await db.SaveChangesAsync();

                // 6) StockTxnLine + trừ StockBalance
                foreach (var item in _cart)
                {
                    db.StockTxnLines.Add(new StockTxnLine
                    {
                        StockTxnId = st.StockTxnId,
                        SkuId = item.SkuId,
                        Qty = item.Qty,
                        UnitCost = item.UnitCost
                    });

                    var sb = await db.StockBalances
                        .FirstAsync(x => x.StoreId == storeId && x.SkuId == item.SkuId);

                    sb.OnHandQty -= item.Qty;
                }

                await db.SaveChangesAsync();
                await tx.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await tx.RollbackAsync();
                MessageBox.Show("Checkout lỗi: " + (ex.InnerException?.Message ?? ex.Message));
                return false;
            }
        }

        // ---------------- EVENTS ----------------

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cboStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi đổi store => refresh KPI + product list
            RefreshKpi();
            LoadProducts();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is PosProductVM p)
                AddToCart(p);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            RefreshCartUI();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProfitValue_Click(object sender, EventArgs e)
        {

        }
    }
}

