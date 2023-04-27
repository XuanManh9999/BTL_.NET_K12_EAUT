using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class bus_Giao_Dich
    {
        KHACH_HANG khachHang = new KHACH_HANG();
        public bool khachHang_GD_BUS(GIAO_DICH giaoDich)
        {
            if (khachHang.chuyenTien(giaoDich))
            {
                return true;
            }
            return false;
        }
    }
}
