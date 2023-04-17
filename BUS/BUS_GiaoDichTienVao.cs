using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_GiaoDichTienVao
    {
        KHACH_HANG KH = new KHACH_HANG();
        public List<rpGiaoDichTienVao> XemGiaoDichTienVao(string MaKH)
        {
            return KH.XemGiaoDichTienVao(MaKH);
        }
    }
}
