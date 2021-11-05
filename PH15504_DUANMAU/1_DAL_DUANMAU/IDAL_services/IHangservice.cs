using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;

namespace _1_DAL_DUANMAU.IDAL_services
{
    public interface IHangservice
    {
        public string addH(Hang h);
        public string updateH(Hang kh);
        public string deleteH(Hang kh);
        public string saveH();
        public List<Hang> listH();
    }
}
