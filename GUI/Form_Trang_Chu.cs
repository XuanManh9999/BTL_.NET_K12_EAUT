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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form_Trang_Chu : Form
    {
        private string MaKH = "";
        private string MaTK = "";
        private string tenTK = "";
        public Form_Trang_Chu()
        {
            InitializeComponent();
        }
        public Form_Trang_Chu(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
        }
       
        public Form_Trang_Chu(string MaKH, string maTK)
        {
            InitializeComponent();
            this.MaKH = MaKH;
            MaTK = maTK;
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaoDich_Click_1(object sender, EventArgs e)
        {
            if(tenTK != "Admin") {
                Form_Giao_Dich formGiaoDich = new Form_Giao_Dich(MaKH);
                formGiaoDich.Show();
            }else
            {
                MessageBox.Show("Đây là chức năng dành cho khách hàng. Vui lòng thao tác lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTietkiem_Click_1(object sender, EventArgs e)
        {
            if (tenTK != "Admin")
            {
                FromTietKiem tietKiem = new FromTietKiem(MaKH, MaTK);
                tietKiem.Show();
            }
            else
            {
                MessageBox.Show("Đây là chức năng dành cho khách hàng. Vui lòng thao tác lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLSGD_Click_1(object sender, EventArgs e)
        {
            if (tenTK != "Admin")
            {
                BUS_DangNhap bUS_DangNhap = new BUS_DangNhap();
                if (bUS_DangNhap.getSTK(MaKH) != "err")
                {
                    FormLich_Su_Giao_Dich formLich_Su_Giao_Dich = new FormLich_Su_Giao_Dich(MaKH, bUS_DangNhap.getSTK(MaKH));
                    formLich_Su_Giao_Dich.Show();
                }
            }
            else
            {
                MessageBox.Show("Đây là chức năng dành cho khách hàng. Vui lòng thao tác lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tenTK != "Admin")
            {
                Form_Bao_Cao form_Bao_Cao = new Form_Bao_Cao(MaKH);
                form_Bao_Cao.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đây là chức năng dành cho khách hàng. Vui lòng thao tác lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuanLy_Click_1(object sender, EventArgs e)
        {
            if (tenTK == "Admin")
            {
                frmQLKH quanLYKH = new frmQLKH();
                quanLYKH.ShowDialog();
            }else
            {
                MessageBox.Show("Chức Năng Này Chỉ Dành Cho Quản Trị.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CloseAllForms()
        {
            // Lặp qua tất cả các Form mở
            foreach (Form form in Application.OpenForms)
            {
                // Nếu Form hiện tại không phải là Form chính của ứng dụng
                if (form.Name != "frmDangNhap")
                {
                    // Đóng Form
                    form.Close();
                }
            }
        }
        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            FormThongTinKhachHang frm = new FormThongTinKhachHang(MaKH);
            frm.ShowDialog();
        }
    }
}
