using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CONNECT
    {
        // ====Chuỗi kết nối của mạnh
        public SqlConnection chuoi_ket_noi_cua_manh()
        {
            string strCon = @"Data Source=DESKTOP-LNJ99RH\SQLEXPRESS;Initial Catalog=QuanLyNganHang;Integrated Security=True";
            SqlConnection SqlCON = new SqlConnection(strCon);
            SqlCON.Open();
            return SqlCON;
        }
        // ====Chuỗi kết nối của hải
            
        // ====Chuỗi kết nối của duy
    }
}
