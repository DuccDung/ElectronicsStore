namespace ElectronicsStoreSystem.View
{
    partial class ProductListForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelGrid;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategoryFilter;

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            rootLayout = new TableLayoutPanel();
            panelTop = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblTitle = new Label();
            lblCategory = new Label();
            cboCategoryFilter = new ComboBox();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            panelGrid = new Panel();
            dgvProducts = new DataGridView();
            rootLayout.SuspendLayout();
            panelTop.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rootLayout.Controls.Add(panelTop, 0, 0);
            rootLayout.Controls.Add(panelGrid, 0, 1);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16);
            rootLayout.RowCount = 2;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.Size = new Size(1040, 640);
            rootLayout.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(btnDelete);
            panelTop.Controls.Add(btnUpdate);
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(lblCategory);
            panelTop.Controls.Add(cboCategoryFilter);
            panelTop.Controls.Add(txtKeyword);
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(btnAdd);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(19, 19);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(16, 12, 16, 12);
            panelTop.Size = new Size(1002, 90);
            panelTop.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(28, 28, 40);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(896, 44);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 36);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(28, 28, 40);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(796, 44);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 36);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnEdit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(207, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách sản phẩm";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(16, 52);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Danh mục:";
            // 
            // cboCategoryFilter
            // 
            cboCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoryFilter.FormattingEnabled = true;
            cboCategoryFilter.Location = new Point(98, 48);
            cboCategoryFilter.Name = "cboCategoryFilter";
            cboCategoryFilter.Size = new Size(204, 28);
            cboCategoryFilter.TabIndex = 2;
            cboCategoryFilter.SelectedIndexChanged += cboCategoryFilter_SelectedIndexChanged;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(259, 15);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Tìm theo SKU / Model / Tên / Brand...";
            txtKeyword.Size = new Size(149, 27);
            txtKeyword.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(318, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 32);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(28, 28, 40);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(700, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 36);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvProducts);
            panelGrid.Location = new Point(19, 115);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(16, 12, 16, 12);
            panelGrid.Size = new Size(1002, 506);
            panelGrid.TabIndex = 1;
            panelGrid.Paint += panelGrid_Paint;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeight = 32;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(16, 12);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(970, 482);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1040, 640);
            Controls.Add(rootLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductListForm";
            Text = "ProductListForm";
            rootLayout.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }
        private Button btnDelete;
        private Button btnUpdate;
    }
}
