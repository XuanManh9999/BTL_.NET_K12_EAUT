using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Giao_Dich : Form
    {
        private string maKh = "";
        public Form_Giao_Dich()
        {
            InitializeComponent();
        }
        public Form_Giao_Dich(string maKH)
        {
            InitializeComponent();
            this.maKh = maKH;
        }
        public List<string> load_STK()
        {
            List<string> stks = new List<string>();
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = "SELECT SoTK FROM THONGTINTAIKHOAN";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while(reader.Read())
            {
                stks.Add(reader.GetString(0));
            }
            reader.Close();
            return stks;
        }
        public string chechkSTK()
        {
            List<string> dsTK = load_STK();
            foreach(string s in dsTK)
            {
                if(txtTaiKhoanNhan.Text == s && txtTaiKhoanNhan.Text != txtSoTaiKhoanGui.Text)
                {
                    return s;
                }
            }
            txtTenTaiKhoanNhan.Text = "";
            return "err";
        }
        public void load_TT()
        {
            cboHinhThucChuyenKhoan.Items.Add("Chuyển Khoản Qua Số Tài Khoản");
            cboHinhThucChuyenKhoan.SelectedIndex = 0;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = $"select SoTK, SoDu, TenKH from THONGTINTAIKHOAN, KHACHHANG where khachhang.MaKH = THONGTINTAIKHOAN.MaKH and KHACHHANG.MaKH = '{maKh}'";
            sqlCommand.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            txtSoTaiKhoanGui.Text = "";
            txtTenTK.Text = "";
            txtSoTien.Text = "";
            if (reader.Read())
            {
                txtSoTaiKhoanGui.Text = reader.GetString(0);
                txtSoTien.Text = reader.GetDouble(1).ToString() + "VNĐ";
                txtTenTK.Text = reader.GetString(2).ToString();
            }
            reader.Close();
        }
        private void Form_Giao_Dich_Load(object sender, EventArgs e)
        {
            load_TT();
        }
        public void hienThiTen(List<string> soTaiKhoan)
        {

        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Trang_Chu frmMain = new Form_Trang_Chu();
            frmMain.Show();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChuyenKhoan_Click_1(object sender, EventArgs e)
        {
            if (txtSoTaiKhoanGui.Text != txtTaiKhoanNhan.Text)
            {
                try
                {
                    GIAO_DICH giaoDich = new GIAO_DICH("", txtSoTienChuyen.Text, txtNoiDungChuyen.Text, "", txtTaiKhoanNhan.Text, txtSoTaiKhoanGui.Text);
                    bus_Giao_Dich giaoDich_bus = new bus_Giao_Dich();
                    if (giaoDich_bus.khachHang_GD_BUS(giaoDich))
                    {
                        MessageBox.Show("Giao Dịch Thành Công.");
                        txtNoiDungChuyen.Text = "";
                        txtSoTienChuyen.Text = "";
                        txtTaiKhoanNhan.Text = "";
                        txtTenTaiKhoanNhan.Text = "";
                        txtTaiKhoanNhan.Focus();
                        load_TT();
                    }
                    else
                    {
                        MessageBox.Show("Giao Dịch Không Thành Công.");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
                }
            }else
            {
                MessageBox.Show("Số tài khoản nhận phải khác số tài khoản gửi. Vui lòng thao tác lại");
            }
        }

        private void txtTaiKhoanNhan_TextChanged_1(object sender, EventArgs e)
        {
            if (chechkSTK() != "err")
            {
                SqlCommand sqlCMD = new SqlCommand();
                sqlCMD.CommandType = CommandType.Text;
                sqlCMD.CommandText = $"SELECT TenKH FROM THONGTINTAIKHOAN, KHACHHANG where THONGTINTAIKHOAN.MaKH = KHACHHANG.MaKH and THONGTINTAIKHOAN.SoTK = '{chechkSTK()}'";
                sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
                SqlDataReader reader1 = sqlCMD.ExecuteReader();
                if (reader1.Read())
                {
                    txtTenTaiKhoanNhan.Text = reader1.GetString(0);
                }
                reader1.Close();
            }
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form_Trang_Chu frmMain = new Form_Trang_Chu();
            frmMain.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
