using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class rpGiaoDichTienVao
    {
        private string _MaKH;
        private string _TenKH;
        private string _MaGD;
        private double _SoTienGD;
        private string _NoiDungGD;
        private string _ThoiGianGD;
        private string _SoTkGui;
        private string _TenKHGui;
        private double _TongTienVao;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string MaGD { get => _MaGD; set => _MaGD = value; }
        public double SoTienGD { get => _SoTienGD; set => _SoTienGD = value; }
        public string NoiDungGD { get => _NoiDungGD; set => _NoiDungGD = value; }
        public string ThoiGianGD { get => _ThoiGianGD; set => _ThoiGianGD = value; }
        public string SoTkGui { get => _SoTkGui; set => _SoTkGui = value; }
        public string TenKHGui { get => _TenKHGui; set => _TenKHGui = value; }
        public double TongTienVao { get => _TongTienVao; set => _TongTienVao = value; }
    }
}
