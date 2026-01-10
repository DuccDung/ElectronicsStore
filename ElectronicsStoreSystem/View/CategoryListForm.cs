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
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent();
            dgvCategories.AutoGenerateColumns = false;
            BuildColumns();
            LoadGrid();
        }

        private void BuildColumns()
        {
            dgvCategories.Columns.Clear();

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryId",
                DataPropertyName = "CategoryId",
                Visible = false
            });

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                DataPropertyName = "CategoryName",
                HeaderText = "Tên danh mục",
                FillWeight = 60
            });

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ParentName",
                DataPropertyName = "ParentName",
                HeaderText = "Danh mục cha",
                FillWeight = 40
            });
        }

        private void LoadGrid()
        {
            using var db = new ElectronicsStoreContext();

            var data = db.Categories
                .AsNoTracking()
                .Select(c => new
                {
                    c.CategoryId,
                    c.CategoryName,
                    ParentName = c.ParentId == null
                        ? ""
                        : db.Categories.Where(p => p.CategoryId == c.ParentId).Select(p => p.CategoryName).FirstOrDefault()
                })
                .OrderBy(x => x.CategoryName)
                .ToList();

            dgvCategories.DataSource = data;
        }

        private int? GetSelectedCategoryId()
        {
            if (dgvCategories.CurrentRow == null) return null;
            var v = dgvCategories.CurrentRow.Cells["CategoryId"]?.Value;
            if (v == null) return null;
            return Convert.ToInt32(v);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var f = new CategoryEditForm(null);
            if (f.ShowDialog(this) == DialogResult.OK)
                LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = GetSelectedCategoryId();
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn 1 danh mục để sửa.");
                return;
            }

            using var f = new CategoryEditForm(id.Value);
            if (f.ShowDialog(this) == DialogResult.OK)
                LoadGrid();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedCategoryId();
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn 1 danh mục để xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn chắc chắn muốn xóa danh mục này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var db = new ElectronicsStoreContext();

                // chặn xóa nếu còn danh mục con
                bool hasChild = await db.Categories.AnyAsync(x => x.ParentId == id.Value);
                if (hasChild)
                {
                    MessageBox.Show("Không thể xóa vì danh mục này còn danh mục con.");
                    return;
                }

                // chặn xóa nếu có Product đang dùng Category này
                bool usedByProduct = await db.Products.AnyAsync(p => p.CategoryId == id.Value);
                if (usedByProduct)
                {
                    MessageBox.Show("Không thể xóa vì danh mục đang được dùng bởi sản phẩm.");
                    return;
                }

                var cat = await db.Categories.FirstOrDefaultAsync(x => x.CategoryId == id.Value);
                if (cat == null)
                {
                    MessageBox.Show("Danh mục không tồn tại.");
                    return;
                }

                db.Categories.Remove(cat);
                await db.SaveChangesAsync();

                MessageBox.Show("Đã xóa danh mục.");
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

        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnEdit_Click(sender, EventArgs.Empty);
        }
    }
}

