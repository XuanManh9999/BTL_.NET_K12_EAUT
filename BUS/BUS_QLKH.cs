using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BUS
{
    public class BUS_QLKH
    {
        QUAN_LY QuanLy = new QUAN_LY();
        // Lấy dữ liệu khách hàng từ DAL
        public DataTable getData()
        {
            return QuanLy.hienThiKhachHang();
        }
        // Thêm khách hàng
        public bool ThemKhachHang(KHACH_HANG KH, QUAN_LY_KHACH_HANG QLKH)
        {
            if(QuanLy.themKhachHang(KH, QLKH))
            {
                return true;
            }
            return false;
        }
        // Sửa khách hàng
        public bool SuaKhachHang(KHACH_HANG KH)
        {
            if(QuanLy.suaKhachHang(KH)) { return true; }
            return false;
        }
        // Xóa khách hàng
        public bool XoaKhachHang(KHACH_HANG KH, QUAN_LY_KHACH_HANG QLKH)
        {
            if(QuanLy.xoaKhachHang(KH, QLKH)) { return true; }
            return false;
        }
        // Tìm kiếm mã KH
        public DataTable TimKiem_MaKH(string txtMaKH)
        {
            return QuanLy.TimKiem_MaKH(txtMaKH);
        }
        // Tìm kiếm tên KH
        public DataTable TimKiem_TenKH(string txtTenKH)
        {
            return QuanLy.TimKiem_TenKH(txtTenKH);
        }
    }
}
