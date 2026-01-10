namespace ElectronicsStoreSystem.View
{
    partial class ProductPickerForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvProducts;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblHint;

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
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            panelGrid = new Panel();
            dgvProducts = new DataGridView();
            SkuID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CostPrice = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            panelBottom = new Panel();
            txtQtyPdt = new TextBox();
            btnNewProduct = new Button();
            lblHint = new Label();
            btnSelect = new Button();
            rootLayout.SuspendLayout();
            panelTop.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rootLayout.Controls.Add(panelTop, 0, 0);
            rootLayout.Controls.Add(panelGrid, 0, 1);
            rootLayout.Controls.Add(panelBottom, 0, 2);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16);
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            rootLayout.Size = new Size(737, 560);
            rootLayout.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(btnRefresh);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(19, 19);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(16, 12, 16, 12);
            panelTop.Size = new Size(699, 74);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(284, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Chọn sản phẩm (SKU/Model)";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(16, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo SKUCode / Barcode / Model / Tên sản phẩm...";
            txtSearch.Size = new Size(495, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(526, 40);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 30);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Tìm kiếm";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvProducts);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(19, 99);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(16, 12, 16, 12);
            panelGrid.Size = new Size(699, 372);
            panelGrid.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeight = 32;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { SkuID, ProductID, ProductName, CostPrice, SalePrice });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(16, 12);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(667, 348);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // SkuID
            // 
            SkuID.DataPropertyName = "SkuID";
            SkuID.HeaderText = "SkuID";
            SkuID.MinimumWidth = 6;
            SkuID.Name = "SkuID";
            SkuID.ReadOnly = true;
            // 
            // ProductID
            // 
            ProductID.DataPropertyName = "ProductID";
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // CostPrice
            // 
            CostPrice.DataPropertyName = "CostPrice";
            CostPrice.HeaderText = "CostPrice";
            CostPrice.MinimumWidth = 6;
            CostPrice.Name = "CostPrice";
            CostPrice.ReadOnly = true;
            // 
            // SalePrice
            // 
            SalePrice.DataPropertyName = "SalePrice";
            SalePrice.HeaderText = "SalePrice";
            SalePrice.MinimumWidth = 6;
            SalePrice.Name = "SalePrice";
            SalePrice.ReadOnly = true;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(txtQtyPdt);
            panelBottom.Controls.Add(btnNewProduct);
            panelBottom.Controls.Add(lblHint);
            panelBottom.Controls.Add(btnSelect);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(19, 477);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(16, 12, 16, 12);
            panelBottom.Size = new Size(699, 64);
            panelBottom.TabIndex = 2;
            // 
            // txtQtyPdt
            // 
            txtQtyPdt.Location = new Point(135, 19);
            txtQtyPdt.Name = "txtQtyPdt";
            txtQtyPdt.Size = new Size(89, 27);
            txtQtyPdt.TabIndex = 4;
            // 
            // btnNewProduct
            // 
            btnNewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewProduct.BackColor = Color.FromArgb(28, 28, 40);
            btnNewProduct.FlatAppearance.BorderSize = 0;
            btnNewProduct.FlatStyle = FlatStyle.Flat;
            btnNewProduct.ForeColor = Color.White;
            btnNewProduct.Location = new Point(398, 15);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(145, 40);
            btnNewProduct.TabIndex = 3;
            btnNewProduct.Text = "Thêm Sản Phẩm";
            btnNewProduct.UseVisualStyleBackColor = false;
            btnNewProduct.Click += btnNewProduct_Click;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new Point(19, 22);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(110, 20);
            lblHint.TabIndex = 0;
            lblHint.Text = "Nhập số lượng:";
            lblHint.Click += lblHint_Click;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.BackColor = Color.FromArgb(28, 28, 40);
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(563, 15);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(120, 40);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Chọn";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // ProductPickerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(737, 560);
            Controls.Add(rootLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductPickerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductPickerForm";
            rootLayout.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }
        private Button btnNewProduct;
        private DataGridViewTextBoxColumn SkuID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CostPrice;
        private DataGridViewTextBoxColumn SalePrice;
        private TextBox txtQtyPdt;
    }
}
