using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TAI_KHOAN_DANG_NHAP
    {
        private string _maTK;
        private string _tenTK;
        private string _matKhau;
        private string _maKH;
        public string MaTK { get => _maTK; set => _maTK = value; }
        public string TenTK { get => _tenTK; set => _tenTK = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public TAI_KHOAN_DANG_NHAP(string _maTK, string _tenTK, string _matKhau, string _maKH)
        {
            this._maTK = _maTK;
            this._tenTK = _tenTK;
            this._matKhau = _matKhau;
            this._maKH = _maKH;
        }
        public TAI_KHOAN_DANG_NHAP()
        {

        }
    }
}
