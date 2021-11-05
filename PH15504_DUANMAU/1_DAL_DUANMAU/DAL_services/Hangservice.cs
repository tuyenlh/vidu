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
    public class Hangservice : IHangservice
    {
        private DB_Context _context = new DB_Context();

        public string addH(Hang h)
        {
            try
            {
                _context.Hangs.Add(h);
                return "thêm thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public string updateH(Hang h)
        {

            try
            {
                _context.Hangs.Update(h);
                return "Sửa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public string deleteH(Hang h)
        {

            try
            {
                _context.Hangs.Remove(h);
                return "Xóa thành công";

            }
            catch (Exception e)
            {
                return e.Message;

            }
        }

        public string saveH()
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

        public List<Hang> listH()
        {
            return _context.Hangs.ToList();
        }
    }
}
