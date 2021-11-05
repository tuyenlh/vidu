using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;

namespace _1_DAL_DUANMAU.IDAL_services
{
    public interface INhanvienService
    {
        public string addnv(NhanVien nv);
        public string updatenv(NhanVien nv);
        public string deletenv(NhanVien nv);
        public string savenv();
        public List<NhanVien> listnv();
    }
}
