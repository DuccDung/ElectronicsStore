using ElectronicsStoreSystem.Model;
using Microsoft.EntityFrameworkCore;
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
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ElectronicsStoreSystem.View
{
    public partial class SupplierEditForm : Form
    {
        private readonly int? _supplierId;

        public SupplierEditForm(int? supplierId)
        {
            _supplierId = supplierId;
            InitializeComponent();
            LoadDataIfEdit();
        }

        private void LoadDataIfEdit()
        {
            if (_supplierId == null)
            {
                lblTitle.Text = "Thêm nhà cung cấp";
                return;
            }

            lblTitle.Text = "Sửa nhà cung cấp";

            using var db = new ElectronicsStoreContext();
            var s = db.Suppliers.AsNoTracking().FirstOrDefault(x => x.SupplierId == _supplierId.Value);
            if (s == null) return;

            txtCode.Text = s.SupplierCode;
            txtName.Text = s.SupplierName;
            txtPhone.Text = s.Phone;
            txtEmail.Text = s.Email;
            txtTaxCode.Text = s.TaxCode;
            txtAddress.Text = s.AddressLine;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var code = (txtCode.Text ?? "").Trim();
            var name = (txtName.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Vui lòng nhập Mã NCC.");
                return;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập Tên NCC.");
                return;
            }

            try
            {
                using var db = new ElectronicsStoreContext();

                // Check trùng mã
                bool duplicateCode = await db.Suppliers.AnyAsync(x =>
                    x.SupplierCode == code &&
                    (!_supplierId.HasValue || x.SupplierId != _supplierId.Value));

                if (duplicateCode)
                {
                    MessageBox.Show("Mã NCC đã tồn tại.");
                    return;
                }

                if (_supplierId == null)
                {
                    var s = new Supplier
                    {
                        SupplierCode = code,
                        SupplierName = name,
                        Phone = (txtPhone.Text ?? "").Trim(),
                        Email = (txtEmail.Text ?? "").Trim(),
                        TaxCode = (txtTaxCode.Text ?? "").Trim(),
                        AddressLine = (txtAddress.Text ?? "").Trim(),
                        IsActive = true
                    };
                    db.Suppliers.Add(s);
                }
                else
                {
                    var s = await db.Suppliers.FirstOrDefaultAsync(x => x.SupplierId == _supplierId.Value);
                    if (s == null)
                    {
                        MessageBox.Show("Nhà cung cấp không tồn tại.");
                        return;
                    }

                    s.SupplierCode = code;
                    s.SupplierName = name;
                    s.Phone = (txtPhone.Text ?? "").Trim();
                    s.Email = (txtEmail.Text ?? "").Trim();
                    s.TaxCode = (txtTaxCode.Text ?? "").Trim();
                    s.AddressLine = (txtAddress.Text ?? "").Trim();
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

