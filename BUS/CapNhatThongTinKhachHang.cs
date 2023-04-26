using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CapNhatThongTinKhachHang
    {
        KHACH_HANG khachHang = new KHACH_HANG();
        public bool capNhatTT(KHACH_HANG kHACH_HANG)
        {
            return khachHang.capNhatThongTin(kHACH_HANG);
        }
    }
}
