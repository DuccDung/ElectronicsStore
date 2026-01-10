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

namespace ElectronicsStoreSystem.View
{
    public partial class CategoryEditForm : Form
    {
        private readonly int? _categoryId;

        public class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
        }

        public CategoryEditForm(int? categoryId)
        {
            _categoryId = categoryId;
            InitializeComponent();
            LoadParentCombo();
            LoadDataIfEdit();
        }

        private void LoadParentCombo()
        {
            using var db = new ElectronicsStoreContext();

            var items = db.Categories
                .AsNoTracking()
                .OrderBy(x => x.CategoryName)
                .Select(x => new ComboItem { Id = x.CategoryId, Name = x.CategoryName })
                .ToList();

            items.Insert(0, new ComboItem { Id = 0, Name = "(Không có)" });

            cboParent.DataSource = items;
            cboParent.DisplayMember = "Name";
            cboParent.ValueMember = "Id";
            cboParent.SelectedValue = 0;
        }

        private void LoadDataIfEdit()
        {
            if (_categoryId == null)
            {
                lblTitle.Text = "Thêm danh mục";
                return;
            }

            lblTitle.Text = "Sửa danh mục";

            using var db = new ElectronicsStoreContext();
            var cat = db.Categories.AsNoTracking().FirstOrDefault(x => x.CategoryId == _categoryId.Value);
            if (cat == null) return;

            txtName.Text = cat.CategoryName;

            if (cat.ParentId.HasValue)
                cboParent.SelectedValue = cat.ParentId.Value;
            else
                cboParent.SelectedValue = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var name = (txtName.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục.");
                return;
            }

            int parentId = 0;
            if (cboParent.SelectedValue != null)
                parentId = Convert.ToInt32(cboParent.SelectedValue);

            // không cho chọn chính nó làm cha
            if (_categoryId.HasValue && parentId == _categoryId.Value)
            {
                MessageBox.Show("Danh mục cha không được là chính nó.");
                return;
            }

            try
            {
                using var db = new ElectronicsStoreContext();

                if (_categoryId == null)
                {
                    var newCat = new Category
                    {
                        CategoryName = name,
                        ParentId = parentId == 0 ? null : parentId
                    };
                    db.Categories.Add(newCat);
                }
                else
                {
                    var cat = await db.Categories.FirstOrDefaultAsync(x => x.CategoryId == _categoryId.Value);
                    if (cat == null)
                    {
                        MessageBox.Show("Danh mục không tồn tại.");
                        return;
                    }

                    cat.CategoryName = name;
                    cat.ParentId = parentId == 0 ? null : parentId;
                }

                await db.SaveChangesAsync();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DbUpdateException ex)
            {
                // hay gặp nhất: UQ_Category (ParentId, CategoryName) bị trùng
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

