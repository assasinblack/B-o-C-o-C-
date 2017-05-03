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
    public partial class frm_dangky : Form
    {
        public frm_dangky()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        KetNoiDT dt = new KetNoiDT();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@HoTen", txthoten.Text);
            SqlParameter para2 = new SqlParameter("@TaiKhoan", txttaikhoan.Text);
            SqlParameter para3 = new SqlParameter("@MatKhau", txtmatkhau.Text);
            SqlParameter para4 = new SqlParameter("@LoaiTK",int.Parse(cmbloaitk.Text));
            dt.sqlThucThi("PSP_NhanVien_Insert", para1, para3, para2, para4);

        }
    }
}
