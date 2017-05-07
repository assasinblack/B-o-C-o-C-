using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Report
{
    public partial class frm_ChiTietQuaHan : Form
    {
        public frm_ChiTietQuaHan()
        {
            InitializeComponent();
        }

        private void frm_ChiTietQuaHan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.QuaThoiHan' table. You can move, or remove it, as needed.
            this.QuaThoiHanTableAdapter.Fill(this.DataSet1.QuaThoiHan);

            this.reportViewer1.RefreshReport();
        }
    }
}
