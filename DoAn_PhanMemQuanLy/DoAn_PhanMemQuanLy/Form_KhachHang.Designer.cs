namespace DoAn_PhanMemQuanLy
{
    partial class Form_KhachHang
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
            this.GrB_TTKhachHang = new System.Windows.Forms.GroupBox();
            this.cbb_LoaiKhachHang = new System.Windows.Forms.ComboBox();
            this.dtp_KhachHang = new System.Windows.Forms.DateTimePicker();
            this.txt_SoTaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_NgayDangKy = new System.Windows.Forms.Label();
            this.lb_STK = new System.Windows.Forms.Label();
            this.lb_Sdt = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrB_DSKhachHang = new System.Windows.Forms.GroupBox();
            this.dataGridView_Form_KhachHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrB_ChucNang = new System.Windows.Forms.GroupBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.GrB_TTKhachHang.SuspendLayout();
            this.GrB_DSKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Form_KhachHang)).BeginInit();
            this.GrB_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrB_TTKhachHang
            // 
            this.GrB_TTKhachHang.Controls.Add(this.btnBaoCao);
            this.GrB_TTKhachHang.Controls.Add(this.cbb_LoaiKhachHang);
            this.GrB_TTKhachHang.Controls.Add(this.dtp_KhachHang);
            this.GrB_TTKhachHang.Controls.Add(this.txt_SoTaiKhoan);
            this.GrB_TTKhachHang.Controls.Add(this.txt_DienThoai);
            this.GrB_TTKhachHang.Controls.Add(this.txt_DiaChi);
            this.GrB_TTKhachHang.Controls.Add(this.label7);
            this.GrB_TTKhachHang.Controls.Add(this.lb_NgayDangKy);
            this.GrB_TTKhachHang.Controls.Add(this.lb_STK);
            this.GrB_TTKhachHang.Controls.Add(this.lb_Sdt);
            this.GrB_TTKhachHang.Controls.Add(this.txt_HoTen);
            this.GrB_TTKhachHang.Controls.Add(this.lb_DiaChi);
            this.GrB_TTKhachHang.Controls.Add(this.lb_HoTen);
            this.GrB_TTKhachHang.Controls.Add(this.txt_MaKH);
            this.GrB_TTKhachHang.Controls.Add(this.label1);
            this.GrB_TTKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_TTKhachHang.Location = new System.Drawing.Point(12, 12);
            this.GrB_TTKhachHang.Name = "GrB_TTKhachHang";
            this.GrB_TTKhachHang.Size = new System.Drawing.Size(644, 238);
            this.GrB_TTKhachHang.TabIndex = 0;
            this.GrB_TTKhachHang.TabStop = false;
            this.GrB_TTKhachHang.Text = "Thông Tin Khách Hàng";
            // 
            // cbb_LoaiKhachHang
            // 
            this.cbb_LoaiKhachHang.FormattingEnabled = true;
            this.cbb_LoaiKhachHang.Items.AddRange(new object[] {
            "THƯỜNG",
            "VIP"});
            this.cbb_LoaiKhachHang.Location = new System.Drawing.Point(447, 133);
            this.cbb_LoaiKhachHang.Name = "cbb_LoaiKhachHang";
            this.cbb_LoaiKhachHang.Size = new System.Drawing.Size(169, 27);
            this.cbb_LoaiKhachHang.TabIndex = 16;
            // 
            // dtp_KhachHang
            // 
            this.dtp_KhachHang.CustomFormat = "dd/MM/yyyy";
            this.dtp_KhachHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_KhachHang.Location = new System.Drawing.Point(447, 80);
            this.dtp_KhachHang.Name = "dtp_KhachHang";
            this.dtp_KhachHang.Size = new System.Drawing.Size(169, 26);
            this.dtp_KhachHang.TabIndex = 15;
            // 
            // txt_SoTaiKhoan
            // 
            this.txt_SoTaiKhoan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_SoTaiKhoan.Enabled = false;
            this.txt_SoTaiKhoan.Location = new System.Drawing.Point(447, 34);
            this.txt_SoTaiKhoan.Name = "txt_SoTaiKhoan";
            this.txt_SoTaiKhoan.ReadOnly = true;
            this.txt_SoTaiKhoan.Size = new System.Drawing.Size(169, 26);
            this.txt_SoTaiKhoan.TabIndex = 12;
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(100, 177);
            this.txt_DienThoai.MaxLength = 10;
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(177, 26);
            this.txt_DienThoai.TabIndex = 11;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(100, 129);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(177, 26);
            this.txt_DiaChi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Loại Khách Hàng :";
            // 
            // lb_NgayDangKy
            // 
            this.lb_NgayDangKy.AutoSize = true;
            this.lb_NgayDangKy.Location = new System.Drawing.Point(318, 82);
            this.lb_NgayDangKy.Name = "lb_NgayDangKy";
            this.lb_NgayDangKy.Size = new System.Drawing.Size(108, 19);
            this.lb_NgayDangKy.TabIndex = 7;
            this.lb_NgayDangKy.Text = "Ngày Đăng Ký :";
            // 
            // lb_STK
            // 
            this.lb_STK.AutoSize = true;
            this.lb_STK.Location = new System.Drawing.Point(318, 37);
            this.lb_STK.Name = "lb_STK";
            this.lb_STK.Size = new System.Drawing.Size(101, 19);
            this.lb_STK.TabIndex = 6;
            this.lb_STK.Text = "Số Tài Khoản :";
            // 
            // lb_Sdt
            // 
            this.lb_Sdt.AutoSize = true;
            this.lb_Sdt.Location = new System.Drawing.Point(12, 180);
            this.lb_Sdt.Name = "lb_Sdt";
            this.lb_Sdt.Size = new System.Drawing.Size(82, 19);
            this.lb_Sdt.TabIndex = 5;
            this.lb_Sdt.Text = "Điện Thoại :";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(100, 79);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(177, 26);
            this.txt_HoTen.TabIndex = 4;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(12, 132);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(62, 19);
            this.lb_DiaChi.TabIndex = 3;
            this.lb_DiaChi.Text = "Địa Chỉ :";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(12, 82);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(75, 19);
            this.lb_HoTen.TabIndex = 2;
            this.lb_HoTen.Text = "Họ và tên :";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_MaKH.Enabled = false;
            this.txt_MaKH.Location = new System.Drawing.Point(100, 34);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.ReadOnly = true;
            this.txt_MaKH.Size = new System.Drawing.Size(177, 26);
            this.txt_MaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH :";
            // 
            // GrB_DSKhachHang
            // 
            this.GrB_DSKhachHang.Controls.Add(this.dataGridView_Form_KhachHang);
            this.GrB_DSKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_DSKhachHang.Location = new System.Drawing.Point(14, 274);
            this.GrB_DSKhachHang.Name = "GrB_DSKhachHang";
            this.GrB_DSKhachHang.Size = new System.Drawing.Size(1042, 212);
            this.GrB_DSKhachHang.TabIndex = 1;
            this.GrB_DSKhachHang.TabStop = false;
            this.GrB_DSKhachHang.Text = "Danh Sách Khách Hàng";
            // 
            // dataGridView_Form_KhachHang
            // 
            this.dataGridView_Form_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Form_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Form_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView_Form_KhachHang.Location = new System.Drawing.Point(7, 26);
            this.dataGridView_Form_KhachHang.Name = "dataGridView_Form_KhachHang";
            this.dataGridView_Form_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Form_KhachHang.Size = new System.Drawing.Size(1029, 180);
            this.dataGridView_Form_KhachHang.TabIndex = 0;
            this.dataGridView_Form_KhachHang.SelectionChanged += new System.EventHandler(this.dataGridView_Form_KhachHang_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaKH";
            this.Column2.HeaderText = "Mã KH";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenKH";
            this.Column1.HeaderText = "Họ và Tên";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoTaiKhoan";
            this.Column5.HeaderText = "Số tài khoản";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayDangKy";
            this.Column6.HeaderText = "Ngày đăng ký";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "LoaiKH";
            this.Column7.HeaderText = "Loại khách hàng";
            this.Column7.Name = "Column7";
            // 
            // GrB_ChucNang
            // 
            this.GrB_ChucNang.Controls.Add(this.txt_TimKiem);
            this.GrB_ChucNang.Controls.Add(this.bt_Sua);
            this.GrB_ChucNang.Controls.Add(this.bt_TimKiem);
            this.GrB_ChucNang.Controls.Add(this.bt_Xoa);
            this.GrB_ChucNang.Controls.Add(this.bt_Thoat);
            this.GrB_ChucNang.Controls.Add(this.bt_Save);
            this.GrB_ChucNang.Controls.Add(this.bt_Huy);
            this.GrB_ChucNang.Controls.Add(this.bt_Them);
            this.GrB_ChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_ChucNang.Location = new System.Drawing.Point(675, 12);
            this.GrB_ChucNang.Name = "GrB_ChucNang";
            this.GrB_ChucNang.Size = new System.Drawing.Size(381, 238);
            this.GrB_ChucNang.TabIndex = 1;
            this.GrB_ChucNang.TabStop = false;
            this.GrB_ChucNang.Text = "Chức Năng";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_TimKiem.Location = new System.Drawing.Point(16, 108);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(195, 26);
            this.txt_TimKiem.TabIndex = 15;
            this.txt_TimKiem.Text = "Mã khách hàng...";
            this.txt_TimKiem.Click += new System.EventHandler(this.txt_TimKiem_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Sua.Enabled = false;
            this.bt_Sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Sua.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Update;
            this.bt_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sua.Location = new System.Drawing.Point(147, 34);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(88, 41);
            this.bt_Sua.TabIndex = 2;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_CapNhat_Click);
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_TimKiem.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Search;
            this.bt_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_TimKiem.Location = new System.Drawing.Point(217, 95);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(146, 49);
            this.bt_TimKiem.TabIndex = 5;
            this.bt_TimKiem.Text = "Tìm Kiếm";
            this.bt_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Xoa.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Delete;
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(267, 34);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(96, 41);
            this.bt_Xoa.TabIndex = 1;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Thoat.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ForeColor = System.Drawing.Color.Red;
            this.bt_Thoat.Location = new System.Drawing.Point(267, 169);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(96, 41);
            this.bt_Thoat.TabIndex = 7;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_Save.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Save;
            this.bt_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Save.Location = new System.Drawing.Point(16, 169);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(96, 41);
            this.bt_Save.TabIndex = 4;
            this.bt_Save.Text = "Lưu";
            this.bt_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Huy.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Huy.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Cancel;
            this.bt_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Huy.Location = new System.Drawing.Point(147, 169);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(88, 41);
            this.bt_Huy.TabIndex = 6;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Huy.UseVisualStyleBackColor = false;
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Them.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Add;
            this.bt_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Them.Location = new System.Drawing.Point(16, 34);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(96, 41);
            this.bt_Them.TabIndex = 0;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.Red;
            this.btnBaoCao.Location = new System.Drawing.Point(447, 177);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(169, 41);
            this.btnBaoCao.TabIndex = 16;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // Form_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1068, 527);
            this.Controls.Add(this.GrB_ChucNang);
            this.Controls.Add(this.GrB_DSKhachHang);
            this.Controls.Add(this.GrB_TTKhachHang);
            this.Name = "Form_KhachHang";
            this.Text = "Quản lý khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_KhachHang_FormClosing);
            this.Load += new System.EventHandler(this.Form_KhachHang_Load);
            this.GrB_TTKhachHang.ResumeLayout(false);
            this.GrB_TTKhachHang.PerformLayout();
            this.GrB_DSKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Form_KhachHang)).EndInit();
            this.GrB_ChucNang.ResumeLayout(false);
            this.GrB_ChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrB_TTKhachHang;
        private System.Windows.Forms.GroupBox GrB_DSKhachHang;
        private System.Windows.Forms.TextBox txt_SoTaiKhoan;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_NgayDangKy;
        private System.Windows.Forms.Label lb_STK;
        private System.Windows.Forms.Label lb_Sdt;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrB_ChucNang;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.DateTimePicker dtp_KhachHang;
        private System.Windows.Forms.DataGridView dataGridView_Form_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cbb_LoaiKhachHang;
        private System.Windows.Forms.Button btnBaoCao;
    }
}