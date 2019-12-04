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
    public partial class Form_Kho : Form
    {
        public Form_Kho()
        {
            conn = new SqlConnection(@"Data Source=SHENLONG-PC\SQLEXPRESS;Initial Catalog=DeAn;Integrated Security=True"); //kết nối với sql
            DS_Nhap = new DataSet(); // Tạo dataset kho nhập 
            DS_Xuat = new DataSet(); // Tạo dataset kho xuất 
            InitializeComponent();
        }
        SqlConnection conn;
        DataSet DS_Nhap;
        DataSet DS_Xuat;
        
        private void Form_Kho_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có chăc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        // Hàm đánh số thứ tự
        public void DanhSo(DataGridView a)
        {
            for (int i = 0; i < a.Rows.Count; i++)
            {
                a.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        //Hàm tải dữ liệu ở kho xuất
        public void TaiDuLieu1()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Kho_Nhap", conn);

            da.Fill(DS_Nhap, "Kho_Nhap");

            DataTable table = DS_Nhap.Tables["Kho_Nhap"];

            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = DS_Nhap.Tables["Kho_Nhap"].Columns[0];

            DS_Nhap.Tables["Kho_Nhap"].PrimaryKey = khoachinh;

            dataGridView_Nhap.DataSource = table;
          

            DanhSo(dataGridView_Nhap);
        }

        /// <summary>
        /// Hàm tải dữ liệu kho xuất
        /// </summary>
        public void TaiDuLieu2()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KHO_XUAT", conn);

            da.Fill(DS_Xuat, "KHO_XUAT");

            DataTable table = DS_Xuat.Tables["KHO_XUAT"];

            DataColumn[] khoachinh = new DataColumn[1];

            khoachinh[0] = DS_Xuat.Tables["KHO_XUAT"].Columns[0];

            DS_Xuat.Tables["KHO_XUAT"].PrimaryKey = khoachinh;

            dataGridView_Xuat.DataSource = table;

            DanhSo(dataGridView_Xuat);
        }

        // Hàm Load dữ liệu của form Kho
        private void Form_Kho_Load(object sender, EventArgs e)
        {
            TaiDuLieu1();
            loadComboBox();
            loadCombobox_Nhap();
            TaiDuLieu2();
            loadCombobox_Xuat();
        }

        // Hàm thêm  đối tượng vào data set
        private void bt_Them_Nhap_Click(object sender, EventArgs e)
        {
           
            DataRow them = DS_Nhap.Tables["KHO_NHAP"].NewRow();
            them[0] = txt_MaSP_Nhap.Text;
            them[1] = txt_TenSP_Nhap.Text;
            them[2] = txt_MaNV_Nhap.Text;
            them[3] = dtp_NgayNhap.Text;
            them[4] = txt_DonVi_Nhap.Text;
            them[5] = txt_SLN_Nhap.Text;
            DataRow ktkc = DS_Nhap.Tables["KHO_NHAP"].Rows.Find(txt_MaSP_Nhap.Text);
            if (ktkc != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                return;
            }
            else
            {
                DS_Nhap.Tables["KHO_NHAP"].Rows.Add(them);
            }
            DanhSo(dataGridView_Nhap);
        }

        // Hàm sửa của kho nhập
        private void bt_Sua_Nhap_Click(object sender, EventArgs e)
        {
            string sua = dataGridView_Nhap.CurrentRow.Cells[1].Value.ToString();
            DataRow row = DS_Nhap.Tables["KHO_NHAP"].Rows.Find(sua);
            if (row != null)
            {
                row["MaSP"] = txt_MaNV_Nhap.Text;
                row["TenSP"] = txt_TenSP_Nhap.Text;
                row["MaNV"] = txt_MaNV_Nhap.Text;
                row["NgayNhap"] = dtp_NgayNhap.Text;
                row["DonViTinh"] = txt_DonVi_Nhap.Text;
                row["SoLuong"] = txt_SLN_Nhap.Text;
            }
            DanhSo(dataGridView_Nhap);
        }

        // Hàm Xóa của kho nhập
        private void bt_Xoa_Nhap_Click(object sender, EventArgs e)
        {
            try
            {
                string xoa = dataGridView_Nhap.CurrentRow.Cells[1].Value.ToString();
                DataRow row = DS_Nhap.Tables["KHO_NHAP"].Rows.Find(xoa);
                if (row != null)
                {
                    row.Delete();
                }
                DanhSo(dataGridView_Nhap);
            }
            catch { MessageBox.Show("Bạn Chưa Chọn đối tượng muốn xóa"); }
        }

        // Hàm Lưu từ dataset vào SQL
        private void bt_Save_Nhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KHO_NHAP", conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(DS_Nhap, "KHO_NHAP");
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi. Yêu cầu xem lại kết nối hệ thống !!!");
            }
        }

        // Hàm clear tất cả các control
        private void bt_Huy_Nhap_Click(object sender, EventArgs e)
        {
            txt_MaSP_Nhap.Clear();
            txt_TenSP_Nhap.Clear();
            txt_MaNV_Nhap.Clear();
            txt_DonVi_Nhap.Clear();
            txt_SLN_Nhap.Clear();
        }

        

        private void bt_Thoat_Nhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hàm tìm kiếm cua hàm nhập bằng combobox
        private void bt_TimKiem_Nhap_Click(object sender, EventArgs e)
        {
            if (bt_TimKiem_Nhap.Text == "Tìm Kiếm")
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string Timkiem = "SELECT * FROM KHO_NHAP WHERE TenSP = @TenSP";
                SqlCommand comd = new SqlCommand(Timkiem, conn);
                comd.Parameters.AddWithValue("MaSP", txt_MaSP_Nhap.Text);
                comd.Parameters.AddWithValue("TenSP", combo_TK_Nhap.Text);
                comd.Parameters.AddWithValue("MaNV", txt_MaNV_Nhap.Text);
                comd.Parameters.AddWithValue("NgayNhap", dtp_NgayNhap.Text);
                comd.Parameters.AddWithValue("DonViTinh", txt_DonVi_Nhap.Text);
                comd.Parameters.AddWithValue("SoLuong", txt_SLN_Nhap.Text);
                comd.ExecuteNonQuery();
                SqlDataReader re = comd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(re);
                dataGridView_Nhap.DataSource = tb;
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                bt_TimKiem_Nhap.Text = "Trở Về";
            }
            else
            {
                TaiDuLieu1();
                bt_TimKiem_Nhap.Text = "Tìm Kiếm";
            }
            DanhSo(dataGridView_Nhap);
        }

        // Hàm chọn hàng rồi hiện thông tin lên control
        private void dataGridView_Nhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bt_Sua_Nhap.Enabled = true;
                txt_MaSP_Nhap.Text = dataGridView_Nhap.CurrentRow.Cells[1].Value.ToString();
                txt_TenSP_Nhap.Text = dataGridView_Nhap.CurrentRow.Cells[2].Value.ToString();
                txt_MaNV_Nhap.Text = dataGridView_Nhap.CurrentRow.Cells[3].Value.ToString();
                dtp_NgayNhap.Text = dataGridView_Nhap.CurrentRow.Cells[4].Value.ToString();
                txt_DonVi_Nhap.Text = dataGridView_Nhap.CurrentRow.Cells[5].Value.ToString();
                txt_SLN_Nhap.Text = dataGridView_Nhap.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------
        // Kho Xuất
        
        //Hàm thêm đối tượng vào dataset của kho xuất
        private void bt_Them_Xuat_Click(object sender, EventArgs e)
        {
            try
            {
                txt_SLConLai.Text = (int.Parse(txt_SLTon.Text) - int.Parse(txt_SLXuat.Text)).ToString();
                DataRow them = DS_Xuat.Tables["KHO_XUAT"].NewRow();
                them[0] = txt_MaSP_Xuat.Text;
                them[1] = combo_TenSP.Text;
                them[2] = txt_MaNV_Xuat.Text;
                them[3] = dtp_NgayNhap_Xuat.Text;
                them[4] = dtp_NgayXuat.Text;
                them[5] = txt_SLTon.Text;
                them[6] = txt_SLXuat.Text;
                them[7] = txt_SLConLai.Text;
                DataRow ktkc = DS_Xuat.Tables["KHO_XUAT"].Rows.Find(combo_TenSP.Text);
                if (ktkc != null)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại");
                    return;
                }
                else
                {
                    DS_Xuat.Tables["KHO_XUAT"].Rows.Add(them);
                }
                DanhSo(dataGridView_Xuat);
            }
            catch { MessageBox.Show("Bạn chưa nhập đầy đủ thông tin"); }
        }

        // Hàm Lưu từ dataset vào SQL
        private void bt_Save_Xuat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KHO_XUAT", conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(DS_Xuat, "KHO_XUAT");
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi. Yêu cầu xem lại kết nối hệ thống !!!");
            }
        }

        // Hàm Xóa của kho nhập
        private void bt_Xoa_Xuat_Click(object sender, EventArgs e)
        {
            string xoa = dataGridView_Xuat.CurrentRow.Cells[1].Value.ToString();
            DataRow row = DS_Xuat.Tables["KHO_XUAT"].Rows.Find(xoa);
            if (row != null)
            {
                row.Delete();
            }
            DanhSo(dataGridView_Xuat);
        }

        private void bt_Huy_Xuat_Click(object sender, EventArgs e)
        {
            txt_MaNV_Xuat.Clear();
            txt_SLConLai.Clear();
            txt_SLXuat.Clear();
            txt_SLTon.Clear();
            txt_MaSP_Xuat.Clear();
        }

        // Hàm tìm kiếm bằng combobox của kho xuất
        private void bt_TimKiem_Xuat_Click(object sender, EventArgs e)
        {
            if (bt_TimKiem_Xuat.Text == "Tìm Kiếm")
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string Timkiem = "SELECT * FROM KHO_XUAT WHERE TenSP = @TenSP";
                SqlCommand comd = new SqlCommand(Timkiem, conn);
                comd.Parameters.AddWithValue("MaSP", txt_MaSP_Xuat.Text);
                comd.Parameters.AddWithValue("TenSP", combo_TenSP.Text);
                comd.Parameters.AddWithValue("MaNV", txt_MaNV_Xuat.Text);
                comd.Parameters.AddWithValue("NgayNhap", dtp_NgayNhap.Text);
                comd.Parameters.AddWithValue("NgayXuat", dtp_NgayXuat.Text);
                comd.Parameters.AddWithValue("SoLuong", txt_SLTon.Text);
                comd.Parameters.AddWithValue("SoLuongXuat", txt_SLXuat.Text);
                comd.Parameters.AddWithValue("SoLuongConLai", txt_SLConLai.Text);
                comd.ExecuteNonQuery();
                SqlDataReader re = comd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(re);
                dataGridView_Xuat.DataSource = tb;
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                bt_TimKiem_Xuat.Text = "Trở Về";
            }
            else
            {
                TaiDuLieu2(); // load dữ liệu của bảng kho xuất
                bt_TimKiem_Xuat.Text = "Tìm Kiếm";
            }
            DanhSo(dataGridView_Xuat);
        }

        private void bt_Thoat_Xuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // hàm tải tên sản phẩm lên combobox của kho xuất
        private void loadComboBox()
        {
            conn.Open();
            string caulenh = "select TenSP from KHO_NHAP";
            SqlCommand cmd = new SqlCommand(caulenh, conn);
            SqlDataAdapter adap = new SqlDataAdapter(caulenh, conn);
            adap.Fill(DS_Nhap);
            cmd.ExecuteNonQuery();
            conn.Close();
            combo_TenSP.DataSource = DS_Nhap.Tables[0];
            combo_TenSP.DisplayMember = DS_Nhap.Tables[0].Columns[1].ToString();
        }

        private void combo_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string Timkiem = "SELECT MaSP,TenSP,MaNV,NgayNhap,SoLuong FROM KHO_NHAP WHERE TenSP = @TenSP";
            SqlCommand comd = new SqlCommand(Timkiem, conn);
            comd.Parameters.AddWithValue("MaSP", txt_MaSP_Xuat.Text);
            comd.Parameters.AddWithValue("TenSP", combo_TenSP.Text);
            comd.Parameters.AddWithValue("MaNV", txt_MaNV_Xuat.Text);
            comd.Parameters.AddWithValue("NgayNhap", dtp_NgayNhap_Xuat.Text);
            comd.Parameters.AddWithValue("SoLuong", txt_SLTon.Text);
            comd.ExecuteNonQuery();
            SqlDataReader re = comd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(re);
            dataGridView_Xuat.DataSource = tb;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Hàm chọn hàng rồi hiện thông tin lên control
        private void dataGridView_Xuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                txt_MaSP_Xuat.Text = dataGridView_Xuat.CurrentRow.Cells[1].Value.ToString();
                combo_TenSP.Text = dataGridView_Xuat.CurrentRow.Cells[2].Value.ToString();
                txt_MaNV_Xuat.Text = dataGridView_Xuat.CurrentRow.Cells[3].Value.ToString();
                dtp_NgayNhap_Xuat.Text = dataGridView_Xuat.CurrentRow.Cells[4].Value.ToString();
                txt_SLTon.Text = dataGridView_Xuat.CurrentRow.Cells[5].Value.ToString();
                TaiDuLieu2();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        //hàm load tên sản phẩm kho nhập lên combobox tìm kiếm
        public void loadCombobox_Nhap()
        {
            conn.Open();
            string caulenh = "select TenSP from KHO_NHAP";
            SqlCommand cmd = new SqlCommand(caulenh, conn);
            SqlDataAdapter adap = new SqlDataAdapter(caulenh, conn);
            adap.Fill(DS_Nhap);
            cmd.ExecuteNonQuery();
            conn.Close();
            combo_TK_Nhap.DataSource = DS_Nhap.Tables[0];
            combo_TK_Nhap.DisplayMember = DS_Nhap.Tables[0].Columns[1].ToString(); // lấy dữ liệu ở cột thứ 1 của bảng
        }

        //hàm load tên sản phẩm kho xuất lên combobox tìm kiếm
        public void loadCombobox_Xuat()
        {
            conn.Open();
            string caulenh = "select TenSP from KHO_XUAT";
            SqlCommand cmd = new SqlCommand(caulenh, conn);
            SqlDataAdapter adap = new SqlDataAdapter(caulenh, conn);
            adap.Fill(DS_Xuat);
            cmd.ExecuteNonQuery();
            conn.Close();
            combo_TK_Xuat.DataSource = DS_Xuat.Tables[0];
            combo_TK_Xuat.DisplayMember = DS_Xuat.Tables[0].Columns[1].ToString(); // lấy dữ liệu ở cột thứ 1 của bảng
        }


        private void bt_BC_KhoNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BC_KhoNhap k = new Form_BC_KhoNhap();
            k.ShowDialog();
            this.Show();
        }

        private void btnBaoCaoXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BC_KhoXuat k = new Form_BC_KhoXuat();
            k.ShowDialog();
            this.Show();
        }  
    }
}
