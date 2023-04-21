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
            string query = "Select * from KhachHang";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            return dt;
        }
        // Hàm xử lý chung thêm, sửa xóa
        public bool quanLyKhachHang(string query, KHACH_HANG KH)
        {
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
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
            string query = "Insert into KhachHang values (@MaKH, @TenKH, @CMND, @NgaySinh, @GioiTinh, @DiaChi, @SDT)";
            if (quanLyKhachHang(query, KH) && ThemQLKH(QLKH))
            {
                return true;
            }
            return false;
        }
        // Sửa khách hàng
        public bool suaKhachHang(KHACH_HANG KH)
        {
            string query = "Update KhachHang set TenKH = @TenKH, CMND = @CMND, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT where MaKH = @MaKH";
            if(quanLyKhachHang(query, KH)) { return true; }
            return false;
        }
        // Xóa khách hàng
        public bool xoaKhachHang(KHACH_HANG KH, QUAN_LY_KHACH_HANG QLKH)
        {
            string query = "Delete KhachHang where MaKH = @MaKH";
            if(XoaQLKH(QLKH) && quanLyKhachHang(query, KH)) { return true; }
            return false;
        }
        // Tìm kiếm khách hàng
        public DataTable timKiemKhachHang(string query, string txtTimKiem, string variable)
        {
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue($"{variable}", txtTimKiem);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            } catch { return null; }
            finally { conn.Close(); }
        }
        // Tìm kiếm theo mã khách hàng
        public DataTable TimKiem_MaKH(string txtMaKH)
        {
            string query = "Select * from KhachHang where MaKH = @MaKH";
            return timKiemKhachHang(query, txtMaKH, "MaKH");
        }
        // Tìm kiếm theo tên khách hàng
        public DataTable TimKiem_TenKH(string txtTenKH)
        {
            string query = "Select * from KhachHang where TenKH = @TenKH";
            return timKiemKhachHang(query, txtTenKH, "TenKH");
        }
        
        // Hàm xử lý bảng qlkh
        public bool XuLyBangQLKH(QUAN_LY_KHACH_HANG QLKH, string query)
        {
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
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
            string query = "Insert into QuanLyKhachHang values (@MaKH, @MaQL)";
            if(XuLyBangQLKH(QLKH, query))
            {
                return true;
            }
            return false;
        }
        // Xóa dữ liệu bảng quản lý khách hàng
        public bool XoaQLKH(QUAN_LY_KHACH_HANG QLKH)
        {
            string query = "Delete QuanLyKhachHang where MaKH = @MaKH";
            if(XuLyBangQLKH(QLKH, query))
            {
                return true;
            }
            return false;
        }

        /* Xử lý bảng thông tin tài khoản khách hàng */
        // Thêm bảng Thông tin tài khoản
        public bool ThemTTTK(THONG_TIN_TAI_KHOAN TTTK)
        {
            string query = "Insert into ThongTinTaiKhoan values (@SoTK, @SoDu, @NgayCap, @TenCN, @LoaiTK, @MaKH)";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("SoTK", TTTK.SoTaiKhoan);
                cmd.Parameters.AddWithValue("SoDu", TTTK.SoDu);
                cmd.Parameters.AddWithValue("NgayCap", TTTK.NgayCap);
                cmd.Parameters.AddWithValue("TenCN", TTTK.TenCN);
                cmd.Parameters.AddWithValue("LoaiTK", TTTK.LoaiKH);
                cmd.Parameters.AddWithValue("MaKH", TTTK.MaKH);
                if(cmd.ExecuteNonQuery() > 0) { return true; }
            } catch { }
            finally { conn.Close(); }
            return false;
        }
        // Xóa bảng Thông tin tài khoản
        public bool XoaTTTK(THONG_TIN_TAI_KHOAN TTTK)
        {
            string query = "Delete ThongTinTaiKhoan where SoTK = @SoTK";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("SoTK", TTTK.SoTaiKhoan);
                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }

        /* Xử lý bảng Tài khoản đăng nhập */
        // Kiểm tra mã tk đã tồn tại chưa
        public bool Check_MaTK(string txtMaTK)
        {
            string query = "Select MaTK from TaiKhoanDangNhap where MaTK = @MaTK";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaTK", txtMaTK);
                SqlDataReader read = cmd.ExecuteReader();
                if(read.Read()) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Thêm vào tài khoản đăng nhập
        public bool ThemTKDN(TaiKhoan TKDN)
        {
            string query = "Insert into TaiKhoanDangNhap values (@MaTK, @TenTK, @MK, @Email, @MaKH)";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaTK", TKDN.MaTaiKhoan);
                cmd.Parameters.AddWithValue("TenTK", TKDN.TenTaiKhoan);
                cmd.Parameters.AddWithValue("MK", TKDN.MatKhau);
                cmd.Parameters.AddWithValue("Email", TKDN.Email);
                cmd.Parameters.AddWithValue("MaKH", TKDN.MaKhachHang);
                if(cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
        // Xóa tài khoản đăng nhập
        public bool XoaTKDN(TaiKhoan TKDN)
        {
            string query = "Delete TaiKhoanDangNhap where MaTK = @MaTK";
            SqlConnection conn = DBConnect.Chuoi_conn_Hai();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MaTK", TKDN.MaTaiKhoan);
                if(cmd.ExecuteNonQuery() > 0) { return true; }
            } 
            catch { }
            finally { conn.Close(); }
            return false;
        }
    }
}
