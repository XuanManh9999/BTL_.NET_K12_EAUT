using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface ITHONG_TIN_TAI_KHOAN
    {
        void xemThongTin();
    }
    public class THONG_TIN_TAI_KHOAN : ITHONG_TIN_TAI_KHOAN
    {
        private string _soTaiKhoan;
        private string _soDu;
        private string _ngayCap;
        private string _tenCN;
        private string _loaiKH;
        private string _maKH;
        public string SoTaiKhoan { get => _soTaiKhoan; set => _soTaiKhoan = value; }
        public string SoDu { get => _soDu; set => _soDu = value; }
        public string NgayCap { get => _ngayCap; set => _ngayCap = value; }
        public string TenCN { get => _tenCN; set => _tenCN = value; }
        public string LoaiKH { get => _loaiKH; set => _loaiKH = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }

        public void xemThongTin()
        {

        }
        public THONG_TIN_TAI_KHOAN()
        {

        }
        public THONG_TIN_TAI_KHOAN(string _soTaiKhoan, string _soDu, string _ngayCap, string _tenCN, string _loaiKH, string _maKH)
        {
            this._soTaiKhoan = _soTaiKhoan;
            this.SoDu = _soDu;
            this._ngayCap = _ngayCap;
            this._tenCN = _tenCN;
            this._loaiKH = _loaiKH;
            this._maKH = _maKH;
        }
    }
}
