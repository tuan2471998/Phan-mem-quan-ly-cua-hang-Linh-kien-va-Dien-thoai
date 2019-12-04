namespace DoAn_PhanMemQuanLy
{
    partial class Form_QLNV
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
            this.GrB_ThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.cbb_ChucVu = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_ChuvVu = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_GioiTinh = new System.Windows.Forms.Label();
            this.lb_NamSinh = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_MaNV = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.GrB_DSNhanVien = new System.Windows.Forms.GroupBox();
            this.DataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.GrB_ThongTinNhanVien.SuspendLayout();
            this.GrB_DSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrB_ThongTinNhanVien
            // 
            this.GrB_ThongTinNhanVien.Controls.Add(this.btnBaoCao);
            this.GrB_ThongTinNhanVien.Controls.Add(this.cbb_ChucVu);
            this.GrB_ThongTinNhanVien.Controls.Add(this.dtpNgaySinh);
            this.GrB_ThongTinNhanVien.Controls.Add(this.rdbNu);
            this.GrB_ThongTinNhanVien.Controls.Add(this.rdbNam);
            this.GrB_ThongTinNhanVien.Controls.Add(this.txtDiaChi);
            this.GrB_ThongTinNhanVien.Controls.Add(this.txtSDT);
            this.GrB_ThongTinNhanVien.Controls.Add(this.txtHoTen);
            this.GrB_ThongTinNhanVien.Controls.Add(this.txtMaNV);
            this.GrB_ThongTinNhanVien.Controls.Add(this.lb_SDT);
            this.GrB_ThongTinNhanVien.Controls.Add(this.lb_ChuvVu);
            this.GrB_ThongTinNhanVien.Controls.Add(this.lb_DiaChi);
            this.GrB_ThongTinNhanVien.Controls.Add(this.lb_GioiTinh);
            this.GrB_ThongTinNhanVien.Controls.Add(this.lb_NamSinh);
            this.GrB_ThongTinNhanVien.Controls.Add(this.lb_HoTen);
            this.GrB_ThongTinNhanVien.Controls.Add(this.lb_MaNV);
            this.GrB_ThongTinNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_ThongTinNhanVien.Location = new System.Drawing.Point(25, 12);
            this.GrB_ThongTinNhanVien.Name = "GrB_ThongTinNhanVien";
            this.GrB_ThongTinNhanVien.Size = new System.Drawing.Size(755, 233);
            this.GrB_ThongTinNhanVien.TabIndex = 0;
            this.GrB_ThongTinNhanVien.TabStop = false;
            this.GrB_ThongTinNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // cbb_ChucVu
            // 
            this.cbb_ChucVu.FormattingEnabled = true;
            this.cbb_ChucVu.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý",
            "Chủ"});
            this.cbb_ChucVu.Location = new System.Drawing.Point(501, 83);
            this.cbb_ChucVu.Name = "cbb_ChucVu";
            this.cbb_ChucVu.Size = new System.Drawing.Size(214, 27);
            this.cbb_ChucVu.TabIndex = 17;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(115, 131);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(214, 26);
            this.dtpNgaySinh.TabIndex = 16;
            this.dtpNgaySinh.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(221, 179);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(48, 23);
            this.rdbNu.TabIndex = 15;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(144, 179);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 23);
            this.rdbNam.TabIndex = 14;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.Location = new System.Drawing.Point(501, 126);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(214, 62);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.Location = new System.Drawing.Point(501, 36);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(214, 26);
            this.txtSDT.TabIndex = 11;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.Location = new System.Drawing.Point(115, 79);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(214, 26);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.White;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(115, 32);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(214, 26);
            this.txtMaNV.TabIndex = 7;
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.Location = new System.Drawing.Point(381, 36);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(103, 19);
            this.lb_SDT.TabIndex = 6;
            this.lb_SDT.Text = "Số Điện Thoại :";
            // 
            // lb_ChuvVu
            // 
            this.lb_ChuvVu.AutoSize = true;
            this.lb_ChuvVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChuvVu.Location = new System.Drawing.Point(381, 83);
            this.lb_ChuvVu.Name = "lb_ChuvVu";
            this.lb_ChuvVu.Size = new System.Drawing.Size(72, 19);
            this.lb_ChuvVu.TabIndex = 5;
            this.lb_ChuvVu.Text = "Chức Vụ :";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(381, 129);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(62, 19);
            this.lb_DiaChi.TabIndex = 4;
            this.lb_DiaChi.Text = "Địa Chỉ :";
            // 
            // lb_GioiTinh
            // 
            this.lb_GioiTinh.AutoSize = true;
            this.lb_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GioiTinh.Location = new System.Drawing.Point(29, 181);
            this.lb_GioiTinh.Name = "lb_GioiTinh";
            this.lb_GioiTinh.Size = new System.Drawing.Size(71, 19);
            this.lb_GioiTinh.TabIndex = 3;
            this.lb_GioiTinh.Text = "Giới Tính :";
            // 
            // lb_NamSinh
            // 
            this.lb_NamSinh.AutoSize = true;
            this.lb_NamSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamSinh.Location = new System.Drawing.Point(29, 133);
            this.lb_NamSinh.Name = "lb_NamSinh";
            this.lb_NamSinh.Size = new System.Drawing.Size(75, 19);
            this.lb_NamSinh.TabIndex = 2;
            this.lb_NamSinh.Text = "Ngày Sinh:";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.Location = new System.Drawing.Point(29, 83);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(80, 19);
            this.lb_HoTen.TabIndex = 1;
            this.lb_HoTen.Text = "Họ và Tên :";
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNV.Location = new System.Drawing.Point(29, 36);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(59, 19);
            this.lb_MaNV.TabIndex = 0;
            this.lb_MaNV.Text = "Mã NV:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(16, 107);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(93, 45);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(16, 29);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(93, 45);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // GrB_DSNhanVien
            // 
            this.GrB_DSNhanVien.Controls.Add(this.DataGridView_NhanVien);
            this.GrB_DSNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_DSNhanVien.Location = new System.Drawing.Point(25, 272);
            this.GrB_DSNhanVien.Name = "GrB_DSNhanVien";
            this.GrB_DSNhanVien.Size = new System.Drawing.Size(1033, 226);
            this.GrB_DSNhanVien.TabIndex = 1;
            this.GrB_DSNhanVien.TabStop = false;
            this.GrB_DSNhanVien.Text = "Danh Sách Nhân Viên";
            // 
            // DataGridView_NhanVien
            // 
            this.DataGridView_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.SDT,
            this.ChucVu,
            this.DiaChi});
            this.DataGridView_NhanVien.Location = new System.Drawing.Point(7, 26);
            this.DataGridView_NhanVien.Name = "DataGridView_NhanVien";
            this.DataGridView_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_NhanVien.Size = new System.Drawing.Size(1020, 194);
            this.DataGridView_NhanVien.TabIndex = 0;
            this.DataGridView_NhanVien.SelectionChanged += new System.EventHandler(this.DataGridView_NhanVien_SelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(799, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(150, 175);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(93, 45);
            this.btn_Thoat.TabIndex = 22;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Cancel;
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(150, 107);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(93, 45);
            this.btn_Huy.TabIndex = 21;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Update;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(150, 26);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(93, 45);
            this.btn_Sua.TabIndex = 20;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Save;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(16, 177);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(93, 45);
            this.btn_Luu.TabIndex = 19;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.Red;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(355, 166);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(114, 45);
            this.btnBaoCao.TabIndex = 23;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // Form_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1085, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrB_DSNhanVien);
            this.Controls.Add(this.GrB_ThongTinNhanVien);
            this.Name = "Form_QLNV";
            this.Text = "Quản Lý Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_QLNV_FormClosing);
            this.Load += new System.EventHandler(this.Form_QLNV_Load);
            this.GrB_ThongTinNhanVien.ResumeLayout(false);
            this.GrB_ThongTinNhanVien.PerformLayout();
            this.GrB_DSNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrB_ThongTinNhanVien;
        private System.Windows.Forms.Label lb_MaNV;
        private System.Windows.Forms.GroupBox GrB_DSNhanVien;
        private System.Windows.Forms.Label lb_ChuvVu;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_GioiTinh;
        private System.Windows.Forms.Label lb_NamSinh;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView DataGridView_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox cbb_ChucVu;
        private System.Windows.Forms.Button btnBaoCao;
    }
}

