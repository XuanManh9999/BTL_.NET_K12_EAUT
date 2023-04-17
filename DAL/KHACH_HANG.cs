using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    interface IKHACH_HANG
    {
        void dangNhapTK();
        void dangKyTK();
        List<rpGiaoDichTienRa> XemGiaoDichTienRa(string MaKH);
        List<rpGiaoDichTienVao> XemGiaoDichTienVao(string MaKH);
        bool chuyenTien(GIAO_DICH giaoDich);
        bool tietKiem(TIET_KIEM tietKiem, string stkChuyen);
        SqlDataReader xemCTGD(string s);
        SqlDataReader tienNhan(string TKNhan);
    }
    public class KHACH_HANG : PERSON, IKHACH_HANG
    {
        private string _maKH;

        public string MaKH { get => _maKH; set => _maKH = value; }

        public KHACH_HANG() {  }
        public KHACH_HANG(string maKH, string ten, string cmnd, string ngaySinh, string gioiTinh, string diaChi, string sdt) : base(ten, cmnd, ngaySinh, gioiTinh, diaChi, sdt)
        {
            this._maKH = maKH;
        }

        CONNECT DBConnect = new CONNECT();
        public void dangNhapTK()
        {

        }
        public void dangKyTK()
        {

        }
        public  bool  chuyenTien(GIAO_DICH giaoDich)
        {
            SqlCommand sqlcheck = new SqlCommand();
            sqlcheck.CommandType = System.Data.CommandType.Text;
            sqlcheck.CommandText = "select MaGD from GIAODICH";
            sqlcheck.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            SqlDataReader reader = sqlcheck.ExecuteReader();
            int i = 0;
            List<int> maGD = new List<int> {};
            while (reader.Read())
            {
                maGD.Add(reader.GetString(i)[reader.GetString(i).Length - 1]);
            }
            back:
            Random random = new Random(); 
            int x = random.Next(1, 1000);
            foreach(int k in maGD)
            {
                if (x == k)
                {
                    goto back;   
                }
            } 
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.Text;
            sqlCMD.CommandText = $"insert into giaodich values('GD00{x}', '{giaoDich.soTienGD}', N'{giaoDich.noiDungGD}', '{DateTime.Now.ToString()}', '{giaoDich.SoTKNhan}', '{giaoDich.SoTKGui}')";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            if (sqlCMD.ExecuteNonQuery() > 0)
            {
                CongTienTKNHAN(giaoDich.soTienGD, giaoDich.SoTKNhan);
                TruTienTKGUI(giaoDich.soTienGD, giaoDich.SoTKGui);
                return true;
            }else { return false; }
        }
        public void CongTienTKNHAN(string tienGiaoDich, string soTaiKhoanNhan)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.Text;
            sqlCMD.CommandText = $"update THONGTINTAIKHOAN set SoDu += {double.Parse(tienGiaoDich)} where SoTK = '{soTaiKhoanNhan}'";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            sqlCMD.ExecuteNonQuery();
        }

        // Lấy thông tin người nhận tiền
        public List<rpThongTinNguoiNhan> Get_TTNN(string MaKH)
        {
            List<rpThongTinNguoiNhan> listTTNN = new List<rpThongTinNguoiNhan>();
            string query = "SELECT T.SoTK, K.TenKH FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T WHERE G.SoTKNhan = T.SoTK AND K.MaKH = T.MaKH " 
                + "AND G.MaGD IN (SELECT G.MaGD FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T WHERE K.MaKH = T.MaKH AND G.SoTKGui = T.SoTK AND K.MaKH = @MaKH)";
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MaKH", MaKH);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rpThongTinNguoiNhan temp = new rpThongTinNguoiNhan();
                temp.SoTK = reader.GetString(0);
                temp.TenNguoiNhan = reader.GetString(1);
                listTTNN.Add(temp);
            }
            conn.Close();
            return listTTNN;
        }
        // Thống kê giao dịch tiền ra
        public List<rpGiaoDichTienRa> XemGiaoDichTienRa(string MaKH)
        {
            // List lưu thông tin người nhận tiền
            List<rpThongTinNguoiNhan> listTTNN = Get_TTNN(MaKH);

            // Biến lưu tổng tiền giao dịch
            double TongTien = 0;

            // List lưu thông tin thống kê
            List<rpGiaoDichTienRa> listReport = new List<rpGiaoDichTienRa>();
            string query = "SELECT K.MaKH, TenKH, MaGD, SoTienGD, NoiDungGD, ThoiGianGD, SoTKNhan FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T " 
                + "WHERE K.MaKH = T.MaKH AND G.SoTKGui = T.SoTK AND K.MaKH = @MaKH";
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MaKH", MaKH);
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                rpGiaoDichTienRa temp = new rpGiaoDichTienRa();
                temp.MaKH = read.GetString(0);
                temp.TenKH = read.GetString(1);
                temp.MaGD = read.GetString(2);
                temp.SoTienGD = read.GetDouble(3);
                TongTien += temp.SoTienGD;
                temp.NoiDungGD = read.GetString(4);
                temp.ThoiGianGD = read.GetString(5);
                temp.SoTKNhan = read.GetString(6);
                foreach(rpThongTinNguoiNhan item in listTTNN)
                {
                    if(item.SoTK == temp.SoTKNhan)
                    {
                        temp.TenKHNhan = item.TenNguoiNhan;
                        break;
                    }
                }
                temp.TongTienRa = TongTien;

                listReport.Add(temp);
            }
            conn.Close();
            return listReport;
        }

        // Lấy thông tin người chuyển tiền
        public List<rpThongTinNguoiGui> Get_TTNG(string MaKH)
        {
            List<rpThongTinNguoiGui> listTTNG = new List<rpThongTinNguoiGui>();
            string query = "SELECT T.SoTK, K.TenKH FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T WHERE G.SoTKGui = T.SoTK AND K.MaKH = T.MaKH " 
                + "AND G.MaGD IN (SELECT G.MaGD FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T WHERE K.MaKH = T.MaKH AND G.SoTKNhan = T.SoTK AND K.MaKH = @MaKH)";
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MaKH", MaKH);
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                rpThongTinNguoiGui temp = new rpThongTinNguoiGui();
                temp.SoTKGui = read.GetString(0);
                temp.TenNguoiGui = read.GetString(1);

                listTTNG.Add(temp);
            }
            conn.Close();
            return listTTNG;
        }
        // Thống kê giao dịch tiền vào
        public List<rpGiaoDichTienVao> XemGiaoDichTienVao(string MaKH)
        {
            List<rpThongTinNguoiGui> listTTNG = Get_TTNG(MaKH);

            List<rpGiaoDichTienVao> listReport = new List<rpGiaoDichTienVao>();

            double TongTienVao = 0;

            string query = "SELECT K.MaKH, TenKH, MaGD, SoTienGD, NoiDungGD, ThoiGianGD, SoTKGui FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T " 
                + "WHERE K.MaKH = T.MaKH AND G.SoTKNhan = T.SoTK AND K.MaKH = @MaKH";
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MaKH", MaKH);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                rpGiaoDichTienVao temp = new rpGiaoDichTienVao();
                temp.MaKH = read.GetString(0);
                temp.TenKH = read.GetString(1);
                temp.MaGD = read.GetString(2);
                temp.SoTienGD = read.GetDouble(3);
                TongTienVao += temp.SoTienGD;
                temp.NoiDungGD = read.GetString(4);
                temp.ThoiGianGD = read.GetString(5);
                temp.SoTkGui = read.GetString(6);
                foreach(rpThongTinNguoiGui item in listTTNG)
                {
                    if(item.SoTKGui == temp.SoTkGui)
                    {
                        temp.TenKHGui = item.TenNguoiGui;
                        break;
                    }
                }

                temp.TongTienVao = TongTienVao;

                listReport.Add(temp);
            }
            conn.Close();
            return listReport;
        }
        public void TruTienTKGUI(string tienGiaoDich, string soTaiKhoanChuyen)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.Text;
            sqlCMD.CommandText = $"update THONGTINTAIKHOAN set SoDu -= {float.Parse(tienGiaoDich)} where SoTK = '{soTaiKhoanChuyen}'";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            sqlCMD.ExecuteNonQuery();
        }
        // Lấy mã tiết kiệm từ csdl
        public List<int> MaTietKiem()
        {
            List<int> list = new List<int>();
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.Text;
            sqlCMD.CommandText = "select MaTK from TIETKIEM";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            while(reader.Read())
            {
                list.Add(reader.GetString(0)[reader.GetString(0).Length - 1]);
            }
            return list;
        }
        public bool tietKiem(TIET_KIEM tietKiem, string stkChuyen)
        {
            back:
            Random ranDom = new Random();
            int x = ranDom.Next(1, 1000);
            foreach(int i in MaTietKiem())
            {
                if (x == i)
                {
                    goto back;
                }
            }
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.Text;
            // Đoạn Này cần thêm mã tài khoản.
            sqlCMD.CommandText = $"insert into TIETKIEM values ('MTK00{x}', {tietKiem.soTienGD}, N'{tietKiem.noiDungGD}', '{DateTime.Now.ToString()}', 'TK001')";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            if (sqlCMD.ExecuteNonQuery() > 0) {
                TruTienTKGUI(tietKiem.soTienGD, stkChuyen);
                return true;
            }
            return false;
        }
        public SqlDataReader xemCTGD(string s)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.Text;
            sqlCMD.CommandText = $"select DISTINCT GIAODICH.MaGD, KHACHHANG.TenKH, GIAODICH.SoTienGD,GIAODICH.NoiDungGD, GIAODICH.SoTKNhan,  GIAODICH.ThoiGianGD from GIAODICH, THONGTINTAIKHOAN, KHACHHANG where GIAODICH.SoTKGui = THONGTINTAIKHOAN.SoTK and THONGTINTAIKHOAN.MaKH = KHACHHANG.MaKH and KHACHHANG.MaKH = '{s}'";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
        public SqlDataReader tienNhan(string TKNhan)
        {
            SqlCommand sqlCMD = new SqlCommand();
            sqlCMD.CommandType = System.Data.CommandType.Text;
            sqlCMD.CommandText = $"select DISTINCT  GIAODICH.MaGD, KHACHHANG.TenKH, GIAODICH.SoTienGD, GIAODICH.NoiDungGD, GIAODICH.SoTKGui, GIAODICH.ThoiGianGD  from GIAODICH, KHACHHANG, THONGTINTAIKHOAN where GIAODICH.SoTKNhan = '{TKNhan}' and KHACHHANG.MaKH = (select KHACHHANG.MaKH from KHACHHANG, THONGTINTAIKHOAN where KHACHHANG.MaKH = THONGTINTAIKHOAN.MaKH and THONGTINTAIKHOAN.SoTK = (select DISTINCT GIAODICH.SoTKGui  from GIAODICH, KHACHHANG, THONGTINTAIKHOAN where GIAODICH.SoTKNhan = '{TKNhan}'))";
            sqlCMD.Connection = CONNECT.chuoi_ket_noi_cua_manh();
            SqlDataReader reader = sqlCMD.ExecuteReader();
            return reader;
        }
    }
}
