using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_DUANMAU
{
    public partial class FormMain : Form
    {
        public static int session = 0;
        public static int profile = 0;
        public static string mail;
        private Thread th;
        private formLI dn;
        public FormMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLI a = new formLI();
            a.Show();
            a.FormClosed += new FormClosedEventHandler(FormMain_Load);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoimatkhau a = new FormDoimatkhau(FormMain.mail);
            a.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLI m = new formLI();
           
            m.Show();
            m.FormClosed += new FormClosedEventHandler(FormMain_Load);

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLySanPham a = new FormQuanLySanPham();
            a.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyNhanVien m = new FormQuanLyNhanVien();

            m.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang m = new FormQuanLyKhachHang();

            m.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            reset();
            if (profile == 1)
            {
                lal_helo.Text = null;
                profile = 0;
            }
        }
        public void reset()
        {
            if (session == 1)
            {
                lal_helo.Text = "chào : "+ " " + FormMain.mail;
                đổiMậtKhẩuToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Visible = true;
                thoátToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                sảnPhẩmToolStripMenuItem.Visible = true;
                nhânViênToolStripMenuItem.Visible = true;
                kháchHàngToolStripMenuItem.Visible = true;
                if (formLI.vaitro == 0)
                {
                    nhânViênToolStripMenuItem.Visible = false;
                    thốngKêToolStripMenuItem.Visible = false;
                }
            }
            else
            {
                đăngNhậpToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = false;
                thoátToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = false;
                sảnPhẩmToolStripMenuItem.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
                kháchHàngToolStripMenuItem.Visible = false;
                đổiMậtKhẩuToolStripMenuItem.Visible = false;
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe a = new FormThongKe();
            a.Show();
        }
    }
}
