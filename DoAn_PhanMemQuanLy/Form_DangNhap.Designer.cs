namespace DoAn_PhanMemQuanLy
{
    partial class Form_DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.bt_DangNhap = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(167, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Location = new System.Drawing.Point(173, 105);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(254, 29);
            this.txt_TaiKhoan.TabIndex = 1;
            this.txt_TaiKhoan.Enter += new System.EventHandler(this.txt_TaiKhoan_Enter);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(351, 205);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(5);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(76, 37);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Đăng Nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu :";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(173, 151);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(254, 29);
            this.txt_MatKhau.TabIndex = 2;
            this.txt_MatKhau.Enter += new System.EventHandler(this.txt_MatKhau_Enter);
            // 
            // bt_DangNhap
            // 
            this.bt_DangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_DangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_DangNhap.Location = new System.Drawing.Point(173, 205);
            this.bt_DangNhap.Name = "bt_DangNhap";
            this.bt_DangNhap.Size = new System.Drawing.Size(125, 37);
            this.bt_DangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_DangNhap.TabIndex = 5;
            this.bt_DangNhap.Text = "Đăng Nhập";
            this.bt_DangNhap.Click += new System.EventHandler(this.bt_DangNhap_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(490, 268);
            this.Controls.Add(this.bt_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private DevComponents.DotNetBar.ButtonX bt_DangNhap;
    }
}