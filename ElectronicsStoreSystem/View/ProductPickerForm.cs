using ElectronicsStoreSystem.Model;
using ElectronicsStoreSystem.Model.ViewModel;
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

    public partial class ProductPickerForm : Form
    {
        public ProductSelected? SelectedProduct;

        public ProductPickerForm()
        {
            InitializeComponent();
            LoadProducts();
        }
        public void LoadProducts()
        {
            using ElectronicsStoreContext db = new ElectronicsStoreContext();
            var products = db.Products
                .Select(p => new Model.ViewModel.Products
                {
                    SkuID = db.ProductSkus.Where(x => x.ProductId == p.ProductId).Select(x => (int?)x.SkuId).FirstOrDefault() ?? 0,
                    ProductID = p.ProductId,
                    ProductName = p.ProductName,
                    CostPrice = db.ProductSkus.Where(x => x.ProductId == p.ProductId).Select(x => (decimal?)x.CostPrice).FirstOrDefault() ?? 0,
                    SalePrice = db.ProductSkus.Where(x => x.ProductId == p.ProductId).Select(x => (decimal?)x.SalePrice).FirstOrDefault() ?? 0,
                })
                .ToList();
            dgvProducts.DataSource = products;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || !int.TryParse(txtQtyPdt.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng hợp lệ (> 0).",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            // Vì DataSource là List<Products> nên lấy thẳng object
            var product = dgvProducts.CurrentRow.DataBoundItem as Model.ViewModel.Products;
            SelectedProduct = new ProductSelected
            {
                SkuID = product.SkuID,
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                CostPrice = product.CostPrice,
                SalePrice = product.SalePrice,
                Quantity = qty
            };
            if (SelectedProduct == null)
            {
                MessageBox.Show("Không lấy được dữ liệu dòng chọn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }


        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Double click = chọn nhanh
                btnSelect_Click(sender, EventArgs.Empty);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Tạm để trống: sau này bạn filter datasource tại đây
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Tạm để trống: sau này reload dữ liệu tại đây
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            using (var createProductForm = new ProductCreateForm())
            {
                createProductForm.StartPosition = FormStartPosition.CenterParent;
                createProductForm.ShowDialog(this);
            }
        }

        private void lblHint_Click(object sender, EventArgs e)
        {

        }
    }
}

