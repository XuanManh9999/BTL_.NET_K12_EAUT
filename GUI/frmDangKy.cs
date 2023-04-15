using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }


        public bool CheckAccount(string ac) // CHECK MAT KHAU VA TEEN TAI KHOAN
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string em) // check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }


        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int matk = random.Next(0, 10);


            string tentk = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string xnmatkhau = txtXacNhanMatKhau.Text;
            string email = txtEmail.Text;
            string makhachhang = txtMaKhachHang.Text;

            if (modify.taiKhoans("Select * from TAIKHOANDANGNHAP where TenTK = '" + tentk + "'").Count != 0)
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí, vui lòng nhập Tên tài khoản khác!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!CheckAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!CheckAccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (makhachhang == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (modify.taiKhoans("Select * from TAIKHOANDANGNHAP where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí, vui lòng nhập Email khác!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "insert into TAIKHOANDANGNHAP values ('" + matk + "','" + tentk + "','" + matkhau + "','" + email + "','" + makhachhang + "')";
            modify.Command(query);
            if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã được đăng kí, vui lòng đăng kí tên tài khoản khác!!");
            }
        }
    }
}
