using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Bus_Xem_Chi_Tiet_Giao_Dich
    {
        KHACH_HANG khachHang = new KHACH_HANG();
        public SqlDataReader bus_xem_lich_su_GD(string s)
        {
            if (khachHang.xemCTGD(s) != null)
            {
                return khachHang.xemCTGD(s);
            }else
            {
                return null;
            }
        }
    }
}
