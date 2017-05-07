using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.HeThong;

namespace WindowsFormsApplication1
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        //string err = "";
        public static string tennhanvien;

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_dangnhap _login = new frm_dangnhap();
            _login.Close();
            if (frm_dangnhap.quyen.ToString() == "2")
            {
                
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnQLHS.Enabled = false;
                btnTacGia.Enabled = false;
                //btnMuonTraSach.Enabled = false;
                btnSach.Enabled = false;
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            frm_quanlysach _sach = new frm_quanlysach();
            _sach.ShowDialog();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            frm_quanlytacgia _tacgia = new frm_quanlytacgia();
            _tacgia.ShowDialog();
        }

        private void btnQLHS_Click(object sender, EventArgs e)
        {
            frm_Quanlyhocsinh _hocsinh = new frm_Quanlyhocsinh();
            _hocsinh.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_doimatkhau _mk = new frm_doimatkhau();
            _mk.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_saoluuphuchoi saoluu = new frm_saoluuphuchoi();
            saoluu.ShowDialog();
            
        }

      

        private void btnMuonTraSach_Click(object sender, EventArgs e)
        {
            Frm_MuonTraSach muontrasach = new Frm_MuonTraSach();
            muontrasach.ShowDialog();
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_dangky phuchoi = new frm_dangky();
            phuchoi.ShowDialog();
        }
      
    }
}
