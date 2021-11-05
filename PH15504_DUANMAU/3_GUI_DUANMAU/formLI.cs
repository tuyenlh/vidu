using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DUANMAU.Entity;
using _2_BUS_DUANMAU.BUS_sevices;
using _2_BUS_DUANMAU.IBUS_Services;
using _2_BUS_DUANMAU.Tiện_ích;

namespace _3_GUI_DUANMAU
{
    public partial class formLI : Form
    {
        private IBUSloginservice _BUSlogin;
        private Tienich _tienich;
        public static int vaitro;
        private NhanVien nv;
        public formLI()
        {
            InitializeComponent();
            _BUSlogin = new BUSloginservice();
            nv = new NhanVien();
            _tienich = new Tienich();
        }

        private void lal_quenPassWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txt_email.Text != "")
            {
                if (_BUSlogin.BUSkiemtraQuenmatkhau(txt_email.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(_tienich.randomstring(4, true));
                    builder.Append(_tienich.randomnumber(1000, 9999));
                    builder.Append(_tienich.randomstring(2, false));
                    string matkhaumoi = _BUSlogin.BUSMahoaPassWord(builder.ToString());
                    _BUSlogin.BUSdoimatkhau(txt_email.Text, matkhaumoi);
                    _tienich.sendmail(txt_email.Text, builder.ToString());
                    MessageBox.Show("Đã có mật khẩu mới gửi về Mail của bạn", "thông báo");

                }
            }
        }

        private void bnt_login_Click(object sender, EventArgs e)
        {
            nv.Email = txt_email.Text;
            nv.MatKhau = _BUSlogin.BUSMahoaPassWord(txt_matkhau.Text);
            if (_BUSlogin.BUSnhanviendangnhap(nv))
            {
                MessageBox.Show("chúc mừng" + txt_email.Text + "đăng nhập thành cônh", "thông báo");
                this.Hide();
                vaitro = _BUSlogin.BUSvaitronv(txt_email.Text);
                FormMain.mail = nv.Email;
                FormMain.session = 1;
                this.Close();

            }
            else
            {
                MessageBox.Show("chúc mừng" + txt_email.Text + "đăng nhập thất bại", "thông báo");
            }
        }

        private void bnt_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
