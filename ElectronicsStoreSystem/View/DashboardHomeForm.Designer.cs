using System.Windows.Forms;
using System.Drawing;

namespace ElectronicsStoreSystem.View
{
    partial class DashboardHomeForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel rootLayout;

        private Panel panelKpi;
        private Label lblKpiTitle;
        private Label lblRevenueText;
        private Label lblRevenueValue;
        private Label lblProfitText;
        private Label lblProfitValue;
        private Label lblOrdersText;
        private Label lblOrdersValue;
        private Label lblLowStockText;
        private Label lblLowStockValue;

        private Panel panelPos;

        private SplitContainer splitPos;

        // LEFT: Products
        private Panel panelLeft;
        private Label lblPosTitle;
        private Label lblStore;
        private ComboBox cboStore;

        private Label lblCategory;
        private ComboBox cboCategory;

        private Label lblBrand;
        private ComboBox cboBrand;

        private TextBox txtKeyword;
        private Button btnSearch;

        private DataGridView dgvProducts;

        // RIGHT: Cart + Checkout
        private Panel panelRight;
        private Label lblCartTitle;
        private DataGridView dgvCart;

        private Panel panelCheckout;
        private Label lblPaymentMethod;
        private ComboBox cboPaymentMethod;

        private Label lblCartTotalText;
        private Label lblCartTotalValue;

        private Button btnClearCart;
        private Button btnCheckout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            rootLayout = new TableLayoutPanel();
            panelKpi = new Panel();
            lblKpiTitle = new Label();
            lblRevenueText = new Label();
            lblRevenueValue = new Label();
            lblProfitText = new Label();
            lblProfitValue = new Label();
            lblOrdersText = new Label();
            lblOrdersValue = new Label();
            lblLowStockText = new Label();
            lblLowStockValue = new Label();
            panelPos = new Panel();
            splitPos = new SplitContainer();
            panelLeft = new Panel();
            label1 = new Label();
            lblPosTitle = new Label();
            lblStore = new Label();
            cboStore = new ComboBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblBrand = new Label();
            cboBrand = new ComboBox();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            panelRight = new Panel();
            lblCartTitle = new Label();
            dgvCart = new DataGridView();
            panelCheckout = new Panel();
            lblPaymentMethod = new Label();
            cboPaymentMethod = new ComboBox();
            lblCartTotalText = new Label();
            lblCartTotalValue = new Label();
            btnClearCart = new Button();
            btnCheckout = new Button();
            rootLayout.SuspendLayout();
            panelKpi.SuspendLayout();
            panelPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitPos).BeginInit();
            splitPos.Panel1.SuspendLayout();
            splitPos.Panel2.SuspendLayout();
            splitPos.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panelCheckout.SuspendLayout();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            rootLayout.Controls.Add(panelKpi, 0, 0);
            rootLayout.Controls.Add(panelPos, 0, 1);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16);
            rootLayout.RowCount = 2;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.Size = new Size(866, 766);
            rootLayout.TabIndex = 0;
            // 
            // panelKpi
            // 
            panelKpi.BackColor = Color.White;
            panelKpi.Controls.Add(lblKpiTitle);
            panelKpi.Controls.Add(lblRevenueText);
            panelKpi.Controls.Add(lblRevenueValue);
            panelKpi.Controls.Add(lblProfitText);
            panelKpi.Controls.Add(lblProfitValue);
            panelKpi.Controls.Add(lblOrdersText);
            panelKpi.Controls.Add(lblOrdersValue);
            panelKpi.Controls.Add(lblLowStockText);
            panelKpi.Controls.Add(lblLowStockValue);
            panelKpi.Dock = DockStyle.Fill;
            panelKpi.Location = new Point(19, 19);
            panelKpi.Name = "panelKpi";
            panelKpi.Padding = new Padding(16, 12, 16, 12);
            panelKpi.Size = new Size(828, 104);
            panelKpi.TabIndex = 0;
            // 
            // lblKpiTitle
            // 
            lblKpiTitle.AutoSize = true;
            lblKpiTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKpiTitle.Location = new Point(16, 10);
            lblKpiTitle.Name = "lblKpiTitle";
            lblKpiTitle.Size = new Size(114, 28);
            lblKpiTitle.TabIndex = 0;
            lblKpiTitle.Text = "Dashboard";
            // 
            // lblRevenueText
            // 
            lblRevenueText.AutoSize = true;
            lblRevenueText.Location = new Point(16, 48);
            lblRevenueText.Name = "lblRevenueText";
            lblRevenueText.Size = new Size(142, 20);
            lblRevenueText.TabIndex = 1;
            lblRevenueText.Text = "Doanh thu hôm nay:";
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRevenueValue.Location = new Point(154, 48);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(20, 23);
            lblRevenueValue.TabIndex = 2;
            lblRevenueValue.Text = "0";
            // 
            // lblProfitText
            // 
            lblProfitText.AutoSize = true;
            lblProfitText.Location = new Point(244, 48);
            lblProfitText.Name = "lblProfitText";
            lblProfitText.Size = new Size(76, 20);
            lblProfitText.TabIndex = 3;
            lblProfitText.Text = "Lợi nhuận:";
            // 
            // lblProfitValue
            // 
            lblProfitValue.AutoSize = true;
            lblProfitValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfitValue.Location = new Point(326, 47);
            lblProfitValue.Name = "lblProfitValue";
            lblProfitValue.Size = new Size(20, 23);
            lblProfitValue.TabIndex = 4;
            lblProfitValue.Text = "0";
            lblProfitValue.Click += lblProfitValue_Click;
            // 
            // lblOrdersText
            // 
            lblOrdersText.AutoSize = true;
            lblOrdersText.Location = new Point(462, 50);
            lblOrdersText.Name = "lblOrdersText";
            lblOrdersText.Size = new Size(120, 20);
            lblOrdersText.TabIndex = 5;
            lblOrdersText.Text = "Số đơn hôm nay:";
            // 
            // lblOrdersValue
            // 
            lblOrdersValue.AutoSize = true;
            lblOrdersValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrdersValue.Location = new Point(591, 48);
            lblOrdersValue.Name = "lblOrdersValue";
            lblOrdersValue.Size = new Size(20, 23);
            lblOrdersValue.TabIndex = 6;
            lblOrdersValue.Text = "0";
            // 
            // lblLowStockText
            // 
            lblLowStockText.AutoSize = true;
            lblLowStockText.Location = new Point(683, 51);
            lblLowStockText.Name = "lblLowStockText";
            lblLowStockText.Size = new Size(91, 20);
            lblLowStockText.TabIndex = 7;
            lblLowStockText.Text = "SKU sắp hết:";
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLowStockValue.Location = new Point(780, 51);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(20, 23);
            lblLowStockValue.TabIndex = 8;
            lblLowStockValue.Text = "0";
            // 
            // panelPos
            // 
            panelPos.BackColor = Color.Transparent;
            panelPos.Controls.Add(splitPos);
            panelPos.Dock = DockStyle.Fill;
            panelPos.Location = new Point(19, 129);
            panelPos.Name = "panelPos";
            panelPos.Size = new Size(828, 618);
            panelPos.TabIndex = 1;
            // 
            // splitPos
            // 
            splitPos.Dock = DockStyle.Fill;
            splitPos.Location = new Point(0, 0);
            splitPos.Name = "splitPos";
            // 
            // splitPos.Panel1
            // 
            splitPos.Panel1.BackColor = Color.White;
            splitPos.Panel1.Controls.Add(panelLeft);
            // 
            // splitPos.Panel2
            // 
            splitPos.Panel2.BackColor = Color.White;
            splitPos.Panel2.Controls.Add(panelRight);
            splitPos.Size = new Size(828, 618);
            splitPos.SplitterDistance = 442;
            splitPos.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(lblPosTitle);
            panelLeft.Controls.Add(lblStore);
            panelLeft.Controls.Add(cboStore);
            panelLeft.Controls.Add(lblCategory);
            panelLeft.Controls.Add(cboCategory);
            panelLeft.Controls.Add(lblBrand);
            panelLeft.Controls.Add(cboBrand);
            panelLeft.Controls.Add(txtKeyword);
            panelLeft.Controls.Add(btnSearch);
            panelLeft.Controls.Add(dgvProducts);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(16, 12, 16, 12);
            panelLeft.Size = new Size(442, 618);
            panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 153);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 10;
            label1.Text = "Tìm kiếm:";
            // 
            // lblPosTitle
            // 
            lblPosTitle.AutoSize = true;
            lblPosTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPosTitle.Location = new Point(16, 10);
            lblPosTitle.Name = "lblPosTitle";
            lblPosTitle.Size = new Size(202, 25);
            lblPosTitle.TabIndex = 0;
            lblPosTitle.Text = "Bán hàng - Sản phẩm";
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(16, 80);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(75, 20);
            lblStore.TabIndex = 1;
            lblStore.Text = "Cửa hàng:";
            // 
            // cboStore
            // 
            cboStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStore.Location = new Point(94, 80);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(180, 28);
            cboStore.TabIndex = 2;
            cboStore.SelectedIndexChanged += cboStore_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(9, 117);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Danh mục:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(94, 114);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(180, 28);
            cboCategory.TabIndex = 4;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(16, 46);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(48, 20);
            lblBrand.TabIndex = 5;
            lblBrand.Text = "Hãng:";
            // 
            // cboBrand
            // 
            cboBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBrand.Location = new Point(94, 43);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(180, 28);
            cboBrand.TabIndex = 6;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(94, 153);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(180, 27);
            txtKeyword.TabIndex = 7;
            txtKeyword.TextChanged += txtKeyword_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(302, 89);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 32);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm / Lọc";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeight = 29;
            dgvProducts.Location = new Point(16, 236);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(385, 942);
            dgvProducts.TabIndex = 9;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(lblCartTitle);
            panelRight.Controls.Add(dgvCart);
            panelRight.Controls.Add(panelCheckout);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(16, 12, 16, 12);
            panelRight.Size = new Size(382, 618);
            panelRight.TabIndex = 0;
            // 
            // lblCartTitle
            // 
            lblCartTitle.AutoSize = true;
            lblCartTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCartTitle.Location = new Point(16, 10);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(93, 25);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "Giỏ hàng";
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeight = 29;
            dgvCart.Location = new Point(16, 46);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(363, 340);
            dgvCart.TabIndex = 1;
            dgvCart.CellEndEdit += dgvCart_CellEndEdit;
            // 
            // panelCheckout
            // 
            panelCheckout.BackColor = Color.White;
            panelCheckout.Controls.Add(lblPaymentMethod);
            panelCheckout.Controls.Add(cboPaymentMethod);
            panelCheckout.Controls.Add(lblCartTotalText);
            panelCheckout.Controls.Add(lblCartTotalValue);
            panelCheckout.Controls.Add(btnClearCart);
            panelCheckout.Controls.Add(btnCheckout);
            panelCheckout.Dock = DockStyle.Bottom;
            panelCheckout.Location = new Point(16, 446);
            panelCheckout.Name = "panelCheckout";
            panelCheckout.Padding = new Padding(12);
            panelCheckout.Size = new Size(350, 160);
            panelCheckout.TabIndex = 2;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(12, 14);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(86, 20);
            lblPaymentMethod.TabIndex = 0;
            lblPaymentMethod.Text = "Thanh toán:";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.Location = new Point(98, 10);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(210, 28);
            cboPaymentMethod.TabIndex = 1;
            // 
            // lblCartTotalText
            // 
            lblCartTotalText.AutoSize = true;
            lblCartTotalText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCartTotalText.Location = new Point(12, 52);
            lblCartTotalText.Name = "lblCartTotalText";
            lblCartTotalText.Size = new Size(92, 23);
            lblCartTotalText.TabIndex = 2;
            lblCartTotalText.Text = "Tổng tiền:";
            // 
            // lblCartTotalValue
            // 
            lblCartTotalValue.AutoSize = true;
            lblCartTotalValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCartTotalValue.Location = new Point(98, 48);
            lblCartTotalValue.Name = "lblCartTotalValue";
            lblCartTotalValue.Size = new Size(24, 28);
            lblCartTotalValue.TabIndex = 3;
            lblCartTotalValue.Text = "0";
            // 
            // btnClearCart
            // 
            btnClearCart.Location = new Point(12, 96);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(110, 40);
            btnClearCart.TabIndex = 4;
            btnClearCart.Text = "Xóa giỏ";
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(28, 28, 40);
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(198, 96);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(110, 40);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Thanh toán";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // DashboardHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(866, 766);
            Controls.Add(rootLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardHomeForm";
            Text = "DashboardHomeForm";
            rootLayout.ResumeLayout(false);
            panelKpi.ResumeLayout(false);
            panelKpi.PerformLayout();
            panelPos.ResumeLayout(false);
            splitPos.Panel1.ResumeLayout(false);
            splitPos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitPos).EndInit();
            splitPos.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panelCheckout.ResumeLayout(false);
            panelCheckout.PerformLayout();
            ResumeLayout(false);
        }
        private Label label1;
    }
}
