using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_DangKyTK
    {
        KHACH_HANG kh = new KHACH_HANG();
        QUAN_LY quanLy = new QUAN_LY();
        // Kiểm tra mã khách hàng đã tồn tại hay chưa
        public bool Check_MaKH(string txtMaKH)
        {
            return kh.Check_MaKH(txtMaKH);
        }
        // Thêm vào bảng thông tin tài khoản
        public bool ThemTTTK(THONG_TIN_TAI_KHOAN TTTK)
        {
            return quanLy.ThemTTTK(TTTK);
        }
        // Xóa bảng thông tin tài khoản
        public bool XoaTTTK(THONG_TIN_TAI_KHOAN TTTK)
        {
            return quanLy.XoaTTTK(TTTK);
        }
        /* Xử lý bảng Tài khoản đăng nhập */
        public bool Check_MaTK(string txtMaTK)
        {
            return quanLy.Check_MaTK(txtMaTK);
        }
        // Thêm vào bảng Tài khoản đăng nhập
        public bool ThemTKDN(TaiKhoan TKDN)
        {
            return quanLy.ThemTKDN(TKDN);
        }
        // Xóa bảng Tài khoản đăng nhập
        public bool XoaTKDN(TaiKhoan TKDN)
        {
            return quanLy.XoaTKDN(TKDN);
        }
    }
}
