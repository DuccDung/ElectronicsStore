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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
            dgvEmployees.AutoGenerateColumns = false;
            BuildColumns();
            LoadGrid();
        }

        private void BuildColumns()
        {
            dgvEmployees.Columns.Clear();

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeId",
                DataPropertyName = "EmployeeId",
                Visible = false
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeCode",
                DataPropertyName = "EmployeeCode",
                HeaderText = "Mã NV",
                FillWeight = 14
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                DataPropertyName = "FullName",
                HeaderText = "Họ tên",
                FillWeight = 26
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Username",
                DataPropertyName = "Username",
                HeaderText = "Username",
                FillWeight = 18
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RoleName",
                DataPropertyName = "RoleName",
                HeaderText = "Vai trò",
                FillWeight = 14
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StoreName",
                DataPropertyName = "StoreName",
                HeaderText = "Cửa hàng",
                FillWeight = 18
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                DataPropertyName = "Phone",
                HeaderText = "SĐT",
                FillWeight = 12
            });
        }

        private void LoadGrid()
        {
            string keyword = (txtKeyword.Text ?? "").Trim().ToLower();

            using var db = new ElectronicsStoreContext();

            var query =
                from e in db.Employees.AsNoTracking()
                join r in db.Roles.AsNoTracking() on e.RoleId equals r.RoleId
                join s in db.Stores.AsNoTracking() on e.StoreId equals s.StoreId
                where e.IsActive
                select new
                {
                    e.EmployeeId,
                    e.EmployeeCode,
                    e.FullName,
                    e.Username,
                    RoleName = r.RoleName,
                    StoreName = s.StoreCode + " | " + s.StoreName,
                    e.Phone
                };

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(x =>
                    (x.EmployeeCode ?? "").ToLower().Contains(keyword) ||
                    (x.FullName ?? "").ToLower().Contains(keyword) ||
                    (x.Username ?? "").ToLower().Contains(keyword) ||
                    (x.RoleName ?? "").ToLower().Contains(keyword) ||
                    (x.StoreName ?? "").ToLower().Contains(keyword) ||
                    (x.Phone ?? "").ToLower().Contains(keyword));
            }

            dgvEmployees.DataSource = query
                .OrderBy(x => x.FullName)
                .ToList();
        }

        private int? GetSelectedEmployeeId()
        {
            if (dgvEmployees.CurrentRow == null) return null;
            var v = dgvEmployees.CurrentRow.Cells["EmployeeId"]?.Value;
            if (v == null) return null;
            return Convert.ToInt32(v);
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadGrid();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var f = new EmpEditForm(null);
            if (f.ShowDialog(this) == DialogResult.OK) LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = GetSelectedEmployeeId();
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để sửa.");
                return;
            }

            using var f = new EmpEditForm(id.Value);
            if (f.ShowDialog(this) == DialogResult.OK) LoadGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedEmployeeId();
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này? (xóa mềm)",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var db = new ElectronicsStoreContext();

                var emp = await db.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id.Value);
                if (emp == null)
                {
                    MessageBox.Show("Nhân viên không tồn tại.");
                    return;
                }

                emp.IsActive = false;
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

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnEdit_Click(sender, EventArgs.Empty);
        }
    }
}

