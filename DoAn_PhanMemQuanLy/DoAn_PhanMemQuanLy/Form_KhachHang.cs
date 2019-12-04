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
    public partial class Form_KhachHang : Form
    {
        SqlConnection conn;
        DataSet DS_KhachHang;

        public Form_KhachHang()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=SHENLONG-PC\SQLEXPRESS;Initial Catalog=DeAn;Integrated Security=True");
            DS_KhachHang = new DataSet();
        }

        private void Form_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có chăc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DanhSo()
        {
            for (int i = 0; i < dataGridView_Form_KhachHang.Rows.Count; i++)
            {
                dataGridView_Form_KhachHang.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Clear();
            txt_DienThoai.Clear();
            txt_HoTen.Clear();
            txt_MaKH.Clear();
            txt_SoTaiKhoan.Clear();
            txt_TimKiem.Clear();
            for (int i = 0; i < dataGridView_Form_KhachHang.Rows.Count - 1; i++)
            {
                dataGridView_Form_KhachHang.Rows[i].Selected = false;
            }
        }

        public void TaiDuLieu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KHACHHANG", conn);
            da.Fill(DS_KhachHang, "KHACHHANG");
            DataTable table = DS_KhachHang.Tables["KHACHHANG"];
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = DS_KhachHang.Tables["KHACHHANG"].Columns[0];
            DS_KhachHang.Tables["KHACHHANG"].PrimaryKey = khoachinh;
            dataGridView_Form_KhachHang.DataSource = table;
            dataGridView_Form_KhachHang.RowHeadersVisible = false;
            DanhSo();
        }

        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text.Length == 0 || txt_DiaChi.Text.Length == 0 || txt_DienThoai.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin khách hàng");
            }
            if (txt_DienThoai.Text.Length != 10 || txt_DienThoai.Text.Substring(0,1) != "0")
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                txt_DienThoai.Focus();
            }
            else
            {
                int count = dataGridView_Form_KhachHang.Rows.Count;
                string mavip = "KHVI";
                string mathuong = "KHTH";
                int demvip = 0;
                int demthuong = 0;
                for (int i = 0; i < count - 1; i++)
                {
                    string vip = dataGridView_Form_KhachHang.Rows[i].Cells[1].Value.ToString();
                    if (vip.Substring(0, 4) == mavip)
                        demvip++;
                }
                for (int i = 0; i < count - 1; i++)
                {
                    string vip = dataGridView_Form_KhachHang.Rows[i].Cells[1].Value.ToString();
                    if (vip.Substring(0, 4) == mathuong)
                        demthuong++;
                }
                DataRow them = DS_KhachHang.Tables["KHACHHANG"].NewRow();
                if (cbb_LoaiKhachHang.Text == "VIP")
                    them[0] = mavip + "0" + (demvip + 1).ToString();
                else
                    them[0] = mathuong + "0" + (demthuong + 1).ToString();
                them[1] = txt_HoTen.Text;
                them[2] = txt_DiaChi.Text;
                them[3] = txt_DienThoai.Text;
                if (cbb_LoaiKhachHang.Text == "VIP")
                    them[4] = txt_DienThoai.Text.Substring(7, 3) + "VI0" + (demvip + 1).ToString();
                else
                    them[4] = txt_DienThoai.Text.Substring(7, 3) + "TH0" + (demthuong + 1).ToString();
                them[5] = dtp_KhachHang.Text;
                if (cbb_LoaiKhachHang.Text == "VIP")
                    them[6] = "VIP";
                else
                    them[6] = "THƯỜNG";

                DataRow ktkc = DS_KhachHang.Tables["KHACHHANG"].Rows.Find(txt_MaKH.Text);
                if (ktkc != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                    return;
                }
                else
                {
                    DS_KhachHang.Tables["KHACHHANG"].Rows.Add(them);
                }
                DanhSo();
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string xoa = dataGridView_Form_KhachHang.CurrentRow.Cells[1].Value.ToString();
                DataRow row = DS_KhachHang.Tables["KHACHHANG"].Rows.Find(xoa);
                if (row != null)
                {
                    row.Delete();
                }
            }
            else
                return;
            DanhSo();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KHACHHANG", conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(DS_KhachHang, "KHACHHANG");
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi. Yêu cầu xem lại kết nối hệ thống !!!");
            }
        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            string sua = dataGridView_Form_KhachHang.CurrentRow.Cells[1].Value.ToString();
            DataRow row = DS_KhachHang.Tables["KHACHHANG"].Rows.Find(sua);
            if (row != null)
            {
                row["MaKH"] = txt_MaKH.Text;
                row["TenKH"] = txt_HoTen.Text;
                row["DiaChi"] = txt_DiaChi.Text;
                row["DienThoai"] = txt_DienThoai.Text;
                row["SoTaiKhoan"] = txt_SoTaiKhoan.Text;
                row["NgayDangKy"] = dtp_KhachHang.Text;
                row["LoaiKH"] = cbb_LoaiKhachHang.Text;
            }
            DanhSo();
        }

        

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "";
        }

        private void dataGridView_Form_KhachHang_SelectionChanged(object sender, EventArgs e)
        {
            bt_Sua.Enabled = true;
            txt_MaKH.Text = dataGridView_Form_KhachHang.CurrentRow.Cells[1].Value.ToString();
            txt_HoTen.Text = dataGridView_Form_KhachHang.CurrentRow.Cells[2].Value.ToString();
            txt_DiaChi.Text = dataGridView_Form_KhachHang.CurrentRow.Cells[3].Value.ToString();
            txt_DienThoai.Text = dataGridView_Form_KhachHang.CurrentRow.Cells[4].Value.ToString();
            txt_SoTaiKhoan.Text = dataGridView_Form_KhachHang.CurrentRow.Cells[5].Value.ToString();
            dtp_KhachHang.Text = dataGridView_Form_KhachHang.CurrentRow.Cells[6].Value.ToString();
            cbb_LoaiKhachHang.Text = dataGridView_Form_KhachHang.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BC_KhachHang k = new Form_BC_KhachHang();
            k.ShowDialog();
            this.Show();
        }
    }
}
