using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_PhanMemQuanLy
{
    public partial class Form_Main : Form
    {
        string manv = "", quyen = "", taikhoan = "", matkhau = "";

        public Form_Main(string manv, string quyen, string taikhoan, string matkhau)
        {
            InitializeComponent();
            this.manv = manv;
            this.quyen = quyen;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }

        public Form_Main()
        {
            // TODO: Complete member initialization
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_HoaDon hd = new Form_HoaDon();
            hd.ShowDialog();
            this.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QLNV nv = new Form_QLNV();
            nv.ShowDialog();
            this.Show();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SanPham sp = new Form_SanPham();
            sp.ShowDialog();
            this.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_KhachHang kh = new Form_KhachHang();
            kh.ShowDialog();
            this.Show();
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Kho kho = new Form_Kho();
            kho.ShowDialog();
            this.Show();
        }

        private void btn_QuyenTruyCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_QuyenTuyCap tc = new Form_QuyenTuyCap();
            tc.ShowDialog(); ;
            this.Show();
        }

        public void GetTK(string str1)
        {
            lb_quyen.Text = str1;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            string s = quyen;
            if (quyen == "admin  ")
            {
                btn_NhanVien.Visible = btn_QuyenTruyCap.Visible = label2.Visible = label6.Visible = true;
            }
            else if (quyen == "manager")
            {
                btn_NhanVien.Visible = label2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
