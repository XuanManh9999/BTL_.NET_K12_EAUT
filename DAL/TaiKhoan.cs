using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoan
    {
        private string maTaiKhoan;
        private string tenTaiKhoan;
        private string matKhau;
        private string email;
        private string maKhachHang;
        public TaiKhoan()
        {

        }
       public TaiKhoan(string maTaiKhoan, string tenTaiKhoan, string matKhau, string email, string maKhachHang)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.tenTaiKhoan= tenTaiKhoan;
            this.matKhau= matKhau;
            this.email= email;
            this.maKhachHang = maKhachHang;         
        }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string Email { get => email; set => email = value; }
        
    }
}
