using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using WindowsFormsApplication1.Bussiness;

namespace WindowsFormsApplication1.HeThong
{
    public partial class frm_saoluuphuchoi : Form
    {
        public frm_saoluuphuchoi()
        {
            InitializeComponent();
        }
        string err = "";
        BLL_SaoLuuPhucHoi bd = new BLL_SaoLuuPhucHoi(Cls_Main.duongdanfileketnoi);
        string databasename = "";
        private void tsbsaoluu_Click(object sender, EventArgs e)
        {
            if (saoluu == true)
            {
                //saoluu
                if (!string.IsNullOrEmpty(txtlayfile.Text))
                {
                    if (File.Exists(txtlayfile.Text))
                    {
                        File.Delete(txtlayfile.Text);
                    }
                    lblerr.Text = "Hệ thống đang tiến hành sao lưu...";
                    Application.DoEvents();
                    try
                    {
                        //thực hiện thủ tục sao lưu
                        databasename = bd.datatbasename;
                        if (bd.SaoLuu(ref err, txtlayfile.Text))
                        {
                            lblerr.Text = "Đã sao lưu thành công";
                            lblerr.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblerr.Text = "Sao lưu không thành công" + err;
                            lblerr.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {

                        err = ex.Message;
                        lblerr.Text = "Sao lưu không thành công" + err;
                        lblerr.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có đường dẫn file bak", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //phục hội
                if (!string.IsNullOrEmpty(txtlayfile.Text))
                {

                    lblerr.Text = "Hệ thống đang tiến hành phục hồi...";
                    Application.DoEvents();
                    try
                    {
                        //thực hiện thủ tục sao lưu
                        //dataname
                        if (bd.PhucHoi(ref err, txtlayfile.Text, databasename))
                        {
                            lblerr.Text = "Đã Phục hồi thành công";
                            lblerr.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblerr.Text = "Phục hồi không thành công" + err;
                            lblerr.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {

                        err = ex.Message;
                        lblerr.Text = "Phục hồi không thành công" + err;
                        lblerr.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có đường dẫn file bak", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tsbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool saoluu = true;
        private void btnlayfile_Click(object sender, EventArgs e)
        {
            if (saoluu == true)
            {
                SaveFileDialog _save = new SaveFileDialog();
                _save.Filter = "Text backup (*.bak)|*.bak|All files (*.*)|*.*";
                _save.FileName = "Filebackup" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + ".bak";
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    txtlayfile.Text = _save.FileName;
                }
            }
            else
            {
                OpenFileDialog _save = new OpenFileDialog();
                _save.Filter = "Text backup (*.bak)|*.bak|All files (*.*)|*.*";
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    txtlayfile.Text = _save.FileName;
                }
            }
        }
   
       // string databasename = "";
        private void frm_saoluuphuchoi_Load(object sender, EventArgs e)
        {
            if (saoluu == false)
            {
                btnsaoluu.Text = "Phục hồi";
                lblpanel.Text = "Phục hồi lại dữ liệu";
            }
            else
            {
                btnsaoluu.Text = "Sao Lưu";
                lblpanel.Text = "Sao lưu dữ liệu";
                
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
