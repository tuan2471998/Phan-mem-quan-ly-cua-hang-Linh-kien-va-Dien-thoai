namespace DoAn_PhanMemQuanLy
{
    partial class Form_HoaDon
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.GrB_TTHoaDon = new System.Windows.Forms.GroupBox();
            this.dtp_NgayBan = new System.Windows.Forms.DateTimePicker();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.lb_ThanhTien = new System.Windows.Forms.Label();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.lb_GiamGia = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.lb_TenSanPham = new System.Windows.Forms.Label();
            this.lb_MaSanPham = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.lb_MaKhachHang = new System.Windows.Forms.Label();
            this.lb_NgayBan = new System.Windows.Forms.Label();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.GrB_DSHoaDon = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.GrB_TTHoaDon.SuspendLayout();
            this.GrB_DSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Save;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(139, 447);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(93, 45);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(384, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hóa Đơn Sản Phẩm";
            // 
            // bt_Huy
            // 
            this.bt_Huy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Huy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Huy.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Cancel;
            this.bt_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Huy.Location = new System.Drawing.Point(360, 447);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(93, 45);
            this.bt_Huy.TabIndex = 35;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Huy.UseVisualStyleBackColor = false;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click_1);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Delete;
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(251, 447);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(93, 45);
            this.bt_Xoa.TabIndex = 32;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Add;
            this.bt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Them.Location = new System.Drawing.Point(25, 447);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(93, 45);
            this.bt_Them.TabIndex = 31;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // GrB_TTHoaDon
            // 
            this.GrB_TTHoaDon.Controls.Add(this.dtp_NgayBan);
            this.GrB_TTHoaDon.Controls.Add(this.lb_TongTien);
            this.GrB_TTHoaDon.Controls.Add(this.txt_TongTien);
            this.GrB_TTHoaDon.Controls.Add(this.lb_ThanhTien);
            this.GrB_TTHoaDon.Controls.Add(this.lb_SoLuong);
            this.GrB_TTHoaDon.Controls.Add(this.txt_GiamGia);
            this.GrB_TTHoaDon.Controls.Add(this.txt_ThanhTien);
            this.GrB_TTHoaDon.Controls.Add(this.txt_DonGia);
            this.GrB_TTHoaDon.Controls.Add(this.lb_GiamGia);
            this.GrB_TTHoaDon.Controls.Add(this.txt_SoLuong);
            this.GrB_TTHoaDon.Controls.Add(this.lb_DonGia);
            this.GrB_TTHoaDon.Controls.Add(this.txt_TenSP);
            this.GrB_TTHoaDon.Controls.Add(this.txt_MaSP);
            this.GrB_TTHoaDon.Controls.Add(this.lb_TenSanPham);
            this.GrB_TTHoaDon.Controls.Add(this.lb_MaSanPham);
            this.GrB_TTHoaDon.Controls.Add(this.lb_TenKH);
            this.GrB_TTHoaDon.Controls.Add(this.txt_TenKH);
            this.GrB_TTHoaDon.Controls.Add(this.txt_MaKH);
            this.GrB_TTHoaDon.Controls.Add(this.txt_MaHD);
            this.GrB_TTHoaDon.Controls.Add(this.lb_MaKhachHang);
            this.GrB_TTHoaDon.Controls.Add(this.lb_NgayBan);
            this.GrB_TTHoaDon.Controls.Add(this.lb_MaHD);
            this.GrB_TTHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_TTHoaDon.Location = new System.Drawing.Point(5, 32);
            this.GrB_TTHoaDon.Name = "GrB_TTHoaDon";
            this.GrB_TTHoaDon.Size = new System.Drawing.Size(1029, 197);
            this.GrB_TTHoaDon.TabIndex = 29;
            this.GrB_TTHoaDon.TabStop = false;
            this.GrB_TTHoaDon.Text = "Thông Tin Hóa Đơn";
            // 
            // dtp_NgayBan
            // 
            this.dtp_NgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayBan.Location = new System.Drawing.Point(160, 80);
            this.dtp_NgayBan.Name = "dtp_NgayBan";
            this.dtp_NgayBan.Size = new System.Drawing.Size(190, 26);
            this.dtp_NgayBan.TabIndex = 22;
            this.dtp_NgayBan.Value = new System.DateTime(2018, 9, 29, 8, 5, 41, 0);
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Location = new System.Drawing.Point(708, 162);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(76, 19);
            this.lb_TongTien.TabIndex = 21;
            this.lb_TongTien.Text = "Tổng Tiền :";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Location = new System.Drawing.Point(800, 162);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(190, 26);
            this.txt_TongTien.TabIndex = 20;
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.AutoSize = true;
            this.lb_ThanhTien.Location = new System.Drawing.Point(708, 80);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(82, 19);
            this.lb_ThanhTien.TabIndex = 19;
            this.lb_ThanhTien.Text = "Thành Tiền :";
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(381, 121);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(77, 19);
            this.lb_SoLuong.TabIndex = 15;
            this.lb_SoLuong.Text = "Số Lượng :";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.BackColor = System.Drawing.Color.White;
            this.txt_GiamGia.Location = new System.Drawing.Point(800, 121);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(190, 26);
            this.txt_GiamGia.TabIndex = 17;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_ThanhTien.Enabled = false;
            this.txt_ThanhTien.Location = new System.Drawing.Point(800, 80);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(190, 26);
            this.txt_ThanhTien.TabIndex = 18;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.Color.White;
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Location = new System.Drawing.Point(800, 36);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(190, 26);
            this.txt_DonGia.TabIndex = 14;
            // 
            // lb_GiamGia
            // 
            this.lb_GiamGia.AutoSize = true;
            this.lb_GiamGia.Location = new System.Drawing.Point(708, 124);
            this.lb_GiamGia.Name = "lb_GiamGia";
            this.lb_GiamGia.Size = new System.Drawing.Size(73, 19);
            this.lb_GiamGia.TabIndex = 16;
            this.lb_GiamGia.Text = "Giảm Giá :";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BackColor = System.Drawing.Color.White;
            this.txt_SoLuong.Location = new System.Drawing.Point(489, 121);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(190, 26);
            this.txt_SoLuong.TabIndex = 13;
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Location = new System.Drawing.Point(708, 39);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(67, 19);
            this.lb_DonGia.TabIndex = 9;
            this.lb_DonGia.Text = "Đơn Giá :";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.BackColor = System.Drawing.Color.White;
            this.txt_TenSP.Enabled = false;
            this.txt_TenSP.Location = new System.Drawing.Point(489, 77);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(190, 26);
            this.txt_TenSP.TabIndex = 12;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.BackColor = System.Drawing.Color.White;
            this.txt_MaSP.Enabled = false;
            this.txt_MaSP.Location = new System.Drawing.Point(489, 36);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(190, 26);
            this.txt_MaSP.TabIndex = 11;
            // 
            // lb_TenSanPham
            // 
            this.lb_TenSanPham.AutoSize = true;
            this.lb_TenSanPham.Location = new System.Drawing.Point(381, 80);
            this.lb_TenSanPham.Name = "lb_TenSanPham";
            this.lb_TenSanPham.Size = new System.Drawing.Size(100, 19);
            this.lb_TenSanPham.TabIndex = 10;
            this.lb_TenSanPham.Text = "Tên Sản Phẩm:";
            // 
            // lb_MaSanPham
            // 
            this.lb_MaSanPham.AutoSize = true;
            this.lb_MaSanPham.Location = new System.Drawing.Point(381, 39);
            this.lb_MaSanPham.Name = "lb_MaSanPham";
            this.lb_MaSanPham.Size = new System.Drawing.Size(98, 19);
            this.lb_MaSanPham.TabIndex = 8;
            this.lb_MaSanPham.Text = "Mã Sản Phẩm:";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(36, 162);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(119, 19);
            this.lb_TenKH.TabIndex = 7;
            this.lb_TenKH.Text = "Tên Khách Hàng :";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.BackColor = System.Drawing.Color.White;
            this.txt_TenKH.Location = new System.Drawing.Point(160, 159);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(190, 26);
            this.txt_TenKH.TabIndex = 6;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.Color.White;
            this.txt_MaKH.Location = new System.Drawing.Point(160, 118);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(190, 26);
            this.txt_MaKH.TabIndex = 5;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.BackColor = System.Drawing.Color.White;
            this.txt_MaHD.Location = new System.Drawing.Point(160, 36);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(190, 26);
            this.txt_MaHD.TabIndex = 3;
            // 
            // lb_MaKhachHang
            // 
            this.lb_MaKhachHang.AutoSize = true;
            this.lb_MaKhachHang.Location = new System.Drawing.Point(36, 121);
            this.lb_MaKhachHang.Name = "lb_MaKhachHang";
            this.lb_MaKhachHang.Size = new System.Drawing.Size(117, 19);
            this.lb_MaKhachHang.TabIndex = 2;
            this.lb_MaKhachHang.Text = "Mã Khách Hàng :";
            // 
            // lb_NgayBan
            // 
            this.lb_NgayBan.AutoSize = true;
            this.lb_NgayBan.Location = new System.Drawing.Point(36, 80);
            this.lb_NgayBan.Name = "lb_NgayBan";
            this.lb_NgayBan.Size = new System.Drawing.Size(77, 19);
            this.lb_NgayBan.TabIndex = 1;
            this.lb_NgayBan.Text = "Ngày Bán :";
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Location = new System.Drawing.Point(36, 39);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(97, 19);
            this.lb_MaHD.TabIndex = 0;
            this.lb_MaHD.Text = "Mã Hóa Đơn :";
            // 
            // GrB_DSHoaDon
            // 
            this.GrB_DSHoaDon.Controls.Add(this.dataGridView1);
            this.GrB_DSHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_DSHoaDon.Location = new System.Drawing.Point(5, 235);
            this.GrB_DSHoaDon.Name = "GrB_DSHoaDon";
            this.GrB_DSHoaDon.Size = new System.Drawing.Size(1029, 206);
            this.GrB_DSHoaDon.TabIndex = 30;
            this.GrB_DSHoaDon.TabStop = false;
            this.GrB_DSHoaDon.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(7, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
           
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayBan";
            this.Column2.HeaderText = "Ngày Bán";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaKH";
            this.Column3.HeaderText = "Mã Khách Hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenKH";
            this.Column4.HeaderText = "Tên Khách Hàng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaSP";
            this.Column5.HeaderText = "Mã Sản Phẩm";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenSP";
            this.Column6.HeaderText = "Tên Sản Phẩm";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "Số Lượng";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DonGia";
            this.Column8.HeaderText = "Đơn Giá";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ThanhTien";
            this.Column9.HeaderText = "Thành Tiền";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "GiamGia";
            this.Column10.HeaderText = "Giảm Giá";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TongTien";
            this.Column11.HeaderText = "Tổng Tiền";
            this.Column11.Name = "Column11";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Thoat.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ForeColor = System.Drawing.Color.Red;
            this.bt_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Thoat.Location = new System.Drawing.Point(860, 518);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(122, 45);
            this.bt_Thoat.TabIndex = 50;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_TimKiem.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Search;
            this.bt_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_TimKiem.Location = new System.Drawing.Point(316, 518);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(146, 49);
            this.bt_TimKiem.TabIndex = 49;
            this.bt_TimKiem.Text = "Tìm Kiếm";
            this.bt_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_TimKiem.Location = new System.Drawing.Point(25, 529);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(275, 29);
            this.txt_TimKiem.TabIndex = 48;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.Red;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(637, 518);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(122, 45);
            this.btnBaoCao.TabIndex = 51;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 578);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.GrB_TTHoaDon);
            this.Controls.Add(this.GrB_DSHoaDon);
            this.Name = "Form_HoaDon";
            this.Text = "Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_HoaDon_FormClosing);
            this.Load += new System.EventHandler(this.Form_HoaDon_Load);
            this.GrB_TTHoaDon.ResumeLayout(false);
            this.GrB_TTHoaDon.PerformLayout();
            this.GrB_DSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.GroupBox GrB_TTHoaDon;
        private System.Windows.Forms.DateTimePicker dtp_NgayBan;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label lb_ThanhTien;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label lb_GiamGia;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.Label lb_TenSanPham;
        private System.Windows.Forms.Label lb_MaSanPham;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label lb_MaKhachHang;
        private System.Windows.Forms.Label lb_NgayBan;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.GroupBox GrB_DSHoaDon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnBaoCao;


    }
}