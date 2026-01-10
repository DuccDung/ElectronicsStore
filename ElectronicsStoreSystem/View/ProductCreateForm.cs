using ElectronicsStoreSystem.Model;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicsStoreSystem.View
{
    public partial class ProductCreateForm : Form
    {
        public ProductCreateForm()
        {
            InitializeComponent();

            // default
            chkProductActive.Checked = true;
            chkSkuActive.Checked = true;

            LoadLookups();
        }

        private void LoadLookups()
        {
            using (var db = new ElectronicsStoreContext())
            {
                // Bạn đổi DbSet đúng theo project của bạn: Categories/Brands/Units
                var categories = db.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                cboCategory.DataSource = categories;
                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "CategoryID";

                var brands = db.Brands
                    .OrderBy(x => x.BrandName)
                    .ToList();

                cboBrand.DataSource = brands;
                cboBrand.DisplayMember = "BrandName";
                cboBrand.ValueMember = "BrandID";

                var units = db.Units
                    .OrderBy(x => x.UnitName)
                    .ToList();

                cboUnit.DataSource = units;
                cboUnit.DisplayMember = "UnitName";
                cboUnit.ValueMember = "UnitID";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate tối thiểu
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên sản phẩm.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSkuCode.Text))
            {
                MessageBox.Show("Vui lòng nhập SKUCode.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSkuCode.Focus();
                return;
            }

            try
            {
                using (var db = new ElectronicsStoreContext())
                {
                    // Check trùng SKUCode (nếu bạn có unique)
                    bool skuExists = db.ProductSkus.Any(x => x.Skucode == txtSkuCode.Text.Trim());
                    if (skuExists)
                    {
                        MessageBox.Show("SKUCode đã tồn tại. Vui lòng nhập SKUCode khác.", "Trùng dữ liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSkuCode.Focus();
                        return;
                    }

                    var product = new Product
                    {
                        CategoryId = Convert.ToInt32(cboCategory.SelectedValue),
                        BrandId = Convert.ToInt32(cboBrand.SelectedValue),
                        ProductName = txtProductName.Text.Trim(),
                        Description = txtDescription.Text.Trim(),
                        WarrantyMonths = Convert.ToInt32(nudWarrantyMonths.Value),
                        IsSerialized = chkIsSerialized.Checked,
                        IsActive = chkProductActive.Checked,
                        CreatedAt = DateTime.Now
                    };

                    db.Products.Add(product);
                    db.SaveChanges(); // để có ProductID

                    var sku = new ProductSku
                    {
                        ProductId = product.ProductId,
                        UnitId = Convert.ToInt32(cboUnit.SelectedValue),
                        Skucode = txtSkuCode.Text.Trim(),
                        Barcode = txtBarcode.Text.Trim(),
                        Model = txtModel.Text.Trim(),
                        Color = txtColor.Text.Trim(),
                        SpecJson = txtSpecJson.Text.Trim(),
                        Vatrate = Convert.ToDecimal(nudVatRate.Value),
                        CostPrice = Convert.ToDecimal(nudCostPrice.Value),
                        SalePrice = Convert.ToDecimal(nudSalePrice.Value),
                        IsActive = chkSkuActive.Checked,
                        CreatedAt = DateTime.Now
                    };

                    db.ProductSkus.Add(sku);
                    db.SaveChanges();
                }

                MessageBox.Show("Thêm sản phẩm thành công!", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

