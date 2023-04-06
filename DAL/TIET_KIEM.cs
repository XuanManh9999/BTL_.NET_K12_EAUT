using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TIET_KIEM : TIET_KIEM_VA_GIAO_DICH
    {
        private string _maTietKiem;
        private string _maTK;

        public string MaTietKiem { get => _maTietKiem; set => _maTietKiem = value; }
        public string MaTK { get => _maTK; set => _maTK = value; }
        public TIET_KIEM(string _maTietKiem, string soTienGD, string noiDungGD, string thoiGianGD, string _maTK) : base(soTienGD, noiDungGD, thoiGianGD)
        {
            this._maTietKiem = _maTietKiem;
            this._maTK = _maTK;
        }
        public TIET_KIEM()
        {

        }
    }
}
