﻿using System;
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
    public partial class Form_QuyenTuyCap : Form
    {
        public Form_QuyenTuyCap()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=SHENLONG-PC\SQLEXPRESS;Initial Catalog=DeAn;Integrated Security=True");
            DS_QuyenTruyCap = new DataSet();
        }

        SqlConnection conn;
        DataSet DS_QuyenTruyCap;

        private void Form_QuyenTuyCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn có chăc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TaiDuLieu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from QUYENTRUYCAP", conn);
            da.Fill(DS_QuyenTruyCap, "QUYENTRUYCAP");
            DataTable table = DS_QuyenTruyCap.Tables["QUYENTRUYCAP"];
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = DS_QuyenTruyCap.Tables["QUYENTRUYCAP"].Columns[0];
            DS_QuyenTruyCap.Tables["QUYENTRUYCAP"].PrimaryKey = khoachinh;
            dataGridView_From_QuyenTruyCap.DataSource = table;
            dataGridView_From_QuyenTruyCap.RowHeadersVisible = false;
        }

        private void Form_QuyenTuyCap_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow them = DS_QuyenTruyCap.Tables["QUYENTRUYCAP"].NewRow();
            them[0] = txtMaNV.Text;
            if (rdbAdmin.Checked)
                them[1] = "admin";
            else if (rdbManager.Checked)
                them[1] = "manager";
            else
                them[1] = "user";
            them[2] = txtTaiKhoan.Text;
            them[3] = txtMatKhau.Text;
            DataRow ktkc = DS_QuyenTruyCap.Tables["QUYENTRUYCAP"].Rows.Find(txtMaNV.Text);
            if (ktkc != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                return;
            }
            else
            {
                DS_QuyenTruyCap.Tables["QUYENTRUYCAP"].Rows.Add(them);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from QUYENTRUYCAP", conn);
                SqlCommandBuilder build = new SqlCommandBuilder(da);
                da.Update(DS_QuyenTruyCap, "QUYENTRUYCAP");
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi. Yêu cầu xem lại kết nối hệ thống hoặc mã nhân viên !!!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                string xoa = dataGridView_From_QuyenTruyCap.CurrentRow.Cells[0].Value.ToString();
                DataRow row = DS_QuyenTruyCap.Tables["QUYENTRUYCAP"].Rows.Find(xoa);
                if (row != null)
                {
                    row.Delete();
                }
            }
            else
                return;
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = null;
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            txtMatKhau.Text = null;
        }

        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            txtMaNV.Text = null; 
        }
    }
}
