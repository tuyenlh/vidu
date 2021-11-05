using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;

namespace _2_BUS_DUANMAU.Models
{
    public class ModelThongKe
    {
        public NhanVien nhanvien { get; set; }
        public Hang hang { get; set; }

        public ModelThongKe()
        {
            nhanvien = new NhanVien();
            hang = new Hang();
        }

        public ModelThongKe(NhanVien nhanvien, Hang hang)
        {
            nhanvien = nhanvien;
            hang = hang;
        }

    }
}
