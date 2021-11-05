using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;

namespace _1_DAL_DUANMAU.IDAL_services
{
    public interface IKhachhangService
    {
        public string addkh(KhachHang kh);
        public string updatekh(KhachHang kh);
        public string deletekh(KhachHang kh);
        public string savekh();
        public List<KhachHang> listkh();
    }
}
