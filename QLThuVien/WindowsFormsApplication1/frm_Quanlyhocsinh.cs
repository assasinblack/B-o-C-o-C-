using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Bussiness;

namespace WindowsFormsApplication1
{
    public partial class frm_Quanlyhocsinh : Form
    {
        public frm_Quanlyhocsinh()
        {
            InitializeComponent();
        }

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
        }
        BLL_HocSinh bd;
        DataTable dtdshosinh;
        string err = "";
        public void HienThiDS()
        {
            dtdshosinh = new DataTable();
            dtdshosinh = bd.GetDSHocSinh(ref err);
            dgvQLHS.DataSource = dtdshosinh.DefaultView;
        }
        /*private void frm_quanlysinhvien_Load(object sender, EventArgs e)
        {
            HienThiDS();

        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
