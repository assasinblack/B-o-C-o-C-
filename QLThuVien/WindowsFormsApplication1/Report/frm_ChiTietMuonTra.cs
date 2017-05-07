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
    public partial class frm_ChiTietMuonTra : Form
    {
        public frm_ChiTietMuonTra()
        {
            InitializeComponent();
        }
        private void frm_ChiTietMuonTra_Load(object sender, EventArgs e)
        {
            this.ChiTietMuonTraTableAdapter.Fill(this.DataSet1.ChiTietMuonTra);
            this.reportViewer1.RefreshReport();
        }
    }
}
