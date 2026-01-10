namespace ElectronicsStoreSystem.View
{
    partial class ProductCreateForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.NumericUpDown nudWarrantyMonths;
        private System.Windows.Forms.CheckBox chkIsSerialized;
        private System.Windows.Forms.CheckBox chkProductActive;

        private System.Windows.Forms.GroupBox grpSku;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblSkuCode;
        private System.Windows.Forms.TextBox txtSkuCode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.NumericUpDown nudVatRate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown nudCostPrice;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.NumericUpDown nudSalePrice;
        private System.Windows.Forms.Label lblSpecJson;
        private System.Windows.Forms.TextBox txtSpecJson;
        private System.Windows.Forms.CheckBox chkSkuActive;

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            rootLayout = new TableLayoutPanel();
            panelHeader = new Panel();
            lblTitle = new Label();
            grpProduct = new GroupBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblBrand = new Label();
            cboBrand = new ComboBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblWarranty = new Label();
            nudWarrantyMonths = new NumericUpDown();
            chkIsSerialized = new CheckBox();
            chkProductActive = new CheckBox();
            grpSku = new GroupBox();
            lblUnit = new Label();
            cboUnit = new ComboBox();
            lblSkuCode = new Label();
            txtSkuCode = new TextBox();
            lblBarcode = new Label();
            txtBarcode = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblColor = new Label();
            txtColor = new TextBox();
            lblVat = new Label();
            nudVatRate = new NumericUpDown();
            lblCost = new Label();
            nudCostPrice = new NumericUpDown();
            lblSale = new Label();
            nudSalePrice = new NumericUpDown();
            lblSpecJson = new Label();
            txtSpecJson = new TextBox();
            chkSkuActive = new CheckBox();
            panelFooter = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            rootLayout.SuspendLayout();
            panelHeader.SuspendLayout();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWarrantyMonths).BeginInit();
            grpSku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVatRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCostPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rootLayout.Controls.Add(panelHeader, 0, 0);
            rootLayout.Controls.Add(grpProduct, 0, 1);
            rootLayout.Controls.Add(grpSku, 0, 2);
            rootLayout.Controls.Add(panelFooter, 0, 3);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16);
            rootLayout.RowCount = 4;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            rootLayout.Size = new Size(831, 720);
            rootLayout.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(19, 19);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(16, 10, 16, 10);
            panelHeader.Size = new Size(793, 54);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(761, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm sản phẩm";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpProduct
            // 
            grpProduct.BackColor = Color.White;
            grpProduct.Controls.Add(lblCategory);
            grpProduct.Controls.Add(cboCategory);
            grpProduct.Controls.Add(lblBrand);
            grpProduct.Controls.Add(cboBrand);
            grpProduct.Controls.Add(lblProductName);
            grpProduct.Controls.Add(txtProductName);
            grpProduct.Controls.Add(lblDescription);
            grpProduct.Controls.Add(txtDescription);
            grpProduct.Controls.Add(lblWarranty);
            grpProduct.Controls.Add(nudWarrantyMonths);
            grpProduct.Controls.Add(chkIsSerialized);
            grpProduct.Controls.Add(chkProductActive);
            grpProduct.Dock = DockStyle.Fill;
            grpProduct.Location = new Point(19, 79);
            grpProduct.Name = "grpProduct";
            grpProduct.Size = new Size(793, 273);
            grpProduct.TabIndex = 1;
            grpProduct.TabStop = false;
            grpProduct.Text = "Thông tin Product";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 35);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Danh mục";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(120, 32);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(260, 28);
            cboCategory.TabIndex = 1;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(420, 35);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(45, 20);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Hãng";
            // 
            // cboBrand
            // 
            cboBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBrand.Location = new Point(480, 32);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(260, 28);
            cboBrand.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(20, 75);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 20);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(120, 72);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(620, 27);
            txtProductName.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 115);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(48, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 112);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(620, 70);
            txtDescription.TabIndex = 7;
            // 
            // lblWarranty
            // 
            lblWarranty.AutoSize = true;
            lblWarranty.Location = new Point(20, 195);
            lblWarranty.Name = "lblWarranty";
            lblWarranty.Size = new Size(123, 20);
            lblWarranty.TabIndex = 8;
            lblWarranty.Text = "Bảo hành (tháng)";
            // 
            // nudWarrantyMonths
            // 
            nudWarrantyMonths.Location = new Point(160, 192);
            nudWarrantyMonths.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudWarrantyMonths.Name = "nudWarrantyMonths";
            nudWarrantyMonths.Size = new Size(90, 27);
            nudWarrantyMonths.TabIndex = 9;
            // 
            // chkIsSerialized
            // 
            chkIsSerialized.AutoSize = true;
            chkIsSerialized.Location = new Point(280, 194);
            chkIsSerialized.Name = "chkIsSerialized";
            chkIsSerialized.Size = new Size(211, 24);
            chkIsSerialized.TabIndex = 10;
            chkIsSerialized.Text = "Quản lý Serial (IsSerialized)";
            // 
            // chkProductActive
            // 
            chkProductActive.AutoSize = true;
            chkProductActive.Location = new Point(520, 194);
            chkProductActive.Name = "chkProductActive";
            chkProductActive.Size = new Size(259, 24);
            chkProductActive.TabIndex = 11;
            chkProductActive.Text = "Đang hoạt động (Product.IsActive)";
            // 
            // grpSku
            // 
            grpSku.BackColor = Color.White;
            grpSku.Controls.Add(lblUnit);
            grpSku.Controls.Add(cboUnit);
            grpSku.Controls.Add(lblSkuCode);
            grpSku.Controls.Add(txtSkuCode);
            grpSku.Controls.Add(lblBarcode);
            grpSku.Controls.Add(txtBarcode);
            grpSku.Controls.Add(lblModel);
            grpSku.Controls.Add(txtModel);
            grpSku.Controls.Add(lblColor);
            grpSku.Controls.Add(txtColor);
            grpSku.Controls.Add(lblVat);
            grpSku.Controls.Add(nudVatRate);
            grpSku.Controls.Add(lblCost);
            grpSku.Controls.Add(nudCostPrice);
            grpSku.Controls.Add(lblSale);
            grpSku.Controls.Add(nudSalePrice);
            grpSku.Controls.Add(lblSpecJson);
            grpSku.Controls.Add(txtSpecJson);
            grpSku.Controls.Add(chkSkuActive);
            grpSku.Dock = DockStyle.Fill;
            grpSku.Location = new Point(19, 358);
            grpSku.Name = "grpSku";
            grpSku.Size = new Size(793, 273);
            grpSku.TabIndex = 2;
            grpSku.TabStop = false;
            grpSku.Text = "Thông tin ProductSKU";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(20, 35);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(52, 20);
            lblUnit.TabIndex = 0;
            lblUnit.Text = "Đơn vị";
            // 
            // cboUnit
            // 
            cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit.Location = new Point(120, 32);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(260, 28);
            cboUnit.TabIndex = 1;
            // 
            // lblSkuCode
            // 
            lblSkuCode.AutoSize = true;
            lblSkuCode.Location = new Point(420, 35);
            lblSkuCode.Name = "lblSkuCode";
            lblSkuCode.Size = new Size(71, 20);
            lblSkuCode.TabIndex = 2;
            lblSkuCode.Text = "SKUCode";
            // 
            // txtSkuCode
            // 
            txtSkuCode.Location = new Point(497, 32);
            txtSkuCode.Name = "txtSkuCode";
            txtSkuCode.Size = new Size(243, 27);
            txtSkuCode.TabIndex = 3;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(20, 75);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(64, 20);
            lblBarcode.TabIndex = 4;
            lblBarcode.Text = "Barcode";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(120, 72);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(260, 27);
            txtBarcode.TabIndex = 5;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(420, 75);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(497, 72);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(243, 27);
            txtModel.TabIndex = 7;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(20, 115);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(38, 20);
            lblColor.TabIndex = 8;
            lblColor.Text = "Màu";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(120, 112);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(260, 27);
            txtColor.TabIndex = 9;
            // 
            // lblVat
            // 
            lblVat.AutoSize = true;
            lblVat.Location = new Point(420, 115);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(90, 20);
            lblVat.TabIndex = 10;
            lblVat.Text = "VATRate (%)";
            // 
            // nudVatRate
            // 
            nudVatRate.DecimalPlaces = 2;
            nudVatRate.Location = new Point(520, 112);
            nudVatRate.Name = "nudVatRate";
            nudVatRate.Size = new Size(120, 27);
            nudVatRate.TabIndex = 11;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(20, 155);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(70, 20);
            lblCost.TabIndex = 12;
            lblCost.Text = "CostPrice";
            // 
            // nudCostPrice
            // 
            nudCostPrice.Location = new Point(120, 152);
            nudCostPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudCostPrice.Name = "nudCostPrice";
            nudCostPrice.Size = new Size(260, 27);
            nudCostPrice.TabIndex = 13;
            nudCostPrice.ThousandsSeparator = true;
            // 
            // lblSale
            // 
            lblSale.AutoSize = true;
            lblSale.Location = new Point(420, 155);
            lblSale.Name = "lblSale";
            lblSale.Size = new Size(69, 20);
            lblSale.TabIndex = 14;
            lblSale.Text = "SalePrice";
            // 
            // nudSalePrice
            // 
            nudSalePrice.Location = new Point(520, 152);
            nudSalePrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudSalePrice.Name = "nudSalePrice";
            nudSalePrice.Size = new Size(220, 27);
            nudSalePrice.TabIndex = 15;
            nudSalePrice.ThousandsSeparator = true;
            // 
            // lblSpecJson
            // 
            lblSpecJson.AutoSize = true;
            lblSpecJson.Location = new Point(20, 195);
            lblSpecJson.Name = "lblSpecJson";
            lblSpecJson.Size = new Size(69, 20);
            lblSpecJson.TabIndex = 16;
            lblSpecJson.Text = "SpecJson";
            // 
            // txtSpecJson
            // 
            txtSpecJson.Location = new Point(120, 192);
            txtSpecJson.Multiline = true;
            txtSpecJson.Name = "txtSpecJson";
            txtSpecJson.Size = new Size(620, 55);
            txtSpecJson.TabIndex = 17;
            // 
            // chkSkuActive
            // 
            chkSkuActive.AutoSize = true;
            chkSkuActive.Location = new Point(16, 249);
            chkSkuActive.Name = "chkSkuActive";
            chkSkuActive.Size = new Size(235, 24);
            chkSkuActive.TabIndex = 18;
            chkSkuActive.Text = "Đang hoạt động (SKU.IsActive)";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(btnCancel);
            panelFooter.Controls.Add(btnSave);
            panelFooter.Dock = DockStyle.Fill;
            panelFooter.Location = new Point(19, 637);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(16, 12, 16, 12);
            panelFooter.Size = new Size(793, 64);
            panelFooter.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(650, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(28, 28, 40);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(504, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ProductCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(831, 720);
            Controls.Add(rootLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductCreateForm";
            rootLayout.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWarrantyMonths).EndInit();
            grpSku.ResumeLayout(false);
            grpSku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudVatRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCostPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).EndInit();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
