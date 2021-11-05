using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.DAL_services;
using _1_DAL_DUANMAU.Entity;
using _1_DAL_DUANMAU.IDAL_services;
using _2_BUS_DUANMAU.IBUS_Services;

namespace _2_BUS_DUANMAU.BUS_sevices
{
    public class BUSsanphamservice :IBUSsanphamservice
    {
        private IHangservice _hangservice;

        public BUSsanphamservice()
        {
            _hangservice = new Hangservice();
        }
        public string addH(Hang H)
        {
            _hangservice.addH(H);
            return "Thành công";
        }

        public string updateH(Hang H)
        {
            _hangservice.updateH(H);
            return "Thành công";
        }

        public string deleteH(Hang H)
        {
            _hangservice.deleteH(H);
            return "Thành công";
        }

        public string saveH()
        {
            _hangservice.saveH();
            return "Thành công";
        }

        public List<Hang> getlistH()
        {
            return _hangservice.listH();
            
        }

        public List<Hang> getlistHtk(string mah)
        {
            return _hangservice.listH().Where(c => c.MaHang.StartsWith(mah)).ToList();
        }
    }
}
