﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DUANMAU.Entity
{
    public class KhachHang
    {
        [Key]
        [StringLength(20)]
        public string SDT { get; set; }
        [StringLength(50)]
        [Required]
        public string TenKhachHang { get; set; }
        [StringLength(100)]
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public int GioiTinh { get; set; }
        public NhanVien Ma_NanVien { get; set; }
    }
}
