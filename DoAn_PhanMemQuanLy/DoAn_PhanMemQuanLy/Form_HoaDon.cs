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
    public partial class Form_HoaDon : Form
    {
        SqlConnection conn;
        DataSet DS_HoaDon;
        public Form_HoaDon()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=SHENLONG-PC\SQLEXPRESS;Initial Catalog=DeAn;Integrated Security=True");
            DS_HoaDon = new DataSet();
        }

        private void Form_HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có chăc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        public string masp, tensp, dongia;

       

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void DanhSo()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }


        public void TaiDuLieu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", conn);
            da.Fill(DS_HoaDon, "HOADON");
            DataTable table = DS_HoaDon.Tables["HOADON"];
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = DS_HoaDon.Tables["HOADON"].Columns[0];
            DS_HoaDon.Tables["HOADON"].PrimaryKey = khoachinh;
            dataGridView1.DataSource = table;
            DanhSo();
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            txt_MaSP.Text = masp;
            txt_TenSP.Text = tensp;
            txt_DonGia.Text = dongia;
            TaiDuLieu();
            
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            try
            {
                txt_ThanhTien.Text = (int.Parse(txt_SoLuong.Text) * int.Parse(txt_DonGia.Text)).ToString();
                txt_GiamGia.Text = (int.Parse(txt_ThanhTien.Text) * Convert.ToDouble(txt_GiamGia.Text) / 100).ToString();
                txt_TongTien.Text = (int.Parse(txt_ThanhTien.Text) - Convert.ToDouble(txt_GiamGia.Text)).ToString();
                DataRow them = DS_HoaDon.Tables["HOADON"].NewRow();
                them[0] = txt_MaHD.Text;
                them[1] = dtp_NgayBan.Text;
                them[2] = txt_MaKH.Text;
                them[3] = txt_TenKH.Text;
                them[4] = txt_MaSP.Text;
                them[5] = txt_TenSP.Text;
                them[6] = txt_SoLuong.Text;
                them[7] = txt_DonGia.Text;
                them[8] = txt_ThanhTien.Text;
                them[9] = txt_GiamGia.Text;
                them[10] = txt_TongTien.Text;

                DataRow ktkc = DS_HoaDon.Tables["HOADON"].Rows.Find(txt_MaHD.Text);
                if (ktkc != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                    return;
                }
                else
                {
                    DS_HoaDon.Tables["HOADON"].Rows.Add(them);
                }
                DanhSo();
            }
            catch { MessageBox.Show("Thêm Thất Bại"); }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sua = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                DataRow row = DS_HoaDon.Tables["HOADON"].Rows.Find(sua);
                if (row != null)
                {
                    row["MaHD"] = txt_MaHD.Text;
                    row["NgayBan"] = dtp_NgayBan.Text;
                    row["MaKH"] = txt_MaKH.Text;
                    row["TenKH"] = txt_TenKH.Text;
                    row["MaSP"] = txt_MaSP.Text;
                    row["TenSP"] = txt_TenSP.Text;
                    row["SoLuong"] = txt_SoLuong.Text;
                    row["DonGia"] = txt_DonGia.Text;
                    row["ThanhTien"] = txt_ThanhTien.Text;
                    row["GiamGia"] = txt_GiamGia.Text;
                    row["TongTien"] = txt_TongTien.Text;
                }
                DanhSo();
            }
            catch { MessageBox.Show("Bạn chưa chọn mục muôn sửa"); }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            string xoa = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DataRow row = DS_HoaDon.Tables["HOADON"].Rows.Find(xoa);
            if (row != null)
            {
                row.Delete();
            }
            DanhSo();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(DS_HoaDon, "HOADON");
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi. Yêu cầu xem lại kết nối hệ thống !!!");
            }
        }

        private void bt_Huy_Click_1(object sender, EventArgs e)
        {
            txt_DonGia.Clear();
            txt_GiamGia.Clear();
            txt_MaHD.Clear();
            txt_MaKH.Clear();
            txt_MaSP.Clear();
            txt_SoLuong.Clear();
            txt_TenKH.Clear();
            txt_TenSP.Clear();
            txt_ThanhTien.Clear();

            txt_TongTien.Clear();
        }

        private void bt_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bt_Sua.Enabled = true;
                txt_MaHD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dtp_NgayBan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_MaKH.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_TenSP.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_MaSP.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_TenSP.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_SoLuong.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_DonGia.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txt_ThanhTien.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txt_GiamGia.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txt_TongTien.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
            catch
            { MessageBox.Show("Bạn chọn Sai !!!"); }
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            if (bt_TimKiem.Text == "Tìm Kiếm")
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string Timkiem = "SELECT * FROM HOADON WHERE MaHD = @MaHD"; ;
                SqlCommand comd = new SqlCommand(Timkiem, conn);

                comd.Parameters.AddWithValue("MaHD", txt_TimKiem.Text);
                comd.Parameters.AddWithValue("NgayBan", dtp_NgayBan.Text);
                comd.Parameters.AddWithValue("MaKH", txt_MaKH.Text);
                comd.Parameters.AddWithValue("TenKH", txt_TenKH.Text);
                comd.Parameters.AddWithValue("MaSP", txt_MaSP.Text);
                comd.Parameters.AddWithValue("TenSP", txt_TenSP.Text);
                comd.Parameters.AddWithValue("SoLuong", txt_SoLuong.Text);
                comd.Parameters.AddWithValue("DonGia", txt_DonGia.Text);
                comd.Parameters.AddWithValue("ThanhTien", txt_ThanhTien.Text);
                comd.Parameters.AddWithValue("GiamGia", txt_GiamGia.Text);
                comd.Parameters.AddWithValue("TongTien", txt_TongTien.Text);

                comd.ExecuteNonQuery();
                SqlDataReader re = comd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(re);
                dataGridView1.DataSource = tb;
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                bt_TimKiem.Text = "Trở Về";
            }
            else
            {
                TaiDuLieu();
                bt_TimKiem.Text = "Tìm Kiếm";
            }
            DanhSo();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BC_HoaDon k = new Form_BC_HoaDon();
            k.ShowDialog();
            this.Show();
        }

    }
}
