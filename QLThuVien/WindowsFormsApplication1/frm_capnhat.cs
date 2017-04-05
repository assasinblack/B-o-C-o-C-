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
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class frm_capnhat : Form
    {
        public frm_capnhat()
        {
            InitializeComponent();
        }
        public bool them = true;
        KetNoiDT dt = new KetNoiDT();

        private void loadCMB()
        {
            DataTable dulieu = dt.sqlLayDuLieu("PSP_TheLoaiSach_Select1");
            for (int i = 1; i <= dulieu.Rows.Count; i++)
            {
                cmbTheLoai.Items.Add(dulieu.Rows[dulieu.Rows.Count - i]["MaTL"].ToString());
            }
        }
        private void frm_capnhat_Load(object sender, EventArgs e)
        {

            loadCMB();
            if (them == true)
            {
                lblPanel.Text = "Thêm Sách";
            }
            else
            {
                lblPanel.Text = "Sửa Sách";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@masach", txtMaSach.Text);
            SqlParameter para2 = new SqlParameter("@tensach", txtTenSach.Text);
            SqlParameter para3 = new SqlParameter("@matl", cmbTheLoai.Text);
            SqlParameter para4 = new SqlParameter("@tacgia", cmbTacGia.Text);
            SqlParameter para5 = new SqlParameter("@giasach", txtGiaSach.Text);
            SqlParameter para6 = new SqlParameter("@ngayxuatban", dtpNgayXB.Text);
            SqlParameter para7 = new SqlParameter("@soluong", txtSoLuong.Text);
            dt.sqlThucThi("PSP_QuanLySach_Insert", para1, para2, para3, para5, para6, para7);
            dt.sqlThucThi("PSP_SachTacGia_Insert", para1, para4);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            frrm_Theloaisach frm = new frrm_Theloaisach();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}
