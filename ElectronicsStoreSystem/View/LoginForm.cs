using ElectronicsStoreSystem.Model;
using ElectronicsStoreSystem.Utils;
using ElectronicsStoreSystem.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElectronicsStoreSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();  
            BuildUI();              
        }

        private void BuildUI()
        {
            // ===== Form =====
            this.Text = "Electronics Store - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(900, 520);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.BackColor = Color.FromArgb(245, 246, 250);
            this.Controls.Clear();

            // ===== Left Sidebar =====
            var panelLeft = new Panel
            {
                Dock = DockStyle.Left,
                Width = 320,
                BackColor = Color.FromArgb(28, 28, 40),
                Padding = new Padding(24, 24, 24, 24)
            };

            var lblBrand = new Label
            {
                Dock = DockStyle.Top,
                Height = 60,
                Text = "Electronics Store",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblSubtitle = new Label
            {
                Dock = DockStyle.Top,
                Height = 70,
                Text = "Quản lý sản phẩm",
                ForeColor = Color.FromArgb(200, 200, 210),
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft
            };

            panelLeft.Controls.Add(lblSubtitle);
            panelLeft.Controls.Add(lblBrand);

            // ===== Right Content =====
            var panelRight = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 246, 250)
            };

            // ===== Card Login =====
            var card = new Panel
            {
                Size = new Size(420, 320),
                BackColor = Color.White
            };

            // Căn giữa card theo panelRight
            panelRight.Controls.Add(card);
            panelRight.Resize += (s, e) =>
            {
                card.Left = (panelRight.ClientSize.Width - card.Width) / 2;
                card.Top = (panelRight.ClientSize.Height - card.Height) / 2;
            };

            // Title
            var lblLoginTitle = new Label
            {
                AutoSize = false,
                Location = new Point(28, 22),
                Size = new Size(360, 32),
                Text = "Đăng nhập",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(28, 28, 40)
            };

            // Username
            var lblUsername = new Label
            {
                AutoSize = true,
                Location = new Point(28, 78),
                Text = "Username",
                ForeColor = Color.FromArgb(90, 90, 110)
            };

            var txtUsername = new TextBox
            {
                Location = new Point(28, 102),
                Size = new Size(360, 32),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Password
            var lblPassword = new Label
            {
                AutoSize = true,
                Location = new Point(28, 148),
                Text = "Password",
                ForeColor = Color.FromArgb(90, 90, 110)
            };

            var txtPassword = new TextBox
            {
                Location = new Point(28, 172),
                Size = new Size(360, 32),
                BorderStyle = BorderStyle.FixedSingle,
                UseSystemPasswordChar = true
            };

            var chkShowPassword = new CheckBox
            {
                AutoSize = true,
                Location = new Point(28, 214),
                Text = "Hiện mật khẩu",
                ForeColor = Color.FromArgb(90, 90, 110)
            };
            chkShowPassword.CheckedChanged += (s, e) =>
            {
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            };

            var btnLogin = new Button
            {
                Location = new Point(28, 250),
                Size = new Size(360, 44),
                Text = "Đăng nhập",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(45, 45, 64),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnLogin.FlatAppearance.BorderSize = 0;

            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.FromArgb(60, 60, 86);
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(45, 45, 64);

            var lblHint = new Label
            {
                AutoSize = false,
                Location = new Point(28, 300),
                Size = new Size(360, 18),
                Text = "Tip: Nhấn Enter để đăng nhập",
                ForeColor = Color.FromArgb(140, 140, 160),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular)
            };

            // Enter = login
            this.AcceptButton = btnLogin;

            // Click login
            btnLogin.Click += async (sender, e) =>
            {
                var user = txtUsername.Text.Trim();
                var pass = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Vui lòng nhập Username và Password.", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using ElectronicsStoreContext db = new ElectronicsStoreContext();
                var account = await db.Employees.Where(x => x.Username == user && x.PasswordHash == HashHelper.Sha256(pass)).FirstOrDefaultAsync();
                if (account == null)
                {
                    MessageBox.Show("Sai Username hoặc Password.", "Lỗi đăng nhập",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DashBoardForm dashboard = new DashBoardForm();
                    dashboard.Show();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công.", "OK",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            // Add to card
            card.Controls.Add(lblLoginTitle);
            card.Controls.Add(lblUsername);
            card.Controls.Add(txtUsername);
            card.Controls.Add(lblPassword);
            card.Controls.Add(txtPassword);
            card.Controls.Add(chkShowPassword);
            card.Controls.Add(btnLogin);
            card.Controls.Add(lblHint);

            // Add panels to form
            this.Controls.Add(panelRight);
            this.Controls.Add(panelLeft);

            // Trigger resize để căn giữa lần đầu
            panelRight.PerformLayout();
            panelRight.Invalidate();
            card.Left = (panelRight.ClientSize.Width - card.Width) / 2;
            card.Top = (panelRight.ClientSize.Height - card.Height) / 2;
        }
    }
}
