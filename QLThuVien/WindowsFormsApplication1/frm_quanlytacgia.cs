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
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class frm_quanlytacgia : Form
    {
        public frm_quanlytacgia()
        {
            InitializeComponent();
        }
        BLL_tacgia bd;
        DataTable dttacgia;
        
        string err = "";
        private void HienThiTacGia()
        {
            dttacgia = new DataTable();
            dttacgia = bd.GetTacGia(ref err);//lay du lieu tu database len
            dgvTacGia.DataSource = dttacgia;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_quanlytacgia_Load(object sender, EventArgs e)
        {
            bd= new BLL_tacgia(Cls_Main.duongdanfileketnoi);
            HienThiTacGia();
        }

    }
}
