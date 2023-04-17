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
        public static SqlConnection chuoi_ket_noi_cua_manh()
        {
            string strCon = @"Data Source=DESKTOP-LNJ99RH\SQLEXPRESS;Initial Catalog=QuanLyNganHang;Integrated Security=True";
            SqlConnection SqlCON = new SqlConnection(strCon);
            SqlCON.Open();
            return SqlCON;
        }
        // ====Chuỗi kết nối của hải
        public SqlConnection Chuoi_conn_Hai()
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL-VIP-PRO;Initial Catalog=QuanLyNganHang;Integrated Security=True");
            return conn;
        }
        // ====Chuỗi kết nối của duy
        // ====Chuỗi kết nối của hải      
    }
    // ====Chuỗi kết nối của duy
    public class Connection
    {
        private static string strConnection = @"Data Source=VANDUY\SQLEXPRESS;Initial Catalog=QuanLyNganHang;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnection);
        }
    }
}
