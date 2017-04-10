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
    public partial class Frm_MuonTraSach : Form
    {
        public Frm_MuonTraSach()
        {
            InitializeComponent();
        }

        KetNoiDT dt = new KetNoiDT();
        private void enable(bool a)
        {
            cmbHoTenHS.Enabled = dtpMuon.Enabled = dtpTra.Enabled = txtSoLuongMuon.Enabled = btnChoMuon.Enabled = a;
        }
        private void lockTra()
        {
           
        }
        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_MuonTraSach_Load(object sender, EventArgs e)
        {
            enable(false);
            DataTable sach = dt.sqlLayDuLieu("PSP_ShowTenSach");
            DataTable chitiet = dt.sqlLayDuLieu("PSP_CTMuonSach_Select");
            dgvChiTietMuon.DataSource = chitiet;
            dgvChitietMuon1.DataSource = chitiet;
            for(int i=1;i<=sach.Rows.Count;i++)
            {
                cmbTenSach.Items.Add(sach.Rows[sach.Rows.Count - i]["TenSach"].ToString());
            }

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            enable(true);
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            enable(false);
            cmbTenSach.Text = "";
            lblMaSach.Text = "";
            lblGia.Text = "";
            lblSLuong.Text = "";
            lblNgayXB.Text = "";
            lblTacGia.Text = "";
        }

        private void btnXemSach_Click(object sender, EventArgs e)
        {
            SqlParameter Tensach = new SqlParameter("@TenSach", cmbTenSach.Text);
            DataTable show = dt.sqlLayDuLieu("PSP_Sach_Show", Tensach);
            lblMaSach.Text = show.Rows[0]["MaSach"].ToString();
            lblGia.Text = show.Rows[0]["GiaSach"].ToString();
            lblSLuong.Text = show.Rows[0]["SoLuong"].ToString();
            lblNgayXB.Text = string.Format("{0:d}", (show.Rows[0]["NgayXuatBan"]));
            lblTacGia.Text = show.Rows[0]["HoTenTG"].ToString();
        }

        private void btnLoad1_Click(object sender, EventArgs e)
        {

        }
    }
}
