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
    public class KhachhangService : IKhachhangService

    {
        private DB_Context _context = new DB_Context();

        public string addkh(KhachHang kh)
        {
            try
            {
                _context.KhachHangs.Add(kh);
                return "thêm thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public string updatekh(KhachHang kh)
        {

            try
            {
                _context.KhachHangs.Update(kh);
                return "Sửa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public string deletekh(KhachHang kh)
        {

            try
            {
                _context.KhachHangs.Remove(kh);
                return "Xóa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public string savekh()
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

        public List<KhachHang> listkh()
        {
            return _context.KhachHangs.ToList();
        }
    }
}
