using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DUANMAU.Entity;
using _2_BUS_DUANMAU.BUS_sevices;
using _2_BUS_DUANMAU.IBUS_Services;

namespace _3_GUI_DUANMAU
{
    public partial class FormQuanLySanPham : Form
    {
        private IBUSnhanvienSevice _buSnhanvien;
        private Hang _h;
        private IBUSsanphamservice _buSsanphamservice;
        private string stremail=FormMain.mail;
        private string checkurlimage;
        private string filename;
        private string filesavepath;
        private string fileaddress;
        private string _MAH;
        public FormQuanLySanPham()
        {
            InitializeComponent();
            _buSsanphamservice = new BUSsanphamservice();
            _buSnhanvien = new BUSnhanvienSevice();
            _h = new Hang();
            loatdata();
        }

        public bool checkform()
        {
            int intsoluong;
            bool isint = int.TryParse(txtPrQuanlity.Text.Trim().ToString(), out intsoluong);
            float floatdongianhap;
            bool isfloatn = float.TryParse(txtImportPrice.Text.Trim().ToString(), out floatdongianhap);
            float floatdongiaban;
            bool isfloatb = float.TryParse(txtExportPeice.Text.Trim().ToString(), out floatdongiaban);
            if (txtPrName.Text.Trim().Length < 0)
            {
                MessageBox.Show("Tên hàng không được để trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrName.Focus();
                return true;
            }
            else if(!isint||int.Parse(txtPrQuanlity.Text)<0)
            {
                MessageBox.Show("số lượng không được để trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrQuanlity.Focus();
                return true;
            }
            else if (!isfloatb || float.Parse(txtExportPeice.Text) < 0)
            {
                MessageBox.Show("Đơn giá bán không được để trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExportPeice.Focus();
                return true;
            }
            else if (!isfloatn || float.Parse(txtImportPrice.Text) < 0)
            {
                MessageBox.Show("Đơn giá nhập không được để trống", "thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtImportPrice.Focus();
                return true;
            }
            else if (txt_hinh.Text.Trim().Length==0)
            {
                MessageBox.Show("hình ảnh không được để trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_hinh.Focus();
                return true;
            }

            return false;

        }
        public void clearform()
        {
            txt_hinh.Text = null;
            txtAddress.Text = null;
            txtExportPeice.Text = null;
            txtFind.Text = null;
            txtImportPrice.Text = null;
            txtPrCode.Text = null;
            txtPrName.Text = null;
            txtPrQuanlity.Text = null;
        }
        public void loatdata()
        {
            dtgv_sanpham.ColumnCount = 8;
            
            dtgv_sanpham.Columns[0].Name = "ID";
            //dtgv_sanpham.Columns[0].Name = "ID";
            dtgv_sanpham.Columns[1].Name = "Mã Hàng";
            dtgv_sanpham.Columns[1].Visible = false;
            dtgv_sanpham.Columns[2].Name = "Tên Hàng";
            dtgv_sanpham.Columns[3].Name = "Số Lượng";
            dtgv_sanpham.Columns[4].Name = "Đơn gía nhập";
            dtgv_sanpham.Columns[5].Name = "Đơn giá bán";
            dtgv_sanpham.Columns[6].Name = "Link ảnh ";
            //dtgv_sanpham.Columns[6].Visible = false;
            dtgv_sanpham.Columns[7].Name = "Ghi chú";
            DataGridViewImageColumn dgvCmb = new DataGridViewImageColumn();
            dgvCmb.Name = "image";
            dgvCmb.HeaderText = "Ảnh";
            //dgvCmb.Image=Image.FromFile("\\Images\\4.jpg");
            //dgvCmb.Image=Properties.Resources.mau_logo_vo_thuat_co_truyen_01;
            dtgv_sanpham.Columns.Insert(8,dgvCmb);
            DataGridViewComboBoxColumn dtgvcmm = new DataGridViewComboBoxColumn();
            dtgvcmm.Name = "cmm";
            dtgvcmm.HeaderText = "Chức năng";
            dtgvcmm.Items.Add("Thêm");
            dtgvcmm.Items.Add("Sửa");
            dtgvcmm.Items.Add("xóa");
            int indexcmm = 9;
            if (dtgv_sanpham.Columns["cmm"] == null)
            {
                dtgv_sanpham.Columns.Insert(indexcmm, dtgvcmm);
            }
            DataGridViewButtonColumn dtgvbt = new DataGridViewButtonColumn();
            dtgvbt.Name = "bt";
            dtgvbt.HeaderText = "Xác nhận";
            dtgvbt.Text = "Xác nhận";
            dtgvbt.UseColumnTextForButtonValue = true;
            int index = 10;
            if (dtgv_sanpham.Columns["bt"] == null)
            {
                dtgv_sanpham.Columns.Insert(index, dtgvbt);
            }
            dtgv_sanpham.Rows.Clear();
            foreach (var x in _buSsanphamservice.getlistH())
            {
                dtgv_sanpham.Rows.Add(x.ID_Hang, x.MaHang, x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.AnhHang,
                    x.GhiChu);
            }
        }
        public void loatdatatk(string mah)
        {
            dtgv_sanpham.ColumnCount = 8;
            dtgv_sanpham.Columns[0].Name = "ID";
            //dtgv_sanpham.Columns[0].Name = "ID";
            dtgv_sanpham.Columns[1].Name = "Mã Hàng";
            dtgv_sanpham.Columns[1].Visible = false;
            dtgv_sanpham.Columns[2].Name = "Tên Hàng";
            dtgv_sanpham.Columns[3].Name = "Số Lượng";
            dtgv_sanpham.Columns[4].Name = "Đơn gía nhập";
            dtgv_sanpham.Columns[5].Name = "Đơn giá bán";
            dtgv_sanpham.Columns[6].Name = "Link ảnh ";
            //dtgv_sanpham.Columns[6].Visible = false;
            dtgv_sanpham.Columns[7].Name = "Ghi chú";
            dtgv_sanpham.Rows.Clear();
            foreach (var x in _buSsanphamservice.getlistHtk(mah))
            {
                dtgv_sanpham.Rows.Add(x.ID_Hang, x.MaHang, x.TenHang, x.SoLuong, x.DonGiaNhap, x.DonGiaBan, x.AnhHang,
                    x.GhiChu);
            }
        }
        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.jfif";
            dlgopen.FilterIndex = 2;
            dlgopen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                fileaddress = dlgopen.FileName;
                pcbAnhHang.Image=Image.FromFile(fileaddress);
                filename = Path.GetFileName(dlgopen.FileName);
              
                txt_hinh.Text = filename;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           if (checkform())return;
            Hang h = new Hang();
            h.ID_Hang = _buSsanphamservice.getlistH().Max(c => c.ID_Hang) + 1;
            h.MaHang = "MH" + h.ID_Hang;
            h.TenHang = txtPrName.Text;
            h.SoLuong = Convert.ToInt32(txtPrQuanlity.Text);
            h.DonGiaNhap = Convert.ToInt32(txtImportPrice.Text);
            h.DonGiaBan = Convert.ToInt32(txtExportPeice.Text);
            h.AnhHang = txt_hinh.Text;
            h.GhiChu = txtAddress.Text;
            h.Ma_NhanVien = _buSnhanvien.getlistnv().Where(c => c.Email == stremail).Select(c => c.Ma_NhanVien)
                .FirstOrDefault();
            MessageBox.Show(_buSsanphamservice.addH(h));
            
            loatdata();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            loatdata();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_buSsanphamservice.saveH());
            //File.Copy(fileaddress, filesavepath, true);
            loatdata();
           
            
        }

        private void dtgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            var index = e.RowIndex;
            if(index==_buSsanphamservice.getlistH().Count||index<0)return;
            txtPrCode.Text = dtgv_sanpham.Rows[index].Cells[0].Value.ToString();
            _MAH=dtgv_sanpham.Rows[index].Cells[1].Value.ToString();
            txtPrName.Text=dtgv_sanpham.Rows[index].Cells[2].Value.ToString();
            txtPrQuanlity.Text=dtgv_sanpham.Rows[index].Cells[3].Value.ToString();
            txtImportPrice.Text=dtgv_sanpham.Rows[index].Cells[4].Value.ToString();
            txtExportPeice.Text=dtgv_sanpham.Rows[index].Cells[5].Value.ToString();
            txt_hinh.Text=dtgv_sanpham.Rows[index].Cells[6].Value.ToString();
            checkurlimage = txt_hinh.Text;
            
            //pcbAnhHang.Image=Image.FromFile(fileaddress);
            txtAddress.Text=dtgv_sanpham.Rows[index].Cells[7].Value.ToString();
            if (e.ColumnIndex == dtgv_sanpham.Columns["bt"].Index && dtgv_sanpham.Rows[index].Cells[9].Value.ToString() == "Sửa")
            {

                if (MessageBox.Show("Bạn  chắc chắc sẽ sửa chứ",
                           "Thông báo",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Hang hang = new Hang();
                    hang = _buSsanphamservice.getlistH().Find(c => c.MaHang == _MAH && c.ID_Hang == Convert.ToInt32(txtPrCode.Text));
                    hang.TenHang = txtPrName.Text;
                    hang.SoLuong = Convert.ToInt32(txtPrQuanlity.Text);
                    hang.DonGiaNhap = Convert.ToInt32(txtImportPrice.Text);
                    hang.DonGiaBan = Convert.ToInt32(txtExportPeice.Text);
                    hang.AnhHang = txt_hinh.Text;
                    hang.GhiChu = txtAddress.Text;
                    MessageBox.Show(_buSsanphamservice.updateH(hang));
                    _buSsanphamservice.saveH();
                    loatdata();
                    clearform();
                }
                
            }
            else if (e.ColumnIndex == dtgv_sanpham.Columns["bt"].Index && dtgv_sanpham.Rows[index].Cells[9].Value.ToString() == "xóa")
            {
                if (MessageBox.Show("bạn muốn xóa chứ", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Hang h = new Hang();
                    h = _buSsanphamservice.getlistH().Find(c => c.MaHang == _MAH && c.ID_Hang == Convert.ToInt32(txtPrCode.Text));
                    MessageBox.Show(_buSsanphamservice.deleteH(h));
                    _buSsanphamservice.saveH();
                    loatdata();
                }

            }
            else if (e.ColumnIndex == dtgv_sanpham.Columns["bt"].Index && dtgv_sanpham.Rows[index].Cells[9].Value.ToString() == "Thêm")
            {
                if (MessageBox.Show("bạn muốn thêm chứ", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (checkform()) return;
                    Hang h = new Hang();
                    h.ID_Hang = _buSsanphamservice.getlistH().Max(c => c.ID_Hang) + 1;
                    h.MaHang = "MH" + h.ID_Hang;
                    h.TenHang = txtPrName.Text;
                    h.SoLuong = Convert.ToInt32(txtPrQuanlity.Text);
                    h.DonGiaNhap = Convert.ToInt32(txtImportPrice.Text);
                    h.DonGiaBan = Convert.ToInt32(txtExportPeice.Text);
                    h.AnhHang = txt_hinh.Text;
                    h.GhiChu = txtAddress.Text;
                    h.Ma_NhanVien = _buSnhanvien.getlistnv().Where(c => c.Email == stremail).Select(c => c.Ma_NhanVien)
                        .FirstOrDefault();
                    MessageBox.Show(_buSsanphamservice.addH(h));
                    _buSsanphamservice.saveH();
                    loatdata();
                }

            }
        }

      

       

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            loatdatatk(txtFind.Text);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            clearform();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
