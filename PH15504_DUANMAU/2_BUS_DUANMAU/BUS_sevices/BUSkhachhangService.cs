using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.DAL_services;
using _1_DAL_DUANMAU.Entity;
using _1_DAL_DUANMAU.IDAL_services;

namespace _2_BUS_DUANMAU.BUS_sevices
{
    public class BUSkhachhangService : IBUSkhachhangService

    {
        private IKhachhangService _khachhang;

        public BUSkhachhangService()
        {
            _khachhang = new KhachhangService();
        }
        public string addkh(KhachHang khachHang)
        {
            _khachhang.addkh(khachHang);
            return "Thành công";
        }

        public string updatekh(KhachHang khachHang)
        {
            _khachhang.updatekh(khachHang);
            return "Thành công";

        }

        public string deletekh(KhachHang khachHang)
        {
            KhachHang kh = new KhachHang();
            kh = _khachhang.listkh().Find(c => c.SDT == khachHang.SDT);
            _khachhang.deletekh(kh);
            return "Thành công";
        }

        public string savekh()
        {


            _khachhang.savekh();
            return "Thành công";
        }

        public List<KhachHang> getlistkh()
        {
            return _khachhang.listkh();
        }

        public List<KhachHang> getlistkhtk(string sdt)
        {
            return _khachhang.listkh().Where(c => c.SDT.StartsWith(sdt)).ToList();
        }
    }
}
