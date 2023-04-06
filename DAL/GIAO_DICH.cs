using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GIAO_DICH : TIET_KIEM_VA_GIAO_DICH
    {
        private string _maGD;
        private string _soTKNhan;
        private string _soTKGui;

        public string MaGD { get => _maGD; set => _maGD = value; }
        public string SoTKNhan { get => _soTKNhan; set => _soTKNhan = value; }
        public string SoTKGui { get => _soTKGui; set => _soTKGui = value; }

        public GIAO_DICH(string _maGD, string soTienGD, string noiDungGD, string thoiGianGD, string _soTKNhan, string _soTKGui) : base(soTienGD, noiDungGD, thoiGianGD)
        {
            this._maGD = _maGD;
            this._soTKNhan = _soTKNhan;
            this._soTKGui = _soTKGui;
        }
        public GIAO_DICH()
        {

        }
    }
}
