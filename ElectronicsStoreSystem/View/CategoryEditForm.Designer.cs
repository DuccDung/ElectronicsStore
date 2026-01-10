namespace ElectronicsStoreSystem.View
{
    partial class CategoryEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.ComboBox cboParent;

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
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();

            lblParent = new Label();
            cboParent = new ComboBox();

            btnSave = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // form
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(520, 220);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Category";

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(16, 12);
            lblTitle.Text = "Danh mục";

            // lblName
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(16, 60);
            lblName.Text = "Tên danh mục";

            // txtName
            txtName.Location = new System.Drawing.Point(140, 56);
            txtName.Size = new System.Drawing.Size(350, 27);

            // lblParent
            lblParent.AutoSize = true;
            lblParent.Location = new System.Drawing.Point(16, 100);
            lblParent.Text = "Danh mục cha";

            // cboParent
            cboParent.DropDownStyle = ComboBoxStyle.DropDownList;
            cboParent.Location = new System.Drawing.Point(140, 96);
            cboParent.Size = new System.Drawing.Size(350, 28);

            // btnSave
            btnSave.BackColor = System.Drawing.Color.FromArgb(28, 28, 40);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(300, 150);
            btnSave.Size = new System.Drawing.Size(90, 36);
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // btnCancel
            btnCancel.Location = new System.Drawing.Point(400, 150);
            btnCancel.Size = new System.Drawing.Size(90, 36);
            btnCancel.Text = "Hủy";
            btnCancel.Click += btnCancel_Click;

            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblParent);
            Controls.Add(cboParent);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
