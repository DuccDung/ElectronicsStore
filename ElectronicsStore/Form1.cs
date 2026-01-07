using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ElectronicsStore
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public Form1()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();

        }

        private void SetupMenuHover(Button btn)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = System.Drawing.Color.FromArgb(45, 45, 64);
            btn.MouseLeave += (s, e) => btn.BackColor = System.Drawing.Color.FromArgb(28, 28, 40);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetupMenuHover(btnDashboard);
            SetupMenuHover(btnProducts);
            SetupMenuHover(btnCategories);
            SetupMenuHover(btnSuppliers);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
