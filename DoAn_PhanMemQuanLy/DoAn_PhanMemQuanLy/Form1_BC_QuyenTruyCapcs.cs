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
    public partial class Form1_BC_QuyenTruyCapcs : Form
    {
        public Form1_BC_QuyenTruyCapcs()
        {
            InitializeComponent();
        }

        private void Form1_BC_QuyenTruyCapcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DeAnDataSet.QUYENTRUYCAP' table. You can move, or remove it, as needed.
            this.QUYENTRUYCAPTableAdapter.Fill(this.DeAnDataSet.QUYENTRUYCAP);

            this.reportViewer1.RefreshReport();
        }
    }
}
