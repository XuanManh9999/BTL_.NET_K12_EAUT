using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_QuenMK
    {
        KHACH_HANG KH = new KHACH_HANG();
        public string LayLaiMK(string txtEmail)
        {
            return KH.quenMK(txtEmail);
        }
    }
}
