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

namespace WindowsFormsApplication1.HeThong
{
    public partial class frm_doimatkhau : Form
    {
        public frm_doimatkhau()
        {
            InitializeComponent();
        }
        KetNoiDT dt = new KetNoiDT();
        private void frm_doimatkhau_Load(object sender, EventArgs e)
        {
            DataTable dulieu = dt.sqlLayDuLieu("PSP_NhanVien_Show");
            for (int i = 1; i <= dulieu.Rows.Count; i++)
            {
                cmbtaikhoan.Items.Add(dulieu.Rows[dulieu.Rows.Count - i]["TaiKhoan"].ToString());
            }
        }
        private bool Matkhau()
        {
            SqlParameter para1 = new SqlParameter("@matkhau", txtmkcu.Text);
            DataTable dulieu= dt.sqlLayDuLieu("PSP_NhanVien_test1",para1);
            if (dulieu.Rows.Count < 1)
                return true;
            else
                return false;
        }
        private void bntdoimatkhau_Click(object sender, EventArgs e)
        {
            if ( Matkhau() == true)
            {
                MessageBox.Show(" Mật khẩu cũ không đúng!");
            }
            if (txtmkmoi.Text != txtnhaplaimkmoi.Text)
            {
                MessageBox.Show(" Mật khẩu mới không trùng khớp!");
            }
            if (txtmkmoi.Text == txtnhaplaimkmoi.Text && Matkhau() == false)
            {
                SqlParameter para1 = new SqlParameter("@TaiKhoan", cmbtaikhoan.Text);
                SqlParameter para2 = new SqlParameter("@MatKhau", txtmkmoi.Text);
                dt.sqlThucThi("PSP_NhanVien_Update", para1, para2);
                MessageBox.Show("Đổi mật khẩu thành công !");
            }
        }

        private void bntthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
