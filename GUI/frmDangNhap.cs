using DAL;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        

        Modify modify = new Modify();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string query = "Select * from TAIKHOANDANGNHAP where TenTK = '" + tentk + "' and MK = '" + matkhau + "'";
                if (modify.taiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }


           
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
        }

        private void btnQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau frm = new frmQuenMatKhau();
            frm.ShowDialog();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn quét QR không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                this.Hide();
                Form1 forme = new Form1();
                forme.ShowDialog();

            }

            
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ với chúng tôi qua số điện thoại 19001080", "Thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
