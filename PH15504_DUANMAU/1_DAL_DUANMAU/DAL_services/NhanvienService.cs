using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.DB_context;
using _1_DAL_DUANMAU.Entity;
using _1_DAL_DUANMAU.IDAL_services;

namespace _1_DAL_DUANMAU.DAL_services
{
    public class NhanvienService : INhanvienService
    {
        private DB_Context _context = new DB_Context();

        public string addnv(NhanVien nv)
        {

                 _context.NhanViens.Add(nv);
                return "thêm thành công";

          
        }

        public string updatenv(NhanVien nv)
        {

            try
            {
                _context.NhanViens.Update(nv);
                return "Sửa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public string deletenv(NhanVien nv)
        {

            try
            {
                _context.NhanViens.Remove(nv);
                return "Xóa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public string savenv()
        {
            try
            {
                _context.SaveChanges();
                return "lưu thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public List<NhanVien> listnv()
        {
            return _context.NhanViens.ToList();
        }
    }
}
