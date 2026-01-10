using ElectronicsStoreSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ElectronicsStoreSystem.View
{
    public partial class EmployeeEditForm : Form
    {
        private readonly int? _employeeId;

        public class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
        }

        public EmployeeEditForm(int? employeeId)
        {
            _employeeId = employeeId;
            InitializeComponent();
            LoadRoleStore();
            LoadDataIfEdit();
        }

        private void LoadRoleStore()
        {
            using var db = new ElectronicsStoreContext();

            var roles = db.Roles
                .AsNoTracking()
                .OrderBy(x => x.RoleName)
                .Select(x => new ComboItem { Id = x.RoleId, Name = x.RoleName })
                .ToList();

            var stores = db.Stores
                .AsNoTracking()
                .OrderBy(x => x.StoreName)
                .Select(x => new ComboItem { Id = x.StoreId, Name = x.StoreCode + " | " + x.StoreName })
                .ToList();

            cboRole.DataSource = roles;
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "Id";

            cboStore.DataSource = stores;
            cboStore.DisplayMember = "Name";
            cboStore.ValueMember = "Id";
        }

        private void LoadDataIfEdit()
        {
            if (_employeeId == null)
            {
                lblTitle.Text = "Thêm nhân viên";
                return;
            }

            lblTitle.Text = "Sửa nhân viên";

            using var db = new ElectronicsStoreContext();
            var e = db.Employees.AsNoTracking()
                .FirstOrDefault(x => x.EmployeeId == _employeeId.Value);

            if (e == null) return;

            txtCode.Text = e.EmployeeCode;
            txtFullName.Text = e.FullName;
            txtUsername.Text = e.Username;
            txtPhone.Text = e.Phone;
            txtEmail.Text = e.Email;
            txtAddress.Text = e.AddressLine;
            txtBaseSalary.Text = e.BaseSalary.ToString();

            cboRole.SelectedValue = e.RoleId;
            cboStore.SelectedValue = e.StoreId;

            // sửa thì không bắt đổi mật khẩu
            txtPassword.Text = "";
        }

        private static byte[] HashPassword(string raw)
        {
            using var sha = SHA256.Create();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(raw));
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string code = (txtCode.Text ?? "").Trim();
            string fullName = (txtFullName.Text ?? "").Trim();
            string username = (txtUsername.Text ?? "").Trim();
            string password = (txtPassword.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(code)) { MessageBox.Show("Vui lòng nhập Mã NV."); return; }
            if (string.IsNullOrWhiteSpace(fullName)) { MessageBox.Show("Vui lòng nhập Họ tên."); return; }
            if (string.IsNullOrWhiteSpace(username)) { MessageBox.Show("Vui lòng nhập Username."); return; }
            if (cboRole.SelectedValue == null) { MessageBox.Show("Vui lòng chọn Role."); return; }
            if (cboStore.SelectedValue == null) { MessageBox.Show("Vui lòng chọn Store."); return; }

            int roleId = Convert.ToInt32(cboRole.SelectedValue);
            int storeId = Convert.ToInt32(cboStore.SelectedValue);

            decimal baseSalary = 0;
            if (!string.IsNullOrWhiteSpace(txtBaseSalary.Text) &&
                !decimal.TryParse(txtBaseSalary.Text.Trim(), out baseSalary))
            {
                MessageBox.Show("Lương cơ bản không hợp lệ.");
                return;
            }

            if (_employeeId == null && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                return;
            }

            try
            {
                using var db = new ElectronicsStoreContext();

                bool dupCode = await db.Employees.AnyAsync(x =>
                    x.EmployeeCode == code &&
                    (!_employeeId.HasValue || x.EmployeeId != _employeeId.Value));

                if (dupCode) { MessageBox.Show("Mã NV đã tồn tại."); return; }

                bool dupUser = await db.Employees.AnyAsync(x =>
                    x.Username == username &&
                    (!_employeeId.HasValue || x.EmployeeId != _employeeId.Value));

                if (dupUser) { MessageBox.Show("Username đã tồn tại."); return; }

                if (_employeeId == null)
                {
                    var emp = new Employee
                    {
                        EmployeeCode = code,
                        FullName = fullName,
                        Username = username,
                        PasswordHash = HashPassword(password),
                        Phone = (txtPhone.Text ?? "").Trim(),
                        Email = (txtEmail.Text ?? "").Trim(),
                        AddressLine = (txtAddress.Text ?? "").Trim(),
                        BaseSalary = baseSalary,
                        RoleId = roleId,
                        StoreId = storeId,
                        IsActive = true
                    };

                    db.Employees.Add(emp);
                }
                else
                {
                    var emp = await db.Employees.FirstOrDefaultAsync(x => x.EmployeeId == _employeeId.Value);
                    if (emp == null) { MessageBox.Show("Nhân viên không tồn tại."); return; }

                    emp.EmployeeCode = code;
                    emp.FullName = fullName;
                    emp.Username = username;
                    emp.Phone = (txtPhone.Text ?? "").Trim();
                    emp.Email = (txtEmail.Text ?? "").Trim();
                    emp.AddressLine = (txtAddress.Text ?? "").Trim();
                    emp.BaseSalary = baseSalary;
                    emp.RoleId = roleId;
                    emp.StoreId = storeId;

                    if (!string.IsNullOrWhiteSpace(password))
                        emp.PasswordHash = HashPassword(password);
                }

                await db.SaveChangesAsync();

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
