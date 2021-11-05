using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DUANMAU.Entity;
using _2_BUS_DUANMAU;
using _2_BUS_DUANMAU.BUS_sevices;

namespace _3_GUI_DUANMAU
{
    public partial class FormQuanLyKhachHang : Form
    {
        private string stremail = FormMain.mail;
        private IBUSkhachhangService _buSkhachhang;
        private BUSnhanvienSevice _buSnhanvien;
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
            _buSkhachhang = new BUSkhachhangService();
            _buSnhanvien = new BUSnhanvienSevice();
            loatdata();
            rdnam.Checked = true;
        }


        public bool checkform()
        {
            if (txtsdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số điện thoại không thể để trống","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtsdt.Focus();
                return true;
            }
            else if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("tên không thể để trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return true;
            }
            else if(txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ  không thể để trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return true;
            }
            else if(rdnam.Checked==false&&rdNu.Checked==false)
            {
                MessageBox.Show("Phải chọn nam hoặc nữ không thể để trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdnam.Focus();
                return true;
            }

            return false;
        }
        public void ClearForm()
        {
            txtsdt.Text = "";
            txtHoTen.Text = "";
            txtdiachi.Text = "";
            rdnam.Checked = false;
            rdNu.Checked = false;

        }
        public void loatdata()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Số điện thoại";
            dataGridView1.Columns[1].Name = "Họ và tên";
            dataGridView1.Columns[2].Name = "Địa chỉ ";
            dataGridView1.Columns[3].Name = "Giới tính";
            DataGridViewComboBoxColumn dtgvcmm = new DataGridViewComboBoxColumn();
            dtgvcmm.Name = "cmm";
            dtgvcmm.HeaderText = "Chức năng";
            dtgvcmm.Items.Add( "Thêm") ;
            dtgvcmm.Items.Add( "Sửa") ;
            dtgvcmm.Items.Add( "xóa") ;
            //int indexcmm = 4;
            //if (dataGridView1.Columns["cmm"] == null)
            //{
            //    dataGridView1.Columns.Insert(indexcmm, dtgvcmm);
            //}
            DataGridViewButtonColumn dtgvbt = new DataGridViewButtonColumn();
            dtgvbt.Name = "bt";
            dtgvbt.HeaderText = "Xác nhận";
            dtgvbt.Text = "Xác nhận";
            dtgvbt.UseColumnTextForButtonValue = true;
            //int index = 5;
            //if (dataGridView1.Columns["bt"] == null)
            //{
            //    dataGridView1.Columns.Insert(index, dtgvbt);
            //}
            dataGridView1.Columns.Add(dtgvcmm);
            dataGridView1.Columns.Add(dtgvbt);
            

            dataGridView1.Rows.Clear();
            foreach (var x in _buSkhachhang.getlistkh())
            {
                dataGridView1.Rows.Add("",x.SDT, x.TenKhachHang, x.DiaChi, x.GioiTinh == 1 ? "Nam" : "Nữ");
            }

           
        }
        public void loatdatatk(string sdt)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Số điện thoại";
            dataGridView1.Columns[1].Name = "Họ và tên";
            dataGridView1.Columns[2].Name = "Địa chỉ ";
            dataGridView1.Columns[3].Name = "Giới tính";
            dataGridView1.Rows.Clear();
            foreach (var x in _buSkhachhang.getlistkhtk(sdt))
            {
                dataGridView1.Rows.Add(x.SDT, x.TenKhachHang, x.DiaChi, x.GioiTinh == 1 ? "Nam" : "Nữ");
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkform())return;
            KhachHang kh = new KhachHang();
            kh.SDT = txtsdt.Text;
            kh.TenKhachHang = txtHoTen.Text;
            kh.DiaChi = txtdiachi.Text;
            kh.GioiTinh = rdnam.Checked == true ? 1 : 0;
            //kh.Ma_NanVien = _buSnhanvien.getlistnv().Where(c => c.Email == stremail).Select(c => c.Ma_NhanVien)
                //.FirstOrDefault();
            _buSkhachhang.addkh(kh);
            _buSkhachhang.savekh();
            loatdata();
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _buSkhachhang.savekh();
            loatdata();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            loatdata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                if (index < 0 || index == _buSkhachhang.getlistkh().Count) return;
                txtsdt.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtHoTen.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                if (dataGridView1.Rows[index].Cells[3].Value.ToString() == "Nam")
                {
                    rdnam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }

                if (e.ColumnIndex == dataGridView1.Columns["bt"].Index && dataGridView1.Rows[index].Cells["cmm"].Value.ToString() == "Sửa")
                {

                    if (MessageBox.Show("Bạn  chắc chắc sẽ sửa chứ",
                               "Thông báo",
                               MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        KhachHang kh = new KhachHang();
                        kh = _buSkhachhang.getlistkh().FirstOrDefault(c => c.SDT == txtsdt.Text);
                        kh.TenKhachHang = txtHoTen.Text;
                        kh.DiaChi = txtdiachi.Text;
                        kh.GioiTinh = rdnam.Checked == true ? 1 : 0;
                        _buSkhachhang.updatekh(kh);
                        _buSkhachhang.savekh();
                        loatdata();


                    }
                    return;
                }
                else if (e.ColumnIndex == dataGridView1.Columns["bt"].Index && dataGridView1.Rows[index].Cells["cmm"].Value.ToString() == "xóa")
                {
                    if (MessageBox.Show("bạn muốn xóa chứ", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        KhachHang kh = new KhachHang();
                        kh.SDT = txtsdt.Text;
                        _buSkhachhang.deletekh(kh);
                        _buSkhachhang.savekh();
                        loatdata();
                        ClearForm();
                    }

                }
                else if (e.ColumnIndex == dataGridView1.Columns["bt"].Index && dataGridView1.Rows[index].Cells["cmm"].Value.ToString() == "Thêm")
                {
                    if (MessageBox.Show("bạn muốn thêm chứ", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        KhachHang kh = new KhachHang();
                        kh.SDT = txtsdt.Text;
                        kh.TenKhachHang = txtHoTen.Text;
                        kh.DiaChi = txtdiachi.Text;
                        kh.GioiTinh = rdnam.Checked == true ? 1 : 0;
                        _buSkhachhang.addkh(kh);
                        _buSkhachhang.savekh();
                        loatdata();
                        ClearForm();

                    }

                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }





        }

        

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            loatdatatk(txtsdt.Text);
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            loatdata();
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            loatdatatk(textBox4.Text);
        }
    }
}
