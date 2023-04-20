using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuenMK : Form
    {
        BUS_QuenMK bus_QuenMK = new BUS_QuenMK();
        public frmQuenMK()
        {
            InitializeComponent();
        }

        // Xử lý khi hover đăng nhập
        private void btnDangNhap_MouseHover(object sender, EventArgs e)
        {
            btnDangNhap.ForeColor = Color.FromArgb(0, 201, 255);
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.ForeColor = Color.Black;
        }

        private void btnLayMK_Click(object sender, EventArgs e)
        {
            string password = bus_QuenMK.LayLaiMK(txtEmail.Text);
            txtMK.Text = password;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Hide();
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
        }
    }
}
