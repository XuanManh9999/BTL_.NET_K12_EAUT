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
    public partial class FormThongTinKhachHang : Form
    {
        private string maKH = "";
        public FormThongTinKhachHang()
        {
            InitializeComponent();
        }
        public FormThongTinKhachHang(string maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
        }
        public void hienThiTT()
        {
            try
            {
                Bus_Thong_Tin_Khach_Hang thongTIn = new Bus_Thong_Tin_Khach_Hang();
                SqlDataReader reader = thongTIn.hienThiTT(maKH);
                while (reader.Read())
                {
                    txtHoTen.Text = reader.GetString(1);
                    txtCMND.Text = reader.GetString(2);
                    txtNgay.Text = reader.GetString(3);
                    txtGioiTinh.Text = reader.GetString(4);
                    txtDiaChi.Text = reader.GetString(5);
                    txtSDT.Text = reader.GetString(6);
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Hiện Thị Thông Tin Không Thành Công");
            }
        }
        private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
            hienThiTT();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        public bool check()
        {
            if ((txtSDT.Text != "" && txtNgay.Text != "" && txtHoTen.Text != "" && txtGioiTinh.Text != "" && txtDiaChi.Text != "" && txtCMND.Text != "") )
            {
                return true;
            }
            return false;
        }
        private void btnCapNhatThongTin_Click_2(object sender, EventArgs e)
        {
          
            CapNhatThongTinKhachHang busCapNhatTT = new CapNhatThongTinKhachHang();
            KHACH_HANG kHACH_HANG = new KHACH_HANG(maKH, txtHoTen.Text, txtCMND.Text, txtNgay.Text, txtGioiTinh.Text, txtDiaChi.Text, txtSDT.Text);
            if(check())
            {
                if (busCapNhatTT.capNhatTT(kHACH_HANG))
                {
                    hienThiTT();
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                else
                {
                    MessageBox.Show("Cập Nhật Không Thành Công Thành Công");
                }
            }else
            {
                MessageBox.Show("Các thông tin phải hợp lệ. Vui lòng kiểm tra và thử lại!");
            }
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
