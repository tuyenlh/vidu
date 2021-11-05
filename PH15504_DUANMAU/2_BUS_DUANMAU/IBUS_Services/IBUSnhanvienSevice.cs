using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;

namespace _2_BUS_DUANMAU.IBUS_Services
{
    public interface IBUSnhanvienSevice
    {
        public String addnv(NhanVien nv);
        public String updatenv(NhanVien nv);
        public String deletenv(NhanVien nv);
        public String savenv();
        public int GetMaxID();
        public List<NhanVien> getlistnv();
        public List<NhanVien> getlistnvtk(string acc);
    }
}
