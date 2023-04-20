using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form_Trang_Chu : Form
    {
        public Form_Trang_Chu()
        {
            InitializeComponent();
        }
        // Chuyển tiền
        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Giao_Dich formGiaoDich = new Form_Giao_Dich();
            formGiaoDich.Show();
        }
        // Gửi tiền tiết kiệm
        private void btnTietkiem_Click(object sender, EventArgs e)
        {
            Hide();
            FromTietKiem tietKiem = new FromTietKiem();
            tietKiem.Show();
        }
        // Xem lịch sử giao dịch
        private void btnLSGD_Click(object sender, EventArgs e)
        {
            Hide();
            FormLich_Su_Giao_Dich formLich_Su_Giao_Dich = new FormLich_Su_Giao_Dich("KH0001", "00999902082003");
            formLich_Su_Giao_Dich.Show();
        }
        
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật...");
        }
        // Chức năng dành cho người quản lý
        private void btnQuanLy_Click(object sender, EventArgs e)
        {

        }
        // Đăng xuất tài khoản
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
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
