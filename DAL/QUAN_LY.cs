﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    interface IQUAN_LY
    {
        DataTable hienThiKhachHang();
        bool quanLyKhachHang(string query, KHACH_HANG KH);
        bool themKhachHang(KHACH_HANG KH, QUAN_LY_KHACH_HANG QLKH);
        bool suaKhachHang(KHACH_HANG KH);
        bool xoaKhachHang(KHACH_HANG KH, QUAN_LY_KHACH_HANG QLKH);
        bool XuLyBangQLKH(QUAN_LY_KHACH_HANG QLKH, string query);
        bool ThemQLKH(QUAN_LY_KHACH_HANG QLKH);
        bool XoaQLKH(QUAN_LY_KHACH_HANG QLKH);
        DataTable timKiemKhachHang(string query, string txtTimKiem, string variable);
        DataTable TimKiem_MaKH(string txtMaKH);
        DataTable TimKiem_TenKH(string txtTenKH);
    }
    public class QUAN_LY : PERSON, IQUAN_LY
    {
        private string _maQL;

        public string maQL { get => _maQL; set => _maQL = value; }
        public QUAN_LY(string maQL, string ten, string cmnd, string ngaySinh, string gioiTinh, string diaChi, string sdt) : base(ten, cmnd, ngaySinh, gioiTinh, diaChi, sdt)
        {
            this._maQL = maQL;
        }
        public QUAN_LY() { }

        CONNECT DBConnect = new CONNECT();

        /* Xử lý bảng khách hàng */

        // lấy thông tin khách khàng
        public DataTable hienThiKhachHang()
        {
            DataTable dt = new DataTable();
            string query = "dbo.HienThiKH";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            return dt;
        }

        // Phương thức xử lý chung thêm, sửa xóa
        public bool quanLyKhachHang(string query, KHACH_HANG KH)
        {
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("MaKH", KH.MaKH);
                cmd.Parameters.AddWithValue("TenKH", KH.ten);
                cmd.Parameters.AddWithValue("CMND", KH.cmnd);
                cmd.Parameters.AddWithValue("NgaySinh", KH.ngaySinh);
                cmd.Parameters.AddWithValue("GioiTinh", KH.gioiTinh);
                cmd.Parameters.AddWithValue("DiaChi", KH.diaChi);
                cmd.Parameters.AddWithValue("SDT", KH.sdt);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Thêm khách hàng
        public bool themKhachHang(KHACH_HANG KH, QUAN_LY_KHACH_HANG QLKH)
        {
            string query = "dbo.ThemKH";
            if (quanLyKhachHang(query, KH) && ThemQLKH(QLKH))
            {
                return true;
            }
            return false;
        }

        // Sửa khách hàng
        public bool suaKhachHang(KHACH_HANG KH)
        {
            string query = "dbo.SuaKH";
            if (quanLyKhachHang(query, KH)) { return true; }
            return false;
        }

        // Xóa khách hàng
        public bool xoaKhachHang(KHACH_HANG KH, QUAN_LY_KHACH_HANG QLKH)
        {
            string query = "dbo.XoaKH";
            if (XoaQLKH(QLKH) && XoaTietKiem(KH.MaKH) && XoaGiaoDich(KH.MaKH) && XoaTTTK_QLKH(KH.MaKH)
                && XoaTKDN_QLKH(KH.MaKH) && quanLyKhachHang(query, KH)) { return true; }
            return false;
        }

        // Tìm kiếm khách hàng
        public DataTable timKiemKhachHang(string query, string txtTimKiem, string variable)
        {
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue($"{variable}", txtTimKiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch { return null; }
            finally { conn.Close(); }
        }

        // Tìm kiếm theo mã khách hàng
        public DataTable TimKiem_MaKH(string txtMaKH)
        {
            string query = "dbo.TimKiemKH_MaKH";
            return timKiemKhachHang(query, txtMaKH, "MaKH");
        }

        // Tìm kiếm theo tên khách hàng
        public DataTable TimKiem_TenKH(string txtTenKH)
        {
            string query = "dbo.TimKiemKH_TenKH";
            return timKiemKhachHang(query, txtTenKH, "TenKH");
        }

        // Hàm xử lý bảng qlkh
        public bool XuLyBangQLKH(QUAN_LY_KHACH_HANG QLKH, string query)
        {
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("MaKH", QLKH.MaKH);
                cmd.Parameters.AddWithValue("MaQL", QLKH.MaQL);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Thêm vào bảng quản lý khách hàng
        public bool ThemQLKH(QUAN_LY_KHACH_HANG QLKH)
        {
            string query = "dbo.ThemQLKH";
            if (XuLyBangQLKH(QLKH, query))
            {
                return true;
            }
            return false;
        }

        // Xóa dữ liệu bảng quản lý khách hàng
        public bool XoaQLKH(QUAN_LY_KHACH_HANG QLKH)
        {
            string query = "dbo.XoaQLKH";
            if (XuLyBangQLKH(QLKH, query))
            {
                return true;
            }
            return false;
        }

        /* Xử lý bảng thông tin tài khoản khách hàng */
        // Thêm bảng Thông tin tài khoản
        public bool ThemTTTK(THONG_TIN_TAI_KHOAN TTTK)
        {
            string query = "dbo.ThemTTTK";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("SoTK", TTTK.SoTaiKhoan);
                cmd.Parameters.AddWithValue("SoDu", TTTK.SoDu);
                cmd.Parameters.AddWithValue("NgayCap", TTTK.NgayCap);
                cmd.Parameters.AddWithValue("TenCN", TTTK.TenCN);
                cmd.Parameters.AddWithValue("LoaiTK", TTTK.LoaiKH);
                cmd.Parameters.AddWithValue("MaKH", TTTK.MaKH);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Xóa bảng Thông tin tài khoản
        public bool XoaTTTK(THONG_TIN_TAI_KHOAN TTTK)
        {
            string query = "dbo.XoaTTTK";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) 
                { 
                    CommandType = CommandType.StoredProcedure 
                };
                cmd.Parameters.AddWithValue("SoTK", TTTK.SoTaiKhoan);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        
        // Xóa thông tin tài khoản khi dùng chức năng xóa KH ở form QLKH
        public bool XoaTTTK_QLKH(string MaKH)
        {
            if(!Check_TTTK(MaKH)) { return true; }
            string query = "dbo.XoaTTTK_QLKH";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Hàm check xem khách hàng đã có thông tin tài khoản hay chưa
        public bool Check_TTTK(string MaKH)
        {
            string query = "dbo.LaySoTK";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { 
                    CommandType = CommandType.StoredProcedure 
                };
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                SqlDataReader read = cmd.ExecuteReader();
                if(read.Read()) { return true; }
            } catch { }
            finally { conn.Close(); }
            return false;
        }

        /* Xử lý bảng Tài khoản đăng nhập */
        // Kiểm tra mã tk đã tồn tại chưa
        public bool Check_MaTK(string txtMaTK)
        {
            string query = "dbo.LayMaTK";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { 
                    CommandType = CommandType.StoredProcedure 
                };
                cmd.Parameters.AddWithValue("MaTK", txtMaTK);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read()) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Thêm vào tài khoản đăng nhập
        public bool ThemTKDN(TaiKhoan TKDN)
        {
            string query = "dbo.ThemTKDN";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { 
                    CommandType = CommandType.StoredProcedure 
                };
                cmd.Parameters.AddWithValue("MaTK", TKDN.MaTaiKhoan);
                cmd.Parameters.AddWithValue("TenTK", TKDN.TenTaiKhoan);
                cmd.Parameters.AddWithValue("MK", TKDN.MatKhau);
                cmd.Parameters.AddWithValue("Email", TKDN.Email);
                cmd.Parameters.AddWithValue("MaKH", TKDN.MaKhachHang);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Xóa tài khoản đăng nhập
        public bool XoaTKDN(TaiKhoan TKDN)
        {
            string query = "dbo.XoaTKDN";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { 
                    CommandType = CommandType.StoredProcedure 
                };
                cmd.Parameters.AddWithValue("MaTK", TKDN.MaTaiKhoan);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Xóa tài khoản đăng nhập khi dùng chức năng xóa KH ở form QLKH
        public bool XoaTKDN_QLKH(string MaKH)
        {
            if (!Check_TKDN(MaKH))
            {
                return true;
            }
            string query = "dbo.XoaTKDN_QLKH";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { 
                    CommandType = CommandType.StoredProcedure 
                };
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Hàm check xem khách hàng đã có tài đăng nhập hay chưa
        public bool Check_TKDN(string MaKH)
        {
            string query = "dbo.LayMaTK_QLKH";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { 
                    CommandType = CommandType.StoredProcedure 
                };
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                SqlDataReader read = cmd.ExecuteReader();
                if(read.Read()) { return true; }
            } catch { }
            finally { conn.Close(); }
            return false;
        }

        // Hàm check xem khách hàng có gửi tiết kiệm hay k
        public bool Check_TietKiem(string MaKH)
        {
            string query = "dbo.Check_TietKiem";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Xóa tiết kiệm
        public bool XoaTietKiem(string MaKH)
        {
            // Nếu khách hàng chưa gửi tiết kiệm thì ko xóa được nên nếu kh chưa gửi thì trả về true
            if (!Check_TietKiem(MaKH))
            {
                return true;
            }
            string query = "dbo.XoaTietKiem_QLKH";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Check khách hàng đã giao dịch hay chưa
        public bool Check_GiaoDich(string MaKH)
        {
            string query = "dbo.Check_GiaoDich";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        // Xóa giao dịch
        public bool XoaGiaoDich(string MaKH)
        {
            // Nếu khách hàng chưa giao dịch thì ko xóa được nên nếu kh chưa gd thì trả về true
            if (!Check_GiaoDich(MaKH))
            {
                return true;
            }
            string query = "dbo.XoaGiaoDich_QLKH";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("MaKH", MaKH);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
    }
}