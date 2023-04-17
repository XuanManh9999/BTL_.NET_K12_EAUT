using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Trang_Chu : Form
    {
        public Form_Trang_Chu()
        {
            InitializeComponent();
        }

        private void Form_Trang_Chu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_Giao_Dich formGiaoDich =new Form_Giao_Dich();
            formGiaoDich.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FromTietKiem tietKiem =new FromTietKiem();
            tietKiem.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FormLich_Su_Giao_Dich formLich_Su_Giao_Dich = new FormLich_Su_Giao_Dich("KH0001", "00999902082003");
            formLich_Su_Giao_Dich.ShowDialog();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frmQLKH frmQLKH = new frmQLKH();
            this.Hide();
            frmQLKH.ShowDialog();
        }
    }
}
