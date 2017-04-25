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
            DataTable dulieu1 = dt.sqlLayDuLieu("PSP_TacGia_Select1");
            for (int j = 1; j <= dulieu1.Rows.Count; j++)
            {
                cmbTacGia.Items.Add(dulieu1.Rows[dulieu1.Rows.Count - j]["MaTG"].ToString());
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
            SqlParameter para4 = new SqlParameter("@matg", cmbTacGia.Text);
            SqlParameter para5 = new SqlParameter("@giasach", txtGiaSach.Text);
            SqlParameter para6 = new SqlParameter("@ngayxuatban", Convert.ToDateTime(dtpNgayXB.Text));
            SqlParameter para7 = new SqlParameter("@soluong", txtSoLuong.Text);
            dt.sqlThucThi("PSP_QuanLySach_Insert", para1, para3, para2, para7, para5, para6);
            SqlParameter para8 = new SqlParameter("@masach", txtMaSach.Text);
            dt.sqlThucThi("PSP_SachTacGia_Insert", para4, para8);
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

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            frm_quanlytacgia frm = new frm_quanlytacgia();
            frm.Show();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

    }
}
