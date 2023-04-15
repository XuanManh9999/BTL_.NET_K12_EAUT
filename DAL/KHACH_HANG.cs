using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IKHACH_HANG
    {
        void dangNhapTK();
        void dangKyTK();
        void chuyenTien();
        void tienKiem();
        List<rpGiaoDichTienRa> XemGiaoDichTienRa(string MaKH);
        List<rpGiaoDichTienVao> XemGiaoDichTienVao(string MaKH);
    }
    public class KHACH_HANG : PERSON, IKHACH_HANG
    {
        private string _maKH;

        public string MaKH { get => _maKH; set => _maKH = value; }

        public KHACH_HANG(string maKH, string ten, string cmnd, string ngaySinh, string gioiTinh, string diaChi, string sdt) : base(ten, cmnd, ngaySinh, gioiTinh, diaChi, sdt)
        {
            this._maKH = maKH;
        }
        public KHACH_HANG()
        {

        }

        CONNECT DBConnect = new CONNECT();

        public void dangNhapTK()
        {

        }
        public void dangKyTK()
        {

        }
        public void chuyenTien()
        {

        }
        public void tienKiem()
        {

        }

        // Lấy thông tin người nhận tiền
        public List<rpThongTinNguoiNhan> Get_TTNN(string MaKH)
        {
            List<rpThongTinNguoiNhan> listTTNN = new List<rpThongTinNguoiNhan>();
            string query = "SELECT T.SoTK, K.TenKH FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T WHERE G.SoTKNhan = T.SoTK AND K.MaKH = T.MaKH " 
                + "AND G.MaGD IN (SELECT G.MaGD FROM KHACHHANG AS K, GIAODICH AS G, THONGTINTAIKHOAN AS T WHERE K.MaKH = T.MaKH AND G.SoTKGui = T.SoTK AND K.MaKH = @MaKH)";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
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
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
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
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
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
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
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
    }
}
