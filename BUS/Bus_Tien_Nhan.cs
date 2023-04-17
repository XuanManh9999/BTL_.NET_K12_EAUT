using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Bus_Tien_Nhan
    {
        KHACH_HANG khachHang = new KHACH_HANG();
        public SqlDataReader bus_Tien_Nhan(string TKNhan)
        {
            if (khachHang.tienNhan(TKNhan) != null)
            {
                return khachHang.tienNhan(TKNhan);
            }
            else
            {
                return null;
            }
        }
    }
}
