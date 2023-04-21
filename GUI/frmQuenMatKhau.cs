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
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
            gunaLabel2.Text = "";
        }
        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email đăng kí!");
            }
            else
            {
                string query = "select * from TaiKhoanDangNhap where Email = '" + email + "'";
                if (modify.taiKhoans(query).Count() != 0)
                {
                    gunaLabel2.ForeColor = Color.Blue;
                    gunaLabel2.Text = "Mật khẩu: " + modify.taiKhoans(query)[0].MatKhau;

                }
                else
                {
                    gunaLabel2.ForeColor = Color.Red;
                    gunaLabel2.Text = "Email này chưa được đăng kí!";
                }
            }
        }

       

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
        }
    }
}
