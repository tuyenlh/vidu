using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_DUANMAU.Tiện_ích
{
    public class Tienich
    {
        public string randomstring(int size, bool a)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToUInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);

            }

            if (a) return builder.ToString().ToLower();
            return builder.ToString();
        }

        public int randomnumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
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
        public void sendmail(string email, string matkhau)
        {
            try
            {
                SmtpClient maicuatoi = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cret = new NetworkCredential("levanhoc001@gmail.com", "0964046838");
                MailMessage mag = new MailMessage();
                mag.From = new MailAddress(email);
                mag.To.Add(email);
                mag.Subject = "bạn đã sử dụng chức năng quên mật khậu";
                mag.Body = "chào anh/chị mật khẩu mới để anh/chị đăng nhập là " + matkhau;
                maicuatoi.Credentials = cret;
                maicuatoi.EnableSsl = true;
                maicuatoi.Send(mag);

            }
            catch (Exception ex)
            {

                return;
            }

        }
        public void sendmailnv(string email, string matkhau)
        {
            try
            {
                SmtpClient maicuatoi = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cret = new NetworkCredential("levanhoc001@gmail.com", "0964046838");
                MailMessage mag = new MailMessage();
                mag.From = new MailAddress(email);
                mag.To.Add(email);
                mag.Subject = "Bạn đã là nhân viên của công ti";
                mag.Body = "chào anh/chị đây là mật khẩu mặc định để anh/chị đăng nhập  :" + matkhau + "\n" + "để đảm bảo hãy đăng nhập và đổi mật khẩu";
                maicuatoi.Credentials = cret;
                maicuatoi.EnableSsl = true;
                maicuatoi.Send(mag);

            }
            catch (Exception ex)
            {

                return;
            }
        }
    }
}
