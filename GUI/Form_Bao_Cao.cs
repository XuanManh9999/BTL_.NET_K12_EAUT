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
    public partial class Form_Bao_Cao : Form
    {
        private string maKH = "";
        public Form_Bao_Cao()
        {
            InitializeComponent();
        }
        public Form_Bao_Cao(string maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmThongKeTienVao frmThongKeTienVao = new frmThongKeTienVao(maKH);
            frmThongKeTienVao.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmThongKeTienRa frmThongKeTienRa = new frmThongKeTienRa(maKH);
            frmThongKeTienRa.ShowDialog();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
