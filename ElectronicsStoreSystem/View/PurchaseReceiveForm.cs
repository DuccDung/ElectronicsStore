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

namespace ElectronicsStoreSystem.View
{
    public partial class PurchaseReceiveForm : Form
    {
        public PurchaseReceiveForm()
        {
            InitializeComponent();
            loadSuppliers();
            loadStores();
        }

        private void loadSuppliers()
        {
            using ElectronicsStoreContext db = new ElectronicsStoreContext();
            var suppliers = db.Suppliers
                .Select(s => new Suppliers
                {
                    SupplierCode = s.SupplierCode,
                    SupplierName = s.SupplierName
                })
                .ToList();

            cboSupplier.DataSource = suppliers;
            cboSupplier.DisplayMember = "SupplierName";
            cboSupplier.ValueMember = "SupplierCode";
        }
        private void loadStores()
        {
            using ElectronicsStoreContext db = new ElectronicsStoreContext();
            var stores = db.Stores
                .Select(s => new
                {
                    StoreCode = s.StoreCode,
                    StoreName = s.StoreCode + " | " + s.StoreName
                })
                .ToList();
            cboStore.DataSource = stores;
            cboStore.DisplayMember = "StoreName";
            cboStore.ValueMember = "StoreCode";
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            using (var pickerForm = new ProductPickerForm())
            {
                pickerForm.StartPosition = FormStartPosition.CenterParent;

                if (pickerForm.ShowDialog(this) == DialogResult.OK)
                {
                    var p = pickerForm.SelectedProduct;
                    if (p == null) return;

                    int rowIndex = dgvLines.Rows.Add();

                    // colSku là ComboBoxColumn trong form nhập hàng của bạn
                    dgvLines.Rows[rowIndex].Cells["colSku"].Value = p.SkuID;
                    dgvLines.Rows[rowIndex].Cells["colName"].Value = p.ProductName;
                    dgvLines.Rows[rowIndex].Cells["colQty"].Value = p.Quantity;
                    dgvLines.Rows[rowIndex].Cells["colUnitCost"].Value = p.CostPrice;
                    dgvLines.Rows[rowIndex].Cells["colLineTotal"].Value = p.CostPrice * p.Quantity; // qty=1

                    // Nếu có hàm tính tổng tiền thì gọi ở đây
                     RecalcTotals();
                }
            }
        }
        public void RecalcTotals()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvLines.Rows)
            {
                if (row.Cells["colLineTotal"].Value != null &&
                    decimal.TryParse(row.Cells["colLineTotal"]?.Value?.ToString(), out decimal lineTotal))
                {
                    total += lineTotal;
                }
            }
            lblSubtotalValue.Text = total.ToString("N2");
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
