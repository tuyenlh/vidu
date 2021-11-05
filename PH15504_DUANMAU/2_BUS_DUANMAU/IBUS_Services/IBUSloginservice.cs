using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;

namespace _2_BUS_DUANMAU.IBUS_Services
{
    public interface IBUSloginservice
    {
        public bool BUSnhanviendangnhap(NhanVien acc);
        public bool BUSkiemtraQuenmatkhau(string mail);
        public bool BUSdoimatkhau(string mail, string matkhaumoi);
        public int BUSvaitronv(string mail);
        public bool BUSupdatepassword(string mkcu, string mkmoi, string email);
        public string BUSMahoaPassWord(string password);
    }
}
