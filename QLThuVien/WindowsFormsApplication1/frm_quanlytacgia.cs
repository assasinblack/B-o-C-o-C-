using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestThuVien.QLThuVienDTO;
using WindowsFormsApplication1.HeThong;



namespace WindowsFormsApplication1
{
    public partial class frm_quanlytacgia : Form
    {
       
        public frm_quanlytacgia()
        {
            InitializeComponent();
        }
       
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        KetNoiDT dt = new KetNoiDT();
        private void frm_quanlytacgia_Load(object sender, EventArgs e)
        {
            DataTable dulieu = dt.sqlLayDuLieu("PSP_TacGia_Select");
            dgvTacGia.DataSource = dulieu;
           
        
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@MaTG", txtMaTG.Text);
            SqlParameter para2 = new SqlParameter("@HoTenTG", txtTenTG.Text);
            dt.sqlThucThi("PSP_TacGia_Insert", para1, para2);
            DataTable dulieu = dt.sqlLayDuLieu("PSP_TacGia_Select");
            dgvTacGia.DataSource = dulieu;
            txtTenTG.Text = "";
            txtMaTG.Text = "";
        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@MaTG", txtMaTG.Text);
            dt.sqlThucThi("PSP_TacGia_Delete", para1);
            DataTable dulieu = dt.sqlLayDuLieu("PSP_TacGia_Select");
            dgvTacGia.DataSource = dulieu;
            txtTenTG.Text = "";
            txtMaTG.Text = "";
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTG.Text = dgvTacGia.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaTG.Text = dgvTacGia.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void bntsua_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@MaTG", txtMaTG.Text);
            SqlParameter para2 = new SqlParameter("@HoTenTG", txtTenTG.Text);
            dt.sqlThucThi("PSP_TacGia_Update", para1, para2);
            DataTable dulieu = dt.sqlLayDuLieu("PSP_TacGia_Select");
            dgvTacGia.DataSource = dulieu;
            txtTenTG.Text = "";
            txtMaTG.Text = "";

        }
       

    }
}
