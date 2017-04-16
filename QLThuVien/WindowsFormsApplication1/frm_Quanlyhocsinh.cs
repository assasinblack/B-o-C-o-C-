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

using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frm_Quanlyhocsinh : Form
    {
        public frm_Quanlyhocsinh()
        {
            InitializeComponent();
        }

        

        KetNoiDT dt = new KetNoiDT();
        private void frm_quanlysinhvien_Load(object sender, EventArgs e)
        {
            DataTable dulieu = dt.sqlLayDuLieu("PSP_HocSinh_Select");
            dgvQLHS.DataSource = dulieu;
            
        }
       
        private void resettext()
        {
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtGhiChu.Text = "";
        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool GioiTinh()
        {
            if (rdbNam.Checked == true)
                return true;
            else
                return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@MaHS", txtMaHS.Text);
            SqlParameter para2 = new SqlParameter("@HoTenHS", txtHoTen.Text);
            SqlParameter para3 = new SqlParameter("@GioiTinh", GioiTinh());
            SqlParameter para4 = new SqlParameter("@NgaySinh", dtpNgaySinh.Text);
            SqlParameter para5 = new SqlParameter("@DiaChi", txtDiaChi.Text);
            SqlParameter para6 = new SqlParameter("@DienThoai", txtDienThoai.Text);
            SqlParameter para7 = new SqlParameter("@GhiChu", txtGhiChu.Text);
            dt.sqlThucThi("PSP_HocSinh_Insert", para1, para2, para3, para4, para5, para6, para7);
            DataTable dulieu = dt.sqlLayDuLieu("PSP_HocSinh_Select");
            dgvQLHS.DataSource = dulieu;
            resettext();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@MaHS", txtMaHS.Text);
            SqlParameter para2 = new SqlParameter("@HoTenHS", txtHoTen.Text);
            SqlParameter para3 = new SqlParameter("@GioiTinh", GioiTinh());
            SqlParameter para4 = new SqlParameter("@NgaySinh", dtpNgaySinh.Text);
            SqlParameter para5 = new SqlParameter("@DiaChi", txtDiaChi.Text);
            SqlParameter para6 = new SqlParameter("@DienThoai", txtDienThoai.Text);
            SqlParameter para7 = new SqlParameter("@GhiChu", txtGhiChu.Text);
            dt.sqlThucThi("PSP_HocSinh_Update", para1, para2, para3, para4, para5, para6, para7);
            DataTable dulieu = dt.sqlLayDuLieu("PSP_HocSinh_Select");
            dgvQLHS.DataSource = dulieu;
            resettext();
        }

        private void dgvQLHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHS.Text = dgvQLHS.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dgvQLHS.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dgvQLHS.Rows[e.RowIndex].Cells[2].Value.Equals(true))
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
            }
            else
            {
                rdbNam.Checked = false;
                rdbNu.Checked = true;
            }
            dtpNgaySinh.Text = dgvQLHS.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvQLHS.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDienThoai.Text = dgvQLHS.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtGhiChu.Text = dgvQLHS.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@MaHS", txtMaHS.Text);
            dt.sqlThucThi("PSP_HocSinh_Delete", para1);
            DataTable dulieu = dt.sqlLayDuLieu("PSP_HocSinh_Select");
            dgvQLHS.DataSource = dulieu;
            resettext();
        }
    }
}
