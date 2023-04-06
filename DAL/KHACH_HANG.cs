using System;
using System.Collections.Generic;
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
        void xemCTGD();
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
        public void xemCTGD()
        {

        }
    }
}
