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
    public partial class Form_QLNV : Form
    {
        public Form_QLNV()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=SHENLONG-PC\SQLEXPRESS;Initial Catalog=DeAn;Integrated Security=True");
            DS_NhanVien = new DataSet();
        }

        SqlConnection conn;
        DataSet DS_NhanVien;

        private void Form_QLNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có chăc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void DanhSo()
        {
            for (int i = 0; i < DataGridView_NhanVien.Rows.Count; i++)
            {
                DataGridView_NhanVien.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        public void TaiDuLieu()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NHANVIEN", conn);
                da.Fill(DS_NhanVien, "NHANVIEN");
                DataTable table = DS_NhanVien.Tables["NHANVIEN"];
                DataColumn[] khoachinh = new DataColumn[1];
                khoachinh[0] = DS_NhanVien.Tables["NHANVIEN"].Columns[0];
                DS_NhanVien.Tables["NHANVIEN"].PrimaryKey = khoachinh;
                DataGridView_NhanVien.DataSource = table;
                DataGridView_NhanVien.RowHeadersVisible = false;
                DanhSo();
            }
            catch { MessageBox.Show("Tải dữ liệu thất bại (-_-)"); }
        }

        private void Form_QLNV_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            cbb_ChucVu.SelectedIndex = 0;
            txtDiaChi.Clear();
            txtHoTen.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            btn_Sua.Enabled = false;
        }

        private void DataGridView_NhanVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btn_Sua.Enabled = true;
                txtMaNV.Text = DataGridView_NhanVien.CurrentRow.Cells[1].Value.ToString();
                txtHoTen.Text = DataGridView_NhanVien.CurrentRow.Cells[2].Value.ToString();
                dtpNgaySinh.Text = DataGridView_NhanVien.CurrentRow.Cells[3].Value.ToString();
                string gioitinh;
                gioitinh = DataGridView_NhanVien.CurrentRow.Cells[4].Value.ToString();
                if (gioitinh == "Nam")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                txtSDT.Text = DataGridView_NhanVien.CurrentRow.Cells[5].Value.ToString();
                cbb_ChucVu.Text = DataGridView_NhanVien.CurrentRow.Cells[6].Value.ToString();
                txtDiaChi.Text = DataGridView_NhanVien.CurrentRow.Cells[7].Value.ToString();
            }
            catch { MessageBox.Show("Bạn Chọn sai (-_-)"); }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow them = DS_NhanVien.Tables["NHANVIEN"].NewRow();
                int dem_ql = 0;
                int dem_nv = 0;
                int cout = DataGridView_NhanVien.Rows.Count;
                string ql = "QL0";
                string nv = "NV0";
                for (int i = 0; i < cout - 1; i++) // đếm số quản lý có trong data
                {
                    string vip = DataGridView_NhanVien.Rows[i].Cells[1].Value.ToString();
                    if (vip.Substring(0, 3) == ql)
                        dem_ql++;
                }
                for (int i = 0; i < cout - 1; i++) // đếm số nhân viên có trong data
                {
                    string vip = DataGridView_NhanVien.Rows[i].Cells[1].Value.ToString();
                    if (vip.Substring(0, 3) == nv)
                        dem_nv++;
                }
                if (txtHoTen.Text.Length == 0 || txtDiaChi.Text.Length == 0)
                    MessageBox.Show("Chưa nhập đầy đủ thông tin nhân viên");
                else
                {
                    // tự động cấp mã quản lý và nhân viên
                    if (cbb_ChucVu.SelectedItem.ToString() == "Chủ")
                        them[0] = "CH000";
                    else if (cbb_ChucVu.SelectedItem.ToString() == "Quản lý")
                        them[0] = "QL0" + (dem_ql + 1).ToString(); // mã quản lý sẽ bằng đếm số quản lý + 1 đơn vị
                    else
                        them[0] = "NV0" + (dem_nv + 1).ToString(); // mã nhân viêns sẽ bằng đếm số quản lý + 1 đơn vị
                    them[1] = txtHoTen.Text;
                    them[2] = dtpNgaySinh.Text;
                    if (rdbNam.Checked)
                        them[3] = "Nam";
                    else
                        them[3] = "Nữ";
                    them[4] = txtSDT.Text;
                    them[5] = cbb_ChucVu.SelectedItem.ToString();
                    them[6] = txtDiaChi.Text;
                    DataRow ktkc = DS_NhanVien.Tables["NHANVIEN"].Rows.Find(txtMaNV.Text);
                    if (ktkc != null)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                        return;
                    }
                    else
                    {
                        DS_NhanVien.Tables["NHANVIEN"].Rows.Add(them);
                    }
                }
                DanhSo();
                MessageBox.Show("Thêm Thành Công)");
            }
            catch { MessageBox.Show("Thêm thất bại (-_-)"); }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    string xoa = DataGridView_NhanVien.CurrentRow.Cells[1].Value.ToString();
                    DataRow row = DS_NhanVien.Tables["NHANVIEN"].Rows.Find(xoa);
                    if (row != null)
                    {
                        row.Delete();
                    }
                }
                else
                    return;
                DanhSo();
            }
            catch { MessageBox.Show("Xóa thất bại (-_-)"); }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NHANVIEN", conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(DS_NhanVien, "NHANVIEN");
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi. Yêu cầu xem lại kết nối hệ thống !!!");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string xoa = DataGridView_NhanVien.CurrentRow.Cells[1].Value.ToString();
                DataRow row = DS_NhanVien.Tables["NHANVIEN"].Rows.Find(xoa);
                if (row != null)
                {
                    row["MaNV"] = txtMaNV.Text;
                    row["HoTen"] = txtHoTen.Text;
                    row["NgaySinh"] = dtpNgaySinh.Text;
                    if (rdbNam.Checked)
                        row["GioiTinh"] = "Nam";
                    else
                        row["GioiTinh"] = "Nữ";
                    row["SDT"] = txtSDT.Text;
                    row["ChucVu"] = cbb_ChucVu.SelectedItem.ToString();
                    row["DiaChi"] = txtDiaChi.Text;
                    MessageBox.Show("Cập nhật thành công");
                }
                DanhSo();
            }
            catch { MessageBox.Show("Cập nhật đối tượng thất bại (-_-)"); }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            cbb_ChucVu.SelectedIndex = 0;
            txtDiaChi.Clear();
            txtHoTen.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            btn_Sua.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BC_NhanVien k = new Form_BC_NhanVien();
            k.ShowDialog();
            this.Show();

        }      
    }
}
