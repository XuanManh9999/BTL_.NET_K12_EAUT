using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IQUAN_LY
    {
        void themKhachHang();
        void suaKhachHang();
        void xoaKhachHang();
        void timKiemKhachHang();
    }
    public class QUAN_LY : PERSON, IQUAN_LY
    {
        private string _maQL;

        public string maQL { get => _maQL; set => _maQL = value; }
        public QUAN_LY(string maQL, string ten, string cmnd, string ngaySinh, string gioiTinh, string diaChi, string sdt) : base(ten, cmnd, ngaySinh, gioiTinh, diaChi, sdt)
        {
            this._maQL = maQL;
        }
        public QUAN_LY()
        {

        }
        public void themKhachHang()
        {
        }
        public void suaKhachHang()
        {
        }
        public void xoaKhachHang()
        {
        }
        public void timKiemKhachHang()
        {
        }
    }
}
