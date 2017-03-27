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
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm_Login _ketnoi = new frm_Login();
            _ketnoi.ShowDialog();
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
            frm_quanlysinhvien _hocsinh = new frm_quanlysinhvien();
            _hocsinh.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_saoluuphuchoi saoluu = new frm_saoluuphuchoi();
            saoluu.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_saoluuphuchoi saoluu = new frm_saoluuphuchoi();
            saoluu.saoluu = false;
            saoluu.ShowDialog();
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            
        }
      
    }
}
