
namespace ElectronicsStoreSystem.View
{
    partial class DashBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPurchase;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEmployee = new Button();
            btnPurchase = new Button();
            btnSuppliers = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            lblTitle = new Label();
            panelTop = new Panel();
            btnClose = new Button();
            panelContent = new Panel();
            panel1.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 40);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnPurchase);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnCategories);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 15, 10, 15);
            panel1.Size = new Size(268, 841);
            panel1.TabIndex = 2;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(28, 28, 40);
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(10, 365);
            btnEmployee.Margin = new Padding(3, 4, 3, 4);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(248, 55);
            btnEmployee.TabIndex = 5;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.FromArgb(28, 28, 40);
            btnPurchase.Dock = DockStyle.Top;
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Location = new Point(10, 310);
            btnPurchase.Margin = new Padding(3, 4, 3, 4);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(248, 55);
            btnPurchase.TabIndex = 4;
            btnPurchase.Text = "  Nhập hàng";
            btnPurchase.TextAlign = ContentAlignment.MiddleLeft;
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.FromArgb(28, 28, 40);
            btnSuppliers.Dock = DockStyle.Top;
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(10, 255);
            btnSuppliers.Margin = new Padding(3, 4, 3, 4);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(248, 55);
            btnSuppliers.TabIndex = 0;
            btnSuppliers.Text = "  Nhà cung cấp";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(28, 28, 40);
            btnCategories.Dock = DockStyle.Top;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(10, 200);
            btnCategories.Margin = new Padding(3, 4, 3, 4);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(248, 55);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "  Danh mục";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(28, 28, 40);
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(10, 145);
            btnProducts.Margin = new Padding(3, 4, 3, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(248, 55);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "  Sản phẩm";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(28, 28, 40);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 90);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(248, 55);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(248, 75);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Electronics Store";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(btnClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(268, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(16, 12, 16, 12);
            panelTop.Size = new Size(866, 75);
            panelTop.TabIndex = 1;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(769, 12);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(81, 51);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(245, 246, 250);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(268, 75);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(866, 766);
            panelContent.TabIndex = 0;
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 841);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Electronics Store - Dashboard";
            panel1.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ResumeLayout(false);

        }



        #endregion

        private Button btnEmployee;
    }
}