using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class rpThongTinNguoiNhan
    {
        private string _SoTK;
        private string _TenNguoiNhan;

        public string SoTK { get => _SoTK; set => _SoTK = value; }
        public string TenNguoiNhan { get => _TenNguoiNhan; set => _TenNguoiNhan = value; }
    }
}
