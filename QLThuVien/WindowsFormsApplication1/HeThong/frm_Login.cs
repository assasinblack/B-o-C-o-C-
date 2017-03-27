using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Bussiness;

namespace WindowsFormsApplication1.HeThong
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        BLL_DangNhap bd;
        string err = "";
        string manv, tennhanvien;
        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            frm_KetNoi _connec = new frm_KetNoi();
            _connec.ShowDialog();
            bd = new BLL_DangNhap(Cls_Main.duongdanfileketnoi);
        }
        private bool KTraDangNhap(string tentaikhoan, string matkhau)
        {
            bool kq = false;
            SqlDataReader _reader = bd.KTraLogin(ref err, tentaikhoan, matkhau);
            while (_reader.Read() == true)
            {
                if (_reader.GetInt32(0) == 1)
                {
                    kq = true;
                    manv = _reader.GetInt32(2).ToString();
                    tennhanvien = _reader.GetString(3);
                    Cls_Main.maNV = manv;
                    Cls_Main.tenNV = tennhanvien;
                }
            }
            return kq;
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                if (!string.IsNullOrEmpty(txtPass.Text))
                {
                    if (KTraDangNhap(txtUser.Text, txtPass.Text) == true)
                    {
                        frm_Main.tennhanvien = tennhanvien;
                        this.Close();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(err))
                        {
                            MessageBox.Show("Đăng nhập không thành công\n" + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập không thành công\n Hãy kiểm tra lại thông tin kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txtUser.Text = "admin";
            if (File.Exists(Cls_Main.duongdanfileketnoi))//tồn tại
            {
                bd = new BLL_DangNhap(Cls_Main.duongdanfileketnoi);
                if (bd.KTraKetNoi(ref err) == false)
                {
                    frm_KetNoi _thietlap = new frm_KetNoi();
                    _thietlap.ShowDialog();
                    bd = new BLL_DangNhap(Cls_Main.duongdanfileketnoi);
                }
            }
            else //không tồn tại
            {
                frm_KetNoi _thietlap = new frm_KetNoi();
                _thietlap.ShowDialog();
                bd = new BLL_DangNhap(Cls_Main.duongdanfileketnoi);
            }
        }
    }
}
