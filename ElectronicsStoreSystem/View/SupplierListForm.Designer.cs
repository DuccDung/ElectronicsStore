namespace ElectronicsStoreSystem.View
{
    partial class SupplierListForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelGrid;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvSuppliers;

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
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            lblTitle = new Label();
            panelGrid = new Panel();
            dgvSuppliers = new DataGridView();
            rootLayout.SuspendLayout();
            panelTop.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
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
            panelTop.Controls.Add(btnEdit);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(txtKeyword);
            panelTop.Controls.Add(lblTitle);
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
            btnDelete.Location = new Point(819, 48);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(28, 28, 40);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(714, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(28, 28, 40);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(603, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(305, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(16, 50);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Tìm theo mã / tên / SĐT / email / MST...";
            txtKeyword.Size = new Size(280, 27);
            txtKeyword.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 28);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Nhà cung cấp";
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvSuppliers);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(19, 115);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(16, 12, 16, 12);
            panelGrid.Size = new Size(1002, 506);
            panelGrid.TabIndex = 1;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.ColumnHeadersHeight = 29;
            dgvSuppliers.Dock = DockStyle.Fill;
            dgvSuppliers.Location = new Point(16, 12);
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersVisible = false;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(970, 482);
            dgvSuppliers.TabIndex = 0;
            dgvSuppliers.CellDoubleClick += dgvSuppliers_CellDoubleClick;
            // 
            // SupplierListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1040, 640);
            Controls.Add(rootLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierListForm";
            Text = "SupplierListForm";
            rootLayout.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }
    }
}
