using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Bus_Tiết_Kiệm
    {
        KHACH_HANG khachHang = new KHACH_HANG();
        public bool tiet_kiem_bus(TIET_KIEM tietKiem)
        {
            if (khachHang.tietKiem(tietKiem))
            {
                return true;
            }
            return false;
        }
    }
}
