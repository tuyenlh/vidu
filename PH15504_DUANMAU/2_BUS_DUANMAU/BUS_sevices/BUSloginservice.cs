using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DUANMAU.DAL_services;
using _1_DAL_DUANMAU.Entity;
using _1_DAL_DUANMAU.IDAL_services;
using _2_BUS_DUANMAU.IBUS_Services;

namespace _2_BUS_DUANMAU.BUS_sevices
{
    public class BUSloginservice : IBUSloginservice
    {
        private INhanvienService DAL_NV;

        public BUSloginservice()
        {
            DAL_NV = new NhanvienService();
        }
        public bool BUSnhanviendangnhap(NhanVien acc)
        {
            if (DAL_NV.listnv().Any(c => c.Email == acc.Email && c.MatKhau == acc.MatKhau))
            {
                return true;
            }

            return false;
        }

        public bool BUSkiemtraQuenmatkhau(string mail)
        {
            if (DAL_NV.listnv().Any(c => c.Email == mail))
            {

                return true;
            }

            return false;
        }

        public bool BUSdoimatkhau(string mail, string matkhaumoi)
        {
            if (DAL_NV.listnv().Any(c => c.Email == mail))
            {
                NhanVien a = new NhanVien();
                a = DAL_NV.listnv().FirstOrDefault(c => c.Email == mail);
                a.MatKhau = matkhaumoi;
                DAL_NV.updatenv(a);
                DAL_NV.savenv();
                return true;
            }

            return false;
        }

        public int BUSvaitronv(string mail)
        {
            if (DAL_NV.listnv().Any(c => c.Email == mail))
            {
                NhanVien nv = new NhanVien();

                int vt = DAL_NV.listnv().Where(c => c.Email == mail).Select(c => c.VaiTro).FirstOrDefault();
                return vt;
            }

            return 100000000;
        }

        public bool BUSupdatepassword(string mkcu, string mkmoi, string email)
        {
            if (DAL_NV.listnv().Any(c => c.Email == email && c.MatKhau == mkcu))
            {
                NhanVien nv = new NhanVien();
                nv = DAL_NV.listnv().FirstOrDefault(c => c.Email == email);
                nv.MatKhau = mkmoi;
                DAL_NV.updatenv(nv);
                DAL_NV.savenv();
                return true;
            }

            return false;
        }
        public string BUSMahoaPassWord(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }

            return encryptdata.ToString();
        }

    }
}
