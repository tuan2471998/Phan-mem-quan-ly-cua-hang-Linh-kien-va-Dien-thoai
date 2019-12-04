namespace DoAn_PhanMemQuanLy
{
    partial class Form_QuyenTuyCap
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
            this.GrB_TT_TaiKhoan = new System.Windows.Forms.GroupBox();
            this.rdbManager = new System.Windows.Forms.RadioButton();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lb_LoaiNV = new System.Windows.Forms.Label();
            this.lb_TaiKhoan = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.lb_MaNV = new System.Windows.Forms.Label();
            this.GrB_DSTaiKhoan = new System.Windows.Forms.GroupBox();
            this.dataGridView_From_QuyenTruyCap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.combo_MaNV = new System.Windows.Forms.ComboBox();
            this.GrB_TT_TaiKhoan.SuspendLayout();
            this.GrB_DSTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_From_QuyenTruyCap)).BeginInit();
            this.SuspendLayout();
            // 
            // GrB_TT_TaiKhoan
            // 
            this.GrB_TT_TaiKhoan.Controls.Add(this.combo_MaNV);
            this.GrB_TT_TaiKhoan.Controls.Add(this.rdbManager);
            this.GrB_TT_TaiKhoan.Controls.Add(this.rdbUser);
            this.GrB_TT_TaiKhoan.Controls.Add(this.rdbAdmin);
            this.GrB_TT_TaiKhoan.Controls.Add(this.txtMatKhau);
            this.GrB_TT_TaiKhoan.Controls.Add(this.txtTaiKhoan);
            this.GrB_TT_TaiKhoan.Controls.Add(this.lb_LoaiNV);
            this.GrB_TT_TaiKhoan.Controls.Add(this.lb_TaiKhoan);
            this.GrB_TT_TaiKhoan.Controls.Add(this.lb_MatKhau);
            this.GrB_TT_TaiKhoan.Controls.Add(this.lb_MaNV);
            this.GrB_TT_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_TT_TaiKhoan.Location = new System.Drawing.Point(25, 29);
            this.GrB_TT_TaiKhoan.Name = "GrB_TT_TaiKhoan";
            this.GrB_TT_TaiKhoan.Size = new System.Drawing.Size(696, 123);
            this.GrB_TT_TaiKhoan.TabIndex = 0;
            this.GrB_TT_TaiKhoan.TabStop = false;
            this.GrB_TT_TaiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // rdbManager
            // 
            this.rdbManager.AutoSize = true;
            this.rdbManager.Location = new System.Drawing.Point(163, 78);
            this.rdbManager.Name = "rdbManager";
            this.rdbManager.Size = new System.Drawing.Size(81, 23);
            this.rdbManager.TabIndex = 11;
            this.rdbManager.TabStop = true;
            this.rdbManager.Text = "Manager";
            this.rdbManager.UseVisualStyleBackColor = true;
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Location = new System.Drawing.Point(250, 78);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(56, 23);
            this.rdbUser.TabIndex = 10;
            this.rdbUser.TabStop = true;
            this.rdbUser.Text = "User";
            this.rdbUser.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(90, 78);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(67, 23);
            this.rdbAdmin.TabIndex = 9;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(417, 75);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(212, 26);
            this.txtMatKhau.TabIndex = 8;
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(417, 25);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(212, 26);
            this.txtTaiKhoan.TabIndex = 7;
            this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            // 
            // lb_LoaiNV
            // 
            this.lb_LoaiNV.AutoSize = true;
            this.lb_LoaiNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiNV.Location = new System.Drawing.Point(16, 81);
            this.lb_LoaiNV.Name = "lb_LoaiNV";
            this.lb_LoaiNV.Size = new System.Drawing.Size(52, 19);
            this.lb_LoaiNV.TabIndex = 3;
            this.lb_LoaiNV.Text = "Quyền:";
            // 
            // lb_TaiKhoan
            // 
            this.lb_TaiKhoan.AutoSize = true;
            this.lb_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaiKhoan.Location = new System.Drawing.Point(324, 28);
            this.lb_TaiKhoan.Name = "lb_TaiKhoan";
            this.lb_TaiKhoan.Size = new System.Drawing.Size(80, 19);
            this.lb_TaiKhoan.TabIndex = 2;
            this.lb_TaiKhoan.Text = "Tài Khoản :";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.Location = new System.Drawing.Point(324, 78);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(78, 19);
            this.lb_MatKhau.TabIndex = 1;
            this.lb_MatKhau.Text = "Mật Khẩu :";
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNV.Location = new System.Drawing.Point(16, 31);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(64, 19);
            this.lb_MaNV.TabIndex = 0;
            this.lb_MaNV.Text = "Mã NV :";
            // 
            // GrB_DSTaiKhoan
            // 
            this.GrB_DSTaiKhoan.Controls.Add(this.dataGridView_From_QuyenTruyCap);
            this.GrB_DSTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrB_DSTaiKhoan.Location = new System.Drawing.Point(45, 166);
            this.GrB_DSTaiKhoan.Name = "GrB_DSTaiKhoan";
            this.GrB_DSTaiKhoan.Size = new System.Drawing.Size(369, 193);
            this.GrB_DSTaiKhoan.TabIndex = 1;
            this.GrB_DSTaiKhoan.TabStop = false;
            this.GrB_DSTaiKhoan.Text = "Danh Sách Tài Khoản";
            // 
            // dataGridView_From_QuyenTruyCap
            // 
            this.dataGridView_From_QuyenTruyCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_From_QuyenTruyCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_From_QuyenTruyCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_From_QuyenTruyCap.Location = new System.Drawing.Point(7, 23);
            this.dataGridView_From_QuyenTruyCap.Name = "dataGridView_From_QuyenTruyCap";
            this.dataGridView_From_QuyenTruyCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_From_QuyenTruyCap.Size = new System.Drawing.Size(356, 164);
            this.dataGridView_From_QuyenTruyCap.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quyen";
            this.Column2.HeaderText = "Quyền";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TaiKhoan";
            this.Column3.HeaderText = "Tài Khoản";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MatKhau";
            this.Column4.HeaderText = "Mật Khẩu";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(420, 189);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(93, 45);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(561, 278);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(93, 45);
            this.btn_Thoat.TabIndex = 27;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Save;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(561, 189);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(93, 45);
            this.btn_Luu.TabIndex = 24;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = global::DoAn_PhanMemQuanLy.Properties.Resources.Delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(420, 278);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(93, 45);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // combo_MaNV
            // 
            this.combo_MaNV.FormattingEnabled = true;
            this.combo_MaNV.Location = new System.Drawing.Point(86, 28);
            this.combo_MaNV.Name = "combo_MaNV";
            this.combo_MaNV.Size = new System.Drawing.Size(220, 27);
            this.combo_MaNV.TabIndex = 12;
            // 
            // Form_QuyenTuyCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(696, 368);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.GrB_DSTaiKhoan);
            this.Controls.Add(this.GrB_TT_TaiKhoan);
            this.Name = "Form_QuyenTuyCap";
            this.Text = "Quyền Truy Cập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_QuyenTuyCap_FormClosing);
            this.Load += new System.EventHandler(this.Form_QuyenTuyCap_Load);
            this.GrB_TT_TaiKhoan.ResumeLayout(false);
            this.GrB_TT_TaiKhoan.PerformLayout();
            this.GrB_DSTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_From_QuyenTruyCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrB_TT_TaiKhoan;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Label lb_MaNV;
        private System.Windows.Forms.GroupBox GrB_DSTaiKhoan;
        private System.Windows.Forms.Label lb_TaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lb_LoaiNV;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dataGridView_From_QuyenTruyCap;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RadioButton rdbManager;
        private System.Windows.Forms.ComboBox combo_MaNV;
    }
}