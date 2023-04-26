using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Bus_Thong_Tin_Khach_Hang
    {
        KHACH_HANG khachHang = new KHACH_HANG();
        public SqlDataReader hienThiTT(string maKH)
        {
            return khachHang.hienThiThongTinKhachHang(maKH);
        }
    }
}
