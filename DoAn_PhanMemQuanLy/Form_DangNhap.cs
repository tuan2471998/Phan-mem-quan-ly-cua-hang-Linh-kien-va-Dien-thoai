using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn_PhanMemQuanLy
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=SHENLONG-PC\SQLEXPRESS;Initial Catalog=DeAn;Integrated Security=True");
        }

        SqlConnection conn;
        public static string manv = "";

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string manv = "";
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select * from QUYENTRUYCAP where TaiKhoan='" + txt_TaiKhoan.Text + "' and MatKhau='" + txt_MatKhau.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                if (table != null)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        manv = dr["MaNV"].ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                if (manv != "")
                {
                    this.Hide();
                    Form_Main main = new Form_Main(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), table.Rows[0][3].ToString());
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    txt_TaiKhoan.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_TaiKhoan_Enter(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = null;
        }

        private void txt_MatKhau_Enter(object sender, EventArgs e)
        {
            txt_MatKhau.Text = null;
        }
    }
}
