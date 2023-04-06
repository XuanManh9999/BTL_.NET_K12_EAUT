using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface ITIET_KIEM_VA_GIAO_DICH
    {
        string soTienGD { get; set; }
        string noiDungGD { get; set; }
        string thoiGianGD { get; set; }
    }
    public class TIET_KIEM_VA_GIAO_DICH : ITIET_KIEM_VA_GIAO_DICH
    {
        public string soTienGD { get; set; }
        public string noiDungGD { get; set; }
        public string thoiGianGD { get; set; }
        public TIET_KIEM_VA_GIAO_DICH()
        {

        }
        public TIET_KIEM_VA_GIAO_DICH(string soTienGD, string noiDungGD, string thoiGianGD)
        {
            this.soTienGD = soTienGD;
            this.noiDungGD = noiDungGD;
            this.thoiGianGD = thoiGianGD;
        }
    }
}
