using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;

namespace _2_BUS_DUANMAU.IBUS_Services
{
    public interface IBUSsanphamservice
    {
        public String addH(Hang H);
        public String updateH(Hang H);
        public String deleteH(Hang H);
        public String saveH();
        public List<Hang> getlistH();
        public List<Hang> getlistHtk(string mah);
    }
}
