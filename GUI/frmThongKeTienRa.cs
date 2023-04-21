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
    public partial class frmThongKeTienRa : Form
    {
        private string maKH = "";
        BUS_GiaoDichTienRa bUS_GiaoDichTienRa = new BUS_GiaoDichTienRa();
        public frmThongKeTienRa()
        {
            InitializeComponent();
        }
        public frmThongKeTienRa(string maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
        }
        private void frmThongKeTienRa_Load(object sender, EventArgs e)
        {
            rptGiaoDichTienRa rp = new rptGiaoDichTienRa();
            rp.SetDataSource(bUS_GiaoDichTienRa.XemGiaoDichTienRa(maKH));
            crysTal_ThongKeGD.ReportSource = null;
            crysTal_ThongKeGD.Refresh();
            crysTal_ThongKeGD.ReportSource = rp;
        }
    }
}
