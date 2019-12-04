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
    public partial class Form_BC_KhoXuat : Form
    {
        public Form_BC_KhoXuat()
        {
            InitializeComponent();
        }

        private void Form_BC_KhoXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DeAnDataSet.KHO_XUAT' table. You can move, or remove it, as needed.
            this.KHO_XUATTableAdapter.Fill(this.DeAnDataSet.KHO_XUAT);

            this.reportViewer1.RefreshReport();
        }
    }
}
