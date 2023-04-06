using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QUAN_LY_KHACH_HANG
    {
        private string _maKH;
        private string _maQL;

        public string MaKH { get => _maKH; set => _maKH = value; }
        public string MaQL { get => _maQL; set => _maQL = value; }
        public QUAN_LY_KHACH_HANG(string maKH, string maQL)
        {
            this._maKH = maKH;
            this._maQL = maQL;
        }
    }
}
