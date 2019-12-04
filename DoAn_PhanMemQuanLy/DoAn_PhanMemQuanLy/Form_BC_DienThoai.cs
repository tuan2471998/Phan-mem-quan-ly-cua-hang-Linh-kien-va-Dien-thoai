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
    public partial class Form_BC_DienThoai : Form
    {
        public Form_BC_DienThoai()
        {
            InitializeComponent();
        }

        private void Form_BC_DienThoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DeAnDataSet.DIENTHOAI' table. You can move, or remove it, as needed.
            this.DIENTHOAITableAdapter.Fill(this.DeAnDataSet.DIENTHOAI);

            this.reportViewer1.RefreshReport();
        }
    }
}
