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
using WindowsFormsApplication1.Bussiness;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frm_Quanlyhocsinh : Form
    {
        public frm_Quanlyhocsinh()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
<<<<<<< HEAD
        KetNoiDT dt = new KetNoiDT();
=======
<<<<<<< HEAD
=======
>>>>>>> origin/master
<<<<<<< HEAD
        //BLL_HocSinh bd;
        //DataTable dtdshosinh;
        //string err = "";
        //public void HienThiDS()
        //{
        //    dtdshosinh = new DataTable();
        //    dtdshosinh = bd.GetDSHocSinh(ref err);
        //    dgvQLHS.DataSource = dtdshosinh.DefaultView;
        //}
        private void frm_quanlysinhvien_Load(object sender, EventArgs e)
        {
            //HienThiDS();
=======
=======
>>>>>>> origin/master
        BLL_HocSinh bd;
        DataTable dtdshosinh;
        string err = "";
>>>>>>> origin/master
        public void HienThiDS()
        {
            DataTable hs = dt.sqlLayDuLieu("PSP_HocSinh_Select");
            dgvQLHS.DataSource = hs;
        }
        private void frm_quanlysinhvien_Load(object sender, EventArgs e)
        {
            HienThiDS();
<<<<<<< HEAD
>>>>>>> origin/master
=======
>>>>>>> origin/master
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlParameter pa1 = new SqlParameter("@MaHS", txtMaHS.Text);
            SqlParameter pa2 = new SqlParameter("@HoTenHS", txtMaHS.Text);
            SqlParameter pa3 = new SqlParameter("@GioiTinh", txtMaHS.Text);
            SqlParameter pa4 = new SqlParameter("@NgaySinh", txtMaHS.Text);
            SqlParameter pa5 = new SqlParameter("@DiaChi", txtMaHS.Text);
            SqlParameter pa6 = new SqlParameter("@DienThoai", txtMaHS.Text);
            SqlParameter pa7=new SqlParameter("@GhiChu")
            dt.sqlThucThi("sqlThucThi");
        }
    }
}
