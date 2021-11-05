using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.Entity;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DUANMAU.DB_context
{
    public class DB_Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=LAPTOP-OD9HM4DG\\SQLEXPRESS;Initial Catalog=Duanmau;User ID=asm_tuyen;Password=222");
            }

        }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Hang> Hangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
    }
}
