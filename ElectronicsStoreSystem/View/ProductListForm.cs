using ElectronicsStoreSystem.Model;
using ElectronicsStoreSystem.Model.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicsStoreSystem.View
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();

            // cho nhanh: tự sinh cột theo ViewModel / object datasource
            dgvProducts.AutoGenerateColumns = true;

            LoadCategoryFilter();
            LoadGrid();
        }
        public class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
        }

        private void LoadCategoryFilter()
        {
            using var db = new ElectronicsStoreContext();

            var categories = db.Categories
                .OrderBy(c => c.CategoryName)
                .Select(c => new ComboItem { Id = c.CategoryId, Name = c.CategoryName })
                .ToList();

            categories.Insert(0, new ComboItem { Id = 0, Name = "Tất cả" });

            cboCategoryFilter.DataSource = categories;
            cboCategoryFilter.DisplayMember = "Name";
            cboCategoryFilter.ValueMember = "Id";
            cboCategoryFilter.SelectedValue = 0;
        }


        private void LoadGrid()
        {
            string keyword = (txtKeyword.Text ?? "").Trim();
            int categoryId = 0;

            if (cboCategoryFilter.SelectedItem is ComboItem item)
            {
                categoryId = item.Id;
            }

            using var db = new ElectronicsStoreContext();

            // Query base
            var query =
                from sku in db.ProductSkus
                join p in db.Products on sku.ProductId equals p.ProductId
                join c in db.Categories on p.CategoryId equals c.CategoryId
                join b in db.Brands on p.BrandId equals b.BrandId
                where sku.IsActive
                select new ProductListItemVM
                {
                    ProductID = p.ProductId,
                    SkuID = sku.SkuId,

                    ProductName = p.ProductName,
                    CategoryName = c.CategoryName,
                    BrandName = b.BrandName,

                    SKUCode = sku.Skucode,
                    Model = sku.Model,

                    CostPrice = sku.CostPrice,
                    SalePrice = sku.SalePrice
                };

            // Filter Category (Id=0 => Tất cả)
            if (categoryId != 0)
            {
                // cần lọc theo CategoryId, nên ta phải lọc trước khi select VM
                // => cách đơn giản: query lại theo join có CategoryId
                var query2 =
                    from sku in db.ProductSkus
                    join p in db.Products on sku.ProductId equals p.ProductId
                    join c in db.Categories on p.CategoryId equals c.CategoryId
                    join b in db.Brands on p.BrandId equals b.BrandId
                    where sku.IsActive && p.CategoryId == categoryId
                    select new ProductListItemVM
                    {
                        ProductID = p.ProductId,
                        SkuID = sku.SkuId,

                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName,
                        BrandName = b.BrandName,

                        SKUCode = sku.Skucode,
                        Model = sku.Model,

                        CostPrice = sku.CostPrice,
                        SalePrice = sku.SalePrice
                    };

                query = query2;
            }

            // Filter Keyword (SKU / Model / Tên / Brand / Category)
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                string k = keyword.ToLower();

                query = query.Where(x =>
                    (x.ProductName ?? "").ToLower().Contains(k) ||
                    (x.SKUCode ?? "").ToLower().Contains(k) ||
                    (x.Model ?? "").ToLower().Contains(k) ||
                    (x.BrandName ?? "").ToLower().Contains(k) ||
                    (x.CategoryName ?? "").ToLower().Contains(k)
                );
            }

            dgvProducts.DataSource = query.ToList();
        }

        //private void LoadGrid()
        //{
        //    // TODO: query join Product + ProductSKU + Category + Brand ở đây
        //    // dgvProducts.DataSource = data;
        //    using (ElectronicsStoreContext db = new ElectronicsStoreContext())
        //    {
        //        var products =
        //            (from sku in db.ProductSkus
        //             join p in db.Products on sku.ProductId equals p.ProductId
        //             join c in db.Categories on p.CategoryId equals c.CategoryId
        //             join b in db.Brands on p.BrandId equals b.BrandId
        //             where sku.IsActive
        //             select new ProductListItemVM
        //             {
        //                 ProductID = p.ProductId,
        //                 SkuID = sku.SkuId,

        //                 ProductName = p.ProductName,
        //                 CategoryName = c.CategoryName,
        //                 BrandName = b.BrandName,

        //                 SKUCode = sku.Skucode,
        //                 Model = sku.Model,

        //                 CostPrice = sku.CostPrice,
        //                 SalePrice = sku.SalePrice
        //             }).ToList();

        //        dgvProducts.DataSource = products;
        //    }
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void cboCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lọc theo category
            LoadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: mở ProductEditForm (thêm)
            // using var f = new ProductEditForm();
            // if (f.ShowDialog(this) == DialogResult.OK) LoadGrid();

            MessageBox.Show("Bạn bấm Thêm (hook sang ProductEditForm).");
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedIds(out int productId, out int skuId))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa.");
                return;
            }

            try
            {
                using var db = new ElectronicsStoreContext();

                var sku = await db.ProductSkus
                    .Include(x => x.Product)
                    .FirstOrDefaultAsync(x => x.SkuId == skuId);

                if (sku == null)
                {
                    MessageBox.Show("Không tìm thấy SKU.");
                    return;
                }

                // demo sửa nhanh (bạn có thể thay bằng ProductEditForm sau)
                string newName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Tên sản phẩm:", "Sửa", sku.Product.ProductName);

                if (string.IsNullOrWhiteSpace(newName)) return;

                string newModel = Microsoft.VisualBasic.Interaction.InputBox(
                    "Model:", "Sửa", sku.Model ?? "");

                string newCost = Microsoft.VisualBasic.Interaction.InputBox(
                    "Giá nhập:", "Sửa", sku.CostPrice.ToString());

                string newSale = Microsoft.VisualBasic.Interaction.InputBox(
                    "Giá bán:", "Sửa", sku.SalePrice.ToString());

                if (!decimal.TryParse(newCost, out var cost)) cost = sku.CostPrice;
                if (!decimal.TryParse(newSale, out var sale)) sale = sku.SalePrice;

                sku.Product.ProductName = newName.Trim();
                sku.Model = newModel.Trim();
                sku.CostPrice = cost;
                sku.SalePrice = sale;

                await db.SaveChangesAsync();

                MessageBox.Show("Đã cập nhật.");
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedIds(out int productId, out int skuId))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa.");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn chắc chắn muốn xóa SKU này? (xóa mềm: IsActive=false)",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var db = new ElectronicsStoreContext();

                // load SKU cần xóa
                var sku = await db.ProductSkus.FirstOrDefaultAsync(x => x.SkuId == skuId);
                if (sku == null)
                {
                    MessageBox.Show("Không tìm thấy SKU.");
                    return;
                }

                sku.IsActive = false;
                await db.SaveChangesAsync();

                // nếu Product không còn SKU active nào -> set Product.IsActive=false
                bool hasAnyActiveSku = await db.ProductSkus.AnyAsync(x => x.ProductId == productId && x.IsActive);
                if (!hasAnyActiveSku)
                {
                    var p = await db.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
                    if (p != null)
                    {
                        p.IsActive = false;
                        await db.SaveChangesAsync();
                    }
                }

                MessageBox.Show("Đã xóa (IsActive=false).");
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }


        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEdit_Click(sender, EventArgs.Empty);
        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool TryGetSelectedIds(out int productId, out int skuId)
        {
            productId = 0;
            skuId = 0;

            if (dgvProducts.CurrentRow == null) return false;

            // cách 1: lấy theo DataBoundItem (ổn định nhất)
            if (dgvProducts.CurrentRow.DataBoundItem is ProductListItemVM vm)
            {
                productId = vm.ProductID;
                skuId = vm.SkuID;
                return true;
            }

            // cách 2: fallback lấy theo cell (trường hợp DataBoundItem không phải vm)
            if (dgvProducts.CurrentRow.Cells["ProductID"]?.Value != null &&
                dgvProducts.CurrentRow.Cells["SkuID"]?.Value != null)
            {
                productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
                skuId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["SkuID"].Value);
                return true;
            }

            return false;
        }

    }
}

