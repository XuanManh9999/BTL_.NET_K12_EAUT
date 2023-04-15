using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_GiaoDichTienRa
    {
        KHACH_HANG kh = new KHACH_HANG();
        public List<rpGiaoDichTienRa> XemGiaoDichTienRa(string MaKH)
        {
            return kh.XemGiaoDichTienRa(MaKH);
        }
    }
}
