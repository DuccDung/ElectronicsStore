using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElectronicsStoreSystem.View
{
    partial class MonthlyReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel rootLayout;
        private Panel panelTop;
        private Panel panelGrid;
        private Panel panelFooter;

        private Label lblTitle;

        private Label lblStore;
        private ComboBox cboStore;

        private Label lblMonth;
        private DateTimePicker dtpMonth;

        private Button btnLoad;
        private Button btnExport;

        private DataGridView dgvReport;

        private Label lblTotalRevenueText;
        private Label lblTotalRevenueValue;

        private Label lblTotalProfitText;
        private Label lblTotalProfitValue;

        private Label lblTotalOrdersText;
        private Label lblTotalOrdersValue;

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
            lblStore = new Label();
            cboStore = new ComboBox();
            lblMonth = new Label();
            dtpMonth = new DateTimePicker();
            btnLoad = new Button();
            btnExport = new Button();
            panelGrid = new Panel();
            dgvReport = new DataGridView();
            panelFooter = new Panel();
            lblTotalRevenueText = new Label();
            lblTotalRevenueValue = new Label();
            lblTotalProfitText = new Label();
            lblTotalProfitValue = new Label();
            lblTotalOrdersText = new Label();
            lblTotalOrdersValue = new Label();
            rootLayout.SuspendLayout();
            panelTop.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            rootLayout.Controls.Add(panelTop, 0, 0);
            rootLayout.Controls.Add(panelGrid, 0, 1);
            rootLayout.Controls.Add(panelFooter, 0, 2);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16);
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rootLayout.Size = new Size(1040, 640);
            rootLayout.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(lblStore);
            panelTop.Controls.Add(cboStore);
            panelTop.Controls.Add(lblMonth);
            panelTop.Controls.Add(dtpMonth);
            panelTop.Controls.Add(btnLoad);
            panelTop.Controls.Add(btnExport);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(19, 19);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(16, 12, 16, 12);
            panelTop.Size = new Size(1002, 104);
            panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(411, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Báo cáo doanh thu / lợi nhuận theo tháng";
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(16, 52);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(75, 20);
            lblStore.TabIndex = 1;
            lblStore.Text = "Cửa hàng:";
            // 
            // cboStore
            // 
            cboStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStore.Location = new Point(97, 48);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(313, 28);
            cboStore.TabIndex = 2;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(420, 52);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(53, 20);
            lblMonth.TabIndex = 3;
            lblMonth.Text = "Tháng:";
            // 
            // dtpMonth
            // 
            dtpMonth.Location = new Point(479, 52);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(249, 27);
            dtpMonth.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(734, 48);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 32);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Tải báo cáo";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.FromArgb(28, 28, 40);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(863, 45);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 38);
            btnExport.TabIndex = 6;
            btnExport.Text = "Xuất Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvReport);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(19, 129);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(16, 12, 16, 12);
            panelGrid.Size = new Size(1002, 412);
            panelGrid.TabIndex = 1;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.ColumnHeadersHeight = 32;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(16, 12);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(970, 388);
            dgvReport.TabIndex = 0;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(lblTotalRevenueText);
            panelFooter.Controls.Add(lblTotalRevenueValue);
            panelFooter.Controls.Add(lblTotalProfitText);
            panelFooter.Controls.Add(lblTotalProfitValue);
            panelFooter.Controls.Add(lblTotalOrdersText);
            panelFooter.Controls.Add(lblTotalOrdersValue);
            panelFooter.Dock = DockStyle.Fill;
            panelFooter.Location = new Point(19, 547);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(16, 12, 16, 12);
            panelFooter.Size = new Size(1002, 74);
            panelFooter.TabIndex = 2;
            // 
            // lblTotalRevenueText
            // 
            lblTotalRevenueText.AutoSize = true;
            lblTotalRevenueText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalRevenueText.Location = new Point(19, 24);
            lblTotalRevenueText.Name = "lblTotalRevenueText";
            lblTotalRevenueText.Size = new Size(143, 23);
            lblTotalRevenueText.TabIndex = 0;
            lblTotalRevenueText.Text = "Tổng doanh thu:";
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            lblTotalRevenueValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalRevenueValue.Location = new Point(165, 19);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new Size(24, 28);
            lblTotalRevenueValue.TabIndex = 1;
            lblTotalRevenueValue.Text = "0";
            // 
            // lblTotalProfitText
            // 
            lblTotalProfitText.AutoSize = true;
            lblTotalProfitText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalProfitText.Location = new Point(298, 25);
            lblTotalProfitText.Name = "lblTotalProfitText";
            lblTotalProfitText.Size = new Size(136, 23);
            lblTotalProfitText.TabIndex = 2;
            lblTotalProfitText.Text = "Tổng lợi nhuận:";
            // 
            // lblTotalProfitValue
            // 
            lblTotalProfitValue.AutoSize = true;
            lblTotalProfitValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalProfitValue.Location = new Point(440, 20);
            lblTotalProfitValue.Name = "lblTotalProfitValue";
            lblTotalProfitValue.Size = new Size(24, 28);
            lblTotalProfitValue.TabIndex = 3;
            lblTotalProfitValue.Text = "0";
            lblTotalProfitValue.Click += lblTotalProfitValue_Click;
            // 
            // lblTotalOrdersText
            // 
            lblTotalOrdersText.AutoSize = true;
            lblTotalOrdersText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalOrdersText.Location = new Point(640, 24);
            lblTotalOrdersText.Name = "lblTotalOrdersText";
            lblTotalOrdersText.Size = new Size(115, 23);
            lblTotalOrdersText.TabIndex = 4;
            lblTotalOrdersText.Text = "Tổng số đơn:";
            // 
            // lblTotalOrdersValue
            // 
            lblTotalOrdersValue.AutoSize = true;
            lblTotalOrdersValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalOrdersValue.Location = new Point(761, 20);
            lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            lblTotalOrdersValue.Size = new Size(24, 28);
            lblTotalOrdersValue.TabIndex = 5;
            lblTotalOrdersValue.Text = "0";
            // 
            // MonthlyReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1040, 640);
            Controls.Add(rootLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonthlyReportForm";
            Text = "MonthlyReportForm";
            rootLayout.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }
    }
}
