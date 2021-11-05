using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_DUANMAU.Models;

namespace _2_BUS_DUANMAU.IBUS_Services
{
    public interface IBUSthongkeservice
    {
        public List<ModelThongKe> listthongke();
        // truyền dữ liệu của hàng và nhân viên vào modelthongke
        public void loatthongke();
    }
}
