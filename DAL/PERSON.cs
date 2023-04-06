using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IPerson
    {
        string ten { get; set; }
        string cmnd { get; set; }
        string ngaySinh { get; set; }
        string gioiTinh { get; set; }
        string diaChi { get; set; }
        string sdt { get; set; }
    }
    public class PERSON
    {
        public string ten { get; set; }
        public string cmnd { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public PERSON()
        {

        }
        public PERSON(string ten, string cmnd, string ngaySinh, string gioiTinh, string diaChi, string sdt)
        {
            this.ten = ten;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }
    }
}
