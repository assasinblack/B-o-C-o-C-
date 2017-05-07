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
    public partial class frm_InSach : Form
    {
        public frm_InSach()
        {
            InitializeComponent();
        }

        private void frm_InSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Sach' table. You can move, or remove it, as needed.
            this.SachTableAdapter.Fill(this.DataSet1.Sach);

            this.reportViewer1.RefreshReport();
        }
    }
}
