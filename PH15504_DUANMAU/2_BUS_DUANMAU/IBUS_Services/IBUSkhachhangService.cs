using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;

namespace _2_BUS_DUANMAU
{
    public interface IBUSkhachhangService
    {
        public string addkh(KhachHang khachHang);
        public string updatekh(KhachHang khachHang);
        public string deletekh(KhachHang khachHang);
        public string savekh();
        public List<KhachHang> getlistkh();
        public List<KhachHang> getlistkhtk(string sdt);
    }
}
