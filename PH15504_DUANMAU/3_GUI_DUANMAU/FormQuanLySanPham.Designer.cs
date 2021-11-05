
namespace _3_GUI_DUANMAU
{
    partial class FormQuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.pcbAnhHang = new System.Windows.Forms.PictureBox();
            this.txtPrCode = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.txtExportPeice = new System.Windows.Forms.TextBox();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtPrQuanlity = new System.Windows.Forms.TextBox();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtPrName = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgv_sanpham = new System.Windows.Forms.DataGridView();
            this.txt_hinh = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnhHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(511, 182);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 62);
            this.txtAddress.TabIndex = 112;
            this.txtAddress.Text = "";
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenImg.Image = global::_3_GUI_DUANMAU.Properties.Resources.client_user;
            this.btnOpenImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenImg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenImg.Location = new System.Drawing.Point(579, 22);
            this.btnOpenImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(125, 45);
            this.btnOpenImg.TabIndex = 114;
            this.btnOpenImg.Text = "Mở ảnh";
            this.btnOpenImg.UseVisualStyleBackColor = false;
            this.btnOpenImg.Click += new System.EventHandler(this.btnOpenImg_Click);
            // 
            // pcbAnhHang
            // 
            this.pcbAnhHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pcbAnhHang.Location = new System.Drawing.Point(727, 30);
            this.pcbAnhHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbAnhHang.Name = "pcbAnhHang";
            this.pcbAnhHang.Size = new System.Drawing.Size(347, 214);
            this.pcbAnhHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAnhHang.TabIndex = 113;
            this.pcbAnhHang.TabStop = false;
            // 
            // txtPrCode
            // 
            this.txtPrCode.Enabled = false;
            this.txtPrCode.Location = new System.Drawing.Point(131, 81);
            this.txtPrCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrCode.Name = "txtPrCode";
            this.txtPrCode.ReadOnly = true;
            this.txtPrCode.Size = new System.Drawing.Size(317, 23);
            this.txtPrCode.TabIndex = 115;
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaHang.Location = new System.Drawing.Point(42, 83);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(60, 15);
            this.lblMaHang.TabIndex = 105;
            this.lblMaHang.Text = "Mã hàng :";
            // 
            // txtExportPeice
            // 
            this.txtExportPeice.Location = new System.Drawing.Point(131, 221);
            this.txtExportPeice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExportPeice.Name = "txtExportPeice";
            this.txtExportPeice.Size = new System.Drawing.Size(317, 23);
            this.txtExportPeice.TabIndex = 106;
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Location = new System.Drawing.Point(131, 187);
            this.txtImportPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(317, 23);
            this.txtImportPrice.TabIndex = 104;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGiaBan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGiaBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGiaBan.Location = new System.Drawing.Point(42, 223);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(54, 15);
            this.lblGiaBan.TabIndex = 107;
            this.lblGiaBan.Text = "Giá bán :";
            // 
            // txtPrQuanlity
            // 
            this.txtPrQuanlity.Location = new System.Drawing.Point(131, 152);
            this.txtPrQuanlity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrQuanlity.Name = "txtPrQuanlity";
            this.txtPrQuanlity.Size = new System.Drawing.Size(317, 23);
            this.txtPrQuanlity.TabIndex = 103;
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGiaNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGiaNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGiaNhap.Location = new System.Drawing.Point(42, 190);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(63, 15);
            this.lblGiaNhap.TabIndex = 108;
            this.lblGiaNhap.Text = "Giá Nhập :";
            // 
            // txtPrName
            // 
            this.txtPrName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrName.Location = new System.Drawing.Point(131, 115);
            this.txtPrName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrName.Name = "txtPrName";
            this.txtPrName.Size = new System.Drawing.Size(317, 23);
            this.txtPrName.TabIndex = 101;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSoLuong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSoLuong.Location = new System.Drawing.Point(42, 155);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(63, 15);
            this.lblSoLuong.TabIndex = 109;
            this.lblSoLuong.Text = "Số lượng :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiaChi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiaChi.Location = new System.Drawing.Point(454, 187);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(52, 15);
            this.lblDiaChi.TabIndex = 110;
            this.lblDiaChi.Text = "Ghi chú:";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTenHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTenHang.Location = new System.Drawing.Point(42, 118);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(63, 15);
            this.lblTenHang.TabIndex = 111;
            this.lblTenHang.Text = "Tên hàng :";
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFind.Location = new System.Drawing.Point(188, 459);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.PlaceholderText = "nhập mã sản phẩm hoặc tên sản phẩm";
            this.txtFind.Size = new System.Drawing.Size(266, 23);
            this.txtFind.TabIndex = 119;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.Image = global::_3_GUI_DUANMAU.Properties.Resources.zoom;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFind.Location = new System.Drawing.Point(496, 449);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(122, 38);
            this.btnFind.TabIndex = 116;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(966, 497);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 38);
            this.btnClose.TabIndex = 120;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.Image = global::_3_GUI_DUANMAU.Properties.Resources.group;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnList.Location = new System.Drawing.Point(823, 497);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(126, 38);
            this.btnList.TabIndex = 118;
            this.btnList.Text = "Danh sách";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSkip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSkip.Image = global::_3_GUI_DUANMAU.Properties.Resources.refresh1;
            this.btnSkip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSkip.Location = new System.Drawing.Point(620, 497);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(115, 38);
            this.btnSkip.TabIndex = 117;
            this.btnSkip.Text = "Bỏ qua";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = global::_3_GUI_DUANMAU.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(496, 497);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 38);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Image = global::_3_GUI_DUANMAU.Properties.Resources.zoom_in;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(188, 497);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 38);
            this.btnAdd.TabIndex = 121;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgv_sanpham
            // 
            this.dtgv_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sanpham.Location = new System.Drawing.Point(67, 281);
            this.dtgv_sanpham.Name = "dtgv_sanpham";
            this.dtgv_sanpham.RowTemplate.Height = 25;
            this.dtgv_sanpham.Size = new System.Drawing.Size(961, 150);
            this.dtgv_sanpham.TabIndex = 125;
            this.dtgv_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sanpham_CellClick);
            // 
            // txt_hinh
            // 
            this.txt_hinh.Location = new System.Drawing.Point(511, 83);
            this.txt_hinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hinh.Name = "txt_hinh";
            this.txt_hinh.Size = new System.Drawing.Size(210, 62);
            this.txt_hinh.TabIndex = 126;
            this.txt_hinh.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(458, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 127;
            this.label1.Text = "Hình :";
            // 
            // FormQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1098, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hinh);
            this.Controls.Add(this.dtgv_sanpham);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnOpenImg);
            this.Controls.Add(this.pcbAnhHang);
            this.Controls.Add(this.txtPrCode);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.txtExportPeice);
            this.Controls.Add(this.txtImportPrice);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.txtPrQuanlity);
            this.Controls.Add(this.lblGiaNhap);
            this.Controls.Add(this.txtPrName);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenHang);
            this.Name = "FormQuanLySanPham";
            this.Text = "FormQuanLySanPham";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnhHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.PictureBox pcbAnhHang;
        private System.Windows.Forms.TextBox txtPrCode;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtExportPeice;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtPrQuanlity;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txtPrName;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgv_sanpham;
        private System.Windows.Forms.RichTextBox txt_hinh;
        private System.Windows.Forms.Label label1;
    }
}