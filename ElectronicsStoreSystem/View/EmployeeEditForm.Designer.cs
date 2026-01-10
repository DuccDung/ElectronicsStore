namespace ElectronicsStoreSystem.View
{
    partial class EmployeeEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;

        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.ComboBox cboStore;

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Label lblBaseSalary;
        private System.Windows.Forms.TextBox txtBaseSalary;

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
            this.lblTitle = new System.Windows.Forms.Label();

            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();

            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();

            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();

            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();

            this.lblStore = new System.Windows.Forms.Label();
            this.cboStore = new System.Windows.Forms.ComboBox();

            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();

            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.lblBaseSalary = new System.Windows.Forms.Label();
            this.txtBaseSalary = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // EmployeeEditForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Employee";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(16, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhân viên";

            int leftLabel = 16;
            int leftInput = 160;
            int top = 60;
            int gap = 34;

            // lblCode
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(leftLabel, top);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 20);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Mã NV";
            // txtCode
            this.txtCode.Location = new System.Drawing.Point(leftInput, top - 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(520, 27);
            this.txtCode.TabIndex = 2;

            top += gap;

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(leftLabel, top);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(53, 20);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Họ tên";
            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(leftInput, top - 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(520, 27);
            this.txtFullName.TabIndex = 4;

            top += gap;

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(leftLabel, top);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(leftInput, top - 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(520, 27);
            this.txtUsername.TabIndex = 6;

            top += gap;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(leftLabel, top);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Mật khẩu";
            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(leftInput, top - 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(520, 27);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;

            top += gap;

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(leftLabel, top);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(55, 20);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Vai trò";
            // cboRole
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Location = new System.Drawing.Point(leftInput, top - 4);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(520, 28);
            this.cboRole.TabIndex = 10;

            top += gap;

            // lblStore
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(leftLabel, top);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(72, 20);
            this.lblStore.TabIndex = 11;
            this.lblStore.Text = "Cửa hàng";
            // cboStore
            this.cboStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStore.Location = new System.Drawing.Point(leftInput, top - 4);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(520, 28);
            this.cboStore.TabIndex = 12;

            top += gap;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(leftLabel, top);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(36, 20);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "SĐT";
            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(leftInput, top - 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(520, 27);
            this.txtPhone.TabIndex = 14;

            top += gap;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(leftLabel, top);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(leftInput, top - 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(520, 27);
            this.txtEmail.TabIndex = 16;

            top += gap;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(leftLabel, top);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 20);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Địa chỉ";
            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(leftInput, top - 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(520, 27);
            this.txtAddress.TabIndex = 18;

            top += gap;

            // lblBaseSalary
            this.lblBaseSalary.AutoSize = true;
            this.lblBaseSalary.Location = new System.Drawing.Point(leftLabel, top);
            this.lblBaseSalary.Name = "lblBaseSalary";
            this.lblBaseSalary.Size = new System.Drawing.Size(96, 20);
            this.lblBaseSalary.TabIndex = 19;
            this.lblBaseSalary.Text = "Lương cơ bản";
            // txtBaseSalary
            this.txtBaseSalary.Location = new System.Drawing.Point(leftInput, top - 4);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(520, 27);
            this.txtBaseSalary.TabIndex = 20;

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(28, 28, 40);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(500, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 36);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(600, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Controls
            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);

            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);

            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);

            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);

            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cboRole);

            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.cboStore);

            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);

            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);

            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);

            this.Controls.Add(this.lblBaseSalary);
            this.Controls.Add(this.txtBaseSalary);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
