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
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ElectronicsStoreSystem.View
{
    public partial class SupplierListForm : Form
    {
        public SupplierListForm()
        {
            InitializeComponent();
            dgvSuppliers.AutoGenerateColumns = false;
            BuildColumns();
            LoadGrid();
        }

        private void BuildColumns()
        {
            dgvSuppliers.Columns.Clear();

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierId",
                DataPropertyName = "SupplierId",
                Visible = false
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierCode",
                DataPropertyName = "SupplierCode",
                HeaderText = "Mã NCC",
                FillWeight = 18
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierName",
                DataPropertyName = "SupplierName",
                HeaderText = "Tên nhà cung cấp",
                FillWeight = 34
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                DataPropertyName = "Phone",
                HeaderText = "SĐT",
                FillWeight = 16
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "Email",
                FillWeight = 18
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TaxCode",
                DataPropertyName = "TaxCode",
                HeaderText = "MST",
                FillWeight = 14
            });
        }

        private void LoadGrid()
        {
            string keyword = (txtKeyword.Text ?? "").Trim().ToLower();

            using var db = new ElectronicsStoreContext();

            var query = db.Suppliers
                .AsNoTracking()
                .Where(s => s.IsActive);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(s =>
                    (s.SupplierCode ?? "").ToLower().Contains(keyword) ||
                    (s.SupplierName ?? "").ToLower().Contains(keyword) ||
                    (s.Phone ?? "").ToLower().Contains(keyword) ||
                    (s.Email ?? "").ToLower().Contains(keyword) ||
                    (s.TaxCode ?? "").ToLower().Contains(keyword));
            }

            var data = query
                .OrderBy(s => s.SupplierName)
                .Select(s => new
                {
                    s.SupplierId,
                    s.SupplierCode,
                    s.SupplierName,
                    s.Phone,
                    s.Email,
                    s.TaxCode
                })
                .ToList();

            dgvSuppliers.DataSource = data;
        }

        private int? GetSelectedSupplierId()
        {
            if (dgvSuppliers.CurrentRow == null) return null;
            var v = dgvSuppliers.CurrentRow.Cells["SupplierId"]?.Value;
            if (v == null) return null;
            return Convert.ToInt32(v);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var f = new SupplierEditForm(null);
            if (f.ShowDialog(this) == DialogResult.OK)
                LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = GetSelectedSupplierId();
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn 1 nhà cung cấp để sửa.");
                return;
            }

            using var f = new SupplierEditForm(id.Value);
            if (f.ShowDialog(this) == DialogResult.OK)
                LoadGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedSupplierId();
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn 1 nhà cung cấp để xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này? (xóa mềm)",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var db = new ElectronicsStoreContext();

                // Nếu đã có phiếu nhập liên quan, vẫn cho xóa mềm (không xóa cứng)
                var s = await db.Suppliers.FirstOrDefaultAsync(x => x.SupplierId == id.Value);
                if (s == null)
                {
                    MessageBox.Show("Nhà cung cấp không tồn tại.");
                    return;
                }

                s.IsActive = false;
                await db.SaveChangesAsync();

                MessageBox.Show("Đã xóa (IsActive=false).");
                LoadGrid();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnEdit_Click(sender, EventArgs.Empty);
        }
    }
}

