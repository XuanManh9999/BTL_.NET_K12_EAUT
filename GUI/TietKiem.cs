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
    public partial class FromTietKiem : Form
    {
        public FromTietKiem()
        {
            InitializeComponent();
        }
        public string soTKChuyen = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }
        public void HienThi()
        {
            comboKyHan.Items.Add("1 Tháng");
            comboKyHan.Items.Add("3 Tháng");
            comboKyHan.Items.Add("6 Tháng");
            comboKyHan.Items.Add("1 Năm");
            comboKyHan.SelectedIndex = 0;
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = CommandType.Text;
            // Đoạn này cần thêm mã khách hàng
            sqlCMD.CommandText = $"SELECT THONGTINTAIKHOAN.SoTK, KHACHHANG.TenKH, THONGTINTAIKHOAN.SoDu \r\nFROM THONGTINTAIKHOAN\r\nINNER JOIN KHACHHANG ON THONGTINTAIKHOAN.MaKH = KHACHHANG.MaKH\r\nWHERE THONGTINTAIKHOAN.MaKH = 'KH0001'";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            cboTaiKhoanNguon.Items.Clear();
            string s = "";
            if (reader.Read())
            {
                soTKChuyen = reader.GetString(0).Trim();
                s = $"Số TK: {reader.GetString(0)}/Họ Tên Khách Hàng: {reader.GetString(1)} / Số Dư: {reader.GetDouble(2)} VNĐ";
                cboTaiKhoanNguon.Items.Add(s);
                cboTaiKhoanNguon.SelectedIndex = 0;
            }
            reader.Close();
        }

        private void FromTietKiem_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void comboKyHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = comboKyHan.SelectedItem.ToString();
            if (value == "6 Tháng" || value == "1 Năm")
            {
                txtMucLaiXuat.Text = "0.8";
            }else
            {
                txtMucLaiXuat.Text = "0.6";
            }
        }

        private void cboTaiKhoanNguon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTietKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkedDieuKhoan.Checked)
                {
                    TIET_KIEM tietKiem = new TIET_KIEM("", txtSoTien.Text, txtNoiDungTietKiem.Text, "", "");
                    Bus_Tiết_Kiệm bus_tietKiem = new Bus_Tiết_Kiệm();
                    if (bus_tietKiem.tiet_kiem_bus(tietKiem, soTKChuyen))
                    {
                        HienThi();
                        MessageBox.Show("Tiết Kiệm Thành Công!");
                    }
                    else
                    {
                        MessageBox.Show("Tiết Kiệm Không Thành Công");
                    }
                }
               
            }
            catch
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!");
            }

        }

        private void checkedDieuKhoan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
