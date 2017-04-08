using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestThuVien.QLThuVienDTO;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frm_quanlysach : Form
    {
        public frm_quanlysach()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm_capnhat _them = new frm_capnhat();
            _them.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_capnhat _them = new frm_capnhat();
            _them.them = false;
            _them.ShowDialog();
        }
        KetNoiDT dt = new KetNoiDT();
        private void frm_quanlysach_Load(object sender, EventArgs e)
        {
            DataTable dulieu = dt.sqlLayDuLieu("PSP_QuanLySach_Select");
            dgvSach.DataSource = dulieu;
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            SqlParameter pa1=new SqlParameter("@seach",cmbLoaiSach.Text);
            SqlParameter pa2=new SqlParameter("@seach",cmbTacGia.Text);
            SqlParameter pa3=new SqlParameter("@seach",txtSeach.Text);

            dt.sqlThucThi("PSP_QuanLySach_Select",pa3);
        }
    }
}
