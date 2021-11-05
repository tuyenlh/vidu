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
    public partial class FormQuanLyNhanVien : Form
    {

        private IBUSnhanvienSevice _buSnhanvien;
        private Tienich _ti;
        private NhanVien _nv;
        private int id;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            _buSnhanvien = new BUSnhanvienSevice();
            _ti = new Tienich();
            _nv = new NhanVien();
            loatdata();

        }

        public bool CheckNull()
        {
            if (txtMail.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length == 0 || txt_diachi.Text.Trim().Length == 0 ||
                rbNhanVien.Checked == false && rbQuanTri.Checked == false ||
                rdHoatDong.Checked == false && rdNgungHoatDong.Checked == false)
            {
                MessageBox.Show("điền đầy đủ thông tin vào", "thông báo");
                txtMail.Focus();

                return true;
            }

            return false;

        }

        public void clearForm()
        {
            txtHoTen.Text = "";
            txtMail.Text = "";
            txt_diachi.Text = "";
            rbQuanTri.Checked = false;
            rbNhanVien.Checked = false;
            rdHoatDong.Checked = false;
            rdNgungHoatDong.Checked = false;
        }

        public void loatdata()
        {
            dtgv_qlnhanvien.ColumnCount = 6;
            dtgv_qlnhanvien.Columns[0].Name = "ID";
            dtgv_qlnhanvien.Columns[0].Visible = false;
            dtgv_qlnhanvien.Columns[1].Name = "Email";
            dtgv_qlnhanvien.Columns[2].Name = "Tên nhân viên";
            dtgv_qlnhanvien.Columns[3].Name = "Chức vụ";
            dtgv_qlnhanvien.Columns[4].Name = "Địa chỉ";
            dtgv_qlnhanvien.Columns[5].Name = "Trạng thái";
            DataGridViewComboBoxColumn dtgvcmm = new DataGridViewComboBoxColumn();
            dtgvcmm.Name = "cmm";
            dtgvcmm.HeaderText = "Chức năng";
            dtgvcmm.Items.Add( "Thêm") ;
            dtgvcmm.Items.Add( "Sửa") ;
            dtgvcmm.Items.Add( "xóa") ;
            int indexcmm = 6;
            if (dtgv_qlnhanvien.Columns["cmm"] == null)
            {
                dtgv_qlnhanvien.Columns.Insert(indexcmm, dtgvcmm);
            }
            DataGridViewButtonColumn dtgvbt = new DataGridViewButtonColumn();
            dtgvbt.Name = "bt";
            dtgvbt.HeaderText = "Xác nhận";
            dtgvbt.Text = "Xác nhận";
            dtgvbt.UseColumnTextForButtonValue = true;
            int index = 7;
            if (dtgv_qlnhanvien.Columns["bt"] == null)
            {
                dtgv_qlnhanvien.Columns.Insert(index, dtgvbt);
            }
            dtgv_qlnhanvien.Rows.Clear();
            foreach (var x in _buSnhanvien.getlistnv())
            {
                dtgv_qlnhanvien.Rows.Add(x.ID_NhanVien, x.Email, x.TenNhanVien,
                    x.VaiTro == 1 ? "Quản lý" : "Nhân viên", x.Diachi,
                    x.TrangThai == true ? "Hoạt động" : "Ngừng hoạt động");
            }
        }

        public void loatdatatimkiem(string nhanViens)
        {
            dtgv_qlnhanvien.ColumnCount = 6;
            dtgv_qlnhanvien.Columns[0].Name = "ID";
            dtgv_qlnhanvien.Columns[0].Visible = false;
            dtgv_qlnhanvien.Columns[1].Name = "Email";
            dtgv_qlnhanvien.Columns[2].Name = "Tên nhân viên";
            dtgv_qlnhanvien.Columns[3].Name = "Chức vụ";
            dtgv_qlnhanvien.Columns[4].Name = "Địa chỉ";
            dtgv_qlnhanvien.Columns[5].Name = "Trạng thái";
            dtgv_qlnhanvien.Rows.Clear();
            foreach (var x in _buSnhanvien.getlistnvtk(nhanViens))
            {
                dtgv_qlnhanvien.Rows.Add(x.ID_NhanVien, x.Email, x.TenNhanVien,
                    x.VaiTro == 1 ? "Quản lý" : "Nhân viên", x.Diachi,
                    x.TrangThai == true ? "Hoạt động" : "Ngừng hoạt động");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //var a= _buSnhanvien.getlistnv().Where(c => c.TenNhanVien.StartsWith(texttimkiem.Text)).ToList();
            // loatdatatimkiem(a);
        }

       

        private void btnDanhSach_Click_1(object sender, EventArgs e)
        {
            loatdata();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(CheckNull())return;

            NhanVien nv = new NhanVien();
            nv.ID_NhanVien = _buSnhanvien.getlistnv().Max(c => c.ID_NhanVien) + 1;
            //nv.ID_NhanVien = _buSnhanvien.GetMaxID();
            nv.Ma_NhanVien = "NV" + nv.ID_NhanVien;
            nv.TenNhanVien = txtHoTen.Text;
            nv.Email = txtMail.Text;
            nv.VaiTro = rbQuanTri.Checked == true ? 1 : 0;
            nv.MatKhau = _ti.BUSMahoaPassWord("123");
            nv.Diachi = txt_diachi.Text;
            nv.TrangThai = rdHoatDong.Checked == true ? true : false;
            nv.TrangThaiMatKhau = true;
            MessageBox.Show(_buSnhanvien.addnv(nv));
            loatdata();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            _buSnhanvien.savenv();
            _ti.sendmailnv(txtMail.Text, "123");
            MessageBox.Show("Đã gửi Email mật khẩu cho nhân viên");
            loatdata();
        }

        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_qlnhanvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0||index ==_buSnhanvien.getlistnv().Count ) return;
            id = Convert.ToInt32(dtgv_qlnhanvien.Rows[index].Cells[0].Value);
            txtMail.Text = dtgv_qlnhanvien.Rows[index].Cells[1].Value.ToString();
            txtHoTen.Text = dtgv_qlnhanvien.Rows[index].Cells[2].Value.ToString();
            if (dtgv_qlnhanvien.Rows[index].Cells[3].Value.ToString() == "Quản lý")
            {
                rbQuanTri.Checked = true;
            }
            else
            {
                rbNhanVien.Checked = true;
            }

            txt_diachi.Text = dtgv_qlnhanvien.Rows[index].Cells[4].Value.ToString();
            if (dtgv_qlnhanvien.Rows[index].Cells[5].Value.ToString() == "Hoạt động")
            {
                rdHoatDong.Checked = true;
            }
            else
            {
                rdNgungHoatDong.Checked = true;
            }
             if (e.ColumnIndex == dtgv_qlnhanvien.Columns["bt"].Index && dtgv_qlnhanvien.Rows[index].Cells[6].Value.ToString() == "Thêm")
            {
                if (MessageBox.Show("bạn muốn thêm chứ", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NhanVien nv = new NhanVien();
                    nv.ID_NhanVien = _buSnhanvien.getlistnv().Max(c => c.ID_NhanVien) + 1;
                    //nv.ID_NhanVien = _buSnhanvien.GetMaxID();
                    nv.Ma_NhanVien = "NV" + nv.ID_NhanVien;
                    nv.TenNhanVien = txtHoTen.Text;
                    nv.Email = txtMail.Text;
                    nv.VaiTro = rbQuanTri.Checked == true ? 1 : 0;
                    nv.MatKhau = _ti.BUSMahoaPassWord("123");
                    nv.Diachi = txt_diachi.Text;
                    nv.TrangThai = rdHoatDong.Checked == true ? true : false;
                    nv.TrangThaiMatKhau = true;
                    MessageBox.Show(_buSnhanvien.addnv(nv));
                    _buSnhanvien.savenv();
                    loatdata();

                }
                return;
            }
             else if (e.ColumnIndex == dtgv_qlnhanvien.Columns["bt"].Index && dtgv_qlnhanvien.Rows[index].Cells[6].Value.ToString() == "Sửa")
                {

                  if (MessageBox.Show("Bạn  chắc chắc sẽ sửa chứ",
                           "Thông báo",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                  {
                    _nv = new NhanVien();
                    _nv = _buSnhanvien.getlistnv().Find(c => c.ID_NhanVien == id);
                    _nv.Email = txtMail.Text;
                    _nv.TenNhanVien = txtHoTen.Text;
                    _nv.VaiTro = rbQuanTri.Checked == true ? 1 : 0;
                    _nv.TrangThai = rdHoatDong.Checked == true ? true : false;
                    MessageBox.Show(_buSnhanvien.updatenv(_nv));
                    _buSnhanvien.savenv();
                    loatdata();
                    clearForm();
                    
                  }
                }
             else if (e.ColumnIndex == dtgv_qlnhanvien.Columns["bt"].Index && dtgv_qlnhanvien.Rows[index].Cells[6].Value.ToString() == "xóa")
             {
                 if (MessageBox.Show("bạn muốn xóa chứ", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {

                     _nv = new NhanVien();
                     _nv = _buSnhanvien.getlistnv().FirstOrDefault(c => c.ID_NhanVien == id);
                     MessageBox.Show(_buSnhanvien.deletenv(_nv));
                     _buSnhanvien.savenv();
                     loatdata();
                 }

             }

         }

        private void txttimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            loatdatatimkiem(txttimkiem.Text);
        }
    }

}

