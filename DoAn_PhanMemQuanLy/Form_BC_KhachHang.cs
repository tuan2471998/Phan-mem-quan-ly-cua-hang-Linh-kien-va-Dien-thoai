﻿using System;
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
    public partial class Form_BC_KhachHang : Form
    {
        public Form_BC_KhachHang()
        {
            InitializeComponent();
        }

        private void Form_BC_KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DeAnDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.KHACHHANGTableAdapter.Fill(this.DeAnDataSet.KHACHHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
