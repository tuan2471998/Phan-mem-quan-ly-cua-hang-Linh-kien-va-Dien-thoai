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
    public partial class Form_SanPham : Form
    {
        SqlConnection conn;
        DataSet DS_SanPham_DienThoai;
        DataSet DS_SanPham_LinhKien;

        public Form_SanPham()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=SHENLONG-PC\SQLEXPRESS;Initial Catalog=DeAn;Integrated Security=True");
            DS_SanPham_DienThoai = new DataSet();
            DS_SanPham_LinhKien = new DataSet();
        }

        private void Form_SanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có chăc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_ThoatLK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_SoLuong_DT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void DanhSoDT()
        {
            for (int i = 0; i < dataGridView_Form_DienThoai.Rows.Count; i++)
            {
                dataGridView_Form_DienThoai.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        public void DanhSoLK()
        {
            for (int i = 0; i < dataGridView_Form_LinhKien.Rows.Count; i++)
            {
                dataGridView_Form_LinhKien.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        public void TaiDuLieuDT()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DIENTHOAI", conn);
                da.Fill(DS_SanPham_DienThoai, "DIENTHOAI");
                DataTable table = DS_SanPham_DienThoai.Tables["DIENTHOAI"];
                DataColumn[] khoachinh = new DataColumn[1];
                khoachinh[0] = DS_SanPham_DienThoai.Tables["DIENTHOAI"].Columns[0];
                DS_SanPham_DienThoai.Tables["DIENTHOAI"].PrimaryKey = khoachinh;
                dataGridView_Form_DienThoai.DataSource = table;
                dataGridView_Form_DienThoai.RowHeadersVisible = false;
                DanhSoDT();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    txt_TimKiemDT.AutoCompleteCustomSource.Add(table.Rows[i][1].ToString());
                }
                txt_TimKiemDT.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_TimKiemDT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch { MessageBox.Show("Tải dư liệu điện thoại thất bại (-_-)"); }
              
        }

        public void TaiDuLieuLK()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LINHKIEN", conn);
                da.Fill(DS_SanPham_LinhKien, "LINHKIEN");
                DataTable table = DS_SanPham_LinhKien.Tables["LINHKIEN"];
                DataColumn[] khoachinh = new DataColumn[1];
                khoachinh[0] = DS_SanPham_LinhKien.Tables["LINHKIEN"].Columns[0];
                DS_SanPham_LinhKien.Tables["LINHKIEN"].PrimaryKey = khoachinh;
                dataGridView_Form_LinhKien.DataSource = table;
                dataGridView_Form_LinhKien.RowHeadersVisible = false;
                DanhSoLK();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    txt_TimKiem_LK.AutoCompleteCustomSource.Add(table.Rows[i][1].ToString());
                }
                txt_TimKiem_LK.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_TimKiem_LK.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch { MessageBox.Show("Tải dư liệu linh kiện thất bại (-_-)"); }

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            TaiDuLieuLK();
            ClearRowLK();
        }

        private void ClearRowDT()
        {
            for (int i = 0; i < dataGridView_Form_DienThoai.RowCount - 1; i++)
            {
                dataGridView_Form_DienThoai.Rows[i].Selected = false;
            }
        }

        private void ClearRowLK()
        {
            for (int i = 0; i < dataGridView_Form_LinhKien.RowCount - 1; i++)
            {
                dataGridView_Form_LinhKien.Rows[i].Selected = false;
            }
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            ClearRowDT();
            try
            {
                for (int i = 0; i < dataGridView_Form_DienThoai.RowCount - 1; i++)
                {
                    if (txt_TimKiemDT.Text == dataGridView_Form_DienThoai.Rows[i].Cells[2].Value.ToString())
                    {
                        dataGridView_Form_DienThoai.Rows[i].Cells[2].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hiện không có sản phẩm này");
            }
        }

        private void btn_TimKiemLK_Click(object sender, EventArgs e)
        {
            ClearRowLK();
            try
            {
                for (int i = 0; i < dataGridView_Form_LinhKien.RowCount - 1; i++)
                {
                    if (txt_TimKiem_LK.Text == dataGridView_Form_LinhKien.Rows[i].Cells[2].Value.ToString())
                    {
                        dataGridView_Form_LinhKien.Rows[i].Cells[2].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hiện không có sản phẩm này");
            }
        } 

        private void Form_SanPham_Load(object sender, EventArgs e)
        {
            TaiDuLieuDT();
            ClearRowDT();
            txt_MaDT.Clear();
            txt_TenDT.Clear();
            txt_DonGiaDT.Clear();
            dtp_DienThoai.Value = System.DateTime.Now;
            txt_SoLuongDT.Clear();
            txt_BaoHanhDT.Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaDT.Text.Length == 0 || txt_TenDT.Text.Length == 0 || txt_DonGiaDT.Text.Length == 0 || txt_SoLuongDT.Text.Length == 0)
                    MessageBox.Show("Thông tin chưa đây đủ");
                else
                {
                    DataRow them = DS_SanPham_DienThoai.Tables["DIENTHOAI"].NewRow();
                    them[0] = txt_MaDT.Text;
                    them[1] = txt_TenDT.Text;
                    them[2] = txt_DonGiaDT.Text;
                    them[3] = dtp_DienThoai.Text;
                    them[4] = txt_BaoHanhDT.Text;
                    them[5] = txt_SoLuongDT.Text;
                    DataRow ktkc = DS_SanPham_DienThoai.Tables["DIENTHOAI"].Rows.Find(txt_MaDT.Text);
                    if (ktkc != null)
                    {
                        MessageBox.Show("Mã điện thoại đã tồn tại");
                        return;
                    }
                    else
                    {
                        DS_SanPham_DienThoai.Tables["DIENTHOAI"].Rows.Add(them);
                    }
                }
                txt_TimKiemDT.AutoCompleteCustomSource.Add(txt_TenDT.Text);
                DanhSoDT();
                txt_MaDT.Clear();
                txt_TenDT.Clear();
                txt_DonGiaDT.Clear();
                dtp_DienThoai.Value = System.DateTime.Now;
                txt_SoLuongDT.Clear();
                txt_BaoHanhDT.Clear();
            }
            catch { MessageBox.Show("Bạn nhập sai"); }
            
        }

        private void btn_ThemLK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaLK.Text.Length == 0 || txt_TenLK.Text.Length == 0 || txt_DonGiaLK.Text.Length == 0 || txt_SoLuongLK.Text.Length == 0)
                    MessageBox.Show("Thông tin chưa đây đủ");
                else
                {
                    DataRow them = DS_SanPham_LinhKien.Tables["LINHKIEN"].NewRow();
                    them[0] = txt_MaLK.Text;
                    them[1] = txt_TenLK.Text;
                    them[2] = txt_DonGiaLK.Text;
                    them[3] = dtp_LinhKien.Text;
                    them[4] = txt_BaoHanhLK.Text;
                    them[5] = txt_SoLuongLK.Text;
                    DataRow ktkc = DS_SanPham_LinhKien.Tables["LINHKIEN"].Rows.Find(txt_MaLK.Text);
                    if (ktkc != null)
                    {
                        MessageBox.Show("Mã linh kiện đã tồn tại");
                        return;
                    }
                    else
                    {
                        DS_SanPham_LinhKien.Tables["LINHKIEN"].Rows.Add(them);
                    }
                }
                txt_TimKiem_LK.AutoCompleteCustomSource.Add(txt_TenLK.Text);
                DanhSoLK();
                txt_TenLK.Clear();
                txt_MaLK.Clear();
                txt_DonGiaLK.Clear();
                dtp_LinhKien.Value = System.DateTime.Now;
                txt_SoLuongLK.Clear();
                txt_BaoHanhLK.Clear();
            }
            catch { MessageBox.Show("Thêm dữ liệu thất bại (-_-)"); }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DIENTHOAI", conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(DS_SanPham_DienThoai, "DIENTHOAI");
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi. Yêu cầu xem lại kết nối hệ thống !!!");
            }
        }

        private void btn_LuuLK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LINHKIEN", conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(DS_SanPham_LinhKien, "LINHKIEN");
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
                string xoa = dataGridView_Form_DienThoai.CurrentRow.Cells[1].Value.ToString();
                DataRow row = DS_SanPham_DienThoai.Tables["DIENTHOAI"].Rows.Find(xoa);
                if (row != null)
                {
                    row["MaDT"] = txt_MaDT.Text;
                    row["TenDT"] = txt_TenDT.Text;
                    row["DonGia"] = txt_DonGiaDT.Text;
                    row["NgaySanXuat"] = dtp_DienThoai.Text;
                    row["BaoHanh"] = txt_BaoHanhDT.Text;
                    row["SoLuong"] = txt_SoLuongDT.Text;
                    MessageBox.Show("Cập nhật thành công");
                }
                DanhSoDT();
            }
            catch { MessageBox.Show("Cập Nhật dữ liệu điện thoại thất bại (-_-)"); }
        }

        private void btn_SuaLK_Click(object sender, EventArgs e)
        {
            try
            {
                string xoa = dataGridView_Form_LinhKien.CurrentRow.Cells[1].Value.ToString();
                DataRow row = DS_SanPham_LinhKien.Tables["LINHKIEN"].Rows.Find(xoa);
                if (row != null)
                {
                    row["MaLK"] = txt_MaLK.Text;
                    row["TenLK"] = txt_TenLK.Text;
                    row["DonGia"] = txt_DonGiaLK.Text;
                    row["NgaySanXuat"] = dtp_LinhKien.Text;
                    row["BaoHanh"] = txt_BaoHanhLK.Text;
                    row["SoLuong"] = txt_SoLuongLK.Text;
                    MessageBox.Show("Cập nhật thành công");
                }
                DanhSoLK();
            }
            catch { MessageBox.Show("Cập nhât dữ liệu linh kiện thất bại (-_-)"); }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    string xoa = dataGridView_Form_DienThoai.CurrentRow.Cells[1].Value.ToString();
                    DataRow row = DS_SanPham_DienThoai.Tables["DIENTHOAI"].Rows.Find(xoa);
                    if (row != null)
                    {
                        row.Delete();
                    }
                }
                else
                    return;
                txt_TimKiemDT.AutoCompleteCustomSource.Remove(txt_TenDT.Text);
                DanhSoDT();
            }
            catch { MessageBox.Show("Xóa dữ liệu điện thoại thất bại (-_-)"); }
        }

        private void btn_XoaLK_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    string xoa = dataGridView_Form_LinhKien.CurrentRow.Cells[1].Value.ToString();
                    DataRow row = DS_SanPham_LinhKien.Tables["LINHKIEN"].Rows.Find(xoa);
                    if (row != null)
                    {
                        row.Delete();
                    }
                }
                else
                    return;
                txt_TimKiem_LK.AutoCompleteCustomSource.Remove(txt_TenLK.Text);
                DanhSoLK();
            }
            catch { MessageBox.Show("Xóa dữ liệu linh kiện thất bại (-_-)"); }
        } 

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_MaDT.Clear();
            txt_TenDT.Clear();
            txt_DonGiaDT.Clear();
            dtp_DienThoai.Value = System.DateTime.Now;
            txt_SoLuongDT.Clear();
            txt_BaoHanhDT.Clear();
            txt_MaDT.Focus();
        }

        private void btn_HuyLK_Click(object sender, EventArgs e)
        {
            txt_MaLK.Clear();
            txt_TenLK.Clear();
            txt_DonGiaLK.Clear();
            dtp_LinhKien.Value = System.DateTime.Now;
            txt_SoLuongLK.Clear();
            txt_BaoHanhLK.Clear();
            txt_MaLK.Focus();
        }

        private void txt_TimKiemDT_Click(object sender, EventArgs e)
        {
            txt_TimKiemDT.Text = null;
        }

        private void txt_TimKiem_LK_Click(object sender, EventArgs e)
        {
            txt_TimKiem_LK.Text = null;
        }

        private void dataGridView_Form_DienThoai_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btn_Sua.Enabled = true;
                for (int i = 0; i < dataGridView_Form_DienThoai.Rows.Count - 1; i++)
                {
                    if (dataGridView_Form_DienThoai.Rows[i].Selected == true)
                    {
                        txt_MaDT.Text = dataGridView_Form_DienThoai.Rows[i].Cells[1].Value.ToString();
                        txt_TenDT.Text = dataGridView_Form_DienThoai.Rows[i].Cells[2].Value.ToString();
                        txt_DonGiaDT.Text = dataGridView_Form_DienThoai.Rows[i].Cells[3].Value.ToString();
                        dtp_DienThoai.Text = dataGridView_Form_DienThoai.Rows[i].Cells[4].Value.ToString();
                        txt_BaoHanhDT.Text = dataGridView_Form_DienThoai.Rows[i].Cells[5].Value.ToString();
                        txt_SoLuongDT.Text = dataGridView_Form_DienThoai.Rows[i].Cells[6].Value.ToString();
                    }
                }
                DanhSoDT();
            }
            catch { MessageBox.Show("Chọn dữ liệu điện thoại thất bại (-_-)"); }
        }

        private void dataGridView_Form_LinhKien_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                btn_SuaLK.Enabled = true;
                for (int i = 0; i < dataGridView_Form_LinhKien.Rows.Count - 1; i++)
                {
                    if (dataGridView_Form_LinhKien.Rows[i].Selected == true)
                    {
                        txt_MaLK.Text = dataGridView_Form_LinhKien.Rows[i].Cells[1].Value.ToString();
                        txt_TenLK.Text = dataGridView_Form_LinhKien.Rows[i].Cells[2].Value.ToString();
                        txt_DonGiaLK.Text = dataGridView_Form_LinhKien.Rows[i].Cells[3].Value.ToString();
                        dtp_LinhKien.Text = dataGridView_Form_LinhKien.Rows[i].Cells[4].Value.ToString();
                        txt_BaoHanhLK.Text = dataGridView_Form_LinhKien.Rows[i].Cells[5].Value.ToString();
                        txt_SoLuongLK.Text = dataGridView_Form_LinhKien.Rows[i].Cells[6].Value.ToString();
                    }
                }
                DanhSoLK();
            }
            catch { MessageBox.Show("Chọn dữ liệu linh kiện thất bại (-_-)"); }
        }

        private void dataGridView_Form_DienThoai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Hide();
                Form_HoaDon hd = new Form_HoaDon();
                hd.masp = txt_MaDT.Text;
                hd.tensp = txt_TenDT.Text;
                hd.dongia = txt_DonGiaDT.Text;
                hd.ShowDialog();
                this.Show();
            }
            catch { MessageBox.Show("Chọn dữ liệu qua hóa đơn thất bại (-_-)"); }
        }

        private void dataGridView_Form_LinhKien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Hide();
                Form_HoaDon hd = new Form_HoaDon();
                hd.masp = txt_MaLK.Text;
                hd.tensp = txt_TenLK.Text;
                hd.dongia = txt_DonGiaLK.Text;
                hd.ShowDialog();
                this.Show();
            }
            catch { MessageBox.Show("Chọn dữ liệu qua hóa đơn thất bại (-_-)"); }
        }

        private void btnBaoCaoDT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BC_DienThoai k = new Form_BC_DienThoai();
            k.ShowDialog();
            this.Show();
        }

        private void btnBaoCaoLK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BC_LinhKien lk = new Form_BC_LinhKien();
            lk.ShowDialog();
            this.Show();
        }

        
    }
}
