using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class rpGiaoDichTienRa
    {
        private string _MaKH;
        private string _TenKH;
        private string _MaGD;
        private double _SoTienGD;
        private string _NoiDungGD;
        private string _ThoiGianGD;
        private string _SoTKNhan;
        private string _TenKHNhan;
        private double _TongTienRa;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string MaGD { get => _MaGD; set => _MaGD = value; }
        public double SoTienGD { get => _SoTienGD; set => _SoTienGD = value; }
        public string NoiDungGD { get => _NoiDungGD; set => _NoiDungGD = value; }
        public string ThoiGianGD { get => _ThoiGianGD; set => _ThoiGianGD = value; }
        public string SoTKNhan { get => _SoTKNhan; set => _SoTKNhan = value; }
        public string TenKHNhan { get => _TenKHNhan; set => _TenKHNhan = value; }
        public double TongTienRa { get => _TongTienRa; set => _TongTienRa = value; }
    }
}
