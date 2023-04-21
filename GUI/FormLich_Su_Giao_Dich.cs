using BUS;
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
    public partial class FormLich_Su_Giao_Dich : Form
    {
        private string maKH;
        private string soTKnhan;
        public FormLich_Su_Giao_Dich()
        {
            InitializeComponent();
        }
        public FormLich_Su_Giao_Dich(string maKH, string soTKnhan)
        {
            this.maKH = maKH;
            this.soTKnhan = soTKnhan;
            InitializeComponent();
        }
        public void HienThiThongTin()
        {
            Bus_Xem_Chi_Tiet_Giao_Dich bus_Xem_Chi_Tiet_Giao_Dich = new Bus_Xem_Chi_Tiet_Giao_Dich();
            if (bus_Xem_Chi_Tiet_Giao_Dich.bus_xem_lich_su_GD(maKH) != null)
            {
                SqlDataReader reader = bus_Xem_Chi_Tiet_Giao_Dich.bus_xem_lich_su_GD(maKH);
                lsvTienGia.Items.Clear();   
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetDouble(2).ToString());
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetString(4));
                    item.SubItems.Add(reader.GetString(5));
                    lsvTienGia.Items.Add(item);
                }
                reader.Close();
            }
        }
        public void HienThiThongTinTienNhan()
        {
            Bus_Tien_Nhan tiemNhan = new Bus_Tien_Nhan();
            if (tiemNhan.bus_Tien_Nhan(soTKnhan) != null)
            {
                SqlDataReader reader = tiemNhan.bus_Tien_Nhan(soTKnhan);
                lsvHienThiTienVao.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetDouble(2).ToString());
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetString(4));
                    item.SubItems.Add(reader.GetString(5));
                    lsvHienThiTienVao.Items.Add(item);
                }
                reader.Close();
            }
        }
        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
        }

        private void FormLich_Su_Giao_Dich_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            HienThiThongTinTienNhan();
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvTienGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
