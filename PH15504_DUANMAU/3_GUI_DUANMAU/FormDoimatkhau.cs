using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_DUANMAU.BUS_sevices;
using _2_BUS_DUANMAU.IBUS_Services;

namespace _3_GUI_DUANMAU
{
    public partial class FormDoimatkhau : Form
    {
        private IBUSloginservice _buSloginservice;
        public FormDoimatkhau(string email)
        {
            InitializeComponent();
            _buSloginservice = new BUSloginservice();
            txtMail.Text = email;
            txtMail.Enabled = false;
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtPass.PasswordChar = '\0';
                txtPassNew.PasswordChar = '\0';
                txtPassNew2.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '$';
                txtPassNew.PasswordChar = '$';
                txtPassNew2.PasswordChar = '$';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập mật khẩu cũ vào", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPass.Focus();
                return;
            }
            else if (txtPassNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập mật khẩu mới vào", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPassNew.Focus();
                return;
            }
            else if (txtPassNew2.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập mật khẩu mới vào", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPassNew2.Focus();
                return;
            }
            else if (txtPassNew2.Text.Trim().Length != txtPassNew.Text.Trim().Length)
            {
                MessageBox.Show("Mật khẩu cũ và mật khẩu mới không trùng nhập lại", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPassNew2.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("bạn có chắc muốn đổi mật khẩu", "thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {

                    string mkcu = _buSloginservice.BUSMahoaPassWord(txtPass.Text);
                    string mkmoi = _buSloginservice.BUSMahoaPassWord(txtPassNew.Text);
                    if (_buSloginservice.BUSupdatepassword(mkcu, mkmoi, txtMail.Text))
                    {
                        MessageBox.Show("đổi rồi đấy check lại xem");
                        FormMain.profile = 1;
                        FormMain.session = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ sai ", "thông báo");
                        txtPass.Text = null;
                        txtPassNew.Text = null;
                        txtPassNew2.Text = null;
                    }
                }
            }
        }

        private void txtPassNew2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }
    }
}
