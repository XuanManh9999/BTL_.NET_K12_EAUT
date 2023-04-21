using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form_Trang_Chu : Form
    {
        private string MaKH = "";
        private string MaTK = "";
        private string TenTK = "";
        public Form_Trang_Chu()
        {
            InitializeComponent();
        }
        public Form_Trang_Chu(string MaKH, string maTK, string tenTK)
        {
            InitializeComponent();
            this.MaKH = MaKH;
            this.MaTK = maTK;
            this.TenTK = tenTK;
        }
        private void btnGiaoDich_Click_1(object sender, EventArgs e)
        {
            Form_Giao_Dich formGiaoDich = new Form_Giao_Dich(MaKH);
            formGiaoDich.Show();
        }

        private void btnTietkiem_Click_1(object sender, EventArgs e)
        {
            FromTietKiem tietKiem = new FromTietKiem(MaKH, MaTK);
            tietKiem.Show();
        }

        private void btnLSGD_Click_1(object sender, EventArgs e)
        {
            BUS_DangNhap bUS_DangNhap = new BUS_DangNhap();
            if (bUS_DangNhap.getSTK(MaKH) != "err")
            {
                FormLich_Su_Giao_Dich formLich_Su_Giao_Dich = new FormLich_Su_Giao_Dich(MaKH, bUS_DangNhap.getSTK(MaKH));
                formLich_Su_Giao_Dich.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_Bao_Cao form_Bao_Cao = new Form_Bao_Cao(MaKH);
            form_Bao_Cao.ShowDialog();
        }

        private void btnQuanLy_Click_1(object sender, EventArgs e)
        {
            if(TenTK == "Admin")
            {
                frmQLKH quanLy = new frmQLKH();
                quanLy.ShowDialog();
            } else
            {
                MessageBox.Show("Chức năng này không dành cho khách hàng");
            }
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                for (int i = 0; i < Application.OpenForms.Count; ++i)
                {
                    if (Application.OpenForms[i] != this)
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
        }
    }
}
