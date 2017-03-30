﻿using System;
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
namespace WindowsFormsApplication1.HeThong
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }
        KetNoiDT dt = new KetNoiDT();
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameter para1 = new SqlParameter("@taikhoan", txtuser.Text);
            SqlParameter para2 = new SqlParameter("@matkhau", txtpass.Text);
            DataTable dulieu= dt.sqlLayDuLieu("PSP_NhanVien_test",para1,para2);
            if (dulieu.Rows.Count < 1)
            {
                MessageBox.Show("sai tai khoan !");
            }
            else
            {
                frm_Main frm = new frm_Main();
                frm.ShowDialog();
            }
        }
    }
}