﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DUANMAU.Entity
{
    public class Hang
    {
        public int ID_Hang { get; set; }
        [StringLength(20)]
        [Required]
        [Key]
        public string MaHang { get; set; }
        [StringLength(20)]
        [Required]
        public string TenHang { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public int DonGiaNhap { get; set; }
        [Required]
        public int DonGiaBan { get; set; }
        [Required]
        public string AnhHang { get; set; }
        public string GhiChu { get; set; }
        [ForeignKey("NhanVien")]
        [Required]
        [StringLength(20)]
        public string Ma_NhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
