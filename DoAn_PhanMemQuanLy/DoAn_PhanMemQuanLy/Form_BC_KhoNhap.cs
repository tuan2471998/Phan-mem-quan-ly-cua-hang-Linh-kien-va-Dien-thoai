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
    public partial class Form_BC_KhoNhap : Form
    {
        public Form_BC_KhoNhap()
        {
            InitializeComponent();
        }

        private void Form_BC_KhoNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DeAnDataSet.KHO_NHAP' table. You can move, or remove it, as needed.
            this.KHO_NHAPTableAdapter.Fill(this.DeAnDataSet.KHO_NHAP);

            this.reportViewer1.RefreshReport();
        }
    }
}
