namespace ElectronicsStoreSystem.View
{
    partial class SupplierEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Label lblCode;
        private TextBox txtCode;

        private Label lblName;
        private TextBox txtName;

        private Label lblPhone;
        private TextBox txtPhone;

        private Label lblEmail;
        private TextBox txtEmail;

        private Label lblTaxCode;
        private TextBox txtTaxCode;

        private Label lblAddress;
        private TextBox txtAddress;

        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();

            lblCode = new Label();
            txtCode = new TextBox();

            lblName = new Label();
            txtName = new TextBox();

            lblPhone = new Label();
            txtPhone = new TextBox();

            lblEmail = new Label();
            txtEmail = new TextBox();

            lblTaxCode = new Label();
            txtTaxCode = new TextBox();

            lblAddress = new Label();
            txtAddress = new TextBox();

            btnSave = new Button();
            btnCancel = new Button();

            SuspendLayout();

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(620, 360);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Supplier";

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(16, 12);
            lblTitle.Text = "Nhà cung cấp";

            int leftLabel = 16, leftInput = 140, top = 60, gap = 40;

            lblCode.AutoSize = true; lblCode.Location = new System.Drawing.Point(leftLabel, top); lblCode.Text = "Mã NCC";
            txtCode.Location = new System.Drawing.Point(leftInput, top - 4); txtCode.Size = new System.Drawing.Size(450, 27);

            top += gap;
            lblName.AutoSize = true; lblName.Location = new System.Drawing.Point(leftLabel, top); lblName.Text = "Tên NCC";
            txtName.Location = new System.Drawing.Point(leftInput, top - 4); txtName.Size = new System.Drawing.Size(450, 27);

            top += gap;
            lblPhone.AutoSize = true; lblPhone.Location = new System.Drawing.Point(leftLabel, top); lblPhone.Text = "SĐT";
            txtPhone.Location = new System.Drawing.Point(leftInput, top - 4); txtPhone.Size = new System.Drawing.Size(450, 27);

            top += gap;
            lblEmail.AutoSize = true; lblEmail.Location = new System.Drawing.Point(leftLabel, top); lblEmail.Text = "Email";
            txtEmail.Location = new System.Drawing.Point(leftInput, top - 4); txtEmail.Size = new System.Drawing.Size(450, 27);

            top += gap;
            lblTaxCode.AutoSize = true; lblTaxCode.Location = new System.Drawing.Point(leftLabel, top); lblTaxCode.Text = "MST";
            txtTaxCode.Location = new System.Drawing.Point(leftInput, top - 4); txtTaxCode.Size = new System.Drawing.Size(450, 27);

            top += gap;
            lblAddress.AutoSize = true; lblAddress.Location = new System.Drawing.Point(leftLabel, top); lblAddress.Text = "Địa chỉ";
            txtAddress.Location = new System.Drawing.Point(leftInput, top - 4);
            txtAddress.Size = new System.Drawing.Size(450, 27);

            btnSave.BackColor = System.Drawing.Color.FromArgb(28, 28, 40);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(400, 300);
            btnSave.Size = new System.Drawing.Size(90, 36);
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            btnCancel.Location = new System.Drawing.Point(500, 300);
            btnCancel.Size = new System.Drawing.Size(90, 36);
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;

            Controls.Add(lblTitle);
            Controls.Add(lblCode); Controls.Add(txtCode);
            Controls.Add(lblName); Controls.Add(txtName);
            Controls.Add(lblPhone); Controls.Add(txtPhone);
            Controls.Add(lblEmail); Controls.Add(txtEmail);
            Controls.Add(lblTaxCode); Controls.Add(txtTaxCode);
            Controls.Add(lblAddress); Controls.Add(txtAddress);
            Controls.Add(btnSave); Controls.Add(btnCancel);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
