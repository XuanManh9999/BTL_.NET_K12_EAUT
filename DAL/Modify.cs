using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class Modify
    {
        public Modify()
        {

        }

        SqlCommand SqlCommand;
        SqlDataReader dataReader; 

        // tạo một list tài khoản 
        public List<TaiKhoan> taiKhoans(string query)  // dung check tai khoan
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            // khi using thực thi phần trong ngoăc thì nó sẽ xóa hết đối tượng ở trên 
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();  
                SqlCommand = new SqlCommand(query, sqlConnection); 
                dataReader = SqlCommand.ExecuteReader();      
                while (dataReader.Read())
                {            
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2),dataReader.GetString(4)));
                }

                sqlConnection.Close(); 
            }
            return taiKhoans;   
        }

        public void Command(string query)  // dung de dang ki tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.ExecuteNonQuery(); // thuc thi cau truy van
                sqlConnection.Close();
            }
        }
    }
}
