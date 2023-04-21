using BUS;
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
    public partial class frmDangKy : Form
    {
        BUS_DangKyTK bus_DK = new BUS_DangKyTK();
        BUS_QLKH bus_QLKH = new BUS_QLKH();

        public frmDangKy()
        {
            InitializeComponent();
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            cbGT.SelectedIndex = 0;
        }

        // Hàm check TextBox
        private bool Check_TextBox()
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Nhập tên khách hàng");
                txtTenKH.Focus();
                return false;
            } 
            else if(string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                MessageBox.Show("Nhập số cmnd");
                txtCMND.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Nhập email");
                txtEmail.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Nhập địa chỉ");
                txtDiaChi.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Nhập số điện thoại di động");
                txtSDT.Focus();
                return false;
            }
            return true;
        }
        // Hàm clear TextBox
        private void Clear_TextBox()
        {
            txtTenKH.Clear();
            txtCMND.Clear();
            dateNS.Value = DateTime.Now;
            txtEmail.Clear();
            cbGT.SelectedIndex = 0;
            txtDiaChi.Clear();
            txtSDT.Clear();
        }
        string MaKH;
        // Hàm tạo đối tượng khách hàng
        private KHACH_HANG Create_KH()
        {
            do
            {
                Random rd = new Random();
                MaKH = $"KH{rd.Next(0, 10000)}";
            } while (bus_DK.Check_MaKH(MaKH));
            string NgaySinh = $"{dateNS.Value.Day}/{dateNS.Value.Month}/{dateNS.Value.Year}";
            KHACH_HANG KH = new KHACH_HANG(MaKH, txtTenKH.Text, txtCMND.Text, NgaySinh, cbGT.Text, txtDiaChi.Text, txtSDT.Text);
            return KH;
        }

        // Hàm tạo đối tượng quản lý khách hàng
        private QUAN_LY_KHACH_HANG Create_QLKH()
        {
            QUAN_LY_KHACH_HANG QLKH = new QUAN_LY_KHACH_HANG(MaKH, "QL001");
            return QLKH;
        }

        // Hàm tạo đối tượng Thông tin tài khoản
        private THONG_TIN_TAI_KHOAN Create_TTTK()
        {
            var date = DateTime.Now;
            string NgayCap = $"{date.Day}/{date.Month}/{date.Year}";
            THONG_TIN_TAI_KHOAN TTTK = new THONG_TIN_TAI_KHOAN(txtCMND.Text, "100000", NgayCap, "Hà Nội", "Thường", MaKH);
            return TTTK;
        }

        // Hàm tạo đối tượng Tài khoản đăng nhập
        private TaiKhoan Create_TK()
        {
            // Random mã tài khoản
            string MaTK;
            do
            {
                Random rd = new Random();
                MaTK = $"TK{rd.Next(0, 10000)}";
            } while (bus_DK.Check_MaTK(MaTK));

            // Random password 6 ký tự
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();
            for(int i = 0; i < stringChars.Length; ++i)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var Password = new String(stringChars);

            TaiKhoan TKDN = new TaiKhoan(MaTK, txtTenKH.Text, Password, txtEmail.Text, MaKH);
            return TKDN;
        }

        // Đăng ký khách hàng
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(Check_TextBox())
            {
                KHACH_HANG KH = Create_KH();
                QUAN_LY_KHACH_HANG QLKH = Create_QLKH();
                THONG_TIN_TAI_KHOAN TTTK = Create_TTTK();
                TaiKhoan TKDN = Create_TK();
                if(bus_QLKH.ThemKhachHang(KH, QLKH) && bus_DK.ThemTTTK(TTTK) && bus_DK.ThemTKDN(TKDN))
                {
                    MessageBox.Show("Thêm thành công");
                    MessageBox.Show($"Tên đăng nhập của bạn: {TKDN.TenTaiKhoan} mật khẩu: {TKDN.MatKhau}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result = MessageBox.Show("Bạn có muốn đăng nhập không?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        this.Close();
                    }
                    Clear_TextBox();
                } else
                {
                    MessageBox.Show("Thêm không thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bus_QLKH.XoaKhachHang(KH, QLKH);
                    bus_DK.XoaTTTK(TTTK);
                    bus_DK.XoaTKDN(TKDN);
                }
            }
        }
    }
}
