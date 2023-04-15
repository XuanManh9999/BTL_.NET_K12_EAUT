using BUS;
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
    public partial class frmThongKeTienVao : Form
    {
        BUS_GiaoDichTienVao BUS_GiaoDichTienVao = new BUS_GiaoDichTienVao();
        public frmThongKeTienVao()
        {
            InitializeComponent();
        }

        private void frmThongKeTienVao_Load(object sender, EventArgs e)
        {
            rpGiaoDichTienVao rp = new rpGiaoDichTienVao();
            rp.SetDataSource(BUS_GiaoDichTienVao.XemGiaoDichTienVao("KH0001"));
            crystalTKGDVao.ReportSource = null;
            crystalTKGDVao.Refresh();
            crystalTKGDVao.ReportSource = rp;
        }
    }
}
