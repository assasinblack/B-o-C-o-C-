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

namespace WindowsFormsApplication1
{
    public partial class frm_quanlysach : Form
    {
        public frm_quanlysach()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm_capnhat _them = new frm_capnhat();
            _them.them = true;
            _them.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_capnhat _them = new frm_capnhat();
            _them.them = false;
            _them.ShowDialog();
        }
        KetNoiDT dt = new KetNoiDT();
        private void frm_quanlysach_Load(object sender, EventArgs e)
        {
            DataTable dulieu = dt.sqlLayDuLieu("PSP_Sach_Select");
            dgvSach.DataSource = dulieu;
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            SqlParameter pa3 = new SqlParameter("@search", txtSeach.Text);
            DataTable seach = dt.sqlLayDuLieu("PSP_QuanLySach_Search", pa3);
            dgvSach.DataSource = seach;
            txtSeach.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_quanlysach_Load(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SqlParameter masach = new SqlParameter("@MaSach", colMaSach.ToString());
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                dt.sqlThucThi("PSP_SachDelete", masach);
            }
        }

        public void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTMP.Text = dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();       
        }
    }
}
