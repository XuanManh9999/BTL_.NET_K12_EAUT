using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DangNhap
    {
        KHACH_HANG KH = new KHACH_HANG();
        public bool DangNhap(string txtTenDN, string txtMK)
        {
            return KH.dangNhapTK(txtTenDN, txtMK);
        }
    }
}
