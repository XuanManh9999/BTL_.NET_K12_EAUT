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
        private string maKH = "";
        private string maTK = "";
        public FromTietKiem()
        {
            InitializeComponent();
        }
        public FromTietKiem(string maKH, string maTK)
        {
            InitializeComponent();
            this.maKH = maKH;
            this.maTK = maTK;
        }
        public string soTKChuyen = "";
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
            sqlCMD.CommandText = $"SELECT THONGTINTAIKHOAN.SoTK, KHACHHANG.TenKH, THONGTINTAIKHOAN.SoDu \r\nFROM THONGTINTAIKHOAN\r\nINNER JOIN KHACHHANG ON THONGTINTAIKHOAN.MaKH = KHACHHANG.MaKH\r\nWHERE THONGTINTAIKHOAN.MaKH = '{maKH}'";
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
        private void btnTietKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                    TIET_KIEM tietKiem = new TIET_KIEM("", txtSoTien.Text, txtNoiDungTietKiem.Text, "", maTK);
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
            catch
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!");
            }
        }

        private void comboKyHan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string value = comboKyHan.SelectedItem.ToString();
            if (value == "6 Tháng" || value == "1 Năm")
            {
                txtMucLaiXuat.Text = "0.8";
            }
            else
            {
                txtMucLaiXuat.Text = "0.6";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
