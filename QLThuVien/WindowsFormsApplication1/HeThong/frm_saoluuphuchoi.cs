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
using TestThuVien.QLThuVienDTO;

namespace WindowsFormsApplication1.HeThong
{
    
    public partial class frm_saoluuphuchoi : Form
    {
        public frm_saoluuphuchoi()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        KetNoiDT dt = new KetNoiDT();
        private void bnttienhanh_Click(object sender, EventArgs e)
        {
            if (rdobackup.Checked == true)
            {
                if (txtduongdan.Text == "")
                {
                    MessageBox.Show("Chưa chọn đường dẫn");

                }
                else
                {
                    try
                    {
                        //thuc hien backup
                        if (!Directory.Exists(Path.GetDirectoryName(txtduongdan.Text)))
                        {
                            MessageBox.Show("Thư mục không tồn tại");
                        }
                        else
                        {
                            dt.MoKetNoi();
                            SqlCommand cmdbackup = new SqlCommand();
                            cmdbackup.CommandType = CommandType.Text;
                            cmdbackup.Connection = KetNoiDT.connect;
                            cmdbackup.CommandText =
                           "BACKUP DATABASE QLThuVien TO DISK='" + txtduongdan.Text + "'WITH FORMAT";
                            cmdbackup.ExecuteNonQuery();
                            MessageBox.Show("Backup thành  công");
                            txtduongdan.Text = "";

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                try
                {
                    if (!File.Exists(txtduongdan.Text))
                    {
                        MessageBox.Show("File không tồn tại");
                    }
                    else
                    {
                        dt.MoKetNoi();
                        SqlCommand cmdrestore = new SqlCommand();
                        cmdrestore.Connection = KetNoiDT.connect;
                        cmdrestore.CommandType = CommandType.Text;
                        cmdrestore.CommandText = "ALTER DATABASE QLThuVien SET OFFLINE WITH ROLLBACK IMMEDIATE USE master RESTORE DATABASE QLThuVien FROM DISK='" + txtduongdan.Text + "' WITH REPLACE ALTER DATABASE QLThuVien SET ONLINE";
                        cmdrestore.ExecuteNonQuery();
                        if (MessageBox.Show("Restore thành công hãy khởi động lại ứng dụng để cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            txtduongdan.Text = "";
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        FileDialog dl;
        private void bntgetlink_Click(object sender, EventArgs e)
        {

               
          
                    if (rdobackup.Checked == true)
                    {
                        dl = new SaveFileDialog();
                    }
                    else
                    {
                        dl = new OpenFileDialog();
                    }
                dl.Filter = "File  type (*.bak)|*.bak";
                dl.DefaultExt = "bak";
                if (dl.ShowDialog() == DialogResult.OK)
                {
                    txtduongdan.Text = dl.FileName;
                }
        }
    }
}
