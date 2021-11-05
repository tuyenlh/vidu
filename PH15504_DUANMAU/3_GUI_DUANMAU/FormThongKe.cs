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
using _2_BUS_DUANMAU.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace _3_GUI_DUANMAU
{
    public partial class FormThongKe : Form
    {
        private IBUSthongkeservice _buSthongkeservice;
        public FormThongKe()
        {
            InitializeComponent();
            _buSthongkeservice = new BUSthongkeservice();
            loatthongketonkho(_buSthongkeservice.listthongke());
            loatthongkenhapkho(_buSthongkeservice.listthongke());
        }

        public void loatthongketonkho(List<ModelThongKe> lisThongKe)
        {
            
            dtgv_tonkho.ColumnCount = 3;
            dtgv_tonkho.Columns[0].Name = "Mã nhân viên";
            dtgv_tonkho.Columns[1].Name = "Tên nhân viên";
            dtgv_tonkho.Columns[2].Name = "Số lượng hàng";
            dtgv_tonkho.Rows.Clear();
            lisThongKe.ForEach(x=>
            {
                dtgv_tonkho.Rows.Add(x.nhanvien.Ma_NhanVien, x.nhanvien.TenNhanVien,x.hang.SoLuong);
            });

        }
        public void loatthongkenhapkho(List<ModelThongKe> lisThongKe)
        {

            dtgv_nhapkho.ColumnCount = 4;
            dtgv_nhapkho.Columns[0].Name = "Tên nhân viên nhập hàng";
            dtgv_nhapkho.Columns[1].Name = "Tên hàng";
            dtgv_nhapkho.Columns[2].Name = "Giá nhập";
            dtgv_nhapkho.Columns[3].Name = "Giá Bán";
            dtgv_nhapkho.Rows.Clear();
            lisThongKe.ForEach(x =>
            {
                dtgv_nhapkho.Rows.Add( x.nhanvien.TenNhanVien,x.hang.TenHang,x.hang.DonGiaNhap,x.hang.DonGiaBan);
            });

        }
        private void dtgv_nhapkho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
