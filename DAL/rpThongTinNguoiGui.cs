using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class rpThongTinNguoiGui
    {
        private string _SoTKGui;
        private string _TenNguoiGui;

        public string SoTKGui { get => _SoTKGui; set => _SoTKGui = value; }
        public string TenNguoiGui { get => _TenNguoiGui; set => _TenNguoiGui = value; }
    }
}
