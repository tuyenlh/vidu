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
    public class BUSnhanvienSevice : IBUSnhanvienSevice

    {
        private INhanvienService _nhanvienService;

        public BUSnhanvienSevice()
        {
            _nhanvienService = new NhanvienService();
        }
        public string addnv(NhanVien nv)
        {
            _nhanvienService.addnv(nv);
            return "Thành công";
        }

        public string updatenv(NhanVien nv)
        {
            _nhanvienService.updatenv(nv);
            return "Thành công";
        }

        public string deletenv(NhanVien nv)
        {
            _nhanvienService.deletenv(nv);
            return "Thành công";
        }

        public string savenv()
        {
            _nhanvienService.savenv();
            return "Thành công";
        }

        public List<NhanVien> getlistnv()
        {

            return _nhanvienService.listnv(); ;
        }

        public List<NhanVien> getlistnvtk(string acc)
        {
            return _nhanvienService.listnv().Where(c => c.TenNhanVien.StartsWith(acc)).ToList();
        }

        public int GetMaxID()
        {
            if (_nhanvienService.listnv().Count == 0)
            {
                return 1000;
            }
            return _nhanvienService.listnv().Max(x => x.ID_NhanVien);
        }
    }
}
