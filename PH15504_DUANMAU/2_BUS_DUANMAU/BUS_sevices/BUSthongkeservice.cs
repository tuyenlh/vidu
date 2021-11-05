using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.DAL_services;
using _1_DAL_DUANMAU.Entity;
using _1_DAL_DUANMAU.IDAL_services;
using _2_BUS_DUANMAU.IBUS_Services;
using _2_BUS_DUANMAU.Models;

namespace _2_BUS_DUANMAU.BUS_sevices
{
    public class BUSthongkeservice:IBUSthongkeservice
    {
        private INhanvienService _nhanvienService;
        private IHangservice _hangservice;
        private List<ModelThongKe> _lstmodelThong;
        private List<NhanVien> _lstNhanViens;
        private List<Hang> _lstHangs;
        public BUSthongkeservice()
        {
            _nhanvienService = new NhanvienService();
            _lstmodelThong = new List<ModelThongKe>();
            _hangservice = new Hangservice();
            _lstHangs = new List<Hang>();
            _lstNhanViens = new List<NhanVien>();
            loatthongke();

        }
        public List<ModelThongKe> listthongke()
        {
            return _lstmodelThong;
        }

        public void loatthongke()
        {
            _lstHangs = _hangservice.listH();
            _lstNhanViens = _nhanvienService.listnv();
            var tame = (from a in _lstNhanViens
                join
                    b in _lstHangs on a.Ma_NhanVien equals b.Ma_NhanVien
                select new
                {
                    NhanVien = a,
                    hang = b
                }).ToList();
           tame.ForEach(x=>
           {
               ModelThongKe a = new ModelThongKe();
               a.hang = x.hang;
               a.nhanvien = x.NhanVien;
               _lstmodelThong.Add(a);
           });
        }
    }
}
